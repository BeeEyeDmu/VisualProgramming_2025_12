﻿namespace _005_bmiForm
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
            this.lblH = new System.Windows.Forms.Label();
            this.txtH = new System.Windows.Forms.TextBox();
            this.txtW = new System.Windows.Forms.TextBox();
            this.lblW = new System.Windows.Forms.Label();
            this.btnBMI = new System.Windows.Forms.Button();
            this.lblBMI = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblH
            // 
            this.lblH.AutoSize = true;
            this.lblH.Location = new System.Drawing.Point(40, 71);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(45, 12);
            this.lblH.TabIndex = 0;
            this.lblH.Text = "키(cm)";
            // 
            // txtH
            // 
            this.txtH.Location = new System.Drawing.Point(104, 68);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(100, 21);
            this.txtH.TabIndex = 1;
            this.txtH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtW
            // 
            this.txtW.Location = new System.Drawing.Point(104, 107);
            this.txtW.Name = "txtW";
            this.txtW.Size = new System.Drawing.Size(100, 21);
            this.txtW.TabIndex = 3;
            this.txtW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblW
            // 
            this.lblW.AutoSize = true;
            this.lblW.Location = new System.Drawing.Point(40, 110);
            this.lblW.Name = "lblW";
            this.lblW.Size = new System.Drawing.Size(52, 12);
            this.lblW.TabIndex = 2;
            this.lblW.Text = "체중(kg)";
            // 
            // btnBMI
            // 
            this.btnBMI.Location = new System.Drawing.Point(129, 157);
            this.btnBMI.Name = "btnBMI";
            this.btnBMI.Size = new System.Drawing.Size(75, 23);
            this.btnBMI.TabIndex = 4;
            this.btnBMI.Text = "BMI 계산";
            this.btnBMI.UseVisualStyleBackColor = true;
            this.btnBMI.Click += new System.EventHandler(this.btnBMI_Click);
            // 
            // lblBMI
            // 
            this.lblBMI.AutoSize = true;
            this.lblBMI.Location = new System.Drawing.Point(42, 214);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(0, 12);
            this.lblBMI.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(259, 320);
            this.Controls.Add(this.lblBMI);
            this.Controls.Add(this.btnBMI);
            this.Controls.Add(this.txtW);
            this.Controls.Add(this.lblW);
            this.Controls.Add(this.txtH);
            this.Controls.Add(this.lblH);
            this.Name = "Form1";
            this.Text = "BMI 계산기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblH;
        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.TextBox txtW;
        private System.Windows.Forms.Label lblW;
        private System.Windows.Forms.Button btnBMI;
        private System.Windows.Forms.Label lblBMI;
    }
}

