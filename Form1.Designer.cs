﻿namespace myScheduler
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.toDoBox = new System.Windows.Forms.CheckedListBox();
            this.newToDo = new System.Windows.Forms.Button();
            this.mainCalender = new System.Windows.Forms.MonthCalendar();
            this.finishButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(508, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "To Do Queue";
            // 
            // toDoBox
            // 
            this.toDoBox.FormattingEnabled = true;
            this.toDoBox.Location = new System.Drawing.Point(382, 83);
            this.toDoBox.Name = "toDoBox";
            this.toDoBox.Size = new System.Drawing.Size(393, 284);
            this.toDoBox.TabIndex = 1;
            // 
            // newToDo
            // 
            this.newToDo.Location = new System.Drawing.Point(382, 391);
            this.newToDo.Name = "newToDo";
            this.newToDo.Size = new System.Drawing.Size(176, 37);
            this.newToDo.TabIndex = 2;
            this.newToDo.Text = "New";
            this.newToDo.UseVisualStyleBackColor = true;
            this.newToDo.Click += new System.EventHandler(this.newToDo_Click);
            // 
            // mainCalender
            // 
            this.mainCalender.Location = new System.Drawing.Point(61, 121);
            this.mainCalender.Name = "mainCalender";
            this.mainCalender.TabIndex = 3;
            this.mainCalender.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.mainCalender_DateSelected);
            // 
            // finishButton
            // 
            this.finishButton.Location = new System.Drawing.Point(595, 391);
            this.finishButton.Name = "finishButton";
            this.finishButton.Size = new System.Drawing.Size(180, 37);
            this.finishButton.TabIndex = 4;
            this.finishButton.Text = "Done";
            this.finishButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.finishButton);
            this.Controls.Add(this.mainCalender);
            this.Controls.Add(this.newToDo);
            this.Controls.Add(this.toDoBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "Form1";
            this.Text = "My Scheduler";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox toDoBox;
        private System.Windows.Forms.Button newToDo;
        private System.Windows.Forms.MonthCalendar mainCalender;
        private System.Windows.Forms.Button finishButton;
    }
}

