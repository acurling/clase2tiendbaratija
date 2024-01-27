// See https://aka.ms/new-console-template for more information
using System.Reflection;
using System.Timers;
using System.Xml.Schema;


//tipos datos

int num1, num2;     // numeros enteros
int valor1 = 56;

long l = 5458887;
byte b = 25;
short s = 5654;

// flotantes
float flotante = 3.123f;
double doble = 5.684d;
decimal dec = 36545.12m;

// boleanos
bool boleano = false;

// cadenas de caracteres
string nombre = "Karla";    // cadena de caracteres
string apellido = "Miranda";
char carecter = 'a';

Console.WriteLine(nombre + " " +apellido);

//Console.WriteLine("Digite un nombre?");
//nombre = Console.ReadLine();

//Console.WriteLine("su nombre es:" + nombre + " " + apellido);

num1 = 10;
num2 = 3;
Console.WriteLine("Sumar:" + (num1 + num2));
Console.WriteLine("Multiplicar:" + (num1 * num2));

//Console.WriteLine("Digite un valor:");
//num1 = int.Parse(Console.ReadLine());   // Parse para convertir un texto 
//Console.WriteLine("Digite otro valor");
//num2 = int.Parse(Console.ReadLine());

//Console.WriteLine("Multiplicar:" + (num1 * num2));
float Camisas = 100;
float pantalones = 200;
float medias = 50;

float precio = 400;
float total = 0;
float stotal = 0;
float descuento = 0;
int cantidad;
float IVA = 0;
int opcion = 0;
string articulo = "";

do
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("********* TIENDA LA BARATIJA **************");
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("1- Camisas");
    Console.WriteLine("2- Pantalones");
    Console.WriteLine("3- Medias");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Que desea comprar..?");
    opcion = int.Parse(Console.ReadLine());
    if (opcion == 1)
    {
        precio = Camisas;
        articulo = "Camisas";
    }
    else if (opcion == 2)
    {
        precio = pantalones;
        articulo = "Pantalones";
    }
    else if (opcion == 3)
    {
        precio = medias;
        articulo = "Medias";
    }
} while (opcion < 1 || opcion > 3);  
  
       

Console.ForegroundColor = ConsoleColor.White;

Console.WriteLine("Digite la cantidad");
 cantidad = int.Parse(Console.ReadLine());
Console.WriteLine("Digite el % de descuento");
descuento = int.Parse(Console.ReadLine());
stotal = cantidad * precio;
Console.WriteLine("El subtotal a pagar es de:............... {0}", stotal);
descuento = stotal * (descuento / 100);
Console.WriteLine("El descuento es............. {0}", descuento);
stotal = stotal - descuento;
Console.WriteLine("El subtotal con descuento:.............. {0}", stotal);
Console.WriteLine("El descuento es {0}", descuento);
IVA = stotal * 0.13f;
Console.WriteLine("El impuesto es.............. {0}",IVA);
Console.WriteLine("Total a pagar por {1} es de............. {0}", (stotal + IVA),articulo);


