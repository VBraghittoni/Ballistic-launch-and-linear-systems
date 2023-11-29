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
    public partial class LancamentoB2 : Form
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
        public LancamentoB2()
        {
            InitializeComponent();
        }
        //Criando duas "Propriedades" para transitar as informações entre os forms...
        public string Property { get; set; }
        public string Property1 { get; set; }

        private void LancamentoB2_Load(object sender, EventArgs e)
        {
            // Fazendo com que não possa alterar as instruções:
            instrucao1.ReadOnly = true;
            instrucao2.ReadOnly = true;
            instrucoes2.ReadOnly = true;
            
            // Supondo que Property e Property1 sejam strings que representam números
            if (double.TryParse(Property, out double x) && double.TryParse(Property1, out double y))
            {
                double minRadianos = Math.Atan(y / x);
                double minGraus = (minRadianos * 180) / Math.PI;
                instrucoes2.Text = $"Baseando-se nas distâncias passadas, sabemos que o valor do ângulo deve ser menor que 90° e maior que {minGraus}°.\r\nJá o radiano deve ser menor que PI/2 e maior que {minRadianos}.\r\n" +
                    $"Escreva o angulo de lançamento.";
            }
        }

        // Recebendo a informação em graus:
        private void angulo_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(radiano.Text))
            {
                // Se o TextBox1 foi preenchido, limpa o TextBox2!
                angulo.Text = string.Empty;
            }
        }

        // Recebendo a informação em radiano:
        private void radiano_TextChanged_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(angulo.Text))
            {
                // Se o TextBox1 foi preenchido, limpa o TextBox2!
                radiano.Text = string.Empty;
            }
        }

        // Botão para ver a parábola sendo criada com a animação:
        private void Canimacao_Click(object sender, EventArgs e)
        {
            double.TryParse(Property, out double x);
            double.TryParse(Property1, out double y);
            double minRadianos = Math.Atan(y / x);
            double minGraus = (minRadianos * 180) / Math.PI;

            if (radiano.Text != "")
            {
                double.TryParse(radiano.Text, out double valor);
                //Using a "if" for if the person click in "enter" and not have written anything in the designated space, keep in form:
                if (radiano.Text == "" && angulo.Text == "")
                {

                }
                else if (valor < (Math.PI/2) && valor > minRadianos)
                {
                    LancamentoB3 open4 = new LancamentoB3();
                    open4.Property = Property;
                    open4.Property1 = Property1;
                    open4.Property2 = radiano.Text;
                    this.Hide();
                    open4.ShowDialog();
                    Close();
                }
            }
            else
            {
                double.TryParse(angulo.Text, out double valor);
                //Using a "if" for if the person click in "enter" and not have written anything in the designated space, keep in form:
                if (radiano.Text == "" && angulo.Text == "")
                {

                }
                else if (valor < 90 && valor > minGraus)
                {
                    LancamentoB3 open4 = new LancamentoB3();
                    open4.Property = Property;
                    open4.Property1 = Property1;
                    open4.Property3 = angulo.Text;
                    this.Hide();
                    open4.ShowDialog();
                    Close();
                }
            }
        }

        // Botão para ver a parábola sendo criada sem a animação:
        private void Sanimacao_Click(object sender, EventArgs e)
        {
            double.TryParse(Property, out double x);
            double.TryParse(Property1, out double y);
            double minRadianos = Math.Atan(y / x);
            double minGraus = (minRadianos * 180) / Math.PI;

            if (radiano.Text != "")
            {
                double.TryParse(radiano.Text, out double valor);
                //Using a "if" for if the person click in "enter" and not have written anything in the designated space, keep in form:
                if (radiano.Text == "" && angulo.Text == "")
                {

                }
                else if (valor < (Math.PI / 2) && valor > minRadianos)
                {
                    LancamentoB4 open5 = new LancamentoB4();
                    open5.Property = Property;
                    open5.Property1 = Property1;
                    open5.Property2 = radiano.Text;
                    this.Hide();
                    open5.ShowDialog();
                    Close();
                }
            }
            else
            {
                double.TryParse(angulo.Text, out double valor);
                //Using a "if" for if the person click in "enter" and not have written anything in the designated space, keep in form:
                if (radiano.Text == "" && angulo.Text == "")
                {

                }
                else if (valor < 90 && valor > minGraus)
                {
                    LancamentoB4 open5 = new LancamentoB4();
                    open5.Property = Property;
                    open5.Property1 = Property1;
                    open5.Property3 = angulo.Text;
                    this.Hide();
                    open5.ShowDialog();
                    Close();
                }
            }

        // Tratando as Text Boxs:
        }
        private void angulo_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            excecoes(angulo.Text, e);
        }

        private void radiano_KeyPress(object sender, KeyPressEventArgs e)
        {
            excecoes(angulo.Text, e);
        }
    }
}
