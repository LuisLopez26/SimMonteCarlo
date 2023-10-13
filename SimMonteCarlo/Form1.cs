using SimMonteCarlo.Algoritmos;
using SimMonteCarlo.Modelos;

namespace SimMonteCarlo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int paneles = Convert.ToInt32(textBox1.Text);
            int experimentos = Convert.ToInt32(textBox2.Text);
            int limInf = Convert.ToInt32(textBox3.Text);
            int limSup = Convert.ToInt32(textBox4.Text);

            if (limSup <= limInf)
            {
                MessageBox.Show("El limite inferior tiene que ser menor que el límite superior");
                return;
            }

            AlgoritmoGenerador algoritmo = new AlgoritmoGenerador();
            List<Experimentos> listaExperimentos = algoritmo.AlgoritmoMonteCarlo(paneles, experimentos, limInf, limSup);
            double promedio = algoritmo.CalcularPromedioTiempoDeVida(listaExperimentos);

            dataGridView1_CellContentClick(listaExperimentos, paneles, promedio);

        }

        public void dataGridView1_CellContentClick(List<Experimentos> lista, int paneles, double promedio)
        {
            dataGridView1.Columns.Clear();
            string numeroColumna1 = "1";
            dataGridView1.Columns.Add(numeroColumna1, "Exp. #");

            for (int columna = 2; columna < paneles + 2; columna++)
            {
                string columnaString = columna.ToString();
                string numPanel = (columna - 1).ToString();

                dataGridView1.Columns.Add(columnaString, "Panel " + numPanel);
        
            }

            string columnaFinal = (paneles + 2).ToString();
            dataGridView1.Columns.Add(columnaFinal, "Satelite");

            for (int i = 0; i < lista.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = (lista[i].Posicion + 1).ToString();

                for (int j = 1; j < paneles + 1; j++)
                {

                    dataGridView1.Rows[i].Cells[j].Value = lista[i].ListaAleatorios[j - 1].ToString();
                    
                }

                dataGridView1.Rows[i].Cells[paneles + 1].Value = lista[i].SegundoMayor.ToString();

            }

            dataGridView1.Rows.Add();
            dataGridView1.Rows[lista.Count].Cells[0].Value = "Promedio";
            dataGridView1.Rows[lista.Count].Cells[paneles + 1].Value = promedio.ToString();


        }
    }
}