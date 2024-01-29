using Clase10_CRUD_ADOnet.DataBase;
using Clase10_CRUD_ADOnet.Entities;

public class Program
{
    static void Main(string[] args)
    {
        GestorDataBase dataBase = new GestorDataBase();
		try
		{
            /*** Lectura en base de datos ***/

            //Console.WriteLine("Ingrese Id que desea buscar");
            //int idBuscado = Convert.ToInt16(Console.ReadLine());
            //Usuario usuarioObtenido = dataBase.GetUsuarioById(idBuscado);
            //Console.WriteLine(usuarioObtenido.ToString());


            /*** Escribir en base de datos ***/

            //Usuario usuarioNuevo = new Usuario("Pedro", "Perez", "pperez", "12345p", "pp@mail.com");
            //if (dataBase.AddUser(usuarioNuevo))
            //{
            //    Console.WriteLine("Usuario agregado exitosamente");
            //}

            /*** Borrar en base de datos ***/

            //Console.WriteLine("Ingrese Id que desea borrar");
            //int idBuscado = Convert.ToInt16(Console.ReadLine());
            //if (dataBase.DeleteUserById(idBuscado))
            //{
            //    Console.WriteLine("Usuario borrado exitosamente");
            //}

            /*** Actualizar en base de datos ***/

            Console.WriteLine("Ingrese Id que desea actualizar");
            int idActualizado = Convert.ToInt16(Console.ReadLine());
            Usuario usuarioAActualizar = new Usuario("Leo", "Messi", "lmessi", "leoCampeon", "lmessi@mail.com");
            if (dataBase.UpdateUserById(idActualizado, usuarioAActualizar))
            {

                Console.WriteLine("Usuario actualizado exitosamente");
            }


        }
        catch (Exception ex)
		{

			Console.WriteLine(ex.Message);
		}
    }
}