using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _017_chart
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      Random r = new Random();

      chart1.Titles.Add("랜덤숫자");

      for (int i = 0; i < 50; i++)
        chart1.Series[0].Points.Add(r.Next(100));

      chart1.Series[0].LegendText = "비주얼\n프로그래밍";
    }
  }
}
