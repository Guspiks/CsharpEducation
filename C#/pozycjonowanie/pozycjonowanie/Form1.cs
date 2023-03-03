using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pozycjonowanie
{
    public partial class Form1 : Form
    {
        int x_pos;
        int y_pos;
        int kierunek;
        public Form1()
        {
            InitializeComponent();

            x_pos = 50;
            y_pos = 50;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Black, x_pos, y_pos, 20, 20);
        }

        private void bt_position_Click(object sender, EventArgs e)
        {
            kierunek = 1;
            for (int x_st = 0; x_st < 16; x_st++)
            {
                for (int y_st = 0; y_st < 16; y_st++)
                {
                    y_pos += kierunek * 10;
                    Invalidate();
                }
                x_pos += 10;
                kierunek *= -1;
                Invalidate();
            }
        }
    }
}
