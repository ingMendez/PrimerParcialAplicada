using PrimerParcial.BLL;
using PrimerParcial.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrimerParcial.UI.Registros
{
    public partial class ExamenRegistro : Form
    {
        public ExamenRegistro()
        {
            InitializeComponent();
        }

        private bool GuardarValidar()
        {
            bool paso = true;


            if (string.IsNullOrWhiteSpace(nombreTextBox.Text))
            {
                SuperErrorProvider.SetError(nombreTextBox, "Debe Llenar el campo ");
                paso = false;
            }

            if (sueldoNumericUpDown.Value == 0)
            {
                SuperErrorProvider.SetError(sueldoNumericUpDown, "Falto Digitar ");
                paso = false;
            }
            if (retencionNumericUpDown.Value == 0)
            {
                SuperErrorProvider.SetError(retencionNumericUpDown, "Falto digitar laretencion");
                paso = false;
            }
            if (Fecha_dateTimePicker.Value != DateTime.Now && Fecha_dateTimePicker.Value < DateTime.Now)
            {
                SuperErrorProvider.SetError(Fecha_dateTimePicker, "Debe digitar una fecha mayor");
                    paso = false;
                
            }
            return paso;
        }

        private void Limpiar()
        {
            vendedorIdNumericUpDown.Value = 0;
            nombreTextBox.Clear();
            sueldoNumericUpDown.Value = 0;
            retencionNumericUpDown.Value = 0;
            rotacionNumericUpDown.Value = 0;
        }

       
        private void Button4_Click(object sender, EventArgs e)
        {
            
                SuperErrorProvider.Clear();
                int id;
                Vendedor vendedor = new Vendedor();
                int.TryParse( vendedorIdNumericUpDown.Text, out id);
                vendedor = VendedorBLL.Buscar(id);
                if (vendedor != null)
                {
                    MessageBox.Show(" encontrado");
                    LlenaCampo(vendedor);

                }
                else
                {
                    MessageBox.Show("no encontrado");
                }

            
        }

        private void ExamenRegistro_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
     
        private Vendedor LlenaCampo(Vendedor vendedor)
        {
            Convert.ToInt32(vendedorIdNumericUpDown.Value = vendedor.VendedorId);
            nombreTextBox.Text = vendedor.Nombre;
            Convert.ToInt32(retencionNumericUpDown.Value = vendedor.Retencion);
            Convert.ToInt32(sueldoNumericUpDown.Value = vendedor.Sueldo);
            Convert.ToInt32(rotacionNumericUpDown.Value = vendedor.Rotacion);


            return vendedor;

        }
        private Vendedor LlenaClase()
        {
            Vendedor vendedor = new Vendedor();

            vendedor.VendedorId = Convert.ToInt32(vendedorIdNumericUpDown.Value);
            vendedor.Nombre = nombreTextBox.Text;
            vendedor.Retencion = Convert.ToInt32(retencionNumericUpDown.Value);
            vendedor.Rotacion = Convert.ToInt32(rotacionNumericUpDown.Value); 
            vendedor.Sueldo = Convert.ToInt32(sueldoNumericUpDown.Value);


            return vendedor;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SuperErrorProvider.Clear();
            int id = (int)vendedorIdNumericUpDown.Value;
            Vendedor vendedor = VendedorBLL.Buscar(id);
            Vendedor vendedor_guardar = LlenaClase();

            if (vendedor == null)
            {
                if (GuardarValidar()) ///sim la funcion validar = true entonces guardaame
                {
                    if (VendedorBLL.Guardar(vendedor_guardar))
                    {
                        MessageBox.Show(" Guardado");
                        Limpiar();

                    }
                }
            }
            else
            {
                if (GuardarValidar())
                {
                    if (VendedorBLL.Modificar(vendedor_guardar))
                        MessageBox.Show(" Modificado");
                    else
                        MessageBox.Show(" no medificado");
                }



            }
            Nuevo_button.PerformClick();

        }

        private void Button3_Click(object sender, EventArgs e)
        {
           
                SuperErrorProvider.Clear();
                int id;
                int.TryParse(vendedorIdNumericUpDown.Text, out id);
                Vendedor vendedor = BLL.VendedorBLL.Buscar(id);
                if (vendedor != null)
                {
                    BLL.VendedorBLL.Eliminar(id);
                    MessageBox.Show(" Eliminado");
                    Limpiar();

                }
                else
                {
                    MessageBox.Show("No se puede eliminar  que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   Nuevo_button.PerformClick();
                }
            }

       
        private void RotacionNumericUpDown_ValueChanged(object sender, EventArgs e)
        {


            rotacionNumericUpDown.Value = (sueldoNumericUpDown.Value * retencionNumericUpDown.Value)/100;
         
        }

        private void NombreLabel_Click(object sender, EventArgs e)
        {

        }

        private void NombreTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


