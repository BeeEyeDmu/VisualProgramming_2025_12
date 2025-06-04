using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _040_TwoForms
{
  public partial class Form2 : Form
  {
    Form1 f;
    public Form2(Form1 form1)
    {
      InitializeComponent();
      f = form1;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      f.Show();
      this.Hide();
    }
  }
}
