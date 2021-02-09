
namespace file_remover
{
    partial class Main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.TableLayoutPanel_Main = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TextBox_TargetPath = new System.Windows.Forms.TextBox();
            this.GroupBox_Main = new System.Windows.Forms.GroupBox();
            this.RadioButton_JustRemove = new System.Windows.Forms.RadioButton();
            this.RadioButton_CleanRemove = new System.Windows.Forms.RadioButton();
            this.DataGridView_Main = new System.Windows.Forms.DataGridView();
            this.Button_PathFind = new System.Windows.Forms.Button();
            this.Label_ProgramRunTime = new System.Windows.Forms.Label();
            this.Label_TargetDriveSpace = new System.Windows.Forms.Label();
            this.Button_LockAndSave = new System.Windows.Forms.Button();
            this.TextBox_WorkTime = new System.Windows.Forms.MaskedTextBox();
            this.TextBox_AddDays = new System.Windows.Forms.MaskedTextBox();
            this.Button_OpenFolder = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TextBox_RemoveExtension = new System.Windows.Forms.TextBox();
            this.Timer_Main = new System.Windows.Forms.Timer(this.components);
            this.MenuStrip_Main = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Dev = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_ClearLog = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Test = new System.Windows.Forms.ToolStripMenuItem();
            this.TableLayoutPanel_Main.SuspendLayout();
            this.GroupBox_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Main)).BeginInit();
            this.MenuStrip_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableLayoutPanel_Main
            // 
            this.TableLayoutPanel_Main.BackColor = System.Drawing.SystemColors.Control;
            this.TableLayoutPanel_Main.ColumnCount = 5;
            this.TableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.TableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.TableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.TableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.TableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.TableLayoutPanel_Main.Controls.Add(this.label1, 0, 0);
            this.TableLayoutPanel_Main.Controls.Add(this.label2, 0, 1);
            this.TableLayoutPanel_Main.Controls.Add(this.label3, 0, 2);
            this.TableLayoutPanel_Main.Controls.Add(this.label4, 0, 4);
            this.TableLayoutPanel_Main.Controls.Add(this.label5, 0, 6);
            this.TableLayoutPanel_Main.Controls.Add(this.label6, 2, 6);
            this.TableLayoutPanel_Main.Controls.Add(this.TextBox_TargetPath, 1, 0);
            this.TableLayoutPanel_Main.Controls.Add(this.GroupBox_Main, 1, 1);
            this.TableLayoutPanel_Main.Controls.Add(this.DataGridView_Main, 0, 5);
            this.TableLayoutPanel_Main.Controls.Add(this.Button_PathFind, 3, 0);
            this.TableLayoutPanel_Main.Controls.Add(this.Label_ProgramRunTime, 1, 6);
            this.TableLayoutPanel_Main.Controls.Add(this.Label_TargetDriveSpace, 3, 6);
            this.TableLayoutPanel_Main.Controls.Add(this.Button_LockAndSave, 3, 4);
            this.TableLayoutPanel_Main.Controls.Add(this.TextBox_WorkTime, 1, 4);
            this.TableLayoutPanel_Main.Controls.Add(this.TextBox_AddDays, 1, 2);
            this.TableLayoutPanel_Main.Controls.Add(this.Button_OpenFolder, 4, 0);
            this.TableLayoutPanel_Main.Controls.Add(this.label7, 0, 3);
            this.TableLayoutPanel_Main.Controls.Add(this.TextBox_RemoveExtension, 1, 3);
            this.TableLayoutPanel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel_Main.Location = new System.Drawing.Point(0, 24);
            this.TableLayoutPanel_Main.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TableLayoutPanel_Main.Name = "TableLayoutPanel_Main";
            this.TableLayoutPanel_Main.RowCount = 7;
            this.TableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.TableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.TableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.TableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.TableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.TableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.TableLayoutPanel_Main.Size = new System.Drawing.Size(884, 437);
            this.TableLayoutPanel_Main.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "타겟 경로";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(5, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 50);
            this.label2.TabIndex = 1;
            this.label2.Text = "완전삭제 유무";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(5, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "보존일 (오늘로 부터)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(5, 165);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "수행시간 (매일)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(5, 402);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 0, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 30);
            this.label5.TabIndex = 4;
            this.label5.Text = "프로그램 동작시간";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(359, 402);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 0, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 30);
            this.label6.TabIndex = 5;
            this.label6.Text = "타겟 드라이브 여유";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TextBox_TargetPath
            // 
            this.TableLayoutPanel_Main.SetColumnSpan(this.TextBox_TargetPath, 2);
            this.TextBox_TargetPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox_TargetPath.Enabled = false;
            this.TextBox_TargetPath.Location = new System.Drawing.Point(165, 9);
            this.TextBox_TargetPath.Margin = new System.Windows.Forms.Padding(5, 9, 5, 5);
            this.TextBox_TargetPath.Name = "TextBox_TargetPath";
            this.TextBox_TargetPath.Size = new System.Drawing.Size(344, 21);
            this.TextBox_TargetPath.TabIndex = 6;
            // 
            // GroupBox_Main
            // 
            this.TableLayoutPanel_Main.SetColumnSpan(this.GroupBox_Main, 2);
            this.GroupBox_Main.Controls.Add(this.RadioButton_JustRemove);
            this.GroupBox_Main.Controls.Add(this.RadioButton_CleanRemove);
            this.GroupBox_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBox_Main.Enabled = false;
            this.GroupBox_Main.Location = new System.Drawing.Point(165, 35);
            this.GroupBox_Main.Margin = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.GroupBox_Main.Name = "GroupBox_Main";
            this.GroupBox_Main.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupBox_Main.Size = new System.Drawing.Size(344, 50);
            this.GroupBox_Main.TabIndex = 7;
            this.GroupBox_Main.TabStop = false;
            // 
            // RadioButton_JustRemove
            // 
            this.RadioButton_JustRemove.AutoSize = true;
            this.RadioButton_JustRemove.Location = new System.Drawing.Point(98, 20);
            this.RadioButton_JustRemove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RadioButton_JustRemove.Name = "RadioButton_JustRemove";
            this.RadioButton_JustRemove.Size = new System.Drawing.Size(123, 16);
            this.RadioButton_JustRemove.TabIndex = 1;
            this.RadioButton_JustRemove.TabStop = true;
            this.RadioButton_JustRemove.Text = "아니요 휴지통으로";
            this.RadioButton_JustRemove.UseVisualStyleBackColor = true;
            // 
            // RadioButton_CleanRemove
            // 
            this.RadioButton_CleanRemove.AutoSize = true;
            this.RadioButton_CleanRemove.Location = new System.Drawing.Point(18, 20);
            this.RadioButton_CleanRemove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RadioButton_CleanRemove.Name = "RadioButton_CleanRemove";
            this.RadioButton_CleanRemove.Size = new System.Drawing.Size(35, 16);
            this.RadioButton_CleanRemove.TabIndex = 0;
            this.RadioButton_CleanRemove.TabStop = true;
            this.RadioButton_CleanRemove.Text = "예";
            this.RadioButton_CleanRemove.UseVisualStyleBackColor = true;
            // 
            // DataGridView_Main
            // 
            this.DataGridView_Main.AllowUserToAddRows = false;
            this.DataGridView_Main.AllowUserToDeleteRows = false;
            this.DataGridView_Main.AllowUserToResizeRows = false;
            this.DataGridView_Main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.TableLayoutPanel_Main.SetColumnSpan(this.DataGridView_Main, 5);
            this.DataGridView_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView_Main.Location = new System.Drawing.Point(5, 200);
            this.DataGridView_Main.Margin = new System.Windows.Forms.Padding(5);
            this.DataGridView_Main.Name = "DataGridView_Main";
            this.DataGridView_Main.RowHeadersVisible = false;
            this.DataGridView_Main.RowTemplate.Height = 23;
            this.DataGridView_Main.Size = new System.Drawing.Size(774, 197);
            this.DataGridView_Main.TabIndex = 10;
            // 
            // Button_PathFind
            // 
            this.Button_PathFind.Enabled = false;
            this.Button_PathFind.Location = new System.Drawing.Point(514, 9);
            this.Button_PathFind.Margin = new System.Windows.Forms.Padding(0, 9, 0, 5);
            this.Button_PathFind.Name = "Button_PathFind";
            this.Button_PathFind.Size = new System.Drawing.Size(100, 21);
            this.Button_PathFind.TabIndex = 11;
            this.Button_PathFind.Text = "찾기";
            this.Button_PathFind.UseVisualStyleBackColor = true;
            // 
            // Label_ProgramRunTime
            // 
            this.Label_ProgramRunTime.AutoSize = true;
            this.Label_ProgramRunTime.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Label_ProgramRunTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_ProgramRunTime.Location = new System.Drawing.Point(165, 402);
            this.Label_ProgramRunTime.Margin = new System.Windows.Forms.Padding(5, 0, 0, 5);
            this.Label_ProgramRunTime.Name = "Label_ProgramRunTime";
            this.Label_ProgramRunTime.Size = new System.Drawing.Size(189, 30);
            this.Label_ProgramRunTime.TabIndex = 12;
            this.Label_ProgramRunTime.Text = "Label_ProgramRunTime";
            this.Label_ProgramRunTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label_TargetDriveSpace
            // 
            this.Label_TargetDriveSpace.AutoSize = true;
            this.Label_TargetDriveSpace.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TableLayoutPanel_Main.SetColumnSpan(this.Label_TargetDriveSpace, 2);
            this.Label_TargetDriveSpace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_TargetDriveSpace.Location = new System.Drawing.Point(514, 402);
            this.Label_TargetDriveSpace.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.Label_TargetDriveSpace.Name = "Label_TargetDriveSpace";
            this.Label_TargetDriveSpace.Size = new System.Drawing.Size(265, 30);
            this.Label_TargetDriveSpace.TabIndex = 13;
            this.Label_TargetDriveSpace.Text = "Label_TargetDriveSpace";
            this.Label_TargetDriveSpace.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Button_LockAndSave
            // 
            this.Button_LockAndSave.Location = new System.Drawing.Point(514, 169);
            this.Button_LockAndSave.Margin = new System.Windows.Forms.Padding(0, 9, 5, 5);
            this.Button_LockAndSave.Name = "Button_LockAndSave";
            this.Button_LockAndSave.Size = new System.Drawing.Size(100, 21);
            this.Button_LockAndSave.TabIndex = 14;
            this.Button_LockAndSave.Text = "잠금 및 적용";
            this.Button_LockAndSave.UseVisualStyleBackColor = true;
            this.Button_LockAndSave.Click += new System.EventHandler(this.ClickButtonLockAndSave);
            // 
            // TextBox_WorkTime
            // 
            this.TableLayoutPanel_Main.SetColumnSpan(this.TextBox_WorkTime, 2);
            this.TextBox_WorkTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox_WorkTime.Enabled = false;
            this.TextBox_WorkTime.Location = new System.Drawing.Point(165, 169);
            this.TextBox_WorkTime.Margin = new System.Windows.Forms.Padding(5, 9, 5, 5);
            this.TextBox_WorkTime.Mask = "90시90분";
            this.TextBox_WorkTime.Name = "TextBox_WorkTime";
            this.TextBox_WorkTime.Size = new System.Drawing.Size(344, 21);
            this.TextBox_WorkTime.TabIndex = 15;
            this.TextBox_WorkTime.ValidatingType = typeof(System.DateTime);
            // 
            // TextBox_AddDays
            // 
            this.TableLayoutPanel_Main.SetColumnSpan(this.TextBox_AddDays, 2);
            this.TextBox_AddDays.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox_AddDays.Enabled = false;
            this.TextBox_AddDays.Location = new System.Drawing.Point(165, 99);
            this.TextBox_AddDays.Margin = new System.Windows.Forms.Padding(5, 9, 5, 5);
            this.TextBox_AddDays.Mask = "-9";
            this.TextBox_AddDays.Name = "TextBox_AddDays";
            this.TextBox_AddDays.Size = new System.Drawing.Size(344, 21);
            this.TextBox_AddDays.TabIndex = 16;
            this.TextBox_AddDays.ValidatingType = typeof(int);
            // 
            // Button_OpenFolder
            // 
            this.Button_OpenFolder.Location = new System.Drawing.Point(624, 9);
            this.Button_OpenFolder.Margin = new System.Windows.Forms.Padding(0, 9, 0, 5);
            this.Button_OpenFolder.Name = "Button_OpenFolder";
            this.Button_OpenFolder.Size = new System.Drawing.Size(100, 21);
            this.Button_OpenFolder.TabIndex = 18;
            this.Button_OpenFolder.Text = "경로 열기";
            this.Button_OpenFolder.UseVisualStyleBackColor = true;
            this.Button_OpenFolder.Click += new System.EventHandler(this.ClickOpenFolder);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(5, 130);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 30);
            this.label7.TabIndex = 22;
            this.label7.Text = "삭제 타겟 확장자";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TextBox_RemoveExtension
            // 
            this.TableLayoutPanel_Main.SetColumnSpan(this.TextBox_RemoveExtension, 2);
            this.TextBox_RemoveExtension.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox_RemoveExtension.Enabled = false;
            this.TextBox_RemoveExtension.Location = new System.Drawing.Point(165, 134);
            this.TextBox_RemoveExtension.Margin = new System.Windows.Forms.Padding(5, 9, 5, 5);
            this.TextBox_RemoveExtension.Name = "TextBox_RemoveExtension";
            this.TextBox_RemoveExtension.Size = new System.Drawing.Size(344, 21);
            this.TextBox_RemoveExtension.TabIndex = 21;
            this.TextBox_RemoveExtension.Text = ".txt,.bmp";
            // 
            // Timer_Main
            // 
            this.Timer_Main.Interval = 1000;
            // 
            // MenuStrip_Main
            // 
            this.MenuStrip_Main.BackColor = System.Drawing.SystemColors.ControlLight;
            this.MenuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Help,
            this.ToolStripMenuItem_Dev});
            this.MenuStrip_Main.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip_Main.Name = "MenuStrip_Main";
            this.MenuStrip_Main.Size = new System.Drawing.Size(884, 24);
            this.MenuStrip_Main.TabIndex = 1;
            this.MenuStrip_Main.Text = "menuStrip1";
            // 
            // ToolStripMenuItem_Help
            // 
            this.ToolStripMenuItem_Help.AutoSize = false;
            this.ToolStripMenuItem_Help.Name = "ToolStripMenuItem_Help";
            this.ToolStripMenuItem_Help.Size = new System.Drawing.Size(80, 20);
            this.ToolStripMenuItem_Help.Text = "도움말(F1)";
            this.ToolStripMenuItem_Help.Click += new System.EventHandler(this.ClickButtonHelp);
            // 
            // ToolStripMenuItem_Dev
            // 
            this.ToolStripMenuItem_Dev.AutoSize = false;
            this.ToolStripMenuItem_Dev.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_ClearLog,
            this.ToolStripMenuItem_Test});
            this.ToolStripMenuItem_Dev.Name = "ToolStripMenuItem_Dev";
            this.ToolStripMenuItem_Dev.Size = new System.Drawing.Size(80, 20);
            this.ToolStripMenuItem_Dev.Text = "개발자도구";
            // 
            // ToolStripMenuItem_ClearLog
            // 
            this.ToolStripMenuItem_ClearLog.Name = "ToolStripMenuItem_ClearLog";
            this.ToolStripMenuItem_ClearLog.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItem_ClearLog.Text = "로그 비우기(F2)";
            this.ToolStripMenuItem_ClearLog.Click += new System.EventHandler(this.ClickLogClear);
            // 
            // ToolStripMenuItem_Test
            // 
            this.ToolStripMenuItem_Test.Name = "ToolStripMenuItem_Test";
            this.ToolStripMenuItem_Test.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItem_Test.Text = "테스트";
            this.ToolStripMenuItem_Test.Click += new System.EventHandler(this.ClickTestButton);
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.TableLayoutPanel_Main);
            this.Controls.Add(this.MenuStrip_Main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip_Main;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Main";
            this.ShowInTaskbar = false;
            this.Text = "FILE REMOVER";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClosingMainForm);
            this.Load += new System.EventHandler(this.LoadMainForm);
            this.Shown += new System.EventHandler(this.ShownMainForm);
            this.TableLayoutPanel_Main.ResumeLayout(false);
            this.TableLayoutPanel_Main.PerformLayout();
            this.GroupBox_Main.ResumeLayout(false);
            this.GroupBox_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Main)).EndInit();
            this.MenuStrip_Main.ResumeLayout(false);
            this.MenuStrip_Main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel_Main;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TextBox_TargetPath;
        private System.Windows.Forms.DataGridView DataGridView_Main;
        private System.Windows.Forms.Button Button_PathFind;
        private System.Windows.Forms.GroupBox GroupBox_Main;
        private System.Windows.Forms.RadioButton RadioButton_JustRemove;
        private System.Windows.Forms.RadioButton RadioButton_CleanRemove;
        private System.Windows.Forms.Label Label_ProgramRunTime;
        private System.Windows.Forms.Label Label_TargetDriveSpace;
        private System.Windows.Forms.Button Button_LockAndSave;
        private System.Windows.Forms.Timer Timer_Main;
        private System.Windows.Forms.MaskedTextBox TextBox_WorkTime;
        private System.Windows.Forms.MaskedTextBox TextBox_AddDays;
        private System.Windows.Forms.Button Button_OpenFolder;
        private System.Windows.Forms.TextBox TextBox_RemoveExtension;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MenuStrip MenuStrip_Main;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Help;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Dev;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_ClearLog;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Test;
    }
}

