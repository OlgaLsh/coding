using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMOLab7Ex5
{
    public partial class Form1 : Form
    {
       

        public Form1()
        {
            InitializeComponent();
        }

        private async Task<String> Algoritm(int max)
        {
            return await Task.Run(() =>
            {
                int maxValue = 0;
                System.Text.StringBuilder resultText = new System.Text.StringBuilder();
                if (int.TryParse(MaxValue.Text, out maxValue))
                {
                    for (int trial = 2; trial <= maxValue; trial++)
                    {
                        bool isPrime = true;
                        for (int divisor = 2; divisor <= Math.Sqrt(trial); divisor++)
                        {
                            if (trial % divisor == 0) { isPrime = false; break; }
                        }
                        if (isPrime)
                        {
                            resultText.AppendFormat("{0} ", trial);
                        }
                    }
                }
                else
                {
                    resultText.Append("Unable to parse maximum value.");
                }
                resultText.ToString();
                return resultText.ToString();

            });

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            int a;
            try
            {
                a = Int32.Parse(MaxValue.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("При выполнении преобразования типов возникла ошибка");
                MaxValue.Text = "";
                return;
            }
            string res = await Algoritm(a);
            //lblResult.Text = res.ToString();
            MessageBox.Show(res.ToString(), "Результат операции");
        }

        private void lblMax_Click(object sender, EventArgs e)
        {

        }

        private void MaxValue_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
