/*Ejercicio 1: Variables
 * Escribe un programa que reciba datos de una persona y genera un mensaje.
 * Usa una variable para cada dato y otra para el mensaje. Ej: nombre, apellido, edad, sabe programar, etc.
 */
Console.WriteLine("¿Cuál es tu nombre?");
string name = Console.ReadLine();
Console.WriteLine("¿Y tus apellidos?");
string familyName = Console.ReadLine();
Console.WriteLine("¿Cuántos años tienes?");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("¿Sabes programar? (Por favor, conteste sí o no)");
string devSkills = Console.ReadLine();
if (devSkills == "sí")
{
    devSkills = "sabes programar";
}
else
{
    devSkills = "no sabes programar";
}
Console.WriteLine("Tu nombre es {0}, tus apellidos {1}, tienes {2} años y {3}.", name, familyName, age, devSkills);

/*Ejercicio 2: Tipos
 * Usando los tipos de variables más adecuados, describe los objetos siguientes:
 * Coche: puertas, ruedas, marca, ITV vigente
 * Mesa: peso, largo, material, color
 * Nota: puedes escribir estos datos por consola si prefieres verlos.
 * La idea del ejercicio es almacenar los datos en los tipos más adecuados.
 */
string brand = "Tesla";
int wheels = 4;
int doors = 5;
bool Mot = true;
string MotStr = "";
if (Mot == true)
{
    MotStr = "has pasado la ITV";
}
else
{
    MotStr = "no has pasado la ITV";
}
Console.WriteLine("Tienes un {0} con {1} ruedas y {2} puertas y {3}.", brand, wheels, doors, MotStr);

int weight = 15;
float length = 2.5f;
string material = "madera";
string colour = "marrón";
Console.WriteLine("Tienes una mesa que pesa {0} kilos, mide {1} metros, es de {2} y de color {3}."
    , weight, length, material, colour);

/*Ejercicio 3: Operadores
 * Determina los operadores para verificar las siguientes condiciones:
 * Un número es mayor o igual a 18
 * Un char es ‘a’
 * Se cumplen dos conciones a la vez (ambas verdaderas)
 * Se cumple una de dos condiciones a la vez (una true y otra false)
 * Nota: puedes escribir estos datos por consola si prefieres verlos.
 * La idea del ejercicio es almacenar los datos en los tipos más adecuados.
 */
Console.WriteLine("Por favor, introduzca un número:");
int i = Convert.ToInt32(Console.ReadLine());
if(i >= 18)
{
    Console.WriteLine("{0} es mayor que 18.", i);
}
else
{
    Console.WriteLine("{0} es menor que 18.");
}

Console.WriteLine("Por favor, introduzca un caracter:");
char c = Convert.ToChar(Console.ReadLine());
if(c == 'a')
{
    Console.WriteLine("Tu caracter es la letra a.");
}
else
{
    Console.WriteLine("Tu caracter no es la letra a.");
}

if(i >= 18 && c == 'a')
{
    Console.WriteLine("¡El número ingresado es mayor o igual que 18 y el caracter es la letra a!");
}
else
{
    Console.WriteLine("Sigue intentándolo; no has cumplido alguna de las condiciones del programa.");

}

if (i >= 18 || c == 'a')
{
    Console.WriteLine("¡O el número ingresado es mayor o igual que 18 y/o el caracter es la letra a!");
}
else
{
    Console.WriteLine("Sigue intentándolo; no has cumplido ninguna de las condiciones del programa.");

}
