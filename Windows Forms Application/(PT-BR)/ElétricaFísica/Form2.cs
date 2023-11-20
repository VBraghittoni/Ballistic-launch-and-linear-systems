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
    public partial class LancamentoB1 : Form
    {
        // Criando uma função para as text boxs:
        void excecoes(string textBox, KeyPressEventArgs e)
        {
            // Limitações para tratar exceções:
            // Verifica se o caractere inserido não é um dígito ou um ponto decimal
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true; // Impede a inserção do caractere na caixa de texto
            }

            // Verifica se já existe um ponto decimal na caixa de texto
            if ((e.KeyChar == ',') && (textBox.IndexOf(',') > -1))
            {
                e.Handled = true; // Impede a inserção de mais de um ponto decimal
            }

            // Impede esse atalho:
            if (e.KeyChar == (char)22) // 22 é o código ASCII para Ctrl+V
            {
                e.Handled = true; // Ignora a entrada do usuário para Ctrl+V
            }
        }
        public LancamentoB1()
        {
            InitializeComponent();
        }

        private void LancamentoB1_Load(object sender, EventArgs e)
        {
            // Não deixando com que o usuário mude a "TextBox":
            instrucoes1.ReadOnly = true;
            instrucao1.ReadOnly = true;
            instrucao2.ReadOnly = true;

            // Texto:
            instrucoes1.Text = $"Agora me diga a distância horizontal e vertical em metros do alvo:";
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            //Using a "if" for if the person click in "enter" and not have written anything in the designated space, keep in form:
            if (distancia.Text == "" || altura.Text == "")
            {

            }
            else
            {
                LancamentoB2 open3 = new LancamentoB2();
                open3.Property = distancia.Text;
                open3.Property1 = altura.Text;
                this.Hide();
                open3.ShowDialog();
                Close();
            }
        }

        // Tratando as Text Boxs:
        private void distancia_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            excecoes(distancia.Text, e);
        }

        private void altura_KeyPress(object sender, KeyPressEventArgs e)
        {
            excecoes(altura.Text, e);
        }
    }
}
