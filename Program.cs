// EJERCICIO 1

Console.WriteLine("Ingrese su nombre:");

string nombre = Console.ReadLine();

Console.WriteLine("Ingrese su apellido:");

string apellido = Console.ReadLine();

Console.WriteLine("Ingrese su edad:");

string edad = Console.ReadLine();

Console.WriteLine("¿Sabe programar?");

string programar = Console.ReadLine();

string mensaje = "Su nombre es " + nombre + " " + apellido + ", su edad es " + edad + " y " + programar + " sabe programar.";

Console.WriteLine(mensaje);


// EJERCICIO 2

// Coche

int puertas = 2;
    int ruedas = 4;
    string marca = "BMW";
    bool itv_vigente = true;


// Mesa

    float peso = 15.5f;
    float largo = 1.5f;
    string material = "Madera";
    string color= "Café";


// EJERCICIO 3

// Un número es mayor o igual a 18

Console.WriteLine("Ingrese un número");

string n = Console.ReadLine();

int numero = Convert.ToInt32(n);

if(numero == 18)
{
    Console.WriteLine("Número es igual a 18");
}
else
{
    Console.WriteLine("Número no es igual a 18");
}


// Un char es ‘a’

Console.WriteLine("Ingrese un caracter");

string c = Console.ReadLine();

char cc = Convert.ToChar(c);

if (cc == 'a')
{
    Console.WriteLine("Caracter es 'a'");
}
else
{
    Console.WriteLine("Caracter no es 'a'");
}

// Se cumplen dos conciones a la vez (ambas verdaderas)


Console.WriteLine("Ingrese un numero");

string nu = Console.ReadLine();

int numero2 = Convert.ToInt32(nu);

if (numero2 > 0 && numero%2==0)
{
    Console.WriteLine("Número es positivo y par");
}
else
{
    Console.WriteLine("Número no es positivo o no es par");
}

// Se cumple una de dos condiciones a la vez (una true y otra false)

if (numero2 > 0 || numero % 2 == 0)
{
    Console.WriteLine("Número es positivo o par");
}
else
{
    Console.WriteLine("Número no es positivo ni par");
}




