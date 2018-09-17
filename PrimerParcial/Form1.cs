using PrimerParcial.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrimerParcial
{
    public partial class PrimerParcial : Form
    {
        public PrimerParcial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExamenRegistro r = new ExamenRegistro();
            r.ShowDialog();
        }

        private void Consultar_Click(object sender, EventArgs e)
        {
            
        }

        private void PrimerParcial_Load(object sender, EventArgs e)
        {

        }

        private void SaLir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
