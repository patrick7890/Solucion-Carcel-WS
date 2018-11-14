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
    public partial class Listar_Preso : Form
    {
        public Listar_Preso()
        {
            InitializeComponent();

            preso.WSPresoClient p = new preso.WSPresoClient();

            dataGridView1.DataSource = p.listarTodo();

        }
    }
}
