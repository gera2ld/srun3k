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
			this.cbRemember = new System.Windows.Forms.CheckBox();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.btSettings = new System.Windows.Forms.Button();
			this.btLog = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textUsr = new System.Windows.Forms.TextBox();
			this.textPwd = new System.Windows.Forms.TextBox();
			this.cbHidePwd = new System.Windows.Forms.CheckBox();
			this.traySRun3K = new System.Windows.Forms.NotifyIcon(this.components);
			this.menuTray = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.menuShowHide = new System.Windows.Forms.ToolStripMenuItem();
			this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
			this.labelMsg = new System.Windows.Forms.Label();
			this.tableLayoutPanel2.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.menuTray.SuspendLayout();
			this.SuspendLayout();
			// 
			// cbRemember
			// 
			this.cbRemember.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.cbRemember.AutoSize = true;
			this.tableLayoutPanel1.SetColumnSpan(this.cbRemember, 3);
			this.cbRemember.Location = new System.Drawing.Point(3, 57);
			this.cbRemember.Name = "cbRemember";
			this.cbRemember.Size = new System.Drawing.Size(278, 16);
			this.cbRemember.TabIndex = 0;
			this.cbRemember.Text = "&Remember me";
			this.cbRemember.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.AutoSize = true;
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Controls.Add(this.btSettings, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.btLog, 0, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 133);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(284, 29);
			this.tableLayoutPanel2.TabIndex = 13;
			// 
			// btSettings
			// 
			this.btSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.btSettings.Location = new System.Drawing.Point(145, 3);
			this.btSettings.Name = "btSettings";
			this.btSettings.Size = new System.Drawing.Size(136, 23);
			this.btSettings.TabIndex = 4;
			this.btSettings.Text = "&Settings...";
			this.btSettings.UseVisualStyleBackColor = true;
			this.btSettings.Click += new System.EventHandler(this.BtSettingsClick);
			// 
			// btLog
			// 
			this.btLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.btLog.Location = new System.Drawing.Point(3, 3);
			this.btLog.Name = "btLog";
			this.btLog.Size = new System.Drawing.Size(136, 23);
			this.btLog.TabIndex = 3;
			this.btLog.UseVisualStyleBackColor = true;
			this.btLog.Click += new System.EventHandler(this.BtLogClick);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.AutoSize = true;
			this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.Controls.Add(this.cbRemember, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.textUsr, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.textPwd, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.cbHidePwd, 2, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 76);
			this.tableLayoutPanel1.TabIndex = 0;
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
			// textUsr
			// 
			this.textUsr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.SetColumnSpan(this.textUsr, 2);
			this.textUsr.Location = new System.Drawing.Point(68, 3);
			this.textUsr.Name = "textUsr";
			this.textUsr.Size = new System.Drawing.Size(213, 21);
			this.textUsr.TabIndex = 1;
			// 
			// textPwd
			// 
			this.textPwd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.textPwd.Location = new System.Drawing.Point(68, 30);
			this.textPwd.Name = "textPwd";
			this.textPwd.Size = new System.Drawing.Size(159, 21);
			this.textPwd.TabIndex = 3;
			// 
			// cbHidePwd
			// 
			this.cbHidePwd.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.cbHidePwd.AutoSize = true;
			this.cbHidePwd.Location = new System.Drawing.Point(233, 32);
			this.cbHidePwd.Name = "cbHidePwd";
			this.cbHidePwd.Size = new System.Drawing.Size(48, 16);
			this.cbHidePwd.TabIndex = 4;
			this.cbHidePwd.Text = "&Hide";
			this.cbHidePwd.UseVisualStyleBackColor = true;
			this.cbHidePwd.CheckedChanged += new System.EventHandler(this.CbHidePwdCheckedChanged);
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
									this.menuExit});
			this.menuTray.Name = "menuTray";
			this.menuTray.Size = new System.Drawing.Size(188, 48);
			// 
			// menuShowHide
			// 
			this.menuShowHide.Name = "menuShowHide";
			this.menuShowHide.Size = new System.Drawing.Size(187, 22);
			this.menuShowHide.Text = "Show/&Hide window";
			this.menuShowHide.Click += new System.EventHandler(this.MenuShowHideClick);
			// 
			// menuExit
			// 
			this.menuExit.Name = "menuExit";
			this.menuExit.Size = new System.Drawing.Size(187, 22);
			this.menuExit.Text = "E&xit";
			this.menuExit.Click += new System.EventHandler(this.MenuExitClick);
			// 
			// labelMsg
			// 
			this.labelMsg.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelMsg.Location = new System.Drawing.Point(0, 76);
			this.labelMsg.Name = "labelMsg";
			this.labelMsg.Size = new System.Drawing.Size(284, 57);
			this.labelMsg.TabIndex = 14;
			this.labelMsg.Text = "Welcome to use SRun3K Stupid!";
			this.labelMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 162);
			this.Controls.Add(this.labelMsg);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.tableLayoutPanel2);
			this.Icon = global::SRun3KStupid.Properties.SRun3K.internet2;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "SRun3K Stupid v1.1";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFormFormClosed);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.menuTray.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.CheckBox cbHidePwd;
		private System.Windows.Forms.Label labelMsg;
		private System.Windows.Forms.ToolStripMenuItem menuShowHide;
		private System.Windows.Forms.ToolStripMenuItem menuExit;
		private System.Windows.Forms.ContextMenuStrip menuTray;
		private System.Windows.Forms.NotifyIcon traySRun3K;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Button btSettings;
		private System.Windows.Forms.Button btLog;
		private System.Windows.Forms.CheckBox cbRemember;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TextBox textPwd;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textUsr;
		private System.Windows.Forms.Label label1;
	}
}
