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
    public partial class RegistrarVisita : MetroFramework.Forms.MetroForm
    {

        public RegistrarVisita()
        {

            InitializeComponent();


            horario.WSHorarioClient h = new horario.WSHorarioClient();
            foreach (horario.horario horario in h.findAllHorario().ToArray())
            {
                cboHorario.Items.Add(horario.descripcionH);
            }


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string mensaje = "";
            if (txtNombre.Text.Trim() == "" && txtNombre.Text.Length < 3)
            {
                mensaje += "-Nombre Ingresado Incorrectamente :(";


            }
            int edad = 0;

            if (int.TryParse(txtEdad.Text, out edad) == false)
            {
                mensaje += "\n-edad mal ingresada";
            }

            if (edad < 18 || edad > 60)
            {
                mensaje += "\n-La edad Ingresada fuera de rango";

            }
            else
            {
                preso.WSPresoClient p = new preso.WSPresoClient();
                preso.preso pre = p.buscarPreso(int.Parse(txtPreso.Text));
                if (pre.visitaV != 1)
                {


                    try
                    {
                        Visita.WSVisitaClient v = new Visita.WSVisitaClient();
                        string idv = v.idvisita();
                        bool aux = v.agregarVisita(idv, txtObcervacion.Text, int.Parse(txtPreso.Text), txtNombre.Text, short.Parse(txtEdad.Text), cboHorario.SelectedIndex + 1);

                        if (aux)
                        {
                            MessageBox.Show("Visita Agregado"+"\n id de visita: "+idv);
                            limpiarVisita();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo Visita ");
                        }
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Algo salio mal :)");

                    }
                }
                else
                {
                    MessageBox.Show("Este preso no puede ser visitado");
                }
            }
            if (mensaje != "")
            {
                MessageBox.Show(mensaje);
            }

        }
        public void limpiarVisita()
        {
            txtNombre.Text = "";
            txtEdad.Text = "";
            cboHorario.SelectedIndex = -1;
            txtPreso.Text = "";
            txtObcervacion.Text = "";



        }

    }
}
