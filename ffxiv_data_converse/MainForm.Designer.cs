namespace ffxiv_data_converse
{
    partial class MainForm
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
            this.button_OpenFile = new System.Windows.Forms.Button();
            this.label_OpenFile = new System.Windows.Forms.Label();
            this.button_StartConversion = new System.Windows.Forms.Button();
            this.button_saveFile = new System.Windows.Forms.Button();
            this.label_SaveFile = new System.Windows.Forms.Label();
            this.label_Status = new System.Windows.Forms.Label();
            this.radioButton_Fate = new System.Windows.Forms.RadioButton();
            this.radioButton_Duty = new System.Windows.Forms.RadioButton();
            this.label_ID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_getID = new System.Windows.Forms.TextBox();
            this.textBox_getName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.textBox_newID = new System.Windows.Forms.TextBox();
            this.label_newID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_OpenFile
            // 
            this.button_OpenFile.Location = new System.Drawing.Point(8, 5);
            this.button_OpenFile.Name = "button_OpenFile";
            this.button_OpenFile.Size = new System.Drawing.Size(93, 29);
            this.button_OpenFile.TabIndex = 0;
            this.button_OpenFile.Text = "파일 선택";
            this.button_OpenFile.UseVisualStyleBackColor = true;
            this.button_OpenFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_OpenFile
            // 
            this.label_OpenFile.AutoSize = true;
            this.label_OpenFile.Location = new System.Drawing.Point(107, 9);
            this.label_OpenFile.Name = "label_OpenFile";
            this.label_OpenFile.Size = new System.Drawing.Size(134, 21);
            this.label_OpenFile.TabIndex = 8;
            this.label_OpenFile.Text = "선택한 파일 이름";
            // 
            // button_StartConversion
            // 
            this.button_StartConversion.Location = new System.Drawing.Point(8, 109);
            this.button_StartConversion.Name = "button_StartConversion";
            this.button_StartConversion.Size = new System.Drawing.Size(93, 29);
            this.button_StartConversion.TabIndex = 2;
            this.button_StartConversion.Text = "변환 시작";
            this.button_StartConversion.UseVisualStyleBackColor = true;
            this.button_StartConversion.Click += new System.EventHandler(this.button_StartConversion_Click);
            // 
            // button_saveFile
            // 
            this.button_saveFile.Location = new System.Drawing.Point(8, 40);
            this.button_saveFile.Name = "button_saveFile";
            this.button_saveFile.Size = new System.Drawing.Size(93, 29);
            this.button_saveFile.TabIndex = 1;
            this.button_saveFile.Text = "경로 지정";
            this.button_saveFile.UseVisualStyleBackColor = true;
            this.button_saveFile.Click += new System.EventHandler(this.button3_Click);
            // 
            // label_SaveFile
            // 
            this.label_SaveFile.AutoSize = true;
            this.label_SaveFile.Location = new System.Drawing.Point(107, 44);
            this.label_SaveFile.Name = "label_SaveFile";
            this.label_SaveFile.Size = new System.Drawing.Size(134, 21);
            this.label_SaveFile.TabIndex = 9;
            this.label_SaveFile.Text = "저장할 파일 이름";
            // 
            // label_Status
            // 
            this.label_Status.AutoSize = true;
            this.label_Status.Location = new System.Drawing.Point(107, 113);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(80, 21);
            this.label_Status.TabIndex = 10;
            this.label_Status.Text = "변환 준비";
            // 
            // radioButton_Fate
            // 
            this.radioButton_Fate.AutoSize = true;
            this.radioButton_Fate.Location = new System.Drawing.Point(76, 75);
            this.radioButton_Fate.Name = "radioButton_Fate";
            this.radioButton_Fate.Size = new System.Drawing.Size(76, 25);
            this.radioButton_Fate.TabIndex = 4;
            this.radioButton_Fate.Text = "F.A.T.E";
            this.radioButton_Fate.UseVisualStyleBackColor = true;
            this.radioButton_Fate.MouseUp += new System.Windows.Forms.MouseEventHandler(this.radioButton_Fate_MouseUp);
            // 
            // radioButton_Duty
            // 
            this.radioButton_Duty.AutoSize = true;
            this.radioButton_Duty.Checked = true;
            this.radioButton_Duty.Location = new System.Drawing.Point(8, 75);
            this.radioButton_Duty.Name = "radioButton_Duty";
            this.radioButton_Duty.Size = new System.Drawing.Size(62, 25);
            this.radioButton_Duty.TabIndex = 3;
            this.radioButton_Duty.TabStop = true;
            this.radioButton_Duty.Text = "Duty";
            this.radioButton_Duty.UseVisualStyleBackColor = true;
            this.radioButton_Duty.MouseUp += new System.Windows.Forms.MouseEventHandler(this.radioButton_Duty_MouseUp);
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Location = new System.Drawing.Point(280, 77);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(35, 21);
            this.label_ID.TabIndex = 11;
            this.label_ID.Text = "ID: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "번째";
            // 
            // textBox_getID
            // 
            this.textBox_getID.Location = new System.Drawing.Point(309, 74);
            this.textBox_getID.Name = "textBox_getID";
            this.textBox_getID.Size = new System.Drawing.Size(52, 29);
            this.textBox_getID.TabIndex = 14;
            this.textBox_getID.Text = "11";
            // 
            // textBox_getName
            // 
            this.textBox_getName.Location = new System.Drawing.Point(309, 109);
            this.textBox_getName.Name = "textBox_getName";
            this.textBox_getName.Size = new System.Drawing.Size(52, 29);
            this.textBox_getName.TabIndex = 17;
            this.textBox_getName.Text = "5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "번째";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(265, 112);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(52, 21);
            this.label_Name.TabIndex = 15;
            this.label_Name.Text = "이름: ";
            // 
            // textBox_newID
            // 
            this.textBox_newID.Location = new System.Drawing.Point(309, 144);
            this.textBox_newID.Name = "textBox_newID";
            this.textBox_newID.Size = new System.Drawing.Size(52, 29);
            this.textBox_newID.TabIndex = 20;
            // 
            // label_newID
            // 
            this.label_newID.AutoSize = true;
            this.label_newID.Location = new System.Drawing.Point(357, 147);
            this.label_newID.Name = "label_newID";
            this.label_newID.Size = new System.Drawing.Size(42, 21);
            this.label_newID.TabIndex = 19;
            this.label_newID.Text = "번째";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(250, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 21);
            this.label4.TabIndex = 18;
            this.label4.Text = "NewID:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 181);
            this.Controls.Add(this.textBox_newID);
            this.Controls.Add(this.label_newID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_getName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.textBox_getID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_ID);
            this.Controls.Add(this.radioButton_Duty);
            this.Controls.Add(this.radioButton_Fate);
            this.Controls.Add(this.label_Status);
            this.Controls.Add(this.label_SaveFile);
            this.Controls.Add(this.button_saveFile);
            this.Controls.Add(this.button_StartConversion);
            this.Controls.Add(this.label_OpenFile);
            this.Controls.Add(this.button_OpenFile);
            this.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "FFXIV DATA Conversion Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_OpenFile;
        private System.Windows.Forms.Label label_OpenFile;
        private System.Windows.Forms.Button button_StartConversion;
        private System.Windows.Forms.Button button_saveFile;
        private System.Windows.Forms.Label label_SaveFile;
        private System.Windows.Forms.Label label_Status;
        private System.Windows.Forms.RadioButton radioButton_Fate;
        private System.Windows.Forms.RadioButton radioButton_Duty;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_getID;
        private System.Windows.Forms.TextBox textBox_getName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.TextBox textBox_newID;
        private System.Windows.Forms.Label label_newID;
        private System.Windows.Forms.Label label4;
    }
}

