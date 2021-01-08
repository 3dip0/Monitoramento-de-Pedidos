using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monitoramento_de_Pedidos
{
    public partial class tempoEntrega : Form
    {
        public string tempo;
        public tempoEntrega()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            tempo = cbTempo.Text;
            Close();
        }
    }
}
