using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElétricaFísica
{
    public partial class SistemaL4 : Form
    {
        // Criando uma função para as text boxs:
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

        public SistemaL4()
        {
            InitializeComponent();
        }

        private void SistemaL4_Load(object sender, EventArgs e)
        {
            // Deixando as "instrucoes" sem poderem ser alteradas:
            instrucoes.ReadOnly = true;

            // Mostrando um texto dentro da Text Box com as instruções:
            instrucoes.Text = "Digite nas três colunas de caixa de texto da esquerda todas as variáveis e na única coluna da direita somente os resultados:" +
                "\r\n\r\n\r\n                              x1  +                          x2  +                           x3   =" +
                "\r\n\r\n                              x1  +                          x2  +                           x3   =" +
                "\r\n\r\n                              x1  +                          x2  +                           x3   =";
        }

        // Usando o botão enter do teclado:
        private void Enter_Click(object sender, EventArgs e)
        {
            // Verificando se todas as text boxs estão preenchidas para ir para o próximo formulário:
            if (verifica(variavel1.Text) && verifica(variavel2.Text) && verifica(variavel3.Text) && verifica(variavel4.Text) && verifica(variavel5.Text) &&
                verifica(variavel6.Text) && verifica(variavel7.Text) && verifica(variavel8.Text) && verifica(variavel9.Text) && verifica(resultado1.Text) &&
                verifica(resultado2.Text) && verifica(resultado3.Text))
            {
                // Convertendo string para número e já fornecendo dentro do sistema:
                double[,] sistema = new double[3, 4];
                sistema[0, 0] = Convert.ToDouble(variavel1.Text);
                sistema[0, 1] = Convert.ToDouble(variavel2.Text);
                sistema[0, 2] = Convert.ToDouble(variavel3.Text);
                sistema[0, 3] = Convert.ToDouble(resultado1.Text);
                sistema[1, 0] = Convert.ToDouble(variavel4.Text);
                sistema[1, 1] = Convert.ToDouble(variavel5.Text);
                sistema[1, 2] = Convert.ToDouble(variavel6.Text);
                sistema[1, 3] = Convert.ToDouble(resultado2.Text);
                sistema[2, 0] = Convert.ToDouble(variavel7.Text);
                sistema[2, 1] = Convert.ToDouble(variavel8.Text);
                sistema[2, 2] = Convert.ToDouble(variavel9.Text);
                sistema[2, 3] = Convert.ToDouble(resultado3.Text);

                // Cálculo:
                // Resolvendo o sistema de equações usando eliminação de Gauss:
                for (int i = 0; i < 3; i++)
                {
                    double pivo = sistema[i, i];

                    for (int j = i; j < 3 + 1; j++)
                    {
                        sistema[i, j] /= pivo;
                    }

                    for (int k = 0; k < 3; k++)
                    {
                        if (k != i)
                        {
                            double fator = sistema[k, i];
                            for (int j = i; j < 3 + 1; j++)
                            {
                                sistema[k, j] -= fator * sistema[i, j];
                            }
                        }
                    }
                }
                // Convertendo números para strings:
                string resposta = sistema[0, 3].ToString();
                string resposta2 = sistema[1, 3].ToString();
                string resposta3 = sistema[2, 3].ToString();

                // Se tudo estiver correto, avança para o próximo formulário
                SistemaL6 open8 = new SistemaL6();
                open8.Property = resposta;
                open8.Property2 = resposta2;
                open8.Property3 = resposta3;
                this.Hide();
                open8.ShowDialog();
                Close();
            }
        }

        // Tratando as Text Boxs:
        private void variavel1_KeyPress(object sender, KeyPressEventArgs e)
        {
            excecoes(variavel1.Text, e);
        }

        private void variavel2_KeyPress(object sender, KeyPressEventArgs e)
        {
            excecoes(variavel2.Text, e);
        }

        private void variavel3_KeyPress(object sender, KeyPressEventArgs e)
        {
            excecoes(variavel3.Text, e);
        }

        private void variavel4_KeyPress(object sender, KeyPressEventArgs e)
        {
            excecoes(variavel4.Text, e);
        }

        private void variavel5_KeyPress(object sender, KeyPressEventArgs e)
        {
            excecoes(variavel5.Text, e);
        }

        private void variavel6_KeyPress(object sender, KeyPressEventArgs e)
        {
            excecoes(variavel6.Text, e);
        }

        private void variavel7_KeyPress(object sender, KeyPressEventArgs e)
        {
            excecoes(variavel7.Text, e);
        }

        private void variavel8_KeyPress(object sender, KeyPressEventArgs e)
        {
            excecoes(variavel8.Text, e);
        }

        private void variavel9_KeyPress(object sender, KeyPressEventArgs e)
        {
            excecoes(variavel9.Text, e);
        }

        private void resultado1_KeyPress(object sender, KeyPressEventArgs e)
        {
            excecoes(resultado1.Text, e);
        }

        private void resultado2_KeyPress(object sender, KeyPressEventArgs e)
        {
            excecoes(resultado2.Text, e);
        }

        private void resultado3_KeyPress(object sender, KeyPressEventArgs e)
        {
            excecoes(resultado3.Text, e);
        }
    }
}
