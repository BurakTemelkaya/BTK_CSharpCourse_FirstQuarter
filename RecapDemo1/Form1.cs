using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            generateBtns();
            
        }
        void generateBtns()
        {
            Button[,] btns = new Button[8, 8];
            int top = 0, left = 0;
            for (int i = 0; i <= btns.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= btns.GetUpperBound(1); j++)
                {
                    btns[i, j] = new Button();
                    btns[i, j].Width = 50;
                    btns[i, j].Height = 50;
                    btns[i, j].Left = left;
                    btns[i, j].Top = top;
                    left += 50;
                    if ((i + j) % 2 == 0)
                    {
                        btns[i, j].BackColor = Color.Black;
                    }
                    else
                    {
                        btns[i, j].BackColor = Color.White;
                    }
                    this.Controls.Add(btns[i, j]);
                }
                left = 0;
                top += 50;
            }
        }
    }
}
