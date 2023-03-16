using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MacroRecorder
{
	public partial class Form1 : Form
	{
		public Macro macro = new Macro();
		public Config ConfigSystem = new Config(Directory.GetCurrentDirectory() + "\\MacroConfigs");
		public Form1()
		{
			InitializeComponent();

		}


		/*
		private void button1_Click(object sender, EventArgs e)
		{
			//Recd
			macro.ToogleRecord(true);
			Task.Run(() => { macro.Record(e); });
		}

		private void button2_Click(object sender, EventArgs e)
		{
			//Stop
			macro.StopRecording();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			//Play
			macro.Play();
		}
		*/
		private void PlayMacro_Click(object sender, EventArgs e)
		{
			macro.Play();
		}

		private void StopMacro_Click(object sender, EventArgs e)
		{
			macro.StopRecording();
		}

		private void SaveMacro_Click(object sender, EventArgs e)
		{
			ConfigSystem.Save(macro.MacroList);
		}

		private void PlayConfigFile_Click(object sender, EventArgs e)
		{
			//MessageBox.Show(AllConfigs.SelectedItem.ToString());
			ConfigSystem.PlayConfigFile(AllConfigs.SelectedItem.ToString());
		}

		private void ConfigFileName_Click(object sender, EventArgs e)
		{
			ConfigSystem.SaveAsConfig(ConfigNameBox.Text, macro.MacroList);
		}

		private void AllConfigs_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void Record_Click(object sender, EventArgs e)
		{
			macro.MacroList.Clear();
			macro.ToogleRecord(true);
			Task.Run(() => { macro.Record(e); });
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Task.Run(() =>
			{
				CheckForIllegalCrossThreadCalls = false;
				string[] fileNames = Directory.GetFiles(Directory.GetCurrentDirectory() + "\\MacroConfigs", "*.config");

				foreach (string fileName in fileNames)
				{
					AllConfigs.Items.Add(Path.GetFileName(fileName));
				}

			});

		}

		private void Form1_KeyPress(object sender, KeyPressEventArgs e)
		{
			//MessageBox.Show("Die Taste " + e.KeyChar.ToString() + " wurde gedrückt.");
		}

		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			MessageBox.Show("Die Taste " + e.KeyCode.ToString() + " wurde gedrückt.");
		}

		private void Clicktest_Click(object sender, EventArgs e)
		{
			Task.Run(() =>
			{
				CheckForIllegalCrossThreadCalls = false;
				MessageBox.Show("Clicked");

			});
		}
	}
	public class Macro
	{
		[DllImport("user32.dll")]
		public static extern short GetAsyncKeyState(int vKey);
		public List<String> MacroList = new List<String>();
		public Config ConfigSystem = new Config(Directory.GetCurrentDirectory() + "\\MacroConfigs");
		public bool OnActivate = false;
		public Mouse mouse = new Mouse();
		public Task Record(EventArgs keyDown)
		{
			int latestX = 0;
			int latestY = 0;
			//Check for Pressed Keys
			Task.Run(() =>
			{

				while (OnActivate)
				{

					short leftMouseButtonState = GetAsyncKeyState(0x01);
					// Check for Left Mouse Site
					if (leftMouseButtonState == -32767)
					{
						MacroList.Add("LeftMouseClick");
					}

					// Check for right Mouse Site
					short rightMouseButtonState = GetAsyncKeyState(0x02);

					if (rightMouseButtonState == -32767)
					{
						MacroList.Add("RightMouseClick");
					}

					for (int i = 0; i < 255; i++)
					{
						short keyState = GetAsyncKeyState(i);

						if (keyState == -32767)
						{
							MacroList.Add(((ConsoleKey)i).ToString());
						}
					}
				}

			});
			//Check for Mouse Cords
			while (OnActivate)
			{
				Thread.Sleep(1);


				if (Cursor.Position.X != latestX && Cursor.Position.Y != latestY)
				{
					MacroList.Add("M:" + Cursor.Position.X + "," + Cursor.Position.Y);
					latestY = Cursor.Position.Y;
					latestX = Cursor.Position.X;
				}
			}

			return Task.CompletedTask;
		}
		public void ToogleRecord(bool toggle)
		{
			OnActivate = toggle;
		}
		public void StopRecording()
		{
			ToogleRecord(false);
		}

		//Mouse Requirements
		[DllImport("user32.dll")]
		static extern bool SetCursorPos(int X, int Y);


		public void Play()
		{
			MessageBox.Show("Positions in Array: " + MacroList.Count);
			foreach (var PostionVar in MacroList)
			{
				Thread.Sleep(20);
				//Check for key
				if (PostionVar.StartsWith("M:"))
				{
					String[] Positions = PostionVar.ToString().Replace("M:", "").Split(',');
					//MessageBox.Show("Pos : " + Positions[0] + "," + Positions[1]);
					//Thread.Sleep(100);
					SetCursorPos(Int32.Parse(Positions[0]), Int32.Parse(Positions[1]));
				}
				else
				{

					if (PostionVar.StartsWith("LeftMouseClick"))
					{
						// Linksklick simulieren.
						mouse.SendMouseClick();
					}
					else
					{
						//Key Press here
						//	MessageBox.Show("Send Key: " + PostionVar.ToString());
						Thread.Sleep(100);
						SendKeys.SendWait(PostionVar.ToString());
						SendKeys.Flush();
					}
				}

			}
		}
		public void PlayConfigFile(Guna2ComboBox Dropdownmenu)
		{

		}

	}
	public class Mouse
	{
		[DllImport("user32.dll")]
		public static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

		private const int MOUSEEVENTF_LEFTDOWN = 0x0002;
		private const int MOUSEEVENTF_LEFTUP = 0x0004;
		public void SendMouseClick()
		{
			// Position des Mauszeigers
			int x = Cursor.Position.X;
			int y = Cursor.Position.Y;

			// Linksklick simulieren.
			mouse_event(MOUSEEVENTF_LEFTDOWN, (int)x, (int)y, 0, 0);
			mouse_event(MOUSEEVENTF_LEFTUP, (int)x, (int)y, 0, 0);
		}
	}
	public class Config
	{

		[DllImport("user32.dll")]
		static extern bool SetCursorPos(int X, int Y);
		public Mouse mouse = new Mouse();
		public List<string> ConfigMacro = new List<string>();
		public String SlectedPath = "NONE";
		public Config(string slectedPath)
		{
			SlectedPath = slectedPath;
		}
		bool ExistRequierements()
		{
			if (!Directory.Exists(SlectedPath))
			{
				Directory.CreateDirectory(SlectedPath);
				return true;
			}

			return false;
		}
		public void Save(List<String> Config)
		{
			if (!ExistRequierements())
				return;

			using (StreamWriter ConfigWritter = new StreamWriter(SlectedPath))
			{
				foreach (var CofigLine in Config)
					ConfigWritter.WriteLine(CofigLine);
			}
		}

		public void SaveAsConfig(String Configname, List<string> Macros)
		{
			File.Create(SlectedPath + "\\" + Configname + ".config").Close();
			File.WriteAllText(SlectedPath + "\\" + Configname + ".config", String.Join("\n", Macros));
		}
		public void PlayConfigFile(String ConfigName)
		{


			foreach (var line in File.ReadAllLines(Directory.GetCurrentDirectory() + "\\MacroConfigs\\" + ConfigName))
			{
				//Append to MacroList
				ConfigMacro.Add(line);

			}

			//Print Num of Positions
			MessageBox.Show("Positions in Array: " + ConfigMacro.Count);
			foreach (var PostionVar in ConfigMacro)
			{
				//MessageBox.Show("Go");
				Thread.Sleep(20);
				//Check for key
				if (PostionVar.StartsWith("M:"))
				{
					String[] Positions = PostionVar.ToString().Replace("M:", "").Split(',');
					//MessageBox.Show("Pos : " + Positions[0] + "," + Positions[1]);
					//Thread.Sleep(100);
					SetCursorPos(Int32.Parse(Positions[0]), Int32.Parse(Positions[1]));
				}
				else
				{

					if (PostionVar.StartsWith("LeftMouseClick"))
					{
						// Linksklick simulieren.
						mouse.SendMouseClick();
					}
					else
					{
						//Key Press here
						//	MessageBox.Show("Send Key: " + PostionVar.ToString());
						Thread.Sleep(100);
						SendKeys.SendWait(PostionVar.ToString());
						SendKeys.Flush();
					}
				}

			}
		}
		public void LoadConfig(String ConfigName)
		{
			Macro ConfigSystem = new Macro();

			if (!ExistRequierements())
				return;

			using (StreamReader ConfigReader = new StreamReader(SlectedPath + "\\" + ConfigName))
			{
				while (ConfigReader.Peek() != 0)
				{
					String Line = ConfigReader.ReadLine();
					if (Line != "")
					{
						ConfigSystem.MacroList.Add(Line);
					}
				}
			}
		}
	}
}
