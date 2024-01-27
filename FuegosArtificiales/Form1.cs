using System.Drawing.Text;

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

            // LA CANTIDAD DE IM�GENES DE FONDO DE PANTALLA DE LA INTERFAZ SE IR� INCREMENTANDO SI SE CUMPLE CON ESTA CONDICI�N...

            if (numeroFondosDePantalla < ubicacion_imagen.Count -1)
            {
                numeroFondosDePantalla++;
            }
            else // EN CASO CONTRARIO...
            {
                numeroFondosDePantalla = 0; // EL N�MERO DE LOS FONDOS DE PANTALLA ESTAR�N SIENDO CONTABILIZADAS EN 0.
            }

            this.BackgroundImage = Image.FromFile(ubicacion_imagen[numeroFondosDePantalla]); // DENTRO DE ESTE ARCHIVO, ELIGIREMOS LA UBICACI�N DE LA IMAGEN SEG�N LA CANTIDAD DE FONDOS DE PANTALLA QUE HAYA.
        }

        private void PresionarBotonMouse(object sender, MouseEventArgs e)
        {
            // ESTE ES EL EVENTO CUANDO PRESIONA UN BOT�N DEL MOUSE.

            // DECLARAREMOS LAS SIGUIENTES VARIABLES:

            Point posicionMouse = new Point(); // PUNTO EN DONDE SE POSICIONA EL MOUSE A PRESIONAR EL BOT�N.
            posicionMouse.X = e.X; // PUNTO EN LA POSICI�N X DEL MOUSE.
            posicionMouse.Y = e.Y; // PUNTO EN LA POSICI�N Y DEL MOUSE.

            FuegoArtificialDefault nuevaPirotecnia = new FuegoArtificialDefault(); // CREAREMOS UNA NUEVA PIROTECNIA POR DEFECTO.
            nuevaPirotecnia.posicion.X = posicionMouse.X - (nuevaPirotecnia.ancho / 2); // SE CREA UNA NUEVA PIROTECNIA EN LA POSICI�N X DEL MOUSE.
            nuevaPirotecnia.posicion.Y = posicionMouse.Y - (nuevaPirotecnia.altura / 2); // SE CREA UNA NUEVA PIROTECNIA EN LA POSICI�N Y DEL MOUSE.
            listado_fireworks.Add(nuevaPirotecnia); // UNA NUEVA PIROTECNIA SE AGREGA MEDIANTE UN LISTADO DE FUEGOS ARTIFICIALES.
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