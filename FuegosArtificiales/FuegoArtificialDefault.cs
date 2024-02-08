using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuegosArtificiales
{
    internal class FuegoArtificialDefault
    {
        // ATENCIÓN!!! ESTE ES UNA CLASE POR DEFECTO.

        // ANTES DE COMENZAR, ES IMPORTANTE TENER EN CUENTA LAS VARIABLES A DECLARAR A CONTINUACIÓN...

        public int altura; // ALTURA DE UN FUEGO ARTIFICIAL.
        public int ancho; // ANCHO DE UN FUEGO ARTIFICIAL.
        public int patron; // PATRÓN DE UN FUEGO ARTIFICIAL.
        public int patron_actual = 0; // CANTIDAD ACTUAL DE PATRONES DE CADA FUEGO ARTIFICIAL.
        public Point posicion = new Point(); // POSICIÓN DE CUALQUIER FUEGO ARTIFICIAL MEDIANTE UN PUNTO DE COORDENADAS DE LA INTERFAZ GRÁFICA DEL PROYECTO.
        public List<string> ubicacion_imagen = new List<string>(); // LA UBICACIÓN DE CADA IMAGEN SE INICIALIZARÁ MEDIANTE UNA LISTA DE FUEGOS ARTIFICIALES UBICADOS EN CADA PUNTO ASOCIADO DENTRO DE LA INTERFAZ GRÁFICA.
        public bool animacionCompletada = false; // EN ESTOS MOMENTOS, NO SE MOSTRARÁN TODAS LAS ANIMACIONES DE CADA FUEGO ARTIFICAL DE LA INTERFAZ.
        public Image pirotecnia; // IMÁGENES DE CADA FUEGO ARTIFICIAL.

        // AHORA PROCEDEREMOS A CREAR UN CONSTRUCTOR PARA ESTA CLASE POR DEFECTO.

        public FuegoArtificialDefault()
        {
            ubicacion_imagen = Directory.GetFiles("images", "*.png").ToList(); // MEDIANTE UN EXPLORADOR DE SOLUCIONES, SE SELECCIONA UNA UBICACIÓN RESPECTIVA PARA CADA FUEGO ARTIFICIAL EXISTENTE DENTRO DEL DIRECTORIO CORRESPONDIENTE.
            altura = 200; // LA ALTURA PARA CADA FUEGO ARTIFICIAL ES DE 200 METROS.
            ancho = 200; // EL ANCHO PARA CADA FUEGO ARTIFICIAL TAMBIÉN ES DE 200 METROS.
            pirotecnia = Image.FromFile(ubicacion_imagen[0]); // LA SIGUIENTE VARIABLE SE GENERA A MODO DE REFERENCIA PARA ENUMERAR POR NÚMERO DE UBICACIÓN DE IMAGEN MEDIANTE LISTAS.
            patron = ubicacion_imagen.Count; // LOS PATRONES APARECERÁN CONTANDO REPETIDAMENTE.
        }

        // EN ESTA CLASE, PARA FINALIZAR VAMOS A CREAR OTRO MÉTODO PARA ANIMAR LOS FUEGOS ARTIFICIALES.

        public void AnimarFuegosArtificiales()
        {
            // SI EL PATRÓN ACTUAL DE LA PIROTECNIA ES MENOR QUE LOS DEMÁS PATRONES, ENTONCES SE INCREMENTA EL VALOR DE CADA PATRÓN EXISTENTE.
            
            if (patron_actual < patron - 1)
            {
                patron_actual++;
                pirotecnia = Image.FromFile(ubicacion_imagen[patron_actual]);
            }
            else // EN CASO CONTRARIO...
            {
                // NO SE MOSTRARÁN LAS ANIMACIONES DE AQUELLA PIROTECNIA POR PATRÓN.

                patron_actual = 0;
                animacionCompletada = true;
                pirotecnia = null;
                ubicacion_imagen.Clear();
            }
            
        }
        
    }
}