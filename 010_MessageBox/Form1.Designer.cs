namespace _010_MessageBox
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
      this.btn1 = new System.Windows.Forms.Button();
      this.btn2 = new System.Windows.Forms.Button();
      this.btn3 = new System.Windows.Forms.Button();
      this.btn4 = new System.Windows.Forms.Button();
      this.btn5 = new System.Windows.Forms.Button();
      this.btn6 = new System.Windows.Forms.Button();
      this.btn7 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(25, 33);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(120, 12);
      this.label1.TabIndex = 0;
      this.label1.Text = "MessageBox의 종류";
      // 
      // btn1
      // 
      this.btn1.Location = new System.Drawing.Point(27, 77);
      this.btn1.Name = "btn1";
      this.btn1.Size = new System.Drawing.Size(235, 23);
      this.btn1.TabIndex = 1;
      this.btn1.Text = "가장 간단한 메시지 박스";
      this.btn1.UseVisualStyleBackColor = true;
      this.btn1.Click += new System.EventHandler(this.btn1_Click);
      // 
      // btn2
      // 
      this.btn2.Location = new System.Drawing.Point(27, 113);
      this.btn2.Name = "btn2";
      this.btn2.Size = new System.Drawing.Size(235, 23);
      this.btn2.TabIndex = 2;
      this.btn2.Text = "타이틀을 갖는 메시지 박스";
      this.btn2.UseVisualStyleBackColor = true;
      this.btn2.Click += new System.EventHandler(this.btn2_Click);
      // 
      // btn3
      // 
      this.btn3.Location = new System.Drawing.Point(27, 149);
      this.btn3.Name = "btn3";
      this.btn3.Size = new System.Drawing.Size(235, 23);
      this.btn3.TabIndex = 3;
      this.btn3.Text = "두 개의 버튼을 갖는 메시지 박스";
      this.btn3.UseVisualStyleBackColor = true;
      this.btn3.Click += new System.EventHandler(this.btn3_Click);
      // 
      // btn4
      // 
      this.btn4.Location = new System.Drawing.Point(27, 185);
      this.btn4.Name = "btn4";
      this.btn4.Size = new System.Drawing.Size(235, 23);
      this.btn4.TabIndex = 4;
      this.btn4.Text = "세개의 버튼과 물음표";
      this.btn4.UseVisualStyleBackColor = true;
      this.btn4.Click += new System.EventHandler(this.btn4_Click);
      // 
      // btn5
      // 
      this.btn5.Location = new System.Drawing.Point(27, 221);
      this.btn5.Name = "btn5";
      this.btn5.Size = new System.Drawing.Size(235, 23);
      this.btn5.TabIndex = 5;
      this.btn5.Text = "디폴트를 두번째로 설정한 메시지 박스";
      this.btn5.UseVisualStyleBackColor = true;
      this.btn5.Click += new System.EventHandler(this.btn5_Click);
      // 
      // btn6
      // 
      this.btn6.Location = new System.Drawing.Point(27, 257);
      this.btn6.Name = "btn6";
      this.btn6.Size = new System.Drawing.Size(235, 23);
      this.btn6.TabIndex = 6;
      this.btn6.Text = "느낌표와 알람 소리가 나는 메시지 박스";
      this.btn6.UseVisualStyleBackColor = true;
      this.btn6.Click += new System.EventHandler(this.btn6_Click);
      // 
      // btn7
      // 
      this.btn7.Location = new System.Drawing.Point(27, 293);
      this.btn7.Name = "btn7";
      this.btn7.Size = new System.Drawing.Size(235, 23);
      this.btn7.TabIndex = 7;
      this.btn7.Text = "당신의 선택은?";
      this.btn7.UseVisualStyleBackColor = true;
      this.btn7.Click += new System.EventHandler(this.btn7_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(286, 371);
      this.Controls.Add(this.btn7);
      this.Controls.Add(this.btn6);
      this.Controls.Add(this.btn5);
      this.Controls.Add(this.btn4);
      this.Controls.Add(this.btn3);
      this.Controls.Add(this.btn2);
      this.Controls.Add(this.btn1);
      this.Controls.Add(this.label1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btn1;
    private System.Windows.Forms.Button btn2;
    private System.Windows.Forms.Button btn3;
    private System.Windows.Forms.Button btn4;
    private System.Windows.Forms.Button btn5;
    private System.Windows.Forms.Button btn6;
    private System.Windows.Forms.Button btn7;
  }
}

