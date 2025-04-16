using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _014_RadioButton
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      string s = "국적 : ";

      if (rbKorea.Checked)
        s += "대한민국\n";
      else if (rbChina.Checked)
        s += "중국\n";
      else if (rbJapan.Checked)
        s += "일본\n";
      else if (rbOthers.Checked)
        s += "그 외의 국가\n";

      if (rbMale.Checked)
        s += "성별 : 남성";
      else if (rbFemale.Checked)
        s += "성별 : 여성";

      MessageBox.Show(s, "국적 및 성별");
    }
  }
}
