using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        int x=0, y=0, R;
        string sinal;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn01_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
      
        }

        private void btn02_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
       
        }

        private void btn03_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
     
        }

        private void btn04_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
       
        }

        private void btn05_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
         
        }

        private void btn06_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
       
        }

        private void btn07_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
           
        }

        private void btn08_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
          
        }

        private void btn09_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
            
        }

            private void btn0_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = textBox1.Text + "0";
            
            
        }

        private void btnAd_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt32(textBox1.Text);
            textBox1.Text = textBox1.Text + "+";
            sinal = "ad";
            textBox1.Text = " ";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt32(textBox1.Text);
            textBox1.Text = textBox1.Text + "-";
            sinal = "sub";
            textBox1.Text = " ";
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt32(textBox1.Text);
            textBox1.Text = textBox1.Text + "x";
            sinal = "mult";
            textBox1.Text = " ";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt32(textBox1.Text);
            textBox1.Text = textBox1.Text + "/";
            sinal = "div";
            textBox1.Text = " ";
        }

        private void btnBin_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt32(textBox1.Text);
           // textBox1.Text = textBox1.Text + "bin";
            sinal = "bin";
           // textBox1.Text = " ";
           
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt32(textBox1.Text);
           // textBox1.Text = textBox1.Text + "v";
            sinal = "raiz";
           // textBox1.Text = string.Empty;
        }

        private void btnExp_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt32(textBox1.Text);
            textBox1.Text = textBox1.Text + "^";
            sinal = "exp";
            textBox1.Text = " ";
        }

        private void btnPorc_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt32(textBox1.Text);
            textBox1.Text = textBox1.Text + "%";
            sinal = "porc";
            textBox1.Text = " ";
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = String.Empty;
         
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
                //int y = Convert.ToInt32(textBox1.Text);
           
            if (sinal == "ad")
            {
                int y = Convert.ToInt32(textBox1.Text);
                R = (x + y);
                textBox1.Text = Convert.ToString(R);
               
            }

            if (sinal == "sub")
            {
                int y = Convert.ToInt32(textBox1.Text);
                R = (x - y);
                textBox1.Text = Convert.ToString(R);

            }
            if (sinal == "mult")
            {
                int y = Convert.ToInt32(textBox1.Text);
                R = (x * y);
                textBox1.Text = Convert.ToString(R);

            }
            if (sinal == "div")
            {
                int y = Convert.ToInt32(textBox1.Text);
                if (y == 0)
                {
                    MessageBox.Show("Erro! Div por 0!");
                }
                R = (x / y);
                textBox1.Text = Convert.ToString(R);

            }
            if (sinal == "porc")
            {
                int y = Convert.ToInt32(textBox1.Text);
                R = (x/100)*y;
                textBox1.Text = Convert.ToString(R);

            }

            if (sinal == "exp")
            {
                int y = Convert.ToInt32(textBox1.Text);
                R = Convert.ToInt32(Math.Pow(x, y)); 
                textBox1.Text = Convert.ToString(R);

            }

            if (sinal == "raiz")
            {
                x = int.Parse(textBox1.Text);
       
                textBox1.Text = "";
                R = Convert.ToInt32(Math.Sqrt(x));
                textBox1.Text = Convert.ToString(R);

            }

            if (sinal == "bin")
            {
               int x = int.Parse(textBox1.Text);
                string R = "";
                while(x>0)
                {
                    R = (x % 2) + R;
                    x/=2;
                }
                textBox1.Text = Convert.ToString(R);

            }

        }
    }
}
