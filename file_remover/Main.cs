using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;

namespace file_remover
{
    public partial class Main : Form
    {
        private DateTime ProgramStartDateTime = DateTime.Now;
        private int WorkHour = 5882;
        private int WorkMinute = 6974;
        private bool WaitWork = true; // 주 동작을 한번만 하도록 플래그 세움        

        private void ShownMainForm(object sender, EventArgs e)
        {
            this.Button_PathFind.Click += ClickButtonPathFind;
            this.Timer_Main.Tick += TickTimerMain;
            this.Timer_Main.Start();
        }

        private void TickTimerMain(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;

            // time span
            this.Label_ProgramRunTime.Text = string.Format("{0:hh\\:mm\\:ss}", now - this.ProgramStartDateTime);

            // main work
            if(int.TryParse(this.TextBox_WorkTime.Text.Split('시')[0], out this.WorkHour) && int.TryParse(this.TextBox_WorkTime.Text.Split('시')[1].Replace('분', ' '), out this.WorkMinute))
            {
                if (now.Hour == this.WorkHour && now.Minute == WorkMinute)
                {
                    if (true == this.WaitWork)
                    {
                        RemoveFiles();                        
                        this.WaitWork = false;
                        GC.Collect();
                    }                    
                }
                else
                {
                    this.WaitWork = true;
                }
            }

            // drive monitoring
            this.Label_TargetDriveSpace.Text = AvailableDriveSize(this.TextBox_TargetPath.Text) + "GB";
        }

        private void RemoveFiles()
        {
            // dynamic where clause 해결되면 확장자 필터링 넣을 것
            var files = Directory.GetFiles(this.TextBox_TargetPath.Text, "*.*", System.IO.SearchOption.AllDirectories)
                .Select(f => new FileInfo(f))
                .Where(f => f.CreationTime < DateTime.Now.AddDays(int.Parse(this.TextBox_AddDays.Text))); 
            // .OrderBy(f => f.CreationTime)

            // 제거 옵션& 제거
            string fullName = "";
            RecycleOption option = this.RadioButton_CleanRemove.Checked ? RecycleOption.DeletePermanently : RecycleOption.SendToRecycleBin;
            foreach(FileInfo file in files)
            {
                try
                {
                    fullName = file.FullName;
                    FileSystem.DeleteFile(fullName, UIOption.OnlyErrorDialogs, option);
                    AppendLog(fullName + " 삭제 완료");
                }
                catch
                {
                    AppendLog(fullName + " 삭제 실패");
                }
            }
        }





        #region 중요치 않음
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);
        private string ConfigPath = string.Format(@"{0}/{1}", Application.StartupPath, "config.ini");

        private bool TestMode = false; // 테스트 모드 flag
        private bool EditMode = false; // 컨트롤 enabled
        private List<Control> ControlList = new List<Control>();

        private string AvailableDriveSize(string _targetPath)
        {
            string availableSize = "";
            string driveName = _targetPath.Split(':')[0];
            
            DriveInfo[] driveArr = DriveInfo.GetDrives();
            foreach(DriveInfo drive in driveArr)
            {
                if(drive.DriveType == DriveType.Fixed && drive.Name.Contains(driveName))
                {
                    availableSize = Convert.ToInt32(drive.AvailableFreeSpace / 1024 / 1024 / 1024).ToString();
                    break;
                }
            }
            driveArr = null;
            return availableSize;
        }

        public Main()
        {
            InitializeComponent();
        }

        private void AppendLog(string _message)
        {
            try
            {
                this.DataGridView_Main.Rows.Insert(0, DateTime.Now.ToString("yyyy-mm-dd hh:mm:ss"), _message.Trim());

                if (this.DataGridView_Main.Rows.Count > 50)
                {
                    this.DataGridView_Main.Rows.RemoveAt(this.DataGridView_Main.Rows.Count - 1);
                }
            }
            catch { }
        }

        private void LoadMainForm(object sender, EventArgs e)
        {
            this.TestMode = GetConfig("TEST_MODE") == "Y" ? true : false;
            this.TextBox_TargetPath.Text = GetConfig("TARGET_PATH");
            this.RadioButton_CleanRemove.Checked = GetConfig("CLEAN_REMOVE_YN") == "Y" ? true : false;
            this.RadioButton_JustRemove.Checked = GetConfig("CLEAN_REMOVE_YN") == "N" ? true : false;
            this.TextBox_AddDays.Text = GetConfig("ADD_DAYS");
            this.TextBox_WorkTime.Text = GetConfig("WORK_TIME");
            this.Label_ProgramRunTime.Text = "00:00:00";
            this.Label_TargetDriveSpace.Text = "";

            this.DataGridView_Main.Columns.Add("time", "시간");
            this.DataGridView_Main.Columns.Add("message", "내용");
            this.DataGridView_Main.Columns[0].Width = 150;
            this.DataGridView_Main.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            typeof(DataGridView).InvokeMember("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty, 
                null, this.DataGridView_Main, new object[] { true });

            ControlList.Add(this.TextBox_TargetPath);
            ControlList.Add(this.GroupBox_Main);
            ControlList.Add(this.TextBox_AddDays);
            ControlList.Add(this.TextBox_WorkTime);
            ControlList.Add(this.Button_PathFind);

            AppendLog("프로그램 시작");
        }

        private void ClickButtonPathFind(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.TextBox_TargetPath.Text = dialog.SelectedPath;
            }
        }

        private void WriteConfig(string _key, string _value)
        {
            try
            {
                WritePrivateProfileString("CONFIG", _key, _value, this.ConfigPath);
            }
            catch (Exception _ex)
            {
                AppendLog("WriteConfig 실패 =" + _ex.Message);
            }
        }

        private string GetConfig(string _key)
        {
            StringBuilder builder = new StringBuilder();

            try
            {
                GetPrivateProfileString("CONFIG", _key, "(NONE)", builder, 128, this.ConfigPath);
            }
            catch (Exception _ex)
            {
                AppendLog("GetConfig 실패 =" + _ex.Message);
            }

            return builder.ToString().Trim();
        }

        private void ClickTestButton(object sender, EventArgs e)
        {
            if (true == this.TestMode)
            {
                RemoveFiles();
                GC.Collect();
            }
        }

        private void ClosingMainForm(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("정말요?", "경고", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            e.Cancel = result == DialogResult.OK ? false : true;
        }

        private void ClickButtonLockAndSave(object sender, EventArgs e)
        {
            // control enabled
            this.EditMode = !this.EditMode;
            foreach (Control c in this.ControlList)
            {
                c.Enabled = this.EditMode;
            }

            // update config ini
            if (false == this.EditMode)
            {
                WriteConfig("TARGET_PATH", this.TextBox_TargetPath.Text.Trim());
                WriteConfig("CLEAN_REMOVE_YN", this.RadioButton_CleanRemove.Checked == true ? "Y" : "N");
                WriteConfig("ADD_DAYS", this.TextBox_AddDays.Text.Trim());
                WriteConfig("WORK_TIME", this.TextBox_WorkTime.Text.Trim());
                AppendLog("프로그램 설정 변경 완료");
            }            
        }

        private void ClickOpenFolder(object sender, EventArgs e)
        {
            Process.Start(this.TextBox_TargetPath.Text);
        }

        private void ClickLogClear(object sender, EventArgs e)
        {
            this.DataGridView_Main.Rows.Clear();
        }

        private void ClickButtonHelp(object sender, EventArgs e)
        {
            Process.Start(string.Format(@"{0}/{1}", Application.StartupPath, "readme.txt"));
        }
        #endregion
    }
}
