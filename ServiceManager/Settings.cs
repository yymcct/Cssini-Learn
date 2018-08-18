using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Microsoft.Win32;

namespace ServiceManager
{
	/// <summary>
	/// Summary description for Settings.
	/// </summary>
	public class Settings : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label lblSettings;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblStop;
		private System.Windows.Forms.Label lblStart;
		private System.Windows.Forms.TextBox txtPath;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.FolderBrowserDialog folderBrowser;
		private System.Windows.Forms.TextBox txtVdir;
		private System.Windows.Forms.TextBox txtPort;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;

		private string path;
		private string vdir;
		private int port;

		private RegistryKey key;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Settings()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			key = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Cassini", true);

			port = int.Parse(key.GetValue("port").ToString());
			path = key.GetValue("path").ToString();
			vdir = key.GetValue("vdir","/").ToString();
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
			this.lblSettings = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblStop = new System.Windows.Forms.Label();
			this.lblStart = new System.Windows.Forms.Label();
			this.txtPath = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
			this.txtVdir = new System.Windows.Forms.TextBox();
			this.txtPort = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblSettings
			// 
			this.lblSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblSettings.Location = new System.Drawing.Point(8, 124);
			this.lblSettings.Name = "lblSettings";
			this.lblSettings.Size = new System.Drawing.Size(96, 23);
			this.lblSettings.TabIndex = 6;
			this.lblSettings.Text = "Port:";
			this.lblSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.label4.ForeColor = System.Drawing.Color.Green;
			this.label4.Location = new System.Drawing.Point(0, 201);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(346, 23);
			this.label4.TabIndex = 10;
			this.label4.Text = "Bart De Smet - 2004 - www.bartdesmet.net";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Navy;
			this.label3.Location = new System.Drawing.Point(65, 4);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(216, 23);
			this.label3.TabIndex = 0;
			this.label3.Text = "Cassini Service Settings";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// lblStop
			// 
			this.lblStop.Enabled = false;
			this.lblStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblStop.Location = new System.Drawing.Point(8, 84);
			this.lblStop.Name = "lblStop";
			this.lblStop.Size = new System.Drawing.Size(96, 23);
			this.lblStop.TabIndex = 4;
			this.lblStop.Text = "Virtual directory:";
			this.lblStop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblStart
			// 
			this.lblStart.Enabled = false;
			this.lblStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblStart.Location = new System.Drawing.Point(8, 44);
			this.lblStart.Name = "lblStart";
			this.lblStart.Size = new System.Drawing.Size(96, 23);
			this.lblStart.TabIndex = 1;
			this.lblStart.Text = "Home directory:";
			this.lblStart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtPath
			// 
			this.txtPath.Location = new System.Drawing.Point(104, 48);
			this.txtPath.Name = "txtPath";
			this.txtPath.ReadOnly = true;
			this.txtPath.Size = new System.Drawing.Size(200, 20);
			this.txtPath.TabIndex = 2;
			this.txtPath.Text = "";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(312, 48);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(24, 23);
			this.button1.TabIndex = 3;
			this.button1.Text = "...";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// folderBrowser
			// 
			this.folderBrowser.RootFolder = System.Environment.SpecialFolder.MyComputer;
			// 
			// txtVdir
			// 
			this.txtVdir.Location = new System.Drawing.Point(104, 86);
			this.txtVdir.Name = "txtVdir";
			this.txtVdir.Size = new System.Drawing.Size(200, 20);
			this.txtVdir.TabIndex = 5;
			this.txtVdir.Text = "";
			// 
			// txtPort
			// 
			this.txtPort.Location = new System.Drawing.Point(104, 128);
			this.txtPort.MaxLength = 5;
			this.txtPort.Name = "txtPort";
			this.txtPort.Size = new System.Drawing.Size(56, 20);
			this.txtPort.TabIndex = 7;
			this.txtPort.Text = "";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(92, 168);
			this.button2.Name = "button2";
			this.button2.TabIndex = 8;
			this.button2.Text = "OK";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button3.Location = new System.Drawing.Point(180, 168);
			this.button3.Name = "button3";
			this.button3.TabIndex = 9;
			this.button3.Text = "Cancel";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// Settings
			// 
			this.AcceptButton = this.button2;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.CancelButton = this.button3;
			this.ClientSize = new System.Drawing.Size(346, 224);
			this.ControlBox = false;
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.txtPort);
			this.Controls.Add(this.txtVdir);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txtPath);
			this.Controls.Add(this.lblSettings);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lblStop);
			this.Controls.Add(this.lblStart);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "Settings";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Cassini Service Settings";
			this.Load += new System.EventHandler(this.Settings_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void Settings_Load(object sender, System.EventArgs e)
		{
			txtPort.Text = port.ToString();
			txtPath.Text = path;
			txtVdir.Text = vdir;
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			folderBrowser.SelectedPath = txtPath.Text;
			if (folderBrowser.ShowDialog(this) == DialogResult.OK)
                txtPath.Text = folderBrowser.SelectedPath;			
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			if (HasChanged())
			{
				Save();
				this.DialogResult = DialogResult.OK;
				return;
			}
			
			this.DialogResult = DialogResult.Cancel;
		}

		private bool HasChanged()
		{
			return (txtPort.Text != port.ToString() || txtPath.Text != path || txtVdir.Text != vdir);
		}

		private void Save()
		{
			try
			{
				key.SetValue("port",int.Parse(txtPort.Text));
			}
			catch
			{
				txtPort.Focus();
				return;
			}
			key.SetValue("path",txtPath.Text);
			key.SetValue("vdir",txtVdir.Text);
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			if (HasChanged())
			{
				DialogResult res = MessageBox.Show("Changes have been made to the configuration. Do you want to continue without saving the changes?","Cassini Service Settings",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
				if (res == DialogResult.No)
					return;
			}

			this.DialogResult = DialogResult.Cancel;
		}
	}
}
