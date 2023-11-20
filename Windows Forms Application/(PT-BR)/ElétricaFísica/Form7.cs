using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ElétricaFísica
{
    public partial class SistemaL2 : Form
    {
        // Criando funções para as text boxs:
        void excecoes(string textBox, KeyPressEventArgs e)
        {
            // Limitações para tratar exceções:
            // Verifica se o caractere inserido não é um dígito ou um ponto decimal:
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',') && (e.KeyChar != '-'))
            {
                e.Handled = true; // Impede a inserção do caractere na caixa de texto
            }

            // Verifica se já existe um ponto decimal na caixa de texto:
            if ((e.KeyChar == ',') && (textBox.IndexOf(',') > -1))
            {
                e.Handled = true; // Impede a inserção de mais de um ponto decimal...
            }

            // Verifica se já existe um sinal negativo na caixa de texto:
            if ((e.KeyChar == '-') && (textBox.IndexOf('-') > -1))
            {
                e.Handled = true; // Impede a inserção de mais de um sinal negativo...
            }

            // Impede esse atalho:
            if (e.KeyChar == (char)22) // 22 é o código ASCII para Ctrl+V
            {
                e.Handled = true; // Ignora a entrada do usuário para Ctrl+V
            }
        }

        // função de verificação dos valores de input
        public bool verifica(string TextBox)
        {
            // se o campo estiver vazio
            if (TextBox.Length == 0)
            {
                MessageBox.Show("Preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            // lista de caracteres válidos
            string valido = "-0123456789";

            for (int i = 0; i < TextBox.Length; i++)
            {
                //se o caracter for inválido
                if (valido.IndexOf(TextBox[i]) == -1)
                {
                    MessageBox.Show("Existe algum caracter inválido em um ou mais campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                // se o sinal de número negativo estiver fora da posição adequada
                if (i > 0 && TextBox[i] == '-')
                {
                    MessageBox.Show("O sinal negativo '-' deve estar no primeiro índice de cada caixa de texto, caso houver.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }

        public SistemaL2()
        {
            InitializeComponent();
        }

        private void SistemaL2_Load(object sender, EventArgs e)
        {
            // Deixando as "instrucoes" sem poderem ser alteradas:
            instrucoes.ReadOnly = true;

            // Mostrando um texto dentro da Text Box com as instruções:
            instrucoes.Text = "Digite na primeira caixa de texto a sua primeira variável e na segunda a resultante:" +
                "\r\n\r\n                                  x1   =";
        }

        // Usando o botão enter do teclado:
        private void Enter_Click(object sender, EventArgs e)
        {
            // Verificando se todas as text boxs estão preenchidas para ir para o próximo formulário:
            if (verifica(variavel1.Text) && verifica(resultado1.Text))
            {
                // Convertendo string para número e já fornecendo dentro do sistema:
                double[,] sistema = new double[1, 2];
                sistema[0, 0] = Convert.ToDouble(variavel1.Text);
                sistema[0, 1] = Convert.ToDouble(resultado1.Text);

                // Cálculo:
                // Resolvendo o sistema de equações usando eliminação de Gauss:
                for (int i = 0; i < 1; i++)
                {
                    double pivo = sistema[i, i];

                    for (int j = i; j < 1 + 1; j++)
                    {
                        sistema[i, j] /= pivo;
                    }

                    for (int k = 0; k < 1; k++)
                    {
                        if (k != i)
                        {
                            double fator = sistema[k, i];
                            for (int j = i; j < 1 + 1; j++)
                            {
                                sistema[k, j] -= fator * sistema[i, j];
                            }
                        }
                    }
                }
                // Convertendo número para string:
                string resposta = sistema[0, 1].ToString();

                // Se tudo estiver correto, avança para o próximo formulário:
                SistemaL6 open8 = new SistemaL6();
                open8.Property = resposta;
                this.Hide();
                open8.ShowDialog();
                Close();
            }
        }

        // Tratando as Text Boxs:
        private void variavel1_KeyPress(object sender, KeyPressEventArgs e)
        {
            excecoes(variavel1.Text,e);
        }

        private void resultado1_KeyPress(object sender, KeyPressEventArgs e)
        {
            excecoes(resultado1.Text, e);
        }
    }
}
