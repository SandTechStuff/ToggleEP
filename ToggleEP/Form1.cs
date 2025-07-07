using System.Diagnostics;
using System.IO;

namespace ToggleEP
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			CheckIfExists();
		}
		private void EnableButton_Click(Object sender, EventArgs e)
		{
			EnableAllModules();
		}
		private void DisableButton_Click(object sender, EventArgs e)
		{
			DisableAllModules();
		}
		private void EnableWindowsDxgi_Click(object sender, EventArgs e)
		{
			EnableWindowsModule();
		}
		private void DisableWindowsDxgi_Click(object sender, EventArgs e)
		{
			DisableWindowsModule();
		}
		private void EnableStartDxgi_Click(object sender, EventArgs e)
		{
			EnableStartModule();
		}
		private void DisableStartDxgi_Click(object sender, EventArgs e)
		{
			DisableStartModule();
		}
		private void EnableShellDxgi_Click(object sender, EventArgs e)
		{
			EnableShellModule();
		}
		private void DisableShellDxgi_Click(object sender, EventArgs e)
		{
			DisableShellModule();
		}
		static void RestartExplorer()
		{
			Process[] RunningProcesses = Process.GetProcesses();
			bool RestartSuccess = false;

			foreach (Process Pro in RunningProcesses)
			{
				if (Pro.ProcessName == "explorer")
				{
					Pro.Kill();
				}
			}

			foreach (Process Pro in RunningProcesses)
			{
				if (Pro.ProcessName == "explorer")
				{
					RestartSuccess = true;
				}
			}

			if (!RestartSuccess)
			{
				Process.Start("explorer.exe");
			}
		}
		private void CheckIfExists()
		{
			if (File.Exists(@"C:\Windows\dxgi.dll"))
			{
				WindowsDxgiEnabled.Text = "Enabled";
				WindowsDxgiEnabled.ForeColor = Color.Green;
			}
			else
			{
				WindowsDxgiEnabled.Text = "Disabled";
				WindowsDxgiEnabled.ForeColor = Color.Red;
			}
			if (File.Exists(@"C:\Windows\SystemApps\Microsoft.Windows.StartMenuExperienceHost_cw5n1h2txyewy\dxgi.dll"))
			{
				StartDxgiEnabled.Text = "Enabled";
				StartDxgiEnabled.ForeColor = Color.Green;
			}
			else
			{
				StartDxgiEnabled.Text = "Disabled";
				StartDxgiEnabled.ForeColor = Color.Red;
			}
			if (File.Exists(@"C:\Windows\SystemApps\ShellExperienceHost_cw5n1h2txyewy\dxgi.dll"))
			{
				ShellDxgiEnabled.Text = "Enabled";
				ShellDxgiEnabled.ForeColor = Color.Green;
			}
			else
			{
				ShellDxgiEnabled.Text = "Disabled";
				ShellDxgiEnabled.ForeColor = Color.Red;
			}
		}
		private void EnableAllModules()
		{
			if (File.Exists(@"C:\Windows\dxgi.dll.old"))
			{
				File.Move(@"C:\Windows\dxgi.dll.old", @"C:\Windows\dxgi.dll");
			}
			if (File.Exists(@"C:\Windows\SystemApps\Microsoft.Windows.StartMenuExperienceHost_cw5n1h2txyewy\dxgi.dll.old"))
			{
				File.Move(@"C:\Windows\SystemApps\Microsoft.Windows.StartMenuExperienceHost_cw5n1h2txyewy\dxgi.dll.old", @"C:\Windows\SystemApps\Microsoft.Windows.StartMenuExperienceHost_cw5n1h2txyewy\dxgi.dll");
			}
			if (File.Exists(@"C:\Windows\SystemApps\ShellExperienceHost_cw5n1h2txyewy\dxgi.dll.old"))
			{
				File.Move(@"C:\Windows\SystemApps\ShellExperienceHost_cw5n1h2txyewy\dxgi.dll.old", @"C:\Windows\SystemApps\ShellExperienceHost_cw5n1h2txyewy\dxgi.dll");
			}

			RestartExplorer();
			CheckIfExists();
		}
		private void DisableAllModules()
		{
			if (File.Exists(@"C:\Windows\dxgi.dll"))
			{
				File.Move(@"C:\Windows\dxgi.dll", @"C:\Windows\dxgi.dll.old");
			}
			if (File.Exists(@"C:\Windows\SystemApps\Microsoft.Windows.StartMenuExperienceHost_cw5n1h2txyewy\dxgi.dll"))
			{
				File.Move(@"C:\Windows\SystemApps\Microsoft.Windows.StartMenuExperienceHost_cw5n1h2txyewy\dxgi.dll", @"C:\Windows\SystemApps\Microsoft.Windows.StartMenuExperienceHost_cw5n1h2txyewy\dxgi.dll.old");
			}
			if (File.Exists(@"C:\Windows\SystemApps\ShellExperienceHost_cw5n1h2txyewy\dxgi.dll"))
			{
				File.Move(@"C:\Windows\SystemApps\ShellExperienceHost_cw5n1h2txyewy\dxgi.dll", @"C:\Windows\SystemApps\ShellExperienceHost_cw5n1h2txyewy\dxgi.dll.old");
			}

			RestartExplorer();
			CheckIfExists();
		}
		private void EnableWindowsModule()
		{
			if (File.Exists(@"C:\Windows\dxgi.dll.old"))
			{
				File.Move(@"C:\Windows\dxgi.dll.old", @"C:\Windows\dxgi.dll");
			}

			RestartExplorer();
			CheckIfExists();
		}

		private void DisableWindowsModule()
		{
			if (File.Exists(@"C:\Windows\dxgi.dll"))
			{
				File.Move(@"C:\Windows\dxgi.dll", @"C:\Windows\dxgi.dll.old");
			}

			RestartExplorer();
			CheckIfExists();
		}

		private void EnableStartModule()
		{
			if (File.Exists(@"C:\Windows\SystemApps\Microsoft.Windows.StartMenuExperienceHost_cw5n1h2txyewy\dxgi.dll.old"))
			{
				File.Move(@"C:\Windows\SystemApps\Microsoft.Windows.StartMenuExperienceHost_cw5n1h2txyewy\dxgi.dll.old", @"C:\Windows\SystemApps\Microsoft.Windows.StartMenuExperienceHost_cw5n1h2txyewy\dxgi.dll");
			}

			RestartExplorer();
			CheckIfExists();
		}

		private void DisableStartModule()
		{
			if (File.Exists(@"C:\Windows\SystemApps\Microsoft.Windows.StartMenuExperienceHost_cw5n1h2txyewy\dxgi.dll"))
			{
				File.Move(@"C:\Windows\SystemApps\Microsoft.Windows.StartMenuExperienceHost_cw5n1h2txyewy\dxgi.dll", @"C:\Windows\SystemApps\Microsoft.Windows.StartMenuExperienceHost_cw5n1h2txyewy\dxgi.dll.old");
			}

			RestartExplorer();
			CheckIfExists();
		}

		private void EnableShellModule()
		{
			if (File.Exists(@"C:\Windows\SystemApps\ShellExperienceHost_cw5n1h2txyewy\dxgi.dll.old"))
			{
				File.Move(@"C:\Windows\SystemApps\ShellExperienceHost_cw5n1h2txyewy\dxgi.dll.old", @"C:\Windows\SystemApps\ShellExperienceHost_cw5n1h2txyewy\dxgi.dll");
			}

			RestartExplorer();
			CheckIfExists();
		}

		private void DisableShellModule()
		{
			if (File.Exists(@"C:\Windows\SystemApps\ShellExperienceHost_cw5n1h2txyewy\dxgi.dll"))
			{
				File.Move(@"C:\Windows\SystemApps\ShellExperienceHost_cw5n1h2txyewy\dxgi.dll", @"C:\Windows\SystemApps\ShellExperienceHost_cw5n1h2txyewy\dxgi.dll.old");
			}

			RestartExplorer();
			CheckIfExists();
		}
	}
}
