/*Ejercicio 1 - While
 * Escribe una tabla de multiplicar del 1 al 10 para un número entero que recibe por consola.
 * Es decir, un programa que presente para el 1:
 * 1 x 1 = 1
 * 1 x 2 = 2
 * …
 * 1 x 10 = 10
 */
Console.WriteLine("Por favor, introduzca un número del 1 al 10: ");
int num = Convert.ToInt32(Console.ReadLine());
int i = 1;

while (i <= 10){
    int result = num * i;
    Console.WriteLine(num + " x " + i + " = " + result);
    i++;
}

/*Ejercicio 2 - Do while
 * Escribe un programa que realice estos pasos:
 * Reciba al menos un número por consola
 * Determine si el número es positivo o negativo
 * Presente un contador para cada tipo (positivo y negativo).
 * Nota: el cero se puede abordar en una clase adicional ya que no es ni positivo ni negativo.
 * Tienes completa libertad para elegir el formato de la salida.
 */
Console.WriteLine("Por favor, introduzca un número: ");
int j = Convert.ToInt32(Console.ReadLine());
int result2 = 0;

if (j > 0)
{
    do
    {
        result2 += j;
        Console.WriteLine("j = " + j + "\n result2 = " + result2);
        j--;
    } while (j > 0);
}else if (j < 0){
    do
    {
        result2 += j;
        Console.WriteLine("j = " + j + "\n result2 = " + result2);
        j++;
    } while (j < 0);
}
else
{
    Console.WriteLine("El número 0 no es válido para este ejercicio.");
}

/*Ejercicio 3 - For
 * Escribe un programa que realice estos pasos:
 * Reciba 3 datos: ancho, alto y relleno o no
 * 
 * Dibuje en consola con un mismo caracter, por ejemplo *, un rectángulo de las dimensiones introducidas 
 * y use el tercer dato para discernir si el rectángulo está relleno (tiene más * dentro) o no.
 * En caso de recibir el mismo número n dos veces debe dibujar un cuadrado de lado n.
 * 
 * Reto: Extiende el programa anterior para recibir otro número que sea el número de cuadrados o rectángulos 
 * que se deben dibujar en la pantalla. Ejemplos:
 * Input: 2,2,2, relleno = true
 * Output:
 * ** **
 * ** **
 * 
 * Input: 3, 4, 1, relleno = false
 * Output:
 * ***
 * * *
 * * *
 * ***
 */

//NO HE SIDO CAPAZ DE RESOLVER ESTE EJERCICIO

/*
Console.WriteLine("Por favor, introduzca el ancho del dibujo con dígitos: ");
int width = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Por favor, introduzca el alto del dibujo con dígitos: ");
int height = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("¿Desea que el dibujo esté relleno?");
string response = Console.ReadLine();
bool response2;

if(response == "sí")
{
    response2 = true;
}else if (response == "Sí")
{
    response2 = true;
}
else
{
    response2 = false;
}

int[,] arr = new int[width, height];
if(response2 == true)
{
    for (int w = 0; w < width; w++)
    {
        for (int h = 0; h < height; h++)
        {
            Console.Write(arr[w, h] == 2 ? "*" : "*");
        }
    }
}
else
{
    for (int w = 0; w < width; w++)
    {
        for (int h = 0; h < height; h++)
        {
            Console.Write(arr[w, h] == 2 ? "*" : " ");
        }
    }
}*/
