using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _005_bmiForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // btnBMI 버튼이 클릭되면 실행되는 함수(디자이너에서 만들어 준것)
        private void btnBMI_Click(object sender, EventArgs e)
        {
            double h = double.Parse(txtH.Text);
            double w = double.Parse(txtW.Text);

            h /= 100;

            double bmi = w / (h * h);

            lblBMI.Text = "BMI = " + bmi.ToString();
        }
    }
}
