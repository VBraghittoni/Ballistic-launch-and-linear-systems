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
    public partial class SistemaL6 : Form
    {
        public string Property { get; set; }
        public string Property2 { get; set; }
        public string Property3 { get; set; }
        public string Property4 { get; set; }

        public SistemaL6()
        {
            InitializeComponent();
        }

        private void SistemaL6_Load(object sender, EventArgs e)
        {
            // Deixando a caixa de texto que irá fornecer todas as informações sem poder ser alterada:
            resultado.ReadOnly = true;

            // Testando quais propertys tem informação:
            if (Property2 == null)
            {
                resultado.Text = $"Com os valores dos coeficientes que você forneceu para mim na equação, é nítido que o valor da corrente será de:" +
                    $"\r\nx1 = {Property};";
            }
            else if (Property3 == null)
            {
                resultado.Text = $"Com os valores dos coeficientes que você forneceu para mim nas 2 equações, é nítido que o valor das corrente será de:" +
                    $"\r\nx1 = {Property};" +
                    $"\r\nx2 = {Property2};";
            }
            else if (Property4 == null)
            {
                resultado.Text = $"Com os valores dos coeficientes que você forneceu para mim nas 3 equações, é nítido que o valor das corrente será de:" +
                    $"\r\nx1 = {Property};" +
                    $"\r\nx2 = {Property2};" +
                    $"\r\nx3 = {Property3};";
            }
            else
            {
                resultado.Text = $"Com os valores dos coeficientes que você forneceu para mim nas 4 equações, é nítido que o valor das corrente será de:" +
                    $"\r\nx1 = {Property};" +
                    $"\r\nx2 = {Property2};" +
                    $"\r\nx3 = {Property3};" +
                    $"\r\nx4 = {Property4};";
            }
        }

        // Um botão para retornar ao Início:
        private void Menu_Click(object sender, EventArgs e)
        {
            // Voltar ao menu:
            Menu open1 = new Menu();
            this.Hide();
            open1.ShowDialog();
            Close();
        }

        // Um botão para sair do aplicativo:
        private void sair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
