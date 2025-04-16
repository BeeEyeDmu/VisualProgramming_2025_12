using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _016_gradeCalc
{
  public partial class Form1 : Form
  {
    // 멤버를 사용
    TextBox[] titles; // 교과목 TextBox의 배열
    ComboBox[] crds;  // 학점 Combox의 배열
    ComboBox[] grds;  // 성적 Combox의 배열

    // 생성자 함수(자동으로 만들어짐)
    public Form1()
    {
      InitializeComponent();
    }

    // Form1이 로드될 때, 즉  Form1이 시작될 때
    private void Form1_Load(object sender, EventArgs e)
    {
      txt1.Text = "인체의 구조와 기능";
      txt2.Text = "일반수학I";
      txt3.Text = "디지털 공학 및 실험";
      txt4.Text = "비주얼프로그래밍";
      txt5.Text = "설계및프로젝트기본I";

      crds = new ComboBox[] { crd1, crd2, crd3, crd4, crd5, crd6, crd7 };
      grds = new ComboBox[] { grd1, grd2, grd3, grd4, grd5, grd6, grd7 };
      titles = new TextBox[] {txt1, txt2, txt3, txt4, txt5, txt6, txt7 };

      int[] arrCredit = { 1, 2, 3, 4, 5 };
      List<string> lstGrade = new List<string> {"A+", "A0", "B+", "B0",
        "C+", "C0", "D+", "D0", "F" };

      foreach(var combo in crds)
      {
        foreach(var i in arrCredit)  // foreach 배열 각각의 원소
          combo.Items.Add(i);
        combo.SelectedItem = 3;
      }

      foreach(var combo in grds)
      {
        foreach (var gr in lstGrade) // foreach 리스트 각각의 원소
          combo.Items.Add(gr);
      }
    }

    private void button1_Click(object sender, EventArgs e)
    {
      double totalScore = 0; // 총점
      int totalCredeits = 0;  // 총 학점수

      for (int i = 0; i < crds.Length; i++)
      {
        if (titles[i].Text != "") // 과목명이 빈칸이 아니면
        {
          int crd = int.Parse(crds[i].SelectedItem.ToString());
          totalCredeits += crd;
          totalScore += crd * GetGrade(grds[i].SelectedItem.ToString());
        }

        txtGrade.Text = (totalScore/totalCredeits).ToString("0.00");
      }
    }

    private double GetGrade(string v)
    {
      double grade = 0;

      if (v == "A+") grade = 4.5;
      else if (v == "A0") grade = 4.0;
      else if (v == "B+") grade = 3.5;
      else if (v == "B0") grade = 3.0;
      else if (v == "C+") grade = 2.5;
      else if (v == "C0") grade = 2.0;
      else if (v == "D+") grade = 1.5;
      else if (v == "D0") grade = 1.0;
      else  grade = 0.0;

      return grade;
    }
  }
}
