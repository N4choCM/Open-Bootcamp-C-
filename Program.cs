/*Ejercicio 1: Crea una estructura de datos para un cliente con estos campos:
 * Nombre completo
 * Teléfono
 * Dirección
 * Email
 * Si es nuevo cliente
 * Bonus: escribe un método para presentar estos datos desde la estructura al hacer Console.WriteLine(...)
 */

public struct Customer
{
    static void Main(string[] args)
    {
        Customer c = new Customer("Nacho Campos Martí", 628523682, "C/ Verdial, 29; ático 3A", 
            "nachocamposmarti@gmail.com", true);
        Console.WriteLine(c);
    }
    public string newClientStr = "";
    public Customer(string fullName, int phone, string address, string email, bool newClient)
    {
        this.fullName = fullName;
        this.phone = phone;
        this.address = address;
        this.email = email;
        this.newClient = newClient;

        if (newClient == true)
        {
            newClientStr = "soy un cliente nuevo";
        }
        else
        {
            newClientStr = "no soy un cliente nuevo";
        }
        Console.WriteLine("Hola, mi nombre es {0}, mi número de teléfono {1}, mi dirección {2}, " +
            "mi correo electrónico es {3} y {4}.", fullName, phone, address, email, newClientStr);
    }

    public string fullName { get; set; }
    public int phone { get; set; }
    public string address { get; set; }
    public string email { get; set; }
    public bool newClient { get; set; }
}