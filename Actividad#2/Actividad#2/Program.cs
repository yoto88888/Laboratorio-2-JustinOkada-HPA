using System;
namespace LibroCalificaciones_2
{
    public class LibroPruebaCalificaciones
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("hello world!");
            MiLibroCalificaciones MyLibro = new MiLibroCalificaciones();
            //Pide el nombre del curso y lo recibe como entrada
            Console.WriteLine("Por favor ingrese el nombre del curso: ");

            string nombreDelCurso = Console.ReadLine(); //Lee una linea de texto
            Console.WriteLine(); //Imprime en pantalla una linea en blanco
            //llama el metodo MostrarMensaje de MiLibroCalificaciones
            //y pasa el nombre del curso como argumento

            MyLibro.MostarMensaje(nombreDelCurso);
        }
    }
}
