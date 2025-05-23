﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _012_CheckBox
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void btnSubmit_Click(object sender, EventArgs e)
    {
      string s = "";
      CheckBox[] cBox = { checkBox1, checkBox2, 
        checkBox3, checkBox4, checkBox5 };

      foreach (var item in cBox) // cBox 안의 item 각각에 대해서
      {
        s += string.Format("{0} : {1}\n", item.Text, item.Checked);
      }
      MessageBox.Show(s, "Summary");

      string t = string.Format("좋아하는 과일은 : ");

      foreach (var item in cBox)
      {
        if(item.Checked == true)
        {
          t += item.Text + " ";
        }
      }
      MessageBox.Show(t, "Summary");
    }
  }
}
