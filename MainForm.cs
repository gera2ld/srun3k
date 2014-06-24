/*
 * Created by SharpDevelop.
 * User: Gerald
 * Date: 2013/11/8
 * Time: 20:53
 */
using System;
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
			core=new SRun3KCore(this);
			conf=new Config();
			btLog.Text="&Log In";
			menuShowHide.Text="Hide &Window";
			textUsr.Text=conf.getConfString("user");
			textPwd.Text=conf.getConfString("pwd");
			cbHidePwd.Checked=conf.getConfBool("hidepwd",true);
			textPwd.UseSystemPasswordChar=cbHidePwd.Checked;
			cbRemember.Checked=conf.getConfBool("rem",true);
			conf.getConfBool("autohide",true);
			initCore();
			if(conf.getConfBool("autologin")) toggleLog();
		}
		const string runkey="SRun3kStupid";
		Config conf;
		SRun3KCore core;
		void initCore() {
			core.setServer(conf.getConfString("host"));
			core.setMAC(conf.getConfString("mac"));
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
			if(!conf.getConfBool("autohide")&&window==1) window=0;
			if(window==1&&Visible||window==2&&!Visible) toggleWindow();
		}
		public void callback(string message,int window) {
			Invoke(new Action<string,int>(_callback),new object[]{message,window});
		}
		
		void toggleLog() {
			btLog.Enabled=false;
			if(core.isLoggedIn()) core.logOut();
			else {
				enableItems(false);
				core.logIn(textUsr.Text,textPwd.Text);
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
			if(f.ShowDialog()==DialogResult.OK)
				initCore();
		}
		
		void CbHidePwdCheckedChanged(object sender, EventArgs e)
		{
			textPwd.UseSystemPasswordChar=cbHidePwd.Checked;
		}
	}
}
