using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression;
using System.Diagnostics;

namespace TraductorDeModsMC
{
    public partial class MinecraftTranslator : Form
    {
        private string ModPath;
        private string NewModPath;
        private string translatePath;
        string modId;
        string currentLenguage;

        Process myProcess = new Process();
        public MinecraftTranslator()
        {
            InitializeComponent();
        }

        private void SelectMod(object sender, EventArgs e)
        {
            if(File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\.minecraft\options.txt"))
            {
                currentLenguage = File.ReadLines((Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\.minecraft\options.txt")).Skip(38).Take(1).First().Replace("lang:", "");
            }
            else
            {
                currentLenguage = "es_es";
            }
            if (Directory.Exists(Directory.GetCurrentDirectory() + @"\Mod"))
            {
                Directory.Delete(Directory.GetCurrentDirectory() + @"\Mod", true);
            }
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                ModPath = openFileDialog1.FileName;
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + @"\Mod");
                File.Copy(ModPath, Directory.GetCurrentDirectory() + @"\Mod\ToTranslate.jar");
                NewModPath = Directory.GetCurrentDirectory() + @"\Mod\ToTranslate.jar";
                ZipFile.ExtractToDirectory(NewModPath, Directory.GetCurrentDirectory() + @"\Mod\UnZipped\");
                SearchModId.Enabled = true;
            }
            ModPathBut.Enabled = false;
            TranslatePathBut.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            modId = File.ReadLines(Directory.GetCurrentDirectory() + @"\Mod\UnZipped\META-INF\mods.toml").Skip(5).Take(1).First();
            modId = modId.Replace("modId=", "");
            modId = modId.Replace("\"", "");
            SearchModId.Enabled = false;
        }

        private void SelectLang(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                translatePath = openFileDialog1.FileName;
            }
            TranslatePathBut.Enabled = false;
            StartBut.Enabled = true;
        }

        private void Translate(object sender, EventArgs e)
        {
            if (translatePath.Contains("json"))
            {
                File.Copy(translatePath, (Directory.GetCurrentDirectory() + @"\Mod\UnZipped\assets\" + modId + @"\lang\" + currentLenguage + ".json"));
            }
            else
            {
                File.Copy(translatePath, (Directory.GetCurrentDirectory() + @"\Mod\UnZipped\assets\" + modId + @"\lang\" + currentLenguage + ".lang"));
            }
            ZipFile.CreateFromDirectory(Directory.GetCurrentDirectory() + @"\Mod\UnZipped", Directory.GetCurrentDirectory() + @"\Mod\" + modId + ".jar");
            DeleteFiles();
            Process.Start("explorer.exe", Directory.GetCurrentDirectory() + @"\Mod\");
            myProcess.StartInfo.UseShellExecute = true;
            myProcess.StartInfo.FileName = "https://www.youtube.com/channel/UCOAHgm6pf3a1w9Z_caLzFhg";
            myProcess.Start();
            Application.Restart();
        }

        private void DeleteFiles()
        {
            Directory.Delete(Directory.GetCurrentDirectory() + @"\Mod\UnZipped", true);
            File.Delete(Directory.GetCurrentDirectory() + @"\Mod\ToTranslate.jar");
        }

    }
}
