using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _006_bmiForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBMI_Click(object sender, EventArgs e)
        {
            double w = double.Parse(txtW.Text);
            double h = double.Parse(txtH.Text);

            h /= 100;   // cm를 m로 변환

            double bmi = w / (h * h);
            lblBMI.Text = "BMI = " + bmi.ToString();

            // 비만도 판정
            if (bmi < 20)
            {
                lblResult.Text = "저체중입니다.";
                pictureBox1.BackColor = Color.Blue;
            }
            else if (/*20 <= bmi &&*/ bmi < 25)
            {
                lblResult.Text = "정상체중입니다.";
                pictureBox1.BackColor = Color.Green;
            }
            else if (bmi < 30)
            {
                lblResult.Text = "경도비만입니다.";
                pictureBox1.BackColor = Color.YellowGreen;
            }
            else if (bmi < 40)
            {
                lblResult.Text = "비만입니다.";
                pictureBox1.BackColor = Color.OrangeRed;
            }
            else
            {
                lblResult.Text = "고도비만입니다.";
                pictureBox1.BackColor = Color.Red;
            }
        }
    }
}
