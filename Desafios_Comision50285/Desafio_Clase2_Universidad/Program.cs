using Microsoft.VisualBasic.Logging;

namespace Desafio_Clase2_Universidad
{
    //La secretaria de una universidad nos pide un sistema para poder cargar los datos de sus alumnos, necesitan poder cargar 
    //la comisi�n que puede ser A si son de turno ma�ana, B si son de turno tarde, C si son de turno noche y en caso de no tener
    //comisi�n indica que no tienen turno fijado.

    //Tambi�n cada docente califica a sus alumnos con una nota entre 0 y 10, en caso de ser menor a 4 el alumno Recursa la Materia,
    //si est� entre 4 y 7 es Aprob� Cursada y si es mayor que 7 Promociona la Materia..

    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}