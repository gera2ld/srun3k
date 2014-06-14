/*
 * Created by SharpDevelop.
 * User: Gerald
 * Date: 2013/11/8
 * Time: 20:53
 */
using System;
using System.IO;
using System.Windows.Forms;

namespace SRun3KStupid
{
	/// <summary>
	/// MainForm of SRun3K Stupid.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			Directory.SetCurrentDirectory(Application.StartupPath);
			core=new SRun3KCore(this);
			conf=new Config();
			btLog.Text="&Log In";
			menuShowHide.Text="Hide &Window";
			textUsr.Text=conf.getConfString("user");
			textPwd.Text=conf.getConfString("pwd");
			cbHidePwd.Checked=conf.getConfBool("hidepwd",true);
			textPwd.UseSystemPasswordChar=cbHidePwd.Checked;
			cbRemember.Checked=conf.getConfBool("rem",true);
			getParams();
			if(conf.getConfBool("autologin")) toggleLog();
		}
		const string runkey="SRun3kStupid";
		Config conf;
		SRun3KCore core;
		string host,mac;
		void getParams() {
			host=conf.getConfString("host");
			mac=conf.getConfString("mac");
		}
		void enableItems(bool enabled) {
			textUsr.Enabled=enabled;
			textPwd.Enabled=enabled;
			cbHidePwd.Enabled=enabled;
			btSettings.Enabled=enabled;
		}
		void _callback(string message,int window) {
			if(core.isLoggedIn()) {
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
			labelMsg.Text=String.Format("{0} {1}",DateTime.Now.ToString("HH:mm"),message);
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
			if(string.IsNullOrEmpty(host)||string.IsNullOrEmpty(mac)) {
				labelMsg.Text="Please set host and MAC address first!";
				return;
			}
			btLog.Enabled=false;
			if(core.isLoggedIn()) core.logOut();
			else {
				enableItems(false);
				core.logIn(textUsr.Text,textPwd.Text,host,mac);
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
		
		void BtLogClick(object sender, EventArgs e)
		{
			toggleLog();
		}
		
		void MainFormFormClosed(object sender, FormClosedEventArgs e)
		{
			if(cbRemember.Checked) {
				conf.setConfString("user",textUsr.Text);
				conf.setConfString("pwd",textPwd.Text);
			} else {
				conf.setConfString("user",null);
				conf.setConfString("pwd",null);
			}
			conf.setConfBool("hidepwd",cbHidePwd.Checked);
			conf.setConfBool("rem",cbRemember.Checked);
			conf.save();
		}
		
		void CbShowPwdCheckedChanged(object sender, EventArgs e)
		{
			textPwd.UseSystemPasswordChar=!cbHidePwd.Checked;
		}
		
		void MenuExitClick(object sender, EventArgs e)
		{
			Close();
		}
		
		void MenuShowHideClick(object sender, EventArgs e)
		{
			toggleWindow();
		}
		
		void BtSettingsClick(object sender, EventArgs e)
		{
			SettingsForm f=new SettingsForm(conf);
			f.StartPosition=FormStartPosition.CenterParent;
			if(f.ShowDialog()==DialogResult.OK) getParams();
		}
		
		void CbHidePwdCheckedChanged(object sender, EventArgs e)
		{
			textPwd.UseSystemPasswordChar=cbHidePwd.Checked;
		}
	}
}
