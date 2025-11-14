using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;

namespace prySP4
{
    internal class clsConexionBD
    {
        private string cadenaConexion = "Data Source=SANTIAGO\\SQLEXPRESS; Initial Catalog=ControlCamionesDB; Integrated Security=True;";

        SqlConnection conexion;
        SqlCommand comando;
        SqlDataReader lector;

        private void CargarChart(Chart chart, string consulta, string ejeY, int maxY, int intervalo, ProgressBar pb, SeriesChartType tipoGrafico)
        {
            try
            {
                chart.Series.Clear();
                Series serie = new Series("Camiones");
                serie.ChartType = tipoGrafico;
                serie.Color = System.Drawing.Color.Teal;
                serie.IsValueShownAsLabel = true;
                chart.Series.Add(serie);

                chart.ChartAreas[0].AxisX.Title = "Camiones";
                chart.ChartAreas[0].AxisY.Title = ejeY;
                chart.ChartAreas[0].AxisY.Maximum = maxY;
                chart.ChartAreas[0].AxisY.Interval = intervalo;

                //inicio la conexión con SQL Server
                conexion = new SqlConnection(cadenaConexion);
                conexion.Open();

                //inicio el comando con SQL Server
                comando = new SqlCommand(consulta, conexion);

                //cuento el total de filas (para la barra de progreso)
                int total = 0;

                //uso SqlDataReader temporal
                using (SqlDataReader tempLector = comando.ExecuteReader())
                {
                    while (tempLector.Read()) total++;
                }

                //vuelvo a ejecutar
                lector = comando.ExecuteReader();

                int contador = 0;
                pb.Visible = true;
                pb.Value = 0;

                while (lector.Read())
                {
                    string camion = lector["Camión"].ToString();
                    double valor = Convert.ToDouble(lector["Total"]);

                    int index = chart.Series[0].Points.AddY(valor);
                    chart.Series[0].Points[index].AxisLabel = camion;

                    contador++;
                    pb.Value = (contador * 100) / total;
                    Application.DoEvents();
                }

                lector.Close();
                conexion.Close();
                pb.Value = 100;

                chart.ChartAreas[0].AxisX.Interval = 1;
                chart.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
                chart.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                chart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                chart.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
                pb.Value = 0;
            }
        }

        public void CargarKilometros(Chart chart, ProgressBar pb, SeriesChartType tipoGrafico)
        {
            string consulta = "SELECT Camión, Kilómetros AS Total FROM Camiones";
            CargarChart(chart, consulta, "Kilómetros", 6000, 500, pb, tipoGrafico);
        }

        public void CargarGastos(Chart chart, ProgressBar pb, SeriesChartType tipoGrafico)
        {
            //las columnas Litros y Precio fueron definidas como DECIMAL en SQL Server, 
            
            string consulta = "SELECT Camión, (Litros * Precio) AS Total FROM Camiones";
            CargarChart(chart, consulta, "Gasto en Combustible ($)", 500000, 50000, pb, tipoGrafico);
        }

        public void CargarKilogramos(Chart chart, ProgressBar pb, SeriesChartType tipoGrafico)
        {
            string consulta = "SELECT Camión, kg AS Total FROM Camiones";
            CargarChart(chart, consulta, "Kilogramos", 80000, 5000, pb, tipoGrafico);
        }

        public void CargarViaticos(Chart chart, ProgressBar pb, SeriesChartType tipoGrafico)
        {
            //suma el gasto de combustible con la columna Viáticos.
            string consulta = "SELECT Camión, ((Litros * Precio) + Viáticos) AS Total FROM Camiones";
            CargarChart(chart, consulta, "Gastos Totales ($)", 500000, 50000, pb, tipoGrafico);
        }
    }
}




    

