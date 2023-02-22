using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class Contenedor : Form
    {
        public Contenedor()
        {
            InitializeComponent();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void entregaDePasaporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Entrega_Pasaporte entrega_pasaporte_child = new Entrega_Pasaporte();
            entrega_pasaporte_child.MdiParent = this;
            entrega_pasaporte_child.Show();
        }

        private void Contenedor_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void registroDeInformaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro registro_child = new Registro();
            registro_child.MdiParent = this;
            registro_child.Show();
        }
    }
}
