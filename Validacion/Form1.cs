using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Validacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnValidar_Click(object sender, EventArgs e)
        {
            string dominio = txtDominio.Text.ToUpper(); 
            string patron = @"^([A-Z]{2}\d{3}[A-Z]{2})|([A-Z]{3}\d{3})$";

            if (dominio.Length < 6 )
            {
                MessageBox.Show("El dominio debe tener un minimo de 6 caracteres");
                return;
            }

            if (dominio.Length > 7)
            {
                MessageBox.Show("El dominio debe tener un maximo de 7 caracteres");
                return;
            }

            if (Regex.IsMatch(dominio, patron))
            {
                MessageBox.Show("El domimio es correcto");
            }
            else
            {
                MessageBox.Show("El formato del dominio es incorrecto");
            }
        }

        private void btnExtraer_Click(object sender, EventArgs e)
        {
            string cuil = txtCuil.Text;

            //aca metemos una subcadena q la profe quiere
            if (cuil.Length == 13 && cuil[2] == '-' && cuil[11] == '-')
            {
                string dni = cuil.Substring(3, 8);
                MessageBox.Show($"Se extrajo correctamente el DNI: {dni}");
            }
            else
            {
                MessageBox.Show("El formato es invalido como el gol de boca en el clasico");
            }
        }

    }
}

