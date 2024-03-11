// Metodos y funciones

{
    int val = 10;
    Console.WriteLine(val);
}

int valor = 30;
Console.WriteLine(valor);
//Ejercicio 1
static void suma()
{
    int respuesta, val1, val2 = 0;
    Console.WriteLine("Ingrese el valor 1:");
    val1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese el valor 2:");
    val2 = int.Parse(Console.ReadLine());
    respuesta = val1 + val2;
    Console.WriteLine("Suma =" + respuesta);
}

//Ejercicio 2 
static void datos()
{
    Console.WriteLine("Cual es su nombre? ");
    String nombre = Console.ReadLine();
    Console.WriteLine("Mucho gusto " + nombre);
}

// ejercicio 3 
static void calculoEedad()
{
    Console.WriteLine("Ingrese su año de nacimiento");
    int a = int.Parse(Console.ReadLine());
    int edad2 = 2024 - a;
    Console.WriteLine("Su edad es : " + edad2);
}

static int suma1(int val1, int val2, int val3)
{
    int resultado = val1 + val2;
    return val1 + val2 + val3;

}
int nota2 = 25;
string name = datos1();
int sumanumeros = suma1(10, 20, 40);
int promedio = suma1(30, 20, 40) / 3;
Console.WriteLine(promedio);
promedio = suma1(50, 60, 90);
Console.WriteLine(name + "Tiene promedio de " + promedio);

Console.WriteLine(sumanumeros);

static string datos1()
{
    String nom = Console.ReadLine();
    return nom;
}



int obc;
do
{
    Console.WriteLine("1.Suma");
    Console.WriteLine("2.Nombre");
    Console.WriteLine("3.Edad");
    Console.WriteLine("4.Salir");
    obc = int.Parse(Console.ReadLine());
    switch (obc)
    {
        case 1:
            suma();
            break;
        case 2:
            datos();
            break;
        case 3:
            calculoEedad();
            break;

    }
} while (obc != 4);
Console.WriteLine("Fin");