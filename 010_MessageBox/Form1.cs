using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _010_MessageBox
{
  public partial class Form1 : Form
  {
    DialogResult r1, r2, r3;
    public Form1()
    {
      InitializeComponent();
    }

    private void btn1_Click(object sender, EventArgs e)
    {
      MessageBox.Show("가장 간단한");
    }

    private void btn2_Click(object sender, EventArgs e)
    {
      MessageBox.Show("타이틀을 갖는 ...", "타이틀");
    }

    private void btn3_Click(object sender, EventArgs e)
    {
      r1 = MessageBox.Show("두개의 버튼을 갖는 메시지 박스",
        "Question", MessageBoxButtons.YesNo);
    }

    private void btn4_Click(object sender, EventArgs e)
    {
      r2 = MessageBox.Show("세개의 버튼과 물음표...", "타이틀",
        MessageBoxButtons.YesNoCancel, 
        MessageBoxIcon.Question);
    }

    private void btn7_Click(object sender, EventArgs e)
    {
      string msg = string.Format("당신의 선택 : {0} {1} {2}",
        r1.ToString(), r2.ToString(), r3.ToString());
      MessageBox.Show(msg, "당신의 선택!");
    }

    private void btn5_Click(object sender, EventArgs e)
    {
      r3 = MessageBox.Show("디폴트를 두번째 버튼으로 설정하는 메시지 박스",
        "Question", 
        MessageBoxButtons.YesNoCancel,
        MessageBoxIcon.Question,
        MessageBoxDefaultButton.Button2);
    }

    private void btn6_Click(object sender, EventArgs e)
    {
      MessageBox.Show("느낌표와 알람",
        "느낌표와 알람소리",
        MessageBoxButtons.OK,
        MessageBoxIcon.Exclamation);
    }
  }
}
