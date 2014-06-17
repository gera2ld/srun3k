/*
 * Created by SharpDevelop.
 * User: Gerald
 * Date: 2014/6/14
 * Time: 23:53
 */
using System;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace SRun3KStupid
{
	/// <summary>
	/// Description of SettingsForm.
	/// </summary>
	public partial class SettingsForm : Form
	{
		public SettingsForm(Config conf)
		{
			InitializeComponent();
			this.conf=conf;
			getMACs();
			textHost.Text=conf.getConfString("host");
			comboMAC.Text=conf.getConfString("mac");
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
	}
}
