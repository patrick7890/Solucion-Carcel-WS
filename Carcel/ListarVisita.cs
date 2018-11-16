using BibliotecaCarcel;
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
    public partial class ListarVisita : MetroFramework.Forms.MetroForm
    {
        public ListarVisita()
        {
            InitializeComponent();
            cargarlista();


        }




        public void cargarlista()
        {
            Visita.WSVisitaClient vi = new Visita.WSVisitaClient();
            horario.WSHorarioClient h = new horario.WSHorarioClient();

            penal.WSPenalClient pe = new penal.WSPenalClient();
            preso.WSPresoClient p = new preso.WSPresoClient();

            List<visita> lv = new List<visita>();




            Visita.visita[] visitas = vi.findAll();
            for (int i = 0; i < vi.count(); i++)
            {
                visita v = new visita();
                //set visita
                v.IdVisita = visitas[i].idVisita;
                v.NombreV = visitas[i].nombreV;
                v.Observacion = visitas[i].observacion;
                v.Edad = visitas[i].edad;
                v.TiempoVisita = visitas[i].tiempoVisita;


                preso.preso pr = p.buscarPreso(visitas[i].presoIdPreso.idPreso);
                horario.horario ho = h.buscarHorario(visitas[i].horarioIdHorario.idHorario);

                Horario hora = new Horario();

                //set horario
                hora.IdHorario = ho.idHorario;
                hora.Minutos = ho.minutos;
                hora.DescripcionH = ho.descripcionH;
                //set visita horario
                v.HorarioIdHorario = hora;

                Preso pre = new Preso();
                //set preso
                pre.IdPreso = pr.idPreso;
                pre.Nombre = pr.nombreV;




                if (pr.sexoV == 0)
                {
                    pre.Sexo = 'M';
                }
                else
                {
                    pre.Sexo = 'F';
                }
                if (pr.visitaV == 0)
                {
                    pre.Visita = 'S';
                }
                else
                {
                    pre.Visita = 'N';
                }




                //set penal
                Penal pena = new Penal();
                penal.penal pen = pe.buscarPenal((int)pr.penalIdPenal.idPenal);
                pena.IdPenal = pen.idPenal;
                pena.Descripcion = pen.descripcion;

                //set penal preso
                pre.PenalIdPenal = pena;


                //set visita preso
                v.PresoIdPreso = pre;




                lv.Add(v);
            }
            dataGridView1.DataSource = lv;
            dataGridView1.Refresh();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Visita.WSVisitaClient vi = new Visita.WSVisitaClient();


                Visita.visita v = vi.buscar(txtEliminar.Text);
                if (vi.remove(v))
                {
                    MessageBox.Show("Visita eliminada");
                    cargarlista();

                }
                else
                {
                    MessageBox.Show("error al eliminada");
                }


            }
            catch (Exception)
            {

                MessageBox.Show("Algo salio mal :(");
            }




        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cargarlista();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    if (dataGridView1.Rows[i].Cells[0].Value.ToString() == txtEliminar.Text)
                    {
                        dataGridView1.Rows[i].Selected = true;
                    }
                    else
                    {
                        dataGridView1.Rows[i].Selected= false;
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("khe");
            }
            
        }

        private void btnre_Click(object sender, EventArgs e)
        {
            cargarlista();
        }
    }
}
