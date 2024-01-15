// See https://aka.ms/new-console-template for more information
using Clase5Objetos;

Console.WriteLine("Hello, World!");

Producto producto1 = new Producto();

Producto producto2 = new Producto(001, "Pepsi",1200,800,"Bebidas");

Console.WriteLine(producto1);
Console.WriteLine("Codigo: " + producto2.Codigo);
Console.WriteLine("Descripcion: " + producto2.Descripcion);
Console.WriteLine("Categoria: " + producto2.Categoria);
producto2.PrecioVenta = 2000;
Console.WriteLine("Precio Venta: " + producto2.PrecioVenta);


Console.ReadKey();