using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double nota_1, nota_2, nota_3, promedio;
            string condicion;

            nota_1 = double.Parse(txtnota1.Text);
            nota_2 = double.Parse(txtnota2.Text);
            nota_3 = double.Parse(txtnota3.Text);

            promedio = (nota_1 + nota_2 + nota_3) / 3;

            if(promedio<=14)
            {
                condicion = "DESAPROBADO";
                txtpromedio.Text = promedio.ToString("N2");
                txtcondicion.Text = condicion;
            }else if(promedio > 15 && promedio <= 20)
            {
                condicion = "APROBADO";
                txtpromedio.Text = promedio.ToString("N2");
                txtcondicion.Text = condicion;
            }
        }

        private void btnnuevo_Click_2(object sender, EventArgs e)
        {
            txtnota1.Clear();
            txtnota2.Clear(); 
            txtnota3.Clear(); 
            txtcondicion.Clear(); 
            txtpromedio.Clear();
            txtnota1.Focus();
        }
    }
}
