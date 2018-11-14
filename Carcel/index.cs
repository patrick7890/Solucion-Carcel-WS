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
    public partial class index : Form
    {
        public index()
        {
            InitializeComponent();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarVisita RV = new RegistrarVisita();
            RV.MdiParent = this;
            RV.Show();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.MdiParent = this;
            f.Show();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listar_Preso LP = new Listar_Preso();
            LP.MdiParent = this;
            LP.Show();

        }
    }
}
