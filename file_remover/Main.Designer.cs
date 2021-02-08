﻿
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
            this.TextBox_TargetExtension = new System.Windows.Forms.TextBox();
            this.DataGridView_Main = new System.Windows.Forms.DataGridView();
            this.Button_PathFind = new System.Windows.Forms.Button();
            this.Label_ProgramRunTime = new System.Windows.Forms.Label();
            this.Label_TargetDriveSpace = new System.Windows.Forms.Label();
            this.Button_Test = new System.Windows.Forms.Button();
            this.TextBox_WorkTime = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Timer_Main = new System.Windows.Forms.Timer(this.components);
            this.TableLayoutPanel_Main.SuspendLayout();
            this.GroupBox_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Main)).BeginInit();
            this.SuspendLayout();
            // 
            // TableLayoutPanel_Main
            // 
            this.TableLayoutPanel_Main.ColumnCount = 4;
            this.TableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.TableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.TableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel_Main.Controls.Add(this.label1, 0, 0);
            this.TableLayoutPanel_Main.Controls.Add(this.label2, 0, 1);
            this.TableLayoutPanel_Main.Controls.Add(this.label3, 0, 2);
            this.TableLayoutPanel_Main.Controls.Add(this.label4, 0, 3);
            this.TableLayoutPanel_Main.Controls.Add(this.label5, 0, 5);
            this.TableLayoutPanel_Main.Controls.Add(this.label6, 2, 5);
            this.TableLayoutPanel_Main.Controls.Add(this.TextBox_TargetPath, 1, 0);
            this.TableLayoutPanel_Main.Controls.Add(this.GroupBox_Main, 1, 1);
            this.TableLayoutPanel_Main.Controls.Add(this.TextBox_TargetExtension, 1, 2);
            this.TableLayoutPanel_Main.Controls.Add(this.DataGridView_Main, 0, 4);
            this.TableLayoutPanel_Main.Controls.Add(this.Button_PathFind, 3, 0);
            this.TableLayoutPanel_Main.Controls.Add(this.Label_ProgramRunTime, 1, 5);
            this.TableLayoutPanel_Main.Controls.Add(this.Label_TargetDriveSpace, 3, 5);
            this.TableLayoutPanel_Main.Controls.Add(this.Button_Test, 3, 3);
            this.TableLayoutPanel_Main.Controls.Add(this.TextBox_WorkTime, 1, 3);
            this.TableLayoutPanel_Main.Controls.Add(this.label7, 3, 2);
            this.TableLayoutPanel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel_Main.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanel_Main.Name = "TableLayoutPanel_Main";
            this.TableLayoutPanel_Main.RowCount = 6;
            this.TableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.TableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.TableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.TableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.TableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.TableLayoutPanel_Main.Size = new System.Drawing.Size(800, 450);
            this.TableLayoutPanel_Main.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "타겟 경로";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "완전삭제 유무";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "타겟 확장자";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "수행시간";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 425);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "프로그램 동작시간";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(403, 425);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "타겟 드라이브 여유";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TextBox_TargetPath
            // 
            this.TableLayoutPanel_Main.SetColumnSpan(this.TextBox_TargetPath, 2);
            this.TextBox_TargetPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox_TargetPath.Enabled = false;
            this.TextBox_TargetPath.Location = new System.Drawing.Point(133, 3);
            this.TextBox_TargetPath.Name = "TextBox_TargetPath";
            this.TextBox_TargetPath.Size = new System.Drawing.Size(394, 21);
            this.TextBox_TargetPath.TabIndex = 6;
            // 
            // GroupBox_Main
            // 
            this.TableLayoutPanel_Main.SetColumnSpan(this.GroupBox_Main, 2);
            this.GroupBox_Main.Controls.Add(this.RadioButton_JustRemove);
            this.GroupBox_Main.Controls.Add(this.RadioButton_CleanRemove);
            this.GroupBox_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBox_Main.Enabled = false;
            this.GroupBox_Main.Location = new System.Drawing.Point(133, 28);
            this.GroupBox_Main.Name = "GroupBox_Main";
            this.GroupBox_Main.Size = new System.Drawing.Size(394, 39);
            this.GroupBox_Main.TabIndex = 7;
            this.GroupBox_Main.TabStop = false;
            // 
            // RadioButton_JustRemove
            // 
            this.RadioButton_JustRemove.AutoSize = true;
            this.RadioButton_JustRemove.Location = new System.Drawing.Point(86, 17);
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
            this.RadioButton_CleanRemove.Location = new System.Drawing.Point(16, 17);
            this.RadioButton_CleanRemove.Name = "RadioButton_CleanRemove";
            this.RadioButton_CleanRemove.Size = new System.Drawing.Size(35, 16);
            this.RadioButton_CleanRemove.TabIndex = 0;
            this.RadioButton_CleanRemove.TabStop = true;
            this.RadioButton_CleanRemove.Text = "예";
            this.RadioButton_CleanRemove.UseVisualStyleBackColor = true;
            // 
            // TextBox_TargetExtension
            // 
            this.TableLayoutPanel_Main.SetColumnSpan(this.TextBox_TargetExtension, 2);
            this.TextBox_TargetExtension.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox_TargetExtension.Enabled = false;
            this.TextBox_TargetExtension.Location = new System.Drawing.Point(133, 73);
            this.TextBox_TargetExtension.Name = "TextBox_TargetExtension";
            this.TextBox_TargetExtension.Size = new System.Drawing.Size(394, 21);
            this.TextBox_TargetExtension.TabIndex = 8;
            // 
            // DataGridView_Main
            // 
            this.DataGridView_Main.AllowUserToAddRows = false;
            this.DataGridView_Main.AllowUserToDeleteRows = false;
            this.DataGridView_Main.AllowUserToResizeRows = false;
            this.DataGridView_Main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.TableLayoutPanel_Main.SetColumnSpan(this.DataGridView_Main, 4);
            this.DataGridView_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView_Main.Location = new System.Drawing.Point(3, 123);
            this.DataGridView_Main.Name = "DataGridView_Main";
            this.DataGridView_Main.RowHeadersVisible = false;
            this.DataGridView_Main.RowTemplate.Height = 23;
            this.DataGridView_Main.Size = new System.Drawing.Size(794, 299);
            this.DataGridView_Main.TabIndex = 10;
            // 
            // Button_PathFind
            // 
            this.Button_PathFind.Enabled = false;
            this.Button_PathFind.Location = new System.Drawing.Point(533, 3);
            this.Button_PathFind.Name = "Button_PathFind";
            this.Button_PathFind.Size = new System.Drawing.Size(75, 19);
            this.Button_PathFind.TabIndex = 11;
            this.Button_PathFind.Text = "찾기";
            this.Button_PathFind.UseVisualStyleBackColor = true;
            // 
            // Label_ProgramRunTime
            // 
            this.Label_ProgramRunTime.AutoSize = true;
            this.Label_ProgramRunTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_ProgramRunTime.Location = new System.Drawing.Point(133, 425);
            this.Label_ProgramRunTime.Name = "Label_ProgramRunTime";
            this.Label_ProgramRunTime.Size = new System.Drawing.Size(264, 25);
            this.Label_ProgramRunTime.TabIndex = 12;
            this.Label_ProgramRunTime.Text = "Label_ProgramRunTime";
            this.Label_ProgramRunTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label_TargetDriveSpace
            // 
            this.Label_TargetDriveSpace.AutoSize = true;
            this.Label_TargetDriveSpace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_TargetDriveSpace.Location = new System.Drawing.Point(533, 425);
            this.Label_TargetDriveSpace.Name = "Label_TargetDriveSpace";
            this.Label_TargetDriveSpace.Size = new System.Drawing.Size(264, 25);
            this.Label_TargetDriveSpace.TabIndex = 13;
            this.Label_TargetDriveSpace.Text = "Label_TargetDriveSpace";
            this.Label_TargetDriveSpace.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Button_Test
            // 
            this.Button_Test.Location = new System.Drawing.Point(533, 98);
            this.Button_Test.Name = "Button_Test";
            this.Button_Test.Size = new System.Drawing.Size(150, 19);
            this.Button_Test.TabIndex = 14;
            this.Button_Test.Text = "잠금 및 적용";
            this.Button_Test.UseVisualStyleBackColor = true;
            this.Button_Test.Click += new System.EventHandler(this.ClickTestButton);
            // 
            // TextBox_WorkTime
            // 
            this.TableLayoutPanel_Main.SetColumnSpan(this.TextBox_WorkTime, 2);
            this.TextBox_WorkTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox_WorkTime.Enabled = false;
            this.TextBox_WorkTime.Location = new System.Drawing.Point(133, 98);
            this.TextBox_WorkTime.Mask = "90시90분";
            this.TextBox_WorkTime.Name = "TextBox_WorkTime";
            this.TextBox_WorkTime.Size = new System.Drawing.Size(394, 21);
            this.TextBox_WorkTime.TabIndex = 15;
            this.TextBox_WorkTime.ValidatingType = typeof(System.DateTime);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(533, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(264, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "<< 공사중. 동작안함";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Timer_Main
            // 
            this.Timer_Main.Interval = 1000;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TableLayoutPanel_Main);
            this.Name = "Main";
            this.ShowIcon = false;
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
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TextBox TextBox_TargetExtension;
        private System.Windows.Forms.DataGridView DataGridView_Main;
        private System.Windows.Forms.Button Button_PathFind;
        private System.Windows.Forms.GroupBox GroupBox_Main;
        private System.Windows.Forms.RadioButton RadioButton_JustRemove;
        private System.Windows.Forms.RadioButton RadioButton_CleanRemove;
        private System.Windows.Forms.Label Label_ProgramRunTime;
        private System.Windows.Forms.Label Label_TargetDriveSpace;
        private System.Windows.Forms.Button Button_Test;
        private System.Windows.Forms.Timer Timer_Main;
        private System.Windows.Forms.MaskedTextBox TextBox_WorkTime;
        private System.Windows.Forms.Label label7;
    }
}
