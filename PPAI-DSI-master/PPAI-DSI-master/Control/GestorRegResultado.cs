using System;
using System.Collections.Generic;
using System.Linq;
using PPAI_DSI.Entidad;
using PPAI_DSI.Interfaz;
using PPAI_DSI.Repositorios;
using System.Windows.Forms;


namespace PPAI_DSI.Control
{
    public class GestorRegResultado
    {
        // Atributos
        private List<EventoSismico> eventosSismicos;
        private List<EventoSismico> eventosPteRevision;
        private EventoSismico eventoSeleccionado;
        private List<Estado> estados;
        private PantallaRegResultado pantallaRegResultado;
        private Sesion sesion;

        private GestorGenerarSismograma gestorGenerarSismograma;

        // Constructor
        public GestorRegResultado(PantallaRegResultado pantalla)
        { 
            pantallaRegResultado = pantalla;
            eventosPteRevision = new List<EventoSismico>();

            // Obtengo mis listas desde los repositorios
            eventosSismicos = RepositorioProvider.Eventos.ObtenerTodos().ToList();
            estados = RepositorioProvider.Estados.ObtenerTodos().ToList();
            sesion = RepositorioProvider.Sesiones.ObtenerSesionActiva();

            // Inicializamos el gestor del CU incluido
            gestorGenerarSismograma = new GestorGenerarSismograma();

        }

        // Inicio del caso de uso
        public void opRegResultadosRevision()
        {
            buscarEventoPteRevision();
        }

        // 1) Obtiene del repositorio, filtra y ordena
        public void buscarEventoPteRevision()
        {
            eventosPteRevision.Clear();

            foreach (var evento in eventosSismicos)
            {
                if (evento.estaPendienteRevision())
                {
                    eventosPteRevision.Add(evento);
                }
            }

            // CASO ALTERNATIVO A1: Si no hay eventos pendientes de revisión
            if (eventosPteRevision.Count == 0)
            {
                MessageBox.Show("No hay sismos auto detectados pendientes de revisión.");
                return; // Termina el caso de uso aquí
            }

            ordenarPorFechaHora();
            pantallaRegResultado.solicitarSelecEventoSismico(eventosPteRevision);
        }

        // 2) Ordena los eventos pendientes de revisión
        public void ordenarPorFechaHora()
        {
            eventosPteRevision = eventosPteRevision.OrderBy(ev => ev.getFechaHoraOcurrencia()).ToList();
        }

        // 3) Procesa la selección del evento
        public void tomarSelecEventoSismico(EventoSismico evento)
        {
            DateTime fechaHoraActual = getFechaHoraActual();
            Empleado usuarioLogueado = buscarUsuarioLogueado();
            Estado estadoBloqueado = buscarEstadoBloqueado();

            eventoSeleccionado = evento;
            eventoSeleccionado.revisar(fechaHoraActual, usuarioLogueado, estadoBloqueado);

            // Luego llamas al CU incluido
            gestorGenerarSismograma.ejecutar();

        }

        public DateTime getFechaHoraActual()
        {
            return DateTime.Now;
        }

        public Empleado buscarUsuarioLogueado()
        {
            return sesion.obtenerUsuarioLogueado()
                         .obtenerEmpleado();
        }

        public Estado buscarEstadoBloqueado()
        {
            foreach (var estado in estados)
            {
                if (estado.sosBloqueado() && estado.esAmbitoES())
                {
                    return estado;
                }
            }
            return null;
        }

        public void validarExistencias(EventoSismico evento, string accion)
        {
            if ((evento.getValorMagnitud().Equals("null") || string.IsNullOrEmpty(evento.getNombreAlcance()) || string.IsNullOrEmpty(evento.getNombreOrigenGeneracion())))
            {
                MessageBox.Show("Faltan datos obligatorios del evento (magnitud, alcance u origen).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Validación: si no se seleccionó nada
            if (string.IsNullOrEmpty(accion))
            {
                MessageBox.Show("Por favor, seleccione una opción (Confirmar, Rechazar o Derivar).",
                                "Advertencia",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // inicia el cambio de estado
            if (accion.Equals("Rechazar"))
            {
                DateTime fechaHoraActual = getFechaHoraActual();
                Empleado usuarioLogueado = buscarUsuarioLogueado();
                Estado estadoRechazado = buscarEstadoRechazado();

                eventoSeleccionado = evento;
                eventoSeleccionado.rechazar(fechaHoraActual, usuarioLogueado, estadoRechazado);

                finCU(); // Finaliza el caso de uso

            }
            else
            {
                MessageBox.Show("Opcion no implementada", "Informacion",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }

        }

        public Estado buscarEstadoRechazado() 
        {
            foreach (var estado in estados)
            {
                if (estado.esRechazado() && estado.esAmbitoES())
                {
                    return estado;
                }

            }

            return null;
        }

        public void finCU()
        {
            MessageBox.Show("El evento sísmico ha sido rechazado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }
    }
}

