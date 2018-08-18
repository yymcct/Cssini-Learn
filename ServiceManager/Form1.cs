using System;
using System.ServiceProcess;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace ServiceManager
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Timer timer1;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Button btnStop;
		private System.Windows.Forms.Label lblStart;
		private System.Windows.Forms.Label lblStop;
		private System.Windows.Forms.Label lblSettings;
		private System.Windows.Forms.Button btnSettings;

		private static Form1 instance;
		private Splash s;

		private Form1(Splash s)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			this.s = s;
		}

		public static Form1 GetInstance(Splash s)
		{
			if (instance == null)
				instance = new Form1(s);

			return instance;
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.btnStart = new System.Windows.Forms.Button();
			this.btnStop = new System.Windows.Forms.Button();
			this.lblStart = new System.Windows.Forms.Label();
			this.lblStop = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lblSettings = new System.Windows.Forms.Label();
			this.btnSettings = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// btnStart
			// 
			this.btnStart.Image = ((System.Drawing.Image)(resources.GetObject("btnStart.Image")));
			this.btnStart.Location = new System.Drawing.Point(69, 40);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(32, 32);
			this.btnStart.TabIndex = 1;
			this.btnStart.TabStop = false;
			this.btnStart.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// btnStop
			// 
			this.btnStop.Image = ((System.Drawing.Image)(resources.GetObject("btnStop.Image")));
			this.btnStop.Location = new System.Drawing.Point(69, 80);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new System.Drawing.Size(32, 32);
			this.btnStop.TabIndex = 3;
			this.btnStop.TabStop = false;
			this.btnStop.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
			// 
			// lblStart
			// 
			this.lblStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblStart.Location = new System.Drawing.Point(109, 48);
			this.lblStart.Name = "lblStart";
			this.lblStart.Size = new System.Drawing.Size(57, 23);
			this.lblStart.TabIndex = 2;
			this.lblStart.Text = "Start";
			// 
			// lblStop
			// 
			this.lblStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblStop.Location = new System.Drawing.Point(109, 88);
			this.lblStop.Name = "lblStop";
			this.lblStop.Size = new System.Drawing.Size(57, 23);
			this.lblStop.TabIndex = 4;
			this.lblStop.Text = "Stop";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Navy;
			this.label3.Location = new System.Drawing.Point(9, 8);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(216, 23);
			this.label3.TabIndex = 0;
			this.label3.Text = "Cassini Service Manager";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label4
			// 
			this.label4.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.label4.ForeColor = System.Drawing.Color.Green;
			this.label4.Location = new System.Drawing.Point(0, 161);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(234, 23);
			this.label4.TabIndex = 7;
			this.label4.Text = "Bart De Smet - 2004 - www.bartdesmet.net";
			// 
			// lblSettings
			// 
			this.lblSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblSettings.Location = new System.Drawing.Point(109, 128);
			this.lblSettings.Name = "lblSettings";
			this.lblSettings.Size = new System.Drawing.Size(57, 23);
			this.lblSettings.TabIndex = 6;
			this.lblSettings.Text = "Settings";
			// 
			// btnSettings
			// 
			this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
			this.btnSettings.Location = new System.Drawing.Point(69, 120);
			this.btnSettings.Name = "btnSettings";
			this.btnSettings.Size = new System.Drawing.Size(32, 32);
			this.btnSettings.TabIndex = 5;
			this.btnSettings.TabStop = false;
			this.btnSettings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 500;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(234, 184);
			this.Controls.Add(this.lblSettings);
			this.Controls.Add(this.btnSettings);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lblStop);
			this.Controls.Add(this.lblStart);
			this.Controls.Add(this.btnStop);
			this.Controls.Add(this.btnStart);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cassini Service Manager";
			this.Closing += new System.ComponentModel.CancelEventHandler(this.Form1_Closing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void notifyIcon1_DoubleClick(object sender, System.EventArgs e)
		{
			this.Show();
		}

		private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			instance = null;
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			TestStatus();
		}

		private void timer1_Tick(object sender, System.EventArgs e)
		{
			TestStatus();
		}

		private void TestStatus()
		{
			switch(s.Status)
			{
				case ServiceControllerStatus.Running:
					EnableStart(false);
					EnableStop(true);
					break;
				case ServiceControllerStatus.Stopped:
					EnableStart(true);
					EnableStop(false);
					break;
				default:
					break;
			}
		}

		private void EnableStart(bool enable)
		{
			btnStart.Enabled = lblStart.Enabled = enable;
		}

		private void EnableStop(bool enable)
		{
			btnStop.Enabled = lblStop.Enabled = enable;
		}

		private void btnStart_Click(object sender, System.EventArgs e)
		{
			s.Start();
		}

		private void btnStop_Click(object sender, System.EventArgs e)
		{
			s.Stop();
		}

		private void btnSettings_Click(object sender, System.EventArgs e)
		{
			s.Settings();
		}
	}
}
