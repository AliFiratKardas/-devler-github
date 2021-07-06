using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AliFiratSayisalLotoOdevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            FlowLayoutPanel flw = new FlowLayoutPanel();
            this.Controls.Add(flw);
            flw.Width = 1053;
            flw.Height = 440;
            for (int i = 0; i < 6; i++)
            {
                ListBox list = new ListBox();
                for (int j = 0; j < 6; j++)
                {
                    int sayi = rnd.Next(1, 50);
                    flw.Controls.Add(list);
                    list.Items.Add(sayi);

                }
                


            }

        }
    }
}
