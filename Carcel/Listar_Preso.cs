using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaCarcel;
namespace Carcel
{
    public partial class Listar_Preso : Form
    {
        public Listar_Preso()
        {
            InitializeComponent();

            preso.WSPresoClient p = new preso.WSPresoClient();
            penal.WSPenalClient pe = new penal.WSPenalClient();
            List<Preso> lp = new List<Preso>();


            preso.preso[] presos = p.findAllPreso().ToArray();
            for (int i = 0; i < p.countPreso(); i++)
            {
                Preso pre = new Preso();
                Penal pena = new Penal();
                pre.IdPreso = presos[i].idPreso;
                pre.NombreV = presos[i].nombreV;
                if (presos[i].sexoV == 0)
                {
                    pre.SexoV = 'M';
                }
                else
                {
                    pre.SexoV = 'F';
                }
                if (presos[i].visitaV == 0)
                {
                    pre.VisitaV = 'S';
                }
                else
                {
                    pre.VisitaV = 'N';
                }

                penal.penal pen = pe.buscarPenal((int)presos[i].penalIdPenal.idPenal);
                pena.IdPenal = pen.idPenal;
                pena.Descripcion = pen.descripcion;
                pre.PenalIdPenal = pena;

                lp.Add(pre);
            }
            dataGridView1.DataSource = lp;

        }
    }
}
