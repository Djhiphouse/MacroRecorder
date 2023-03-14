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
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//Rec
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
	}
	public class Macro
	{
		public List<String> MacroList = new List<String>();
		public bool OnActivate = false;
		public Task Record(EventArgs keyDown)
		{
			int latestX = 0;
			int latestY = 0;
			while (OnActivate)
			{
				Thread.Sleep(100);
				if (Cursor.Position.X != latestX && Cursor.Position.Y != latestY)
				{
					MacroList.Add("M:" + Cursor.Position.X + "," + Cursor.Position.Y);
					latestY = Cursor.Position.Y;
					latestX = Cursor.Position.X;
				}

				foreach (Keys key in Enum.GetValues(typeof(Keys)))
				{
					//	MacroList.Add(key.ToString());
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

		[DllImport("user32.dll")]
		static extern bool SetCursorPos(int X, int Y);
		public void Play()
		{
			MessageBox.Show("Positions in Array: " + MacroList.Count);
			foreach (var PostionVar in MacroList)
			{
				String[] Positions = PostionVar.ToString().Replace("M:", "").Split(",");
				//MessageBox.Show("Pos : " + Positions[0] + "," + Positions[0]);
				Thread.Sleep(100);
				SetCursorPos(Int32.Parse(Positions[0]), Int32.Parse(Positions[1]));
			}
		}

	}
	public class Config
	{
		public String SlectedPath = "NONE";
		public Config(string slectedPath)
		{
			SlectedPath = slectedPath;
		}

		public void Save(List<String> Config)
		{

			using (StreamWriter ConfigWritter = new StreamWriter(SlectedPath))
			{
				foreach (var CofigLine in Config)
					ConfigWritter.WriteLine(CofigLine);
			}
		}
		public void LoadConfig()
		{
			Macro ConfigSystem = new Macro();
			using (StreamReader ConfigReader = new StreamReader(SlectedPath))
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
