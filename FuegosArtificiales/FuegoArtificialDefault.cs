using System;
using System.Collections.Generic;
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

        // EN INSTANTES...
    }
}
