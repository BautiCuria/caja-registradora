const string nombreComercio = "MAXIKIOSCO 67";

Console.WriteLine($"=== {nombreComercio} === ");

Console.Write("Nombre del cajero: ");
string nombreCajero = Console.ReadLine();

Console.WriteLine($"Bienvenid@, {nombreCajero}. Caja abierta.");


int cantidadProductos = 0;
decimal totalventa = 0;
string opcion = "";

do
{
    Console.WriteLine("¿Que queres hacer?");
    Console.WriteLine("1 - Cargar Producto");
    Console.WriteLine("2 - Cerrar Venta");
    opcion = Console.ReadLine();

    switch (opcion)
    {
        case "1":
            Console.Write("Nombre del Producto");
            string nombreProducto = Console.ReadLine();

            Console.Write("Precio del producto: ");
            decimal precioProducto = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine($"Se cargó el producto {nombreProducto} con un precio de ${precioProducto}");
            cantidadProductos++;
            totalventa = totalventa + precioProducto;

            break;

        case "2":
            Console.WriteLine("Cerrando la Venta");

            break;
        default:
            Console.WriteLine("Opcion Invalida, intente denuevo.");
            break;
    }
} while (opcion != "2");
Console.WriteLine($"Venta Cerrada. Se cargaron {cantidadProductos} productos. Total a cobrar: ${totalventa}");