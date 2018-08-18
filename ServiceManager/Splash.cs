using System;
using System.ServiceProcess;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace ServiceManager
{
	/// <summary>
	/// Summary description for Splash.
	/// </summary>
	public class Splash : System.Windows.Forms.Form
	{
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NotifyIcon notifyIcon1;
		private System.Windows.Forms.ContextMenu contextMenu1;
		private System.Windows.Forms.MenuItem mnuStart;
		private System.Windows.Forms.MenuItem mnuStop;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem mnuSettings;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.Timer timer2;
		private System.Windows.Forms.Timer timer1;
		private System.ComponentModel.IContainer components;
		private ServiceController ctrl;
		private bool hide;
		
		public Splash(bool hide)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			ctrl = new ServiceController("Cassini");
			this.hide = hide;
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Splash));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.contextMenu1 = new System.Windows.Forms.ContextMenu();
			this.mnuStart = new System.Windows.Forms.MenuItem();
			this.mnuStop = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.mnuSettings = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.menuItem6 = new System.Windows.Forms.MenuItem();
			this.timer2 = new System.Windows.Forms.Timer(this.components);
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(8, 8);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(40, 40);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(56, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(216, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "Loading Cassini Service Manager...";
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.ContextMenu = this.contextMenu1;
			this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
			this.notifyIcon1.Text = "Cassini Service Manager";
			this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
			// 
			// contextMenu1
			// 
			this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						 this.mnuStart,
																						 this.mnuStop,
																						 this.menuItem3,
																						 this.mnuSettings,
																						 this.menuItem5,
																						 this.menuItem6});
			// 
			// mnuStart
			// 
			this.mnuStart.Enabled = false;
			this.mnuStart.Index = 0;
			this.mnuStart.Text = "&Start";
			this.mnuStart.Click += new System.EventHandler(this.mnuStart_Click);
			// 
			// mnuStop
			// 
			this.mnuStop.Enabled = false;
			this.mnuStop.Index = 1;
			this.mnuStop.Text = "Sto&p";
			this.mnuStop.Click += new System.EventHandler(this.mnuStop_Click);
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 2;
			this.menuItem3.Text = "-";
			// 
			// mnuSettings
			// 
			this.mnuSettings.Index = 3;
			this.mnuSettings.Text = "Se&ttings";
			this.mnuSettings.Click += new System.EventHandler(this.mnuSettings_Click);
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 4;
			this.menuItem5.Text = "-";
			// 
			// menuItem6
			// 
			this.menuItem6.Index = 5;
			this.menuItem6.Text = "E&xit";
			this.menuItem6.Click += new System.EventHandler(this.menuItem6_Click);
			// 
			// timer2
			// 
			this.timer2.Enabled = true;
			this.timer2.Interval = 500;
			this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// Splash
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(272, 54);
			this.ControlBox = false;
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Name = "Splash";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cassini Service Manager";
			this.Load += new System.EventHandler(this.Splash_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void timer1_Tick(object sender, System.EventArgs e)
		{
			timer1.Enabled = false;
			notifyIcon1.Visible = true;
			if (!hide)
				Form1.GetInstance(this).Show();
			this.Hide();
		}

		private void timer2_Tick(object sender, System.EventArgs e)
		{
			TestStatus();
		}

		private void mnuStart_Click(object sender, System.EventArgs e)
		{
			Start();
		}

		private void TestStatus()
		{
			switch(ctrl.Status)
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
			mnuStart.Enabled = enable;
		}

		private void EnableStop(bool enable)
		{
			mnuStop.Enabled = enable;
		}

		public void Start()
		{
			if (ctrl.Status == ServiceControllerStatus.Stopped)
			{
				ctrl.Start();
				try
				{
					ctrl.WaitForStatus(ServiceControllerStatus.Running, new TimeSpan(0,0,0,5));
					TestStatus();
				}
				catch
				{
					MessageBox.Show("The service could not be started. Please check the configuration settings.", "Cassini Service Manager", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				}
			}
		}

		public void Stop()
		{
			if (ctrl.Status == ServiceControllerStatus.Running)
			{
				ctrl.Stop();
				try
				{
					ctrl.WaitForStatus(ServiceControllerStatus.Stopped, new TimeSpan(0,0,0,5));
				}
				catch
				{
					MessageBox.Show("The service did not stop in a timely fashion.", "Cassini Service Manager", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				}
				TestStatus();
			}
		}

		private void mnuStop_Click(object sender, System.EventArgs e)
		{
			Stop();
		}

		private void mnuSettings_Click(object sender, System.EventArgs e)
		{
			Settings();
		}

		public void Settings()
		{
			DialogResult res = new Settings().ShowDialog(this);
			if (res == DialogResult.OK && ctrl.Status == ServiceControllerStatus.Running)
			{
				if (MessageBox.Show("The configuration of the Cassini Server has been changed. Do you want to restart the service now?", "Cassini Server Manager", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					Stop();
					Start();
				}
			}
		}

		private void menuItem6_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void notifyIcon1_DoubleClick(object sender, System.EventArgs e)
		{
			Form1.GetInstance(this).Show();
		}

		public ServiceControllerStatus Status
		{
			get
			{
				return ctrl.Status;
			}
		}

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args) 
		{
			bool hide = false;
			if (args.Length > 0 && args[0].Trim('-','/') == "hide")
				hide = true;

			Application.Run(new Splash(hide));
		}

		private void Splash_Load(object sender, System.EventArgs e)
		{
		
		}
	}
}
