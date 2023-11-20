using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElétricaFísica
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        // Botões para escolher qual área do programa o usuário que usar:
        private void SistemaL_Click_1(object sender, EventArgs e)
        {
            SistemaL1 open6 = new SistemaL1();
            this.Hide();
            open6.ShowDialog();
            Close();
        }

        private void LancamentoB_Click_1(object sender, EventArgs e)
        {
            LancamentoB1 open2 = new LancamentoB1();
            this.Hide();
            open2.ShowDialog();
            Close();
        }
    }
}
