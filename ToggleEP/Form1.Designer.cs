namespace ToggleEP
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
			DisableButton = new Button();
			EnableButton = new Button();
			WindowsDxgiLabel = new Label();
			StartDxgiLabel = new Label();
			ShellDxgiLabel = new Label();
			WindowsDxgiEnabled = new Label();
			StartDxgiEnabled = new Label();
			ShellDxgiEnabled = new Label();
			DisableWindowsDxgi = new Button();
			EnableWindowsDxgi = new Button();
			DisableStartDxgi = new Button();
			EnableStartDxgi = new Button();
			DisableShellDxgi = new Button();
			EnableShellDxgi = new Button();
			SuspendLayout();
			// 
			// DisableButton
			// 
			DisableButton.Location = new Point(12, 12);
			DisableButton.Name = "DisableButton";
			DisableButton.Size = new Size(100, 25);
			DisableButton.TabIndex = 0;
			DisableButton.Text = "Disable All";
			DisableButton.UseVisualStyleBackColor = true;
			DisableButton.Click += DisableButton_Click;
			// 
			// EnableButton
			// 
			EnableButton.Location = new Point(118, 12);
			EnableButton.Name = "EnableButton";
			EnableButton.Size = new Size(100, 25);
			EnableButton.TabIndex = 1;
			EnableButton.Text = "Enable All";
			EnableButton.UseVisualStyleBackColor = true;
			EnableButton.Click += EnableButton_Click;
			// 
			// WindowsDxgiLabel
			// 
			WindowsDxgiLabel.AutoSize = true;
			WindowsDxgiLabel.Location = new Point(12, 49);
			WindowsDxgiLabel.Name = "WindowsDxgiLabel";
			WindowsDxgiLabel.Size = new Size(100, 15);
			WindowsDxgiLabel.TabIndex = 2;
			WindowsDxgiLabel.Text = "Windows dxgi.dll:";
			// 
			// StartDxgiLabel
			// 
			StartDxgiLabel.AutoSize = true;
			StartDxgiLabel.Location = new Point(12, 95);
			StartDxgiLabel.Name = "StartDxgiLabel";
			StartDxgiLabel.Size = new Size(109, 15);
			StartDxgiLabel.TabIndex = 3;
			StartDxgiLabel.Text = "Start Menu dxgi.dll:";
			// 
			// ShellDxgiLabel
			// 
			ShellDxgiLabel.AutoSize = true;
			ShellDxgiLabel.Location = new Point(12, 141);
			ShellDxgiLabel.Name = "ShellDxgiLabel";
			ShellDxgiLabel.Size = new Size(76, 15);
			ShellDxgiLabel.TabIndex = 4;
			ShellDxgiLabel.Text = "Shell dxgi.dll:";
			// 
			// WindowsDxgiEnabled
			// 
			WindowsDxgiEnabled.Location = new Point(118, 49);
			WindowsDxgiEnabled.Name = "WindowsDxgiEnabled";
			WindowsDxgiEnabled.Size = new Size(100, 15);
			WindowsDxgiEnabled.TabIndex = 5;
			WindowsDxgiEnabled.Text = "Loading...";
			WindowsDxgiEnabled.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// StartDxgiEnabled
			// 
			StartDxgiEnabled.Location = new Point(118, 95);
			StartDxgiEnabled.Name = "StartDxgiEnabled";
			StartDxgiEnabled.Size = new Size(100, 15);
			StartDxgiEnabled.TabIndex = 6;
			StartDxgiEnabled.Text = "Loading...";
			StartDxgiEnabled.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// ShellDxgiEnabled
			// 
			ShellDxgiEnabled.Location = new Point(118, 141);
			ShellDxgiEnabled.Name = "ShellDxgiEnabled";
			ShellDxgiEnabled.Size = new Size(100, 15);
			ShellDxgiEnabled.TabIndex = 7;
			ShellDxgiEnabled.Text = "Loading...";
			ShellDxgiEnabled.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// DisableWindowsDxgi
			// 
			DisableWindowsDxgi.Location = new Point(12, 67);
			DisableWindowsDxgi.Name = "DisableWindowsDxgi";
			DisableWindowsDxgi.Size = new Size(100, 25);
			DisableWindowsDxgi.TabIndex = 8;
			DisableWindowsDxgi.Text = "Disable Module";
			DisableWindowsDxgi.UseVisualStyleBackColor = true;
			DisableWindowsDxgi.Click += DisableWindowsDxgi_Click;
			// 
			// EnableWindowsDxgi
			// 
			EnableWindowsDxgi.Location = new Point(118, 67);
			EnableWindowsDxgi.Name = "EnableWindowsDxgi";
			EnableWindowsDxgi.Size = new Size(100, 25);
			EnableWindowsDxgi.TabIndex = 9;
			EnableWindowsDxgi.Text = "Enable Module";
			EnableWindowsDxgi.UseVisualStyleBackColor = true;
			EnableWindowsDxgi.Click += EnableWindowsDxgi_Click;
			// 
			// DisableStartDxgi
			// 
			DisableStartDxgi.Location = new Point(12, 113);
			DisableStartDxgi.Name = "DisableStartDxgi";
			DisableStartDxgi.Size = new Size(100, 25);
			DisableStartDxgi.TabIndex = 10;
			DisableStartDxgi.Text = "Disable Module";
			DisableStartDxgi.UseVisualStyleBackColor = true;
			DisableStartDxgi.Click += DisableStartDxgi_Click;
			// 
			// EnableStartDxgi
			// 
			EnableStartDxgi.Location = new Point(118, 113);
			EnableStartDxgi.Name = "EnableStartDxgi";
			EnableStartDxgi.Size = new Size(100, 25);
			EnableStartDxgi.TabIndex = 11;
			EnableStartDxgi.Text = "Enable Module";
			EnableStartDxgi.UseVisualStyleBackColor = true;
			EnableStartDxgi.Click += EnableStartDxgi_Click;
			// 
			// DisableShellDxgi
			// 
			DisableShellDxgi.Location = new Point(12, 159);
			DisableShellDxgi.Name = "DisableShellDxgi";
			DisableShellDxgi.Size = new Size(100, 25);
			DisableShellDxgi.TabIndex = 12;
			DisableShellDxgi.Text = "Disable Module";
			DisableShellDxgi.UseVisualStyleBackColor = true;
			DisableShellDxgi.Click += DisableShellDxgi_Click;
			// 
			// EnableShellDxgi
			// 
			EnableShellDxgi.Location = new Point(118, 159);
			EnableShellDxgi.Name = "EnableShellDxgi";
			EnableShellDxgi.Size = new Size(100, 25);
			EnableShellDxgi.TabIndex = 13;
			EnableShellDxgi.Text = "Enable Module";
			EnableShellDxgi.UseVisualStyleBackColor = true;
			EnableShellDxgi.Click += EnableShellDxgi_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(231, 194);
			Controls.Add(EnableShellDxgi);
			Controls.Add(DisableShellDxgi);
			Controls.Add(EnableStartDxgi);
			Controls.Add(DisableStartDxgi);
			Controls.Add(EnableWindowsDxgi);
			Controls.Add(DisableWindowsDxgi);
			Controls.Add(ShellDxgiEnabled);
			Controls.Add(StartDxgiEnabled);
			Controls.Add(WindowsDxgiEnabled);
			Controls.Add(ShellDxgiLabel);
			Controls.Add(StartDxgiLabel);
			Controls.Add(WindowsDxgiLabel);
			Controls.Add(EnableButton);
			Controls.Add(DisableButton);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "Form1";
			ShowIcon = false;
			Text = "Toggle ExplorerPatcher";
			Load += Form1_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button DisableButton;
		private Button EnableButton;
		private Label WindowsDxgiLabel;
		private Label StartDxgiLabel;
		private Label ShellDxgiLabel;
		private Button DisableWindowsDxgi;
		private Label WindowsDxgiEnabled;
		private Label StartDxgiEnabled;
		private Label ShellDxgiEnabled;
		private Button EnableWindowsDxgi;
		private Button DisableStartDxgi;
		private Button EnableStartDxgi;
		private Button DisableShellDxgi;
		private Button EnableShellDxgi;
	}
}
