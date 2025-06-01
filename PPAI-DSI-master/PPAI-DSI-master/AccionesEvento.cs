using PPAI_DSI.Control;
using PPAI_DSI.Entidad;
using PPAI_DSI.Interfaz;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI_DSI
{
    public partial class AccionesEvento : Form
    {
        private PantallaRegResultado pantallaRegResultado;
        private EventoSismico evento;
        private string opcionSeleccionada;
        private GestorRegResultado gestorRegResultado;


        public AccionesEvento(EventoSismico evento, PantallaRegResultado pantallaRegResultado)
        {
            InitializeComponent();
            this.pantallaRegResultado = pantallaRegResultado;  // Guardás el parámetro recibido
            this.gestorRegResultado = new GestorRegResultado(this.pantallaRegResultado);

            this.evento = evento;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string accion = "";
            if (rdConfirmar.Checked)
            {
                accion = "Confirmar";
            }
            else if (rdRechazar.Checked)
            {
                accion = "Rechazar";
            }
            else if (rdDerivar.Checked)
            {
                accion = "Derivar";
            }

            gestorRegResultado.validarExistencias(evento, accion);
           
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
