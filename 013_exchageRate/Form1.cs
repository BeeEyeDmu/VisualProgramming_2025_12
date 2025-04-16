using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _013_exchageRate
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (txtUSD.Text == "" && txtKRW.Text == "")
        MessageBox.Show("액수를 입력하세요.");
      else if(txtUSD.Text != "")
      {
        double krw = double.Parse(txtUSD.Text) * 1449;
        txtKRW.Text = krw.ToString();
      }
      else if(txtKRW.Text != "")
      {
        double usd = double.Parse(txtKRW.Text) / 1449;
        txtUSD.Text = usd.ToString("#.##");
      }
    }
  }
}
