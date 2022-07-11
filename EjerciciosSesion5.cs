/*Ejercicio 1 - If
 * Escribe un programa que:
 * Pida datos a un cliente: Nombre, email, cupón
 * Determine si un cliente tiene un cupon descuento
 * Muestre un precio rebajado en función del descuento
 * Muestre el precio de un producto sin descuento si no hay cupón
 * Nota: puedes poner un precio fijo de un producto o uno variable.
 */
double price = 9.99;
double finalPrice = 0;
Console.WriteLine("Por favor, introduzca su nombre:");
string name = Console.ReadLine();
Console.WriteLine("Por favor, introduzca su dirección de correo electrónico: ");
string email = Console.ReadLine();
Console.WriteLine("¿Tiene algún cupón descuento?");
string discount = Console.ReadLine().ToUpper();

if(discount == "SÍ")
{
    finalPrice = price * 0.80;
    Console.WriteLine("El precio final del cliente {0}, cuyo correo electrónico es {1}, es {2} €.",
        name, email, finalPrice);
}
else if(discount == "SI"){
    finalPrice = price * 0.80;
    Console.WriteLine("El precio final del cliente {0}, cuyo correo electrónico es {1}, es {2} €.",
        name, email, finalPrice);
}
else
{
    Console.WriteLine("El precio final del cliente {0}, cuyo correo electrónico es {1}, es {2} €.",
        name, email, price);
}

/*Ejercicio 2 - Switch
 * Haz una lista de lenguajes de programación, por ejemplo: C#, Java, C++.
 * Presenta la lista en consola y pide que el usuario seleccione el lenguaje mediante 1, 2, 3 o a, b, c.
 * Presenta el resultado en consola.
 * Nota: puedes añadir al resultado el “Hola, mundo” para el caso de C#.
 */
List<string> languages = new List<string>();
languages.Add("C#");
languages.Add("Java");
languages.Add("Python");
languages.Add("SQL");

Console.WriteLine("Por favor, introduzca un número del 1 al 4.");
int num = Convert.ToInt32(Console.ReadLine());

switch (num){
    case 1:
        Console.WriteLine("Has seleccionado {0}.\n¡Hola, Mundo!", languages[0]);
        break;
    case 2:
        Console.WriteLine("Has seleccionado {0}.", languages[1]);
        break;
    case 3:
        Console.WriteLine("Has seleccionado {0}.", languages[2]);
        break;
    case 4:
        Console.WriteLine("Has seleccionado {0}.", languages[3]);
        break;
}
