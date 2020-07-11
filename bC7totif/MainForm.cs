using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices;


namespace bulkTexConverter
{
    public partial class MainForm : Form
    {
        static string gamePath;
        static string outDir;
        static string toolPath;
        static bool busy;
        static Queue<string> consoleBuffer;
        static ListBox.ObjectCollection Items; 
        static int maxfiles;
        static int currentfiles;

        public MainForm()
        {
            consoleBuffer = new Queue<string>();
            InitializeComponent();
            this.MinimumSize = new Size(333, 593);
            this.MaximumSize = new Size(333, 593);
           
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            reloadSettings();
   
        }

        private void reloadSettings()
        {
            gamePath = appSettings.Default.gamePath;
            outDir = appSettings.Default.outDir;
            toolPath = appSettings.Default.toolPath;
            tbToolPath.Text = toolPath;
            tbOutputDir.Text = outDir;
            tbGameDirectory.Text = gamePath;
        }

        private void updateSettings()
        {
            appSettings.Default.gamePath = gamePath;
            appSettings.Default.outDir = outDir;
            appSettings.Default.toolPath = toolPath;
            appSettings.Default.Save();
        }


        private void bigButton_Click(object sender, EventArgs e)
        {

        }

        private void uiUpdate_Tick(object sender, EventArgs e)
        {
            if (toolPath == null || toolPath.Length < 2)
            {
                tbToolPath.BackColor = Color.Pink;
                lblToolPath1.ForeColor = Color.Red;
            } else
            {
                tbToolPath.BackColor = Color.White;
                lblToolPath1.ForeColor = Color.Green;
            }

            if (outDir == null || outDir.Length < 2)
            {
                tbOutputDir.BackColor = Color.Pink;
                lblOutputDir.ForeColor = Color.Red;
            }
            else
            {
                tbOutputDir.BackColor = Color.White;
                lblOutputDir.ForeColor = Color.Green;
            }


            if (gamePath == null || gamePath.Length < 2)
            {
                tbGameDirectory.BackColor = Color.Pink;
                lblGameDirectory.ForeColor = Color.Red;
            }
            else
            {
                tbGameDirectory.BackColor = Color.White;
                lblGameDirectory.ForeColor = Color.Green;
            }

            if (gamePath == null || gamePath.Length < 2 || toolPath == null || toolPath.Length < 2 || gamePath == null || gamePath.Length < 2 || outDir == null || outDir.Length < 2 || busy)
            {
                btnConvert.Enabled = false;
            } else
            {
                btnConvert.Enabled = true;
            }
            if (consoleBuffer.Count > 0)
            {
                var op = consoleBuffer.Dequeue();
                if (op != null)
                {
                    lbConsoleOutput.Items.Add(op);
                    int visibleItems = lbConsoleOutput.ClientSize.Height / lbConsoleOutput.ItemHeight;
                    lbConsoleOutput.TopIndex = Math.Max(lbConsoleOutput.Items.Count - visibleItems + 1, 0);
                }
            }
            convertProgress.Maximum = maxfiles;
            convertProgress.Value = currentfiles;
            convertProgress.Minimum = 0;
        
           
        }

        private void btnSelToolPath_Click(object sender, EventArgs e)
        {
            var diagRes = appFolderBrowser.ShowDialog();
            if (diagRes == DialogResult.OK)
            {
                toolPath = appFolderBrowser.SelectedPath;
                tbToolPath.Text = toolPath;
                updateSettings();
            }

        }

        private void btnBrowseOut_Click(object sender, EventArgs e)
        {
            var diagRes = appFolderBrowser.ShowDialog();
            if (diagRes == DialogResult.OK)
            {
                outDir = appFolderBrowser.SelectedPath;
                tbOutputDir.Text = outDir;
                updateSettings();
            }
        }

        private void btnBrowseGameDir_Click(object sender, EventArgs e)
        {
            var diagRes = appFolderBrowser.ShowDialog();
            if (diagRes == DialogResult.OK)
            {
                gamePath = appFolderBrowser.SelectedPath;
                tbGameDirectory.Text = gamePath;
                updateSettings();
            }
        }

        private void resetSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            appSettings.Default.Reset();
            tbToolPath.Text = "";
            tbOutputDir.Text = "";
            //tbGameDirectory.Text = "";
            tbToolPath.Text = appSettings.Default.toolPath;
            tbOutputDir.Text = appSettings.Default.outDir;
            tbGameDirectory.Text = appSettings.Default.gamePath;
            //appSettings.Default.Save();
        }

        private void tbToolPath_TextChanged(object sender, EventArgs e)
        {
            toolPath = tbToolPath.Text;
            updateSettings();
        }

        private void tbOutputDir_TextChanged(object sender, EventArgs e)
        {
            outDir = tbOutputDir.Text;
            updateSettings();
        }

        private void tbGameDirectory_TextChanged(object sender, EventArgs e)
        {
            
            gamePath = tbGameDirectory.Text;
            updateSettings();
        }



        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


        public static Process StartProcess(string executable, string commandline)
        {
            try
            {
                ProcessStartInfo sInfo = new ProcessStartInfo();
                var myProcess = new Process();
                myProcess.StartInfo = sInfo;
                sInfo.CreateNoWindow = true;
                sInfo.FileName = executable;
                sInfo.Arguments = commandline;
                myProcess.StartInfo.UseShellExecute = false;
                myProcess.StartInfo.RedirectStandardOutput = true;
                myProcess.OutputDataReceived += (sender, args) => { 
                    //Console.WriteLine(args.Data); lock (consoleBuffer) { consoleBuffer.Enqueue(args.Data); }
                };
                myProcess.Start();
                myProcess.BeginOutputReadLine();
                return myProcess;
            }
            catch { consoleBuffer.Enqueue("Error starting process."); }
            return null;
        }

        public static void doConvertAll()
        {

           busy = true;
           var count = 0;
           foreach (string obj in Items)
            {
                if (obj!=null)
                {
                    count++;
                }
            }

            string[] finalDirList = new string[count];

            var cdx = 0;
            foreach (string obj in Items)
            {
                if (obj != null)
                {
                    finalDirList[cdx] = obj;
                    cdx++; 
                }
            }


            var fileCount = 0;

            for (int i=0; i < finalDirList.Length;i++)
            {
                var iPth = gamePath + finalDirList[i];
                if (Directory.Exists(iPth))
                {
                    var w = Directory.GetFiles(iPth, "*", SearchOption.AllDirectories);
                    fileCount += w.Length;
                }
            }

            var fileList = new string[fileCount];
            var fIdx = 0;
            for (int i = 0; i < finalDirList.Length; i++)
            {
                var iPth = gamePath + finalDirList[i];
            
                if (Directory.Exists(iPth))
                {
                    var w = Directory.GetFiles(iPth, "*", SearchOption.AllDirectories);
                    for (int b = 0; b < w.Length; b++)
                    {
                        fileList[fIdx] = w[b];
                        fIdx++;
                    }
                }
            }
         
            maxfiles = fileList.Length;

            int current_working = 0;
            Parallel.For(0, maxfiles, new ParallelOptions { MaxDegreeOfParallelism = 10 }, i =>
            {
                var currentFilePath = fileList[i];
                var DirName = Path.GetDirectoryName(currentFilePath);
                var relDir = DirName.Replace(gamePath, "");
                var destDir = outDir + relDir;
                var convFileName = Path.GetFileName(currentFilePath);
                Directory.CreateDirectory(destDir);
                currentfiles++;
                var cmdArgs = string.Format("-ft TIF -if LINEAR -sRGB -y -o \"{0}\" \"{1}\"", destDir, currentFilePath);
                var newProcess = StartProcess(toolPath + "\\texconv.exe", cmdArgs);
                if (newProcess != null)
                {
                    newProcess.WaitForExit();
                    Interlocked.Increment(ref current_working);
                    consoleBuffer.Enqueue("Converting: " + convFileName + " (" + current_working + "/" + maxfiles + ")");
                }
            }
            );

            MessageBox.Show("Finished!", "Conversion completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            currentfiles = 0;
            busy = false;

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {

            if (!File.Exists(toolPath + "/texconv.exe"))
            {
                MessageBox.Show("Cannot find texconv.exe under tool directory.\n\nPlease ensure ModSDK is installed.", "Error (01)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Directory.Exists(gamePath))
            {
                MessageBox.Show("Game path is wrong.\n\nPlease ensure game is installed.", "Error (02)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            currentfiles = 0;
            Items = lbfolderList.Items;
            var asyncThreadParamInit = new ThreadStart(doConvertAll);
            //doConvertAll();
            var mthd = new Thread(asyncThreadParamInit);
            mthd.Start();
        }

        private void performTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // defunct debug shit
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var diagRes = appFolderBrowser.ShowDialog();
            if (diagRes == DialogResult.OK)
            {
                
                var pth1 = appFolderBrowser.SelectedPath;
                var pth2 = pth1.Replace(gamePath + "\\", "\\");
                if (pth2 == pth1)
                {
                    MessageBox.Show("Path must be inside game directory.", "Error (03)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                lbfolderList.Items.Add(pth2);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            object oc = null;
            try
            {
                oc = lbfolderList.Items[lbfolderList.SelectedIndex];
            } catch { }

            if (oc!=null) 
            {
                lbfolderList.Items.RemoveAt(lbfolderList.SelectedIndex);
            }
        }

        private void LoadPresetsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists("presets.ini"))
            {

                lbfolderList.Items.Clear();
                var presetItems = File.ReadAllLines("presets.ini");
                for (int i = 0; i < presetItems.Length; i++)
                {
                    if (presetItems[i] == null)
                        continue;
                    var pth1 = presetItems[i];
                    lbfolderList.Items.Add(pth1);
                }
            }
            else
            {
                MessageBox.Show("presets.ini not found in application directory.", "Error (05)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInsertPresets_Click(object sender, EventArgs e)
        {
            if (File.Exists("presets.ini"))
            {

                lbfolderList.Items.Clear();
                var presetItems = File.ReadAllLines("presets.ini");
                for (int i = 0; i < presetItems.Length; i++)
                {
                    if (presetItems[i] == null)
                        continue;
                    var pth1 = presetItems[i];
                    lbfolderList.Items.Add(pth1);
                }
            }
            else
            {
                MessageBox.Show("presets.ini not found in application directory.", "Error (07)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
