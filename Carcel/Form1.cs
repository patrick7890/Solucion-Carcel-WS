using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carcel
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            cboSexo.SelectedIndex = 0;
            cboVisita.SelectedIndex = 0;
            cboPenal.SelectedIndex = 0;
            btnActualizar.Enabled = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            preso.WSPresoClient p = new preso.WSPresoClient();
            if (txtNombre.Text.Trim() != "")
            {
                try
                {



                    int visita = cboVisita.SelectedIndex - 1;
                    int sexo = cboSexo.SelectedIndex - 1;
                    bool aux = p.AgregarPreso(txtID.Text, txtNombre.Text, ushort.Parse(sexo.ToString()), ushort.Parse(visita.ToString()), cboPenal.SelectedIndex);

                    if (aux)
                    {
                        MessageBox.Show("Preso Agregado");
                        limpiarPreso();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar ");
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Algo salio mal :)");

                }

            }
            else
            {
                MessageBox.Show("Ingrese un nombre");
            }
        }

        public void limpiarPreso()
        {
            txtID.Text = "";
            txtNombre.Text = "";
            cboSexo.SelectedIndex = 0;
            cboVisita.SelectedIndex = 0;
            cboPenal.SelectedIndex = 0;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            preso.WSPresoClient p = new preso.WSPresoClient();


            try
            {
                int idpreso = int.Parse(txtID.Text);
                preso.preso pre = p.buscarPreso(idpreso);
                txtNombre.Text = pre.nombreV;
                cboSexo.SelectedIndex = pre.sexoV + 1;
                cboVisita.SelectedIndex = pre.visitaV + 1;
                cboPenal.SelectedIndex = pre.penalIdPenal.idPenal + 1;
                btnAgregar.Enabled = false;
                btnActualizar.Enabled = true;
            }
            catch (Exception)
            {

                
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            preso.WSPresoClient p = new preso.WSPresoClient();
            if (txtID.Text.Trim() != "")
            {
                try
                {

                    penal.WSPenalClient pena = new penal.WSPenalClient();
                    int visita = cboVisita.SelectedIndex - 1;
                    int sexo = cboSexo.SelectedIndex - 1;
                    short id = short.Parse(txtID.Text);
                    bool aux = p.actualizarpreso(id, txtNombre.Text, ushort.Parse(sexo.ToString()), ushort.Parse(visita.ToString()), cboPenal.SelectedIndex);

                    if (aux)
                    {
                        MessageBox.Show("Preso actualizado");
                        limpiarPreso();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar ");
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Algo salio mal :)");

                }

            }
            else
            {
                MessageBox.Show("Ingrese un nombre");
            }


        }
    }
}
