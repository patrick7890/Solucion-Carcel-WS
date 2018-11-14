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
    public partial class RegistrarVisita : Form
    {

        public RegistrarVisita()
        {

            InitializeComponent();
            preso.WSPresoClient p = new preso.WSPresoClient();
            foreach (preso.preso presos in p.findAllPreso().ToArray())
            {
                cboPreso.Items.Add(presos.nombreV);
            }

            horario.WSHorarioClient h = new horario.WSHorarioClient();
            foreach (horario.horario horario in h.findAllHorario().ToArray())
            {
                cboHorario.Items.Add(horario.descripcionH);
            }


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Visita.WSVisitaClient v = new Visita.WSVisitaClient();
            v.agregarVisita(txtID.Text, txtObcervacion.Text, cboPreso.SelectedIndex + 1, txtNombre.Text,short.Parse(txtEdad.Text), cboHorario.SelectedIndex + 1);
            


        }
    }
}
