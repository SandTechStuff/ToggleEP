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
			button1 = new Button();
			button2 = new Button();
			button3 = new Button();
			button4 = new Button();
			button5 = new Button();
			button6 = new Button();
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
			WindowsDxgiEnabled.AutoSize = true;
			WindowsDxgiEnabled.Location = new Point(129, 49);
			WindowsDxgiEnabled.Name = "WindowsDxgiEnabled";
			WindowsDxgiEnabled.Size = new Size(59, 15);
			WindowsDxgiEnabled.TabIndex = 5;
			WindowsDxgiEnabled.Text = "Loading...";
			// 
			// StartDxgiEnabled
			// 
			StartDxgiEnabled.AutoSize = true;
			StartDxgiEnabled.Location = new Point(129, 95);
			StartDxgiEnabled.Name = "StartDxgiEnabled";
			StartDxgiEnabled.Size = new Size(59, 15);
			StartDxgiEnabled.TabIndex = 6;
			StartDxgiEnabled.Text = "Loading...";
			// 
			// ShellDxgiEnabled
			// 
			ShellDxgiEnabled.AutoSize = true;
			ShellDxgiEnabled.Location = new Point(129, 141);
			ShellDxgiEnabled.Name = "ShellDxgiEnabled";
			ShellDxgiEnabled.Size = new Size(59, 15);
			ShellDxgiEnabled.TabIndex = 7;
			ShellDxgiEnabled.Text = "Loading...";
			// 
			// button1
			// 
			button1.Location = new Point(12, 67);
			button1.Name = "button1";
			button1.Size = new Size(100, 25);
			button1.TabIndex = 8;
			button1.Text = "Disable Module";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.Location = new Point(118, 67);
			button2.Name = "button2";
			button2.Size = new Size(100, 25);
			button2.TabIndex = 9;
			button2.Text = "Enable Module";
			button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			button3.Location = new Point(12, 113);
			button3.Name = "button3";
			button3.Size = new Size(100, 25);
			button3.TabIndex = 10;
			button3.Text = "Disable Module";
			button3.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			button4.Location = new Point(118, 113);
			button4.Name = "button4";
			button4.Size = new Size(100, 25);
			button4.TabIndex = 11;
			button4.Text = "Enable Module";
			button4.UseVisualStyleBackColor = true;
			// 
			// button5
			// 
			button5.Location = new Point(12, 159);
			button5.Name = "button5";
			button5.Size = new Size(100, 25);
			button5.TabIndex = 12;
			button5.Text = "Disable Module";
			button5.UseVisualStyleBackColor = true;
			// 
			// button6
			// 
			button6.Location = new Point(118, 157);
			button6.Name = "button6";
			button6.Size = new Size(100, 25);
			button6.TabIndex = 13;
			button6.Text = "Enable Module";
			button6.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(231, 194);
			Controls.Add(button6);
			Controls.Add(button5);
			Controls.Add(button4);
			Controls.Add(button3);
			Controls.Add(button2);
			Controls.Add(button1);
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
		private Button button1;
		private Label WindowsDxgiEnabled;
		private Label StartDxgiEnabled;
		private Label ShellDxgiEnabled;
		private Button button2;
		private Button button3;
		private Button button4;
		private Button button5;
		private Button button6;
	}
}
