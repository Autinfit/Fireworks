namespace FuegosArtificiales
{
    public partial class Form1 : Form
    {
        List<string> ubicacion_imagen = new List<string>(); // VARIABLE PARA AGREGAR UNA IMAGEN Y UBICARLO EN CUALQUIER LUGAR.
        List<FuegoArtificialDefault> listado_fireworks = new List<FuegoArtificialDefault>(); // ANTES DE ESO, HAY QUE CREAR PRIMERO UNA NUEVA CLASE QUE PERMITA ASOCIAR A ESTA LISTA.
        int numeroFondosDePantalla; // CADA FONDO DE PANTALLA TIENE UN N�MERO DISTINTO.

        public Form1()
        {
            InitializeComponent();
        }

        // ANTES DE CONTINUAR CON ESTE PROCESO, REALIZAREMOS VARIAS CONFIGURACIONES MEDIANTE ESTE M�TODO.

        private void Configuracion()
        {
            // EN INSTANTES...
        }

        private void SoltarTecla(object sender, KeyEventArgs e)
        {
            // ESTE ES EL EVENTO CUANDO SUELTA UNA TECLA DEL TECLADO.

            // EN INSTANTES...
        }

        private void PresionarBotonMouse(object sender, MouseEventArgs e)
        {
            // ESTE ES EL EVENTO CUANDO PRESIONA UN BOT�N DEL MOUSE.

            // EN INSTANTES...
        }

        private void FormularioDise�o(object sender, PaintEventArgs e)
        {
            // ESTE ES EL EVENTO PARA DISE�AR LA INTERFAZ GR�FICA DEL FORMULARIO.

            // EN INSTANTES...
        }

        private void EventoAnimaciones(object sender, EventArgs e)
        {
            // MEDIANTE UN TEMPORIZADOR SER� ESTE EVENTO PARA ANIMAR CON FUEGOS ARTIFICIALES EN FORMATO .GIF PARA LA INTERFAZ DEL FORMULARIO.

            // EN INSTANTES...
        }
    }
}