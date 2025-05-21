using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _038_WPFCalc
{
  /// <summary>
  /// MainWindow.xaml에 대한 상호 작용 논리
  /// </summary>
  public partial class MainWindow : Window
  {
    bool opFlag = false;  // 연산자 버튼이 눌려지면 true
    double saved;         // 연산자가 눌렸을 때, 결과창의 값이 저장되는 변수
    string op;            // 연산자가 눌렸을 때, 어떤 연산자인지 저장
    bool afterCalc;       // =을 눌러서 계산이 끝났을 때

    public MainWindow()
    {
      InitializeComponent();
    }

    // 1번 숫자버튼
    private void btn_Click(object sender, RoutedEventArgs e)
    {
      Button btn = (Button)sender;

      if (txtResult.Text == "0" 
        || opFlag == true 
        || afterCalc == true) { 
        txtResult.Text = btn.Content.ToString();
        opFlag = false;
        afterCalc = false;
      }
      else
        txtResult.Text += btn.Content.ToString();
    }

    // 소수점
    private void btnDot_Click(object sender, RoutedEventArgs e)
    {
      if (txtResult.Text.Contains("."))
        return;
      else
        txtResult.Text += ".";
    }

    // +-버튼 : 결과창의 값을 숫자로 바꾸고 -1을 곱한 다음, 문자열로 변환해서 출력
    private void btnPlusMinus_Click(object sender, RoutedEventArgs e)
    {
      txtResult.Text = (-1 * double.Parse(txtResult.Text)).ToString();
    }

    // ＋－× ÷ 
    private void opClick(object sender, RoutedEventArgs e)
    {
      Button btn = (Button)sender;
      opFlag = true;

      op = btn.Content.ToString();
      saved = double.Parse(txtResult.Text);

      // 확인용
      // MessageBox.Show(string.Format("op = {0}, saved = {1}", op, saved));
    }

    // = 버튼,   
    private void btnEqual_Click(object sender, RoutedEventArgs e)
    {
      double v = double.Parse(txtResult.Text);

      switch(op)
      {
        case "＋":
          txtResult.Text = (v + saved).ToString();
          break;
        case "－":
          txtResult.Text = (saved - v).ToString();
          break;
        case "×":
          txtResult.Text = (saved * v).ToString();
          break;
        case "÷":
          txtResult.Text = (saved / v).ToString();
          break;
      }

      afterCalc = true;
    }

    // 역수
    private void btnReci_Click(object sender, RoutedEventArgs e)
    {
      double v = Double.Parse(txtResult.Text);
      txtResult.Text = (1 / v).ToString();
    }

    // 제곱
    private void btnSqr_Click(object sender, RoutedEventArgs e)
    {
      double v = Double.Parse(txtResult.Text);
      txtResult.Text = (v * v).ToString();
    }

    private void btnSqrt_Click(object sender, RoutedEventArgs e)
    {
      double v = Double.Parse(txtResult.Text);
      txtResult.Text = Math.Sqrt(v).ToString();
    }

    private void btnCE_Click(object sender, RoutedEventArgs e)
    {
      txtResult.Text = "0";
    }

    private void btnC_Click(object sender, RoutedEventArgs e)
    {
      txtResult.Text = "0";
      saved = 0;
      op = "";
      opFlag = false;
    }

    private void btnDel_Click(object sender, RoutedEventArgs e)
    {
      txtResult.Text = txtResult.Text.Remove(txtResult.Text.Length - 1);
      if (txtResult.Text.Length == 0)
      {
        txtResult.Text = "0";
      }
    }
  }
}
