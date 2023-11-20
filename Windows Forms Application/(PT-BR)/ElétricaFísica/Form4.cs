using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ElétricaFísica
{
    public partial class LancamentoB3 : Form
    {
        //Criando quatro "Propriedades" para transitar as informações entre os forms...
        public string Property { get; set; }
        public string Property1 { get; set; }
        public string Property2 { get; set; }
        public string Property3 { get; set; }

        // Variáveis:
        Chart chart1 = new Chart();
        Series series = new Series();
        Timer timer = new Timer();
        double x = 0; // Valor inicial de x
        double radiano; // Variável para armazenar o valor de radiano
        double g = 9.8; // Aceleração da gravidade (constante)
        double v0; // Velocidade inicial (será calculada)

        public LancamentoB3()
        {
            InitializeComponent();
            InitializeChart();
            InitializeTimer();
        }

        private void explicacao_TextChanged(object sender, EventArgs e)
        {
            // Deixando o texto no topo do forms:
            explicacao.Dock = DockStyle.Top;
        }

        private void LancamentoB3_Load(object sender, EventArgs e)
        {
            // Condição para determinar se usar radianos ou graus:
            if (Property2 != null)
            {
                double.TryParse(Property2, out radiano);
            }
            else
            {
                double.TryParse(Property3, out double angulo);
                radiano = (angulo * Math.PI) / 180;
            }

            // Cálculos relacionados à equação:
            double.TryParse(Property, out double d);
            double.TryParse(Property1, out double h);
            double t = Math.Sqrt(((d * Math.Sin(radiano) / Math.Cos(radiano)) - h) / (g / 2));
            v0 = d / (Math.Cos(radiano) * t);

            // Deixando essa text box com a explicação do que irá acontecer sem poder ser alterado:
            explicacao.ReadOnly = true;
            if ((v0 * Math.Sin(radiano) - g * t) > 0)
            {
                explicacao.Text = $"A velocidade inicial necessária é {v0:F2} m/s, dessa forma o projétil estará subindo quando acertar o alvo.\r\nJá a sua duração de tempo para acontecer é de {t:F1} segundos." +
                    $"\r\nA equação que ilustra esse movimento: y = x * ({(Math.Sin(radiano) / Math.Cos(radiano))}) + x² * ({(-g / (2 * v0 * v0 * Math.Cos(radiano) * Math.Cos(radiano)))})";
            }
            if ((v0 * Math.Sin(radiano) - g * t) == 0)
            {
                explicacao.Text = $"A velocidade inicial necessária é {v0:F2} m/s, dessa forma o projétil estará em pico quando acertar o alvo.\r\nJá a sua duração de tempo para acontecer é de {t:F1} segundos." +
                    $"\r\nA equação que ilustra esse movimento: y = x * ({(Math.Sin(radiano) / Math.Cos(radiano))}) + x² * ({(-g / (2 * v0 * v0 * Math.Cos(radiano) * Math.Cos(radiano)))})";
            }
            if ((v0 * Math.Sin(radiano) - g * t) < 0)
            {
                explicacao.Text = $"A velocidade inicial necessária é {v0:F2} m/s, dessa forma o projétil estará caindo quando acertar o alvo.\r\nJá a sua duração de tempo para acontecer é de {t:F1} segundos." +
                    $"\r\nA equação que ilustra esse movimento: y = x * ({(Math.Sin(radiano) / Math.Cos(radiano))}) + x² * ({(-g / (2 * v0 * v0 * Math.Cos(radiano) * Math.Cos(radiano)))})";
            }
        }

        private void InitializeChart()
        {
            // Adiciona um gráfico ao formulário:
            chart1.Parent = this;
            chart1.Dock = DockStyle.Fill;

            ChartArea chartArea = new ChartArea();
            chart1.ChartAreas.Add(chartArea);

            // Adiciona uma série para representar os pontos:
            series.ChartType = SeriesChartType.Point;
            chart1.Series.Add(series);
        }

        private void InitializeTimer()
        {
            timer.Interval = 1; // Intervalo em milissegundos entre cada ponto no gráfico...
            timer.Tick += Timer_Tick;
            timer.Start(); // Inicia o temporizador...
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Buscando os dados do ponto:
            double.TryParse(Property, out double d);
            double.TryParse(Property1, out double h);

            // Cálculo da equação:
            double y = (x * (Math.Sin(radiano) / Math.Cos(radiano))) + ((x * x) * (-g / (2 * v0 * v0 * Math.Cos(radiano) * Math.Cos(radiano))));

            if (y >= 0)
            {
                series.Points.AddXY(x, y);
                chart1.ChartAreas[0].AxisX.ScaleView.Scroll(ScrollType.Last); // Rola o gráfico para mostrar o último ponto adicionado...
                x += 1; // Incremento de x, o qual pode ser alterado para cada vez menor, assim a parábola é criada com mais facilidade, porém com menos qualidade...
            }
            else
            {
                timer.Stop(); // Para o temporizador quando a função não é mais válida...


                // Mostrando o ponto no gráfico:
                // Adicionando uma linha vertical para um valor específico de x:
                StripLine stripLineX = new StripLine();
                stripLineX.IntervalOffset = d; // Valor de x onde a linha vertical será posicionada
                stripLineX.BorderColor = Color.Red; // Cor da linha
                stripLineX.BorderWidth = 2; // Largura da linha
                chart1.ChartAreas[0].AxisX.StripLines.Add(stripLineX);

                // Adicionando uma linha horizontal para um valor específico de y:
                StripLine stripLineY = new StripLine();
                stripLineY.IntervalOffset = h; // Valor de y onde a linha horizontal será posicionada
                stripLineY.BorderColor = Color.Red;
                stripLineY.BorderWidth = 2;
                chart1.ChartAreas[0].AxisY.StripLines.Add(stripLineY);
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