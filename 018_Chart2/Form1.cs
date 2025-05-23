﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace _018_Chart2
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      chart1.Titles.Add("성적");

      chart1.Series.Add("Series2"); // 이제 Series가 두 개가 되었다

      chart1.Series[0].LegendText = "수학";
      chart1.Series[1].LegendText = "영어";

      Random r = new Random();

      for(int i=0; i<10; i++)
      {
        chart1.Series[0].Points.AddXY(i, r.Next(101));
        chart1.Series[1].Points.AddXY(i, r.Next(101));
      }
    }

    // 나누어 그리기
    private void btnTwoChart_Click(object sender, EventArgs e)
    {
      if(chart1.ChartAreas.Count == 1) {
        chart1.ChartAreas.Add("ChartArea2");
      }
      chart1.Series[1].ChartArea = "ChartArea2";
    }

    // 합쳐서 그리기
    private void btnOneChart_Click(object sender, EventArgs e)
    {
      if(chart1.ChartAreas.Count == 2)
      {
        chart1.ChartAreas.RemoveAt(1);
      }
      chart1.Series[1].ChartArea = "ChartArea1";
    }
  }
}
