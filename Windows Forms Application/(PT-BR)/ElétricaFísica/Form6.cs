using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ElétricaFísica
{
    public partial class SistemaL1 : Form
    {
        public SistemaL1()
        {
            InitializeComponent();
        }
        private void SistemaL1_Load(object sender, EventArgs e)
        {
            // Deixando as "instrucoes" sem poderem ser alteradas:
            QtdEquacoes.ReadOnly = true;

            // Deixando com que a ComboBox só possa ser alterada pela setinha do lado:
            qtd.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void caminho_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (qtd.Text == "1")
            {
                SistemaL2 open7 = new SistemaL2();
                this.Hide();
                open7.ShowDialog();
                Close();
            }
            else if (qtd.Text == "2")
            {
                SistemaL3 open7 = new SistemaL3();
                this.Hide();
                open7.ShowDialog();
                Close();
            }
            else if (qtd.Text == "3")
            {
                SistemaL4 open7 = new SistemaL4();
                this.Hide();
                open7.ShowDialog();
                Close();
            }
            else if (qtd.Text == "4")
            {
                SistemaL5 open7 = new SistemaL5();
                this.Hide();
                open7.ShowDialog();
                Close();
            }
        }
    }
}
