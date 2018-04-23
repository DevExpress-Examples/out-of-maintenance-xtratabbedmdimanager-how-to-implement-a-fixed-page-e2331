using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraTabbedMdi;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        Color GetRandomColor()
        {
            return Color.FromArgb(r.Next(255), r.Next(255), r.Next(255));
        }

        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 10; i++)
            {
                Form form = new Form();
                form.MdiParent = this;
                form.Show();
                form.Text = String.Format("Page{0}", i);
                form.BackColor = GetRandomColor();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myMDIManager1.SetFixedForm(new StartPage());
        }
    }
}