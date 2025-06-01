using PPAI_DSI.Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PPAI_DSI.Interfaz
{
    public partial class DatosSismicosSelec : Form
    {
        private EventoSismico evento;
        private PantallaRegResultado pantallaRegResultado;
        DataTable tabla;
        DataTable tablaSeries;

        public DatosSismicosSelec(EventoSismico evento, PantallaRegResultado pantalla)
        {
            InitializeComponent();
            this.evento = evento;
            this.pantallaRegResultado = pantalla;
        }

        private void DatosSismicosSelec_Load(object sender, EventArgs e)
        {
            tabla = new DataTable();

            tabla.Columns.Add("Alcance");
            tabla.Columns.Add("Origen");
            tabla.Columns.Add("Clasificacion");

            dataGridViewDatosGenerales.AutoGenerateColumns = true;
            dataGridViewDatosGenerales.DataSource = tabla;

            MostrarDatosGeneralesEvento();

            tablaSeries = new DataTable();

            tablaSeries.Columns.Add("Estación");
            tablaSeries.Columns.Add("Fecha/Hora Muestra");
            tablaSeries.Columns.Add("Velocidad de Onda (Km/seg)");
            tablaSeries.Columns.Add("Frecuencia de Onda (Hz)");
            tablaSeries.Columns.Add("Longitud de Onda (km/ciclo)");

            dataGridViewDatosGenerales.AutoGenerateColumns = true;
            dataGridViewSeriesTemporales.DataSource = tablaSeries;

            MostrarSeriesTemporales();

            //limpia la seleccion por defecto
            dataGridViewSeriesTemporales.AutoGenerateColumns = true;
            dataGridViewSeriesTemporales.DataSource = tablaSeries;

        }

        private void MostrarDatosGeneralesEvento()
        {
            

            DataRow fila = tabla.NewRow();
            fila["Alcance"] = evento.getNombreAlcance();
            fila["Origen"] = evento.getNombreOrigenGeneracion();
            fila["Clasificacion"] = evento.getNombreClasificacion();
            tabla.Rows.Add(fila);
        }

        private void MostrarSeriesTemporales()
        {
            var series = evento.obtenerDatosSeriesTemporales()
                   .OrderBy(serie => serie.getEstacionSismologica().getCodigoEstacion());

            foreach (var serie in series)
            {

                foreach (var muestra in serie.getMuestras())
                {
                    DataRow fila = tablaSeries.NewRow();
                    fila["Estación"] = serie.getEstacionSismologica().getCodigoEstacion().ToString();
                    fila["Fecha/Hora Muestra"] = muestra.getFechaHora();
                    fila["Velocidad de Onda (Km/seg)"] = muestra.getVelocidadOnda();
                    fila["Frecuencia de Onda (Hz)"] = muestra.getFrecuenciaOnda();
                    fila["Longitud de Onda (km/ciclo)"] = muestra.getLongitudOnda();
                    tablaSeries.Rows.Add(fila);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            pantallaRegResultado.solicitarOpMapa(evento);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("¿Está seguro de que desea cancelar?", "Confirmar cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }

}


