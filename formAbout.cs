/*
 * Created by SharpDevelop.
 * User: Gerald
 * Date: 2013/12/19
 * Time: 22:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SRun3KStupid
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class formAbout : Form
	{
		public formAbout()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void LinkLabel1LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			try {
				System.Diagnostics.Process.Start("http://geraldl.ml/Production/srun3k");
			} catch {
				
			}
		}
	}
}
