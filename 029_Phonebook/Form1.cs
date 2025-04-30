using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Interfaces;
using FireSharp.Config;
using FireSharp.Response;

namespace _029_Phonebook
{
  public partial class Form1 : Form
  {
    IFirebaseConfig config = new FirebaseConfig
    {
      AuthSecret = "q9dAJRX1ZMtKyjcuGAY2VkkoFjmc1WoDw4nd8lZM",
      BasePath = "https://vp02-95924-default-rtdb.firebaseio.com/"
    };

    IFirebaseClient client;
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      client = new FireSharp.FirebaseClient(config);

      if (client != null)
      {
        MessageBox.Show("Connection 성공!");
      }
    }

    private async void btnInsert_Click(object sender, EventArgs e)
    {
      Data data = new Data
      {
        Id = txtId.Text,
        SId = txtSId.Text,
        Name = txtName.Text,
        Phone = txtPhone.Text
      };

      SetResponse response 
        = await client.SetAsync("Phonebook/" + txtId.Text, data);

      Data result = response.ResultAs<Data>();
      MessageBox.Show(
        string.Format("Data Inserted : Id = {0}, Name = {1}",
        result.Id, result.Name));
    }
  }
}
