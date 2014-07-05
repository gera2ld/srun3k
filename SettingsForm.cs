/*
 * Created by SharpDevelop.
 * User: Gerald
 * Date: 2014/6/14
 * Time: 23:53
 */
using System;
using System.Net;
using System.Net.NetworkInformation;
using System.Threading;
using System.Windows.Forms;

namespace SRun3KStupid
{
	/// <summary>
	/// SettingsForm.
	/// </summary>
	public partial class SettingsForm : Form
	{
		public SettingsForm(Config conf)
		{
			InitializeComponent();
			this.conf=conf;
			textHost.Text=conf.getConfString("host");
			comboMAC.Text=conf.getConfString("mac");
			cbAutoHide.Checked=conf.getConfBool("autohide");
			cbAutoLogIn.Checked=conf.getConfBool("autologin");
		}
		Config conf;
		void getMACs() {
            IPGlobalProperties computerProperties = IPGlobalProperties.GetIPGlobalProperties();
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            if(nics!=null) foreach(NetworkInterface adapter in nics) {
                PhysicalAddress address=adapter.GetPhysicalAddress();
                byte[] bytes=address.GetAddressBytes();
                string[] buf=new string[bytes.Length];
                for(int j=0;j<bytes.Length;j++) buf[j]=bytes[j].ToString("X2");
                string mac=string.Join("-",buf);
                if(!string.IsNullOrEmpty(mac)) comboMAC.Items.Add(mac);
            }
		}
		
		void BtOKClick(object sender, EventArgs e)
		{
			conf.setConfString("host",textHost.Text);
			conf.setConfString("mac",comboMAC.Text);
			conf.setConfBool("autohide",cbAutoHide.Checked);
			conf.setConfBool("autologin",cbAutoLogIn.Checked);
			Close();
		}
		
		void BtMACClick(object sender, EventArgs e)
		{
			Random r=new Random();
			comboMAC.Text=string.Format("{0:X2}-{1:X2}-{2:X2}-{3:X2}-{4:X2}-{5:X2}",
		                           r.Next(256),r.Next(256),r.Next(256),
		                           r.Next(256),r.Next(256),r.Next(256));
		}
		
		void LinkSupportLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			try {
				System.Diagnostics.Process.Start("http://geraldl.ml/proj/srun3k");
			} catch {
				
			}
		}
		
		void _callback(object[] o) {
			int code=(int)o[0];
			string msg=(string)o[1],data=(string)o[2];
			switch(code) {
				case 1:
					if(data!=null) textHost.Text=data;
					btGuess.Enabled=true;
					break;
			}
			lblMsg.Text=msg;
		}
		void callback(int code,string msg,string data) {
			try {
				Invoke(new Action<object[]>(_callback),new object[]{new object[]{code,msg,data}});
			} catch {
				
			}
		}
		
		void guess() {
			callback(0,"Trying to guess a host...",null);
			HttpWebRequest req=(HttpWebRequest)WebRequest.Create("http://www.baidu.com/");
			req.Method="GET";
			req.Proxy=null;
			req.Timeout=1000;
			HttpWebResponse res;
			try {
				res=(HttpWebResponse)req.GetResponse();
			} catch {
				callback(1,"Guess failed: Network error.",null);
				return;
			}
			if(res.ResponseUri.Host=="www.baidu.com") {
				callback(1,"Guess failed: Internet is already connected.",null);
			} else {
				callback(1,"Guess succeeded: Host is guessed!",res.ResponseUri.Host);
			}
		}
		
		void BtGuessClick(object sender, EventArgs e)
		{
			btGuess.Enabled=false;
			Thread t=new Thread(new ThreadStart(guess));
			t.IsBackground=true;
			t.Start();
		}
		
		void SettingsFormLoad(object sender, EventArgs e)
		{
			getMACs();
		}
	}
}
