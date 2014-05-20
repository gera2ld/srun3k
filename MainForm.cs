/*
 * Created by SharpDevelop.
 * User: Gerald
 * Date: 2013/11/8
 * Time: 20:53
 */
using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.Win32;

namespace SRun3KStupid
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			Directory.SetCurrentDirectory(Application.StartupPath);
			btLog.Text="&Log In";
			menuShowHide.Text="Hide &Window";
			loadConf();
			srcore=new core(this);
			if(string.IsNullOrEmpty(textMAC.Text)) getMAC();
			if(cbAutoLogIn.Checked) toggleLog();
			appname=Application.ExecutablePath;
			using(RegistryKey r=Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run")) {
				if(r!=null) try {
					if(r.GetValue(runkey).ToString()==appname) cbAutoStart.Checked=true;
				}catch{
				}
			}
		}
		const string runkey="SRun3kStupid";
		ConfigParser cp=new ConfigParser();
		core srcore;
		string appname;
		void loadConf() {
			if(cp.initLoad()) try{
				int key;
				while((key=cp.loadKey())!=-1) {
					switch ((char)key) {
						case 'r':
							cbRemember.Checked=cp.loadBool();
							break;
						case 'a':
							cbAutoLogIn.Checked=cp.loadBool();
							break;
						case 'h':
							textHost.Text=cp.loadString();
							break;
						case 'u':
							textUsr.Text=cp.loadString();
							break;
						case 'p':
							textPwd.Text=cp.loadString();
							break;
						case 'm':
							textMAC.Text=cp.loadString();
							break;
					}
				}
			}catch{
				
			}finally{
				cp.close();
			}
		}
		void enableItems(bool enabled) {
			textUsr.Enabled=enabled;
			textPwd.Enabled=enabled;
			textHost.Enabled=enabled;
			textMAC.Enabled=enabled;
			btMAC.Enabled=enabled;
		}
		void _callback(string message,int window) {
			if(srcore.isLoggedIn()) {
				btLog.Text="&Log Out";
				this.Icon=Properties.SRun3K.internet1;
				this.traySRun3K.Icon=Properties.SRun3K.internet1;
			} else {
				btLog.Text="&Log In";
				enableItems(true);
				this.Icon=Properties.SRun3K.internet2;
				this.traySRun3K.Icon=Properties.SRun3K.internet2;
			}
			btLog.Enabled=true;
			sbMessage.Text=String.Format("{0} {1}",DateTime.Now.ToString("HH:mm"),message);
			switch (window) {
				case 1:
					if(Visible) toggleWindow();
					break;
				case 2:
					if(!Visible) toggleWindow();
					break;
			}
		}
		public void callback(string message,int window) {
			Invoke(new Action<string,int>(_callback),new object[]{message,window});
		}
		
		void toggleLog() {
			btLog.Enabled=false;
			if(srcore.isLoggedIn()) srcore.logOut();
			else {
				enableItems(false);
				srcore.logIn(textUsr.Text,textPwd.Text,textHost.Text,textMAC.Text);
			}
		}
		
		void toggleWindow() {
			if(Visible) {
				Hide();
				menuShowHide.Text="Show &Window";
			} else {
				Show();
				menuShowHide.Text="Hide &Window";
				WindowState=FormWindowState.Normal;
			}
		}
		
		void TraySRun3KClick(object sender, EventArgs e)
		{
			MouseEventArgs a=(MouseEventArgs)e;
			if(a.Button==MouseButtons.Left) toggleWindow();
		}
		
		void BtMinimizeClick(object sender, EventArgs e)
		{
			Hide();
		}
		
		void BtLogClick(object sender, EventArgs e)
		{
			toggleLog();
		}
		
		void MainFormFormClosed(object sender, FormClosedEventArgs e)
		{
			if(cp.initDump()) {
				cp.dumpValue('r',cbRemember.Checked);
				cp.dumpValue('a',cbAutoLogIn.Checked);
				cp.dumpValue('h',textHost.Text);
				if(cbRemember.Checked) {
					cp.dumpValue('u',textUsr.Text);
					cp.dumpValue('p',textPwd.Text);
				}
				cp.dumpValue('m',textMAC.Text);
				cp.close();
			}
		}
		
		void getMAC() {
			ProcessStartInfo s=new ProcessStartInfo("ipconfig","/all");
			s.UseShellExecute=false;
			s.RedirectStandardInput=true;
			s.RedirectStandardOutput=true;
			s.RedirectStandardError=true;
			s.CreateNoWindow=true;
			Process p=Process.Start(s);
			StreamReader sr=p.StandardOutput;
			Regex re=new Regex(@"([\dA-F]{2}-){5}([\dA-F]{2})");
			while(!sr.EndOfStream) {
				string line=sr.ReadLine();
				Match m=re.Match(line.Trim());
				if(m.Length>0) {
					textMAC.Text=m.Value;
					return;
				}
			}
			// MAC not found
			Random r=new Random();
			textMAC.Text=string.Format("{0:X2}-{1:X2}-{2:X2}-{3:X2}-{4:X2}-{5:X2}",
			                           r.Next(256),r.Next(256),r.Next(256),
			                           r.Next(256),r.Next(256),r.Next(256));
		}
		
		void BtMACClick(object sender, EventArgs e)
		{
			getMAC();
		}
		
		void CbAutoStartClick(object sender, EventArgs e)
		{
			bool b=cbAutoStart.Checked;
			using(RegistryKey r=Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run",true)) {
				if(r!=null) try {
					if(b) r.DeleteValue(runkey);
					else r.SetValue(runkey,appname);
					r.Close();
					cbAutoStart.Checked=!b;
				} catch {
				}
			}
		}
		
		void AboutToolStripMenuItemClick(object sender, EventArgs e)
		{
			formAbout f=new formAbout();
			f.ShowDialog();
		}
		
		void ExitToolStripMenuItemClick(object sender, EventArgs e)
		{
			Close();
		}
		
		void ShowHideWindowToolStripMenuItemClick(object sender, EventArgs e)
		{
			toggleWindow();
		}
	}
	
	class ConfigParser {
		public ConfigParser() {
			filename=getFullPath("SRun3K.conf");
		}
		public string getFullPath(string f) {
			string a=Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)+"\\"+f;
			if(File.Exists(a)) return a;
			if(File.Exists(f)) return f;
			return a;	// Default %AppData%\{f}
		}
		string filename;
		FileStream fs=null;
		public void close() {
			fs.Close();
		}
		bool init(FileMode fm) {
			try{
				fs=new FileStream(filename,fm);
			}catch{
				return false;
			}
			return true;
		}
		byte getByte(int i) {
			byte k=22;
			return (byte)((i^k)&255);
		}
		public bool initLoad() {
			return init(FileMode.Open);
		}
		public int loadKey() {
			int k=fs.ReadByte();
			return k>=0?getByte(k):k;
		}
		public bool loadBool() {
			return getByte(fs.ReadByte())>0;
		}
		public string loadString() {
			int l=getByte(fs.ReadByte());
			byte[] b=new byte[l];
			fs.Read(b,0,l);
			for(int i=0;i<l;i++) b[i]=getByte(b[i]);
			return Encoding.UTF8.GetString(b);
		}
		public bool initDump() {
			return init(FileMode.Create);
		}
		public void dumpValue(char key,bool b) {
			fs.WriteByte(getByte((int)key));
			fs.WriteByte(getByte(b?1:0));
		}
		public void dumpValue(char key,string v) {
			byte[] b=Encoding.UTF8.GetBytes(v);
			fs.WriteByte(getByte(key));
			fs.WriteByte(getByte(b.Length));
			for(int i=0;i<b.Length;i++) b[i]=getByte(b[i]);
			fs.Write(b,0,b.Length);
		}
	}
}
