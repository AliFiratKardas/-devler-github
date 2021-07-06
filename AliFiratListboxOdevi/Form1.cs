using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AliFiratListboxOdevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ListBox list = new ListBox();

        private void Form1_Load(object sender, EventArgs e)
        {
            FlowLayoutPanel flw = new FlowLayoutPanel();
            flw.Left = 13;
            flw.Top = 41;
            flw.Width = 775;
            flw.Height = 200;

            ComboBox cmb = new ComboBox();
            this.Controls.Add(cmb);
            cmb.Items.Add("Listbox");
            cmb.Items.Add("Textbox");
            cmb.Items.Add("DateTimePicker");
            cmb.Items.Add("Button");
            cmb.Items.Add("CheckBox");
            cmb.SelectedValueChanged += Cmb_SelectedValueChanged;
            
           
            Button btn = new Button();
            TextBox txt = new TextBox();
            DateTimePicker dt = new DateTimePicker();
            CheckBox chk = new CheckBox();

            this.Controls.Add(flw);
            flw.Controls.Add(btn);
            flw.Controls.Add(txt);
            flw.Controls.Add(dt);
            flw.Controls.Add(chk);

            this.Controls.Add(list);
            
            list.Left = 13;
            list.Top = 300;
            list.Width = 400;
            list.Height = 150;
             
        }

        private void Cmb_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            string gelen = cmb.Text;
            list.Items.Add(gelen);
        }

        
    }
}
