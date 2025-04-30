namespace _029_Phonebook
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
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.label1 = new System.Windows.Forms.Label();
      this.txtId = new System.Windows.Forms.TextBox();
      this.txtSId = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txtName = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.txtPhone = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.btnInsert = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.button4 = new System.Windows.Forms.Button();
      this.button5 = new System.Windows.Forms.Button();
      this.button6 = new System.Windows.Forms.Button();
      this.button7 = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // dataGridView1
      // 
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new System.Drawing.Point(13, 13);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.RowTemplate.Height = 23;
      this.dataGridView1.Size = new System.Drawing.Size(625, 275);
      this.dataGridView1.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.label1.Location = new System.Drawing.Point(27, 316);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(21, 17);
      this.label1.TabIndex = 1;
      this.label1.Text = "ID";
      // 
      // txtId
      // 
      this.txtId.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.txtId.Location = new System.Drawing.Point(96, 313);
      this.txtId.Name = "txtId";
      this.txtId.Size = new System.Drawing.Size(146, 25);
      this.txtId.TabIndex = 2;
      this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // txtSId
      // 
      this.txtSId.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.txtSId.Location = new System.Drawing.Point(96, 352);
      this.txtSId.Name = "txtSId";
      this.txtSId.Size = new System.Drawing.Size(146, 25);
      this.txtSId.TabIndex = 4;
      this.txtSId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.label2.Location = new System.Drawing.Point(27, 355);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(34, 17);
      this.label2.TabIndex = 3;
      this.label2.Text = "학번";
      // 
      // txtName
      // 
      this.txtName.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.txtName.Location = new System.Drawing.Point(96, 391);
      this.txtName.Name = "txtName";
      this.txtName.Size = new System.Drawing.Size(146, 25);
      this.txtName.TabIndex = 6;
      this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.label3.Location = new System.Drawing.Point(27, 394);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(34, 17);
      this.label3.TabIndex = 5;
      this.label3.Text = "이름";
      // 
      // txtPhone
      // 
      this.txtPhone.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.txtPhone.Location = new System.Drawing.Point(96, 430);
      this.txtPhone.Name = "txtPhone";
      this.txtPhone.Size = new System.Drawing.Size(146, 25);
      this.txtPhone.TabIndex = 8;
      this.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.label4.Location = new System.Drawing.Point(27, 433);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(60, 17);
      this.label4.TabIndex = 7;
      this.label4.Text = "전화번호";
      // 
      // button1
      // 
      this.button1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.button1.Location = new System.Drawing.Point(316, 311);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(146, 23);
      this.button1.TabIndex = 9;
      this.button1.Text = "button1";
      this.button1.UseVisualStyleBackColor = true;
      // 
      // btnInsert
      // 
      this.btnInsert.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.btnInsert.Location = new System.Drawing.Point(316, 350);
      this.btnInsert.Name = "btnInsert";
      this.btnInsert.Size = new System.Drawing.Size(146, 23);
      this.btnInsert.TabIndex = 10;
      this.btnInsert.Text = "추가";
      this.btnInsert.UseVisualStyleBackColor = true;
      this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
      // 
      // button3
      // 
      this.button3.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.button3.Location = new System.Drawing.Point(316, 389);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(146, 23);
      this.button3.TabIndex = 11;
      this.button3.Text = "button3";
      this.button3.UseVisualStyleBackColor = true;
      // 
      // button4
      // 
      this.button4.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.button4.Location = new System.Drawing.Point(316, 428);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(146, 23);
      this.button4.TabIndex = 12;
      this.button4.Text = "button4";
      this.button4.UseVisualStyleBackColor = true;
      // 
      // button5
      // 
      this.button5.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.button5.Location = new System.Drawing.Point(492, 428);
      this.button5.Name = "button5";
      this.button5.Size = new System.Drawing.Size(146, 23);
      this.button5.TabIndex = 16;
      this.button5.Text = "button5";
      this.button5.UseVisualStyleBackColor = true;
      // 
      // button6
      // 
      this.button6.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.button6.Location = new System.Drawing.Point(492, 389);
      this.button6.Name = "button6";
      this.button6.Size = new System.Drawing.Size(146, 23);
      this.button6.TabIndex = 15;
      this.button6.Text = "button6";
      this.button6.UseVisualStyleBackColor = true;
      // 
      // button7
      // 
      this.button7.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.button7.Location = new System.Drawing.Point(492, 350);
      this.button7.Name = "button7";
      this.button7.Size = new System.Drawing.Size(146, 23);
      this.button7.TabIndex = 14;
      this.button7.Text = "button7";
      this.button7.UseVisualStyleBackColor = true;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(656, 499);
      this.Controls.Add(this.button5);
      this.Controls.Add(this.button6);
      this.Controls.Add(this.button7);
      this.Controls.Add(this.button4);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.btnInsert);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.txtPhone);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.txtName);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.txtSId);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.txtId);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.dataGridView1);
      this.Name = "Form1";
      this.Text = "Phonebook ";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtId;
    private System.Windows.Forms.TextBox txtSId;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtName;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtPhone;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button btnInsert;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Button button5;
    private System.Windows.Forms.Button button6;
    private System.Windows.Forms.Button button7;
  }
}

