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
using MySql.Data.MySqlClient;

namespace _042_EIS
{
  /// <summary>
  /// MainWindow.xaml에 대한 상호 작용 논리
  /// </summary>
  public partial class MainWindow : Window
  {

    private string connStr = "server=localhost; user id=root; password=1234; database=eis_db";
    private MySqlConnection conn;
    private string gender;
    private string dateEnter;
    private string dateExit;
    private string dept;
    private string pos;

    public MainWindow()
    {
      InitializeComponent();

      conn = new MySqlConnection(connStr);

      if (conn != null)
        MessageBox.Show("Connection Success!");
    }

    // Insert 버튼
    private void btnInsert_Click(object sender, RoutedEventArgs e)
    {
      if (rbMale.IsChecked == true)
        gender = "남성";
      else if (rbFemale.IsChecked == true)
        gender = "여성";

      // 입사일
      if(dpEnter.SelectedDate != null)
        dateEnter 
          = dpEnter.SelectedDate.Value.Date.ToShortDateString(); // 년월일 포맷

      // 퇴사일
      if (dpExit.SelectedDate != null)  // 퇴사일이 있는 퇴사한 사람
        dateExit = dpExit.SelectedDate.Value.Date.ToShortDateString();
      else
        dateExit = DateTime.MaxValue.ToShortDateString();

      // 부서, 직급
      dept = cbDept.Text;
      pos = cbPos.Text;

      string sql = string.Format("INSERT_INTO eis_table (name, department," +
        " position, gender, date_enter, date_exit, contact, comment) " +
        "VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')",
        txtName.Text, dept, pos, gender, dateEnter, dateExit, txtContact.Text, txtComment.Text);

      // MessageBox.Show(sql);

      conn.Open();
      MySqlCommand cmd = new MySqlCommand(sql, conn);
      if (cmd.ExecuteNonQuery() == 1)
        MessageBox.Show("Insert Success!");

      conn.Close();
      InitControls();

    }

    private void InitControls()
    {
      txtEid.Text = "";
      txtName.Text = "";
      txtContact.Text = string.Empty;
      txtComment.Text = string.Empty;
      cbDept.SelectedIndex = -1;
      cbPos.SelectedIndex = -1;
      rbMale.IsChecked = false;
      rbFemale.IsChecked = false;
      dpEnter.Text = string.Empty;
      dpExit.Text = string.Empty;
    }
  }
}
