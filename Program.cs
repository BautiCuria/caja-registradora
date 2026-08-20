const string nombreComercio = "MAXIKIOSCO 67";

Console.WriteLine($"=== {nombreComercio} === ");

Console.Write("Nombre del cajero: ");
string nombreCajero = Console.ReadLine();

Console.WriteLine($"Bienvenid@, {nombreCajero}. Caja abierta.");

Console.Write("Nombre del Producto");
string nombreProducto = Console.ReadLine();

Console.Write("Precio del producto: ");
decimal precioProducto = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine($"Se cargó el producto {nombreProducto} con un precio de ${precioProducto}");
