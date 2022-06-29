using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseAltura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void btnCalcular_Click_1(object sender, EventArgs e)
        {
            double basee, altura, area;

            basee = double.Parse(txtBase.Text);
            altura = double.Parse(txtAltura.Text);
            area = basee * altura / 2;

            lblArea.Text = area.ToString();
        }
    }
}
