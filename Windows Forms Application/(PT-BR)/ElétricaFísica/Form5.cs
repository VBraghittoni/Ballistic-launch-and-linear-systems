using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ElétricaFísica
{
    public partial class LancamentoB4 : Form
    {
        //Criando quatro "Propriedades" para transitar as informações entre os forms...
        public string Property { get; set; }
        public string Property1 { get; set; }
        public string Property2 { get; set; }
        public string Property3 { get; set; }

        public LancamentoB4()
        {
            InitializeComponent();
        }

        private void explicacao_TextChanged(object sender, EventArgs e)
        {
            // Deixando o texto no topo do forms:
            explicacao.Dock = DockStyle.Top;
        }

        private void LancamentoB4_Load(object sender, EventArgs e)
        {
            // Descobrindo se vai utilizar angulo ou radiano:
            double radiano = 0;
            if (Property2 != null)
            {
                double.TryParse(Property2, out radiano);
            }
            else
            {
                double.TryParse(Property3, out double angulo);
                radiano = (angulo * Math.PI) / 180;
            }

            // Adicione pontos à série representando a equação de segundo grau (parábola) e variáveis:
            double.TryParse(Property, out double d);
            double.TryParse(Property1, out double h);
            double minRadianos = Math.Atan(h / d);
            double minGraus = (minRadianos * 180) / Math.PI;
            double g = 9.8;
            double t = Math.Sqrt(((d * Math.Sin(radiano) / Math.Cos(radiano)) - h) / (g / 2));
            double v0 = d / (Math.Cos(radiano) * t);
            double v0y = v0 * Math.Sin(radiano);

            // Adiciona um gráfico ao formulário:
            Chart chart1 = new Chart();
            chart1.Parent = this;
            chart1.Dock = DockStyle.Fill;

            // Adiciona uma área de gráfico:
            ChartArea chartArea = new ChartArea();
            chart1.ChartAreas.Add(chartArea);

            // Adiciona uma série para representar a equação de segundo grau:
            Series series = new Series();
            series.ChartType = SeriesChartType.Spline; // Use um gráfico de linha

            // Um laço de repetição para criar um gráfico com a função:
            double x = 0;
            while (true)
            {
                double y = (x * (Math.Sin(radiano) / Math.Cos(radiano))) + ((x * x) * (-g / (2 * v0 * v0 * Math.Cos(radiano) * Math.Cos(radiano))));
                if (y >= 0) // Apenas desenha pontos onde y não é negativo...
                {
                    series.Points.AddXY(x, y);
                }
                else
                {
                    break;
                }
                x += 1; // Incremento de x, o qual pode ser alterado para cada vez menor, assim a parábola é criada com mais facilidade, porém com menos qualidade...
            }

            // Adicione a série ao gráfico:
            chart1.Series.Add(series);


            // Mostrando o ponto no gráfico:
            // Adicionando uma linha vertical para um valor específico de x:
            StripLine stripLineX = new StripLine();
            stripLineX.IntervalOffset = d; // Valor de x onde a linha vertical será posicionada
            stripLineX.BorderColor = Color.Red; // Cor da linha
            stripLineX.BorderWidth = 2; // Largura da linha
            chartArea.AxisX.StripLines.Add(stripLineX);

            // Adicionando uma linha horizontal para um valor específico de y:
            StripLine stripLineY = new StripLine();
            stripLineY.IntervalOffset = h; // Valor de y onde a linha horizontal será posicionada
            stripLineY.BorderColor = Color.Red;
            stripLineY.BorderWidth = 2;
            chartArea.AxisY.StripLines.Add(stripLineY);

            // Deixando essa text box com a explicação do que irá acontecer sem poder ser alterado:
            explicacao.ReadOnly = true;
            if ((v0y - g * t) > 0)
            {
                explicacao.Text = $"A velocidade inicial necessária é {v0:F2}m/s, dessa forma o projétil estará subindo quando acertar o alvo.\r\nJá a sua duração de tempo para acontecer é de {t:F1} segundos." +
                    $"\r\nA equação que ilustra esse movimento: y = x * ({(Math.Sin(radiano) / Math.Cos(radiano))}) + x² * ({(-g / (2 * v0 * v0 * Math.Cos(radiano) * Math.Cos(radiano)))})";
            }
            if ((v0y - g * t) == 0)
            {
                explicacao.Text = $"A velocidade inicial necessária é {v0:F2}m/s, dessa forma o projétil estará em pico quando acertar o alvo.\r\nJá a sua duração de tempo para acontecer é de {t:F1} segundos." +
                    $"\r\nA equação que ilustra esse movimento: y = x * ({(Math.Sin(radiano) / Math.Cos(radiano))}) + x² * ({(-g / (2 * v0 * v0 * Math.Cos(radiano) * Math.Cos(radiano)))})";
            }
            if ((v0y - g * t) < 0)
            {
                explicacao.Text = $"A velocidade inicial necessária é {v0:F2}m/s, dessa forma o projétil estará caindo quando acertar o alvo.\r\nJá a sua duração de tempo para acontecer é de {t:F1} segundos." +
                    $"\r\nA equação que ilustra esse movimento: y = x * ({(Math.Sin(radiano) / Math.Cos(radiano))}) + x² * ({(-g / (2 * v0 * v0 * Math.Cos(radiano) * Math.Cos(radiano)))})";
            }
        }

        // Um botão para retornar ao Início:
        private void Menu_Click(object sender, EventArgs e)
        {
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