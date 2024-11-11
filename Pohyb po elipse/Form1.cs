using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pohyb_po_elipse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double x = 200, y = 200;
        double uhel = 0;
        int posun = 5;
        
        int sirka = 300;
        int vyska = 200;
        int velikostKruhu = 50;


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
           Graphics kp = e.Graphics;
           kp.DrawEllipse(Pens.Black, velikostKruhu, velikostKruhu, sirka*2,vyska*2);
           kp.FillEllipse(Brushes.Black, Convert.ToInt32(x - (velikostKruhu / 2)), Convert.ToInt32(y - (velikostKruhu/2)), velikostKruhu, velikostKruhu);
        }

        private void tlacitkoPrepocitej_Click(object sender, EventArgs e)
        {
            try
            {
                sirka = Convert.ToInt32(poleSirka.Text);
                vyska = Convert.ToInt32(poleVyska.Text);

            }
            catch 
            {
;               return;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                timer1.Enabled = false;
                button1.Text = "Jeď";
            }
            else
            {
                timer1.Enabled = true;
                button1.Text = "Zastav";
            }
        }

        private void poleRychlost_TextChanged(object sender, EventArgs e)
        {
            try
            {

                posun = Convert.ToInt32(poleRychlost.Text);
            }
            catch
            {
                return;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            uhel += posun;
            x = (sirka * Math.Cos(uhel / 180) + sirka) + velikostKruhu;
            y = (vyska * Math.Sin(uhel / 180) + vyska) + velikostKruhu;
            labelRychlost.Text = Convert.ToString(posun);

            if (uhel>Math.PI*360)
            {
                uhel -= Math.PI*360;
            }
            labelUhel.Text = Convert.ToString(Convert.ToInt32(uhel/Math.PI));
            Refresh();
        }
    }
}
