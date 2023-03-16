namespace MacroRecorder
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
			this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
			this.AllConfigs = new Guna.UI2.WinForms.Guna2ComboBox();
			this.StopMacro = new Guna.UI2.WinForms.Guna2GradientButton();
			this.PlayMacro = new Guna.UI2.WinForms.Guna2GradientButton();
			this.SaveMacro = new Guna.UI2.WinForms.Guna2GradientButton();
			this.PlayConfigFile = new Guna.UI2.WinForms.Guna2GradientButton();
			this.ConfigNameBox = new Guna.UI2.WinForms.Guna2TextBox();
			this.ConfigFileName = new Guna.UI2.WinForms.Guna2GradientButton();
			this.Record = new Guna.UI2.WinForms.Guna2GradientButton();
			this.Clicktest = new Guna.UI2.WinForms.Guna2GradientButton();
			this.SuspendLayout();
			// 
			// guna2BorderlessForm1
			// 
			this.guna2BorderlessForm1.ContainerControl = this;
			this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
			this.guna2BorderlessForm1.TransparentWhileDrag = true;
			// 
			// AllConfigs
			// 
			this.AllConfigs.BackColor = System.Drawing.Color.Transparent;
			this.AllConfigs.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.AllConfigs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.AllConfigs.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.AllConfigs.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.AllConfigs.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.AllConfigs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
			this.AllConfigs.ItemHeight = 30;
			this.AllConfigs.Location = new System.Drawing.Point(206, 149);
			this.AllConfigs.Name = "AllConfigs";
			this.AllConfigs.Size = new System.Drawing.Size(140, 36);
			this.AllConfigs.TabIndex = 3;
			this.AllConfigs.SelectedIndexChanged += new System.EventHandler(this.AllConfigs_SelectedIndexChanged);
			// 
			// StopMacro
			// 
			this.StopMacro.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.StopMacro.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.StopMacro.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.StopMacro.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.StopMacro.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.StopMacro.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.StopMacro.ForeColor = System.Drawing.Color.White;
			this.StopMacro.Location = new System.Drawing.Point(6, 84);
			this.StopMacro.Name = "StopMacro";
			this.StopMacro.Size = new System.Drawing.Size(76, 33);
			this.StopMacro.TabIndex = 4;
			this.StopMacro.Text = "Stop";
			this.StopMacro.Click += new System.EventHandler(this.StopMacro_Click);
			// 
			// PlayMacro
			// 
			this.PlayMacro.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.PlayMacro.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.PlayMacro.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.PlayMacro.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.PlayMacro.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.PlayMacro.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.PlayMacro.ForeColor = System.Drawing.Color.White;
			this.PlayMacro.Location = new System.Drawing.Point(6, 27);
			this.PlayMacro.Name = "PlayMacro";
			this.PlayMacro.Size = new System.Drawing.Size(76, 33);
			this.PlayMacro.TabIndex = 5;
			this.PlayMacro.Text = "Play";
			this.PlayMacro.Click += new System.EventHandler(this.PlayMacro_Click);
			// 
			// SaveMacro
			// 
			this.SaveMacro.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.SaveMacro.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.SaveMacro.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.SaveMacro.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.SaveMacro.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.SaveMacro.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.SaveMacro.ForeColor = System.Drawing.Color.White;
			this.SaveMacro.Location = new System.Drawing.Point(107, 84);
			this.SaveMacro.Name = "SaveMacro";
			this.SaveMacro.Size = new System.Drawing.Size(76, 33);
			this.SaveMacro.TabIndex = 6;
			this.SaveMacro.Text = "Save";
			this.SaveMacro.Click += new System.EventHandler(this.SaveMacro_Click);
			// 
			// PlayConfigFile
			// 
			this.PlayConfigFile.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.PlayConfigFile.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.PlayConfigFile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.PlayConfigFile.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.PlayConfigFile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.PlayConfigFile.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.PlayConfigFile.ForeColor = System.Drawing.Color.White;
			this.PlayConfigFile.Location = new System.Drawing.Point(206, 191);
			this.PlayConfigFile.Name = "PlayConfigFile";
			this.PlayConfigFile.Size = new System.Drawing.Size(140, 33);
			this.PlayConfigFile.TabIndex = 7;
			this.PlayConfigFile.Text = "Play Config";
			this.PlayConfigFile.Click += new System.EventHandler(this.PlayConfigFile_Click);
			// 
			// ConfigNameBox
			// 
			this.ConfigNameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.ConfigNameBox.DefaultText = "";
			this.ConfigNameBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.ConfigNameBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.ConfigNameBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.ConfigNameBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.ConfigNameBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.ConfigNameBox.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.ConfigNameBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.ConfigNameBox.Location = new System.Drawing.Point(206, 60);
			this.ConfigNameBox.Name = "ConfigNameBox";
			this.ConfigNameBox.PasswordChar = '\0';
			this.ConfigNameBox.PlaceholderText = "";
			this.ConfigNameBox.SelectedText = "";
			this.ConfigNameBox.Size = new System.Drawing.Size(140, 33);
			this.ConfigNameBox.TabIndex = 8;
			// 
			// ConfigFileName
			// 
			this.ConfigFileName.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.ConfigFileName.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.ConfigFileName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.ConfigFileName.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.ConfigFileName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.ConfigFileName.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.ConfigFileName.ForeColor = System.Drawing.Color.White;
			this.ConfigFileName.Location = new System.Drawing.Point(206, 99);
			this.ConfigFileName.Name = "ConfigFileName";
			this.ConfigFileName.Size = new System.Drawing.Size(140, 33);
			this.ConfigFileName.TabIndex = 9;
			this.ConfigFileName.Text = "Save Config";
			this.ConfigFileName.Click += new System.EventHandler(this.ConfigFileName_Click);
			// 
			// Record
			// 
			this.Record.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.Record.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.Record.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.Record.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.Record.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.Record.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.Record.ForeColor = System.Drawing.Color.White;
			this.Record.Location = new System.Drawing.Point(107, 27);
			this.Record.Name = "Record";
			this.Record.Size = new System.Drawing.Size(76, 33);
			this.Record.TabIndex = 10;
			this.Record.Text = "Rec";
			this.Record.Click += new System.EventHandler(this.Record_Click);
			// 
			// Clicktest
			// 
			this.Clicktest.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.Clicktest.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.Clicktest.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.Clicktest.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.Clicktest.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.Clicktest.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.Clicktest.ForeColor = System.Drawing.Color.White;
			this.Clicktest.Location = new System.Drawing.Point(51, 191);
			this.Clicktest.Name = "Clicktest";
			this.Clicktest.Size = new System.Drawing.Size(76, 33);
			this.Clicktest.TabIndex = 11;
			this.Clicktest.Text = "Click test";
			this.Clicktest.Click += new System.EventHandler(this.Clicktest_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(358, 245);
			this.Controls.Add(this.Clicktest);
			this.Controls.Add(this.Record);
			this.Controls.Add(this.ConfigFileName);
			this.Controls.Add(this.ConfigNameBox);
			this.Controls.Add(this.PlayConfigFile);
			this.Controls.Add(this.SaveMacro);
			this.Controls.Add(this.PlayMacro);
			this.Controls.Add(this.StopMacro);
			this.Controls.Add(this.AllConfigs);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
			this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
		private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
		private Guna.UI2.WinForms.Guna2GradientButton PlayConfigFile;
		private Guna.UI2.WinForms.Guna2GradientButton SaveMacro;
		private Guna.UI2.WinForms.Guna2GradientButton PlayMacro;
		private Guna.UI2.WinForms.Guna2GradientButton StopMacro;
		private Guna.UI2.WinForms.Guna2ComboBox AllConfigs;
		private Guna.UI2.WinForms.Guna2GradientButton ConfigFileName;
		private Guna.UI2.WinForms.Guna2TextBox ConfigNameBox;
		private Guna.UI2.WinForms.Guna2GradientButton Record;
		private Guna.UI2.WinForms.Guna2GradientButton Clicktest;
	}
}
