using Newtonsoft.Json;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinTesteTarget_Sistemas
{
    public partial class Form1 : Form
    {
        private object valor;

        class ValoresDiaMes
        {
            public int dia { get; set; }
            public double valor { get; set; }
        }

        class faturamento
        {
            public string uf { get; set; }
            public double valor { get; set; }
        }



        public Form1()
        {
            InitializeComponent();
        }

        private void Questao1_Click(object sender, EventArgs e)
        {
            int INDICE = 13;
            int SOMA = 0;
            int K = 0;

            while (K < INDICE)
            {
                K++;
                SOMA = SOMA + K;
            }

            textQuestao1.Text = SOMA.ToString();

        }

        public static int FibonacciIterativo(int n)
        {
            if (n <= 1)
            {
                return n;
            }

            int a = 0;
            int b = 1;

            for (int i = 2; i <= n; i++)
            {
                int temp = a + b;
                a = b;
                b = temp;
            }

            return b;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Questao2_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(entradaNumeroFB.Value);

            textResultadoFB.Text = string.Empty;
            bool pertenceFB = false;
            int numeroFB = 0;

            for (int i = 0; i < numero; i++)
            {
                numeroFB = FibonacciIterativo(i);
                if (numero == numeroFB)
                    pertenceFB = true;

                textResultadoFB.Text += numeroFB.ToString() + ",";
            }

            if (pertenceFB)
                MessageBox.Show("Pertence a pertence a sequ�ncia Fibonacci");
            else
                MessageBox.Show("N�o pertence a pertence a sequ�ncia Fibonacci");
        }


        public static int fibRetorno(int n)
        {
            if (n <= 1)
            {
                return n;
            }

            int a = 0;
            int b = 1;

            for (int i = 2; i <= n; i++)
            {
                int temp = a + b;
                a = b;
                b = temp;
            }

            return b;
        }


        private List<ValoresDiaMes> popularMes()
        {
            List<ValoresDiaMes> items = new List<ValoresDiaMes>();

            using (StreamReader r = new StreamReader("C:\\tmp\\dados.json"))
            {
                var json = r.ReadToEnd();
                items = JsonConvert.DeserializeObject<List<ValoresDiaMes>>(json);
            }

            return items;

        }

        private void Questao3_Click(object sender, EventArgs e)
        {
            List<ValoresDiaMes> lista = popularMes();

            var maiorfaturamento = lista.MaxBy(c => c.valor).valor;
            var menorfaturamento = lista.MinBy(c => c.valor).valor; ;
            double mediafaturamento = lista.Sum(c => c.valor) / lista.Count();
            var qtdeDiaSuperiorMedaia = lista.Count(c => c.valor > mediafaturamento);

            txtMaiorFaturamento.Text = maiorfaturamento.ToString();
            txtMenorFaturamento.Text = menorfaturamento.ToString();
            txtQtdeMaiorMediaDia.Text = qtdeDiaSuperiorMedaia.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<faturamento> lista = new List<faturamento>()
            {
                new faturamento { uf = "SP", valor = 67836.43 },
                new faturamento { uf = "RJ", valor = 36678.66 },
                new faturamento { uf = "MG", valor = 29229.88 },
                new faturamento { uf = "ES", valor = 27165.48 },
                new faturamento { uf = "Outros", valor = 19849.53 }
            };

            var vrTotal = lista.Sum(c => c.valor);
            var percentualMG = lista.Select(c => new { uf = c.uf, percentual = (c.valor / vrTotal) * 100 }).ToList();

            foreach (var item in percentualMG)
            {
                textRetornoQ1.Text += "UF: " + item.uf + " , Percentual: " + item.percentual.ToString("0.00") + "%" + Environment.NewLine;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtString2.Text = string.Empty;


            char[] cArray = txtString1.Text.ToCharArray();
            string reverse = string.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            txtString2.Text = reverse;

        }
    }
}
