namespace Laboratorio_2___Actividada_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear el objeto LibroCalificaciones
            //Invocar el objeto LibroCalificaciones

            LibroCalificaciones myLibro = new LibroCalificaciones("CS101 Programacion en C#");
            LibroCalificaciones myLibro2 = new LibroCalificaciones("CS102 Estructura de Datos");
            Console.Write("El nombre del curso es: {0}\n", myLibro.NombreCurso);
            Console.Write("El nombre del curso es: {0}\n", myLibro2.NombreCurso);

            //Pide y lee el nombre del curso
            Console.WriteLine("\nEscriba el nombre del curso: ");
            string elNombreCurso = Console.ReadLine();
            myLibro.NombreCurso = elNombreCurso; //Establece el nombre del curso usando una propiedad
            Console.WriteLine("El nombre del curso es: {0}", myLibro.NombreCurso);
        }
    }
}
