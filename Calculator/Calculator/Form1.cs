using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        char _islem;
        bool _ekranTemizlenecekMi;
        int _ilkSayi;
        public Form1()
        {
            InitializeComponent();
        }

        private void nbr1_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                screen.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (screen.Text == "0") screen.Text = "";
            screen.Text += "1";
        }

        private void nbr2_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                screen.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (screen.Text == "0") screen.Text = "";
            screen.Text += "2";
        }

        private void nbr3_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                screen.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (screen.Text == "0") screen.Text = "";
            screen.Text += "3";
        }

        private void nbr4_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                screen.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (screen.Text == "0") screen.Text = "";
            screen.Text += "4";
        }

        private void nbr5_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                screen.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (screen.Text == "0") screen.Text = "";
            screen.Text += "5";
        }

        private void nbr6_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                screen.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (screen.Text == "0") screen.Text = "";
            screen.Text += "6";
        }

        private void nbr7_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                screen.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (screen.Text == "0") screen.Text = "";
            screen.Text += "7";
        }

        private void nbr8_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                screen.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (screen.Text == "0") screen.Text = "";
            screen.Text += "8";
        }

        private void nbr9_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                screen.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (screen.Text == "0") screen.Text = "";
            screen.Text += "9";
        }

        private void nbr0_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                screen.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (screen.Text == "0") screen.Text = "";
            screen.Text += "0";
        }

        private void topla_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _ekranTemizlenecekMi = true;
            _ilkSayi = Convert.ToInt32(screen.Text);
        }

        private void result_Click(object sender, EventArgs e)
        {
            int ikinciSayi = Convert.ToInt32(screen.Text);
            int sonuc;

            switch (_islem)
            {
                case '+':
                    sonuc = _ilkSayi + ikinciSayi;
                    break;
                case '-':
                    sonuc = _ilkSayi - ikinciSayi;
                    break;
                case '*':
                    sonuc = _ilkSayi * ikinciSayi;
                    break;
                case '/':
                    sonuc = _ilkSayi / ikinciSayi;
                    break;
                default:
                    sonuc = 0;
                    return;
            }

            screen.Text = Convert.ToString(sonuc);
        }

        private void cikar_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _ekranTemizlenecekMi = true;
            _ilkSayi = Convert.ToInt32(screen.Text);
        }

        private void carp_Click(object sender, EventArgs e)
        {
            _islem = '*';
            _ekranTemizlenecekMi = true;
            _ilkSayi = Convert.ToInt32(screen.Text);
        }

        private void bol_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _ekranTemizlenecekMi = true;
            _ilkSayi = Convert.ToInt32(screen.Text);
        }

        private void remove_Click(object sender, EventArgs e)
        {
            screen.Text = "0";
        }
    }
}
