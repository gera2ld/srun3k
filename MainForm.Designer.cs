/*
 * Created by SharpDevelop.
 * User: Gerald
 * Date: 2013/11/8
 * Time: 20:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace SRun3KStupid
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.sbMessage = new System.Windows.Forms.ToolStripStatusLabel();
			this.cbRemember = new System.Windows.Forms.CheckBox();
			this.cbAutoLogIn = new System.Windows.Forms.CheckBox();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.btMinimize = new System.Windows.Forms.Button();
			this.btLog = new System.Windows.Forms.Button();
			this.cbAutoStart = new System.Windows.Forms.CheckBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.btMAC = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.textMAC = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textPwd = new System.Windows.Forms.TextBox();
			this.textUsr = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textHost = new System.Windows.Forms.TextBox();
			this.traySRun3K = new System.Windows.Forms.NotifyIcon(this.components);
			this.menuTray = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.menuShowHide = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.menuTray.SuspendLayout();
			this.SuspendLayout();
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.sbMessage});
			this.statusStrip1.Location = new System.Drawing.Point(0, 213);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(351, 22);
			this.statusStrip1.TabIndex = 7;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// sbMessage
			// 
			this.sbMessage.Name = "sbMessage";
			this.sbMessage.Size = new System.Drawing.Size(336, 17);
			this.sbMessage.Spring = true;
			this.sbMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cbRemember
			// 
			this.cbRemember.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.cbRemember.AutoSize = true;
			this.cbRemember.Checked = true;
			this.cbRemember.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbRemember.Location = new System.Drawing.Point(3, 3);
			this.cbRemember.Name = "cbRemember";
			this.cbRemember.Size = new System.Drawing.Size(169, 16);
			this.cbRemember.TabIndex = 0;
			this.cbRemember.Text = "&Remember me";
			this.cbRemember.UseVisualStyleBackColor = true;
			// 
			// cbAutoLogIn
			// 
			this.cbAutoLogIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.cbAutoLogIn.AutoSize = true;
			this.cbAutoLogIn.Location = new System.Drawing.Point(178, 3);
			this.cbAutoLogIn.Name = "cbAutoLogIn";
			this.cbAutoLogIn.Size = new System.Drawing.Size(170, 16);
			this.cbAutoLogIn.TabIndex = 1;
			this.cbAutoLogIn.Text = "Log in at &start up";
			this.cbAutoLogIn.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.AutoSize = true;
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Controls.Add(this.cbRemember, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.cbAutoLogIn, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.btMinimize, 1, 2);
			this.tableLayoutPanel2.Controls.Add(this.btLog, 0, 2);
			this.tableLayoutPanel2.Controls.Add(this.cbAutoStart, 0, 1);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 140);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 3;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.Size = new System.Drawing.Size(351, 73);
			this.tableLayoutPanel2.TabIndex = 13;
			// 
			// btMinimize
			// 
			this.btMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.btMinimize.Location = new System.Drawing.Point(178, 47);
			this.btMinimize.Name = "btMinimize";
			this.btMinimize.Size = new System.Drawing.Size(170, 23);
			this.btMinimize.TabIndex = 4;
			this.btMinimize.Text = "Minimize to &tray";
			this.btMinimize.UseVisualStyleBackColor = true;
			this.btMinimize.Click += new System.EventHandler(this.BtMinimizeClick);
			// 
			// btLog
			// 
			this.btLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.btLog.Location = new System.Drawing.Point(3, 47);
			this.btLog.Name = "btLog";
			this.btLog.Size = new System.Drawing.Size(169, 23);
			this.btLog.TabIndex = 3;
			this.btLog.UseVisualStyleBackColor = true;
			this.btLog.Click += new System.EventHandler(this.BtLogClick);
			// 
			// cbAutoStart
			// 
			this.cbAutoStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.cbAutoStart.AutoCheck = false;
			this.cbAutoStart.AutoSize = true;
			this.tableLayoutPanel2.SetColumnSpan(this.cbAutoStart, 2);
			this.cbAutoStart.Location = new System.Drawing.Point(3, 25);
			this.cbAutoStart.Name = "cbAutoStart";
			this.cbAutoStart.Size = new System.Drawing.Size(345, 16);
			this.cbAutoStart.TabIndex = 2;
			this.cbAutoStart.Text = "Run &automatically when system starts";
			this.cbAutoStart.UseVisualStyleBackColor = true;
			this.cbAutoStart.Click += new System.EventHandler(this.CbAutoStartClick);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.AutoSize = true;
			this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.Controls.Add(this.btMAC, 1, 4);
			this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.textMAC, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.textHost, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.textUsr, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.textPwd, 1, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 5;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(351, 140);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// btMAC
			// 
			this.btMAC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.btMAC.Location = new System.Drawing.Point(73, 111);
			this.btMAC.Name = "btMAC";
			this.btMAC.Size = new System.Drawing.Size(275, 23);
			this.btMAC.TabIndex = 8;
			this.btMAC.Text = "&Get MAC of current device";
			this.btMAC.UseVisualStyleBackColor = true;
			this.btMAC.Click += new System.EventHandler(this.BtMACClick);
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 88);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(29, 12);
			this.label3.TabIndex = 6;
			this.label3.Text = "&MAC:";
			// 
			// textMAC
			// 
			this.textMAC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.textMAC.Location = new System.Drawing.Point(73, 84);
			this.textMAC.Name = "textMAC";
			this.textMAC.Size = new System.Drawing.Size(275, 21);
			this.textMAC.TabIndex = 7;
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 34);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(59, 12);
			this.label2.TabIndex = 2;
			this.label2.Text = "&Password:";
			// 
			// textPwd
			// 
			this.textPwd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.textPwd.Location = new System.Drawing.Point(73, 30);
			this.textPwd.Name = "textPwd";
			this.textPwd.PasswordChar = '*';
			this.textPwd.Size = new System.Drawing.Size(275, 21);
			this.textPwd.TabIndex = 3;
			// 
			// textUsr
			// 
			this.textUsr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.textUsr.Location = new System.Drawing.Point(73, 3);
			this.textUsr.Name = "textUsr";
			this.textUsr.Size = new System.Drawing.Size(275, 21);
			this.textUsr.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "&User:";
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(3, 61);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(35, 12);
			this.label4.TabIndex = 4;
			this.label4.Text = "&Host:";
			// 
			// textHost
			// 
			this.textHost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.textHost.Location = new System.Drawing.Point(73, 57);
			this.textHost.Name = "textHost";
			this.textHost.Size = new System.Drawing.Size(275, 21);
			this.textHost.TabIndex = 5;
			// 
			// traySRun3K
			// 
			this.traySRun3K.ContextMenuStrip = this.menuTray;
			this.traySRun3K.Icon = global::SRun3KStupid.Properties.SRun3K.internet2;
			this.traySRun3K.Text = "SRun3K Stupid";
			this.traySRun3K.Visible = true;
			this.traySRun3K.Click += new System.EventHandler(this.TraySRun3KClick);
			// 
			// menuTray
			// 
			this.menuTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.menuShowHide,
									this.aboutToolStripMenuItem,
									this.exitToolStripMenuItem});
			this.menuTray.Name = "menuTray";
			this.menuTray.Size = new System.Drawing.Size(112, 70);
			// 
			// menuShowHide
			// 
			this.menuShowHide.Name = "menuShowHide";
			this.menuShowHide.Size = new System.Drawing.Size(111, 22);
			this.menuShowHide.Click += new System.EventHandler(this.ShowHideWindowToolStripMenuItemClick);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
			this.aboutToolStripMenuItem.Text = "&About";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItemClick);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
			this.exitToolStripMenuItem.Text = "E&xit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(351, 235);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.tableLayoutPanel2);
			this.Controls.Add(this.statusStrip1);
			this.Icon = global::SRun3KStupid.Properties.SRun3K.internet2;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "SRun3K Stupid v1.0";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFormFormClosed);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.menuTray.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox textHost;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ToolStripMenuItem menuShowHide;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip menuTray;
		private System.Windows.Forms.CheckBox cbAutoStart;
		private System.Windows.Forms.NotifyIcon traySRun3K;
		private System.Windows.Forms.ToolStripStatusLabel sbMessage;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Button btMAC;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.Button btMinimize;
		private System.Windows.Forms.Button btLog;
		private System.Windows.Forms.CheckBox cbAutoLogIn;
		private System.Windows.Forms.CheckBox cbRemember;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TextBox textMAC;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textPwd;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textUsr;
		private System.Windows.Forms.Label label1;
	}
}
