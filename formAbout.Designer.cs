/*
 * Created by SharpDevelop.
 * User: Gerald
 * Date: 2013/12/19
 * Time: 22:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace SRun3KStupid
{
	partial class formAbout
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
			this.label2 = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.buttonOK = new System.Windows.Forms.Button();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.label1 = new System.Windows.Forms.Label();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Location = new System.Drawing.Point(3, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(246, 39);
			this.label2.TabIndex = 1;
			this.label2.Text = "Dedicate to my dreamgirl,\r\n  wish her happy and beautiful forever.";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.buttonOK, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.linkLabel1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 4;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(252, 139);
			this.tableLayoutPanel1.TabIndex = 3;
			// 
			// buttonOK
			// 
			this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonOK.Location = new System.Drawing.Point(174, 113);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(75, 23);
			this.buttonOK.TabIndex = 3;
			this.buttonOK.Text = "OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			// 
			// linkLabel1
			// 
			this.linkLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.linkLabel1.LinkArea = new System.Windows.Forms.LinkArea(30, 13);
			this.linkLabel1.Location = new System.Drawing.Point(3, 0);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(246, 40);
			this.linkLabel1.TabIndex = 4;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "=== For private use only ===\r\nVisit website";
			this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.linkLabel1.UseCompatibleTextRendering = true;
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1LinkClicked);
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Location = new System.Drawing.Point(3, 79);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(246, 30);
			this.label1.TabIndex = 5;
			this.label1.Text = "-- Gerald";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// formAbout
			// 
			this.AcceptButton = this.buttonOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonOK;
			this.ClientSize = new System.Drawing.Size(252, 139);
			this.Controls.Add(this.tableLayoutPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = global::SRun3KStupid.Properties.SRun3K.internet1;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "formAbout";
			this.ShowInTaskbar = false;
			this.Text = "About SRun3K Stupid";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label label2;
	}
}
