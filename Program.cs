Console.WriteLine("Hello, World!");
/*int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);*/

Console.WriteLine("Ingrese 5-Propiedades 6-Max-Min");
int i = 0;
string s = Console.ReadLine();
bool opcionValida = int.TryParse(s, out i);

switch (i)
{
    case 5:
        Console.WriteLine("Ingrese un numero");
        string entrada = Console.ReadLine();
        float num;

        if (float.TryParse(entrada, out num))
        {
            Console.WriteLine("Valor absoluto: " + Math.Abs(num));
            Console.WriteLine("El cuadrado: " + Math.Pow(num, 2));
            Console.WriteLine("La raiz cuadrada: " + Math.Sqrt(num));
            Console.WriteLine("El seno: " + Math.Sin(num));
            Console.WriteLine("El coseno: " + Math.Cos(num));
            Console.WriteLine("Parte entera: " + Math.Truncate(num));
        }
        break;
        
    case 6: 
        Console.WriteLine("Ingrese el primer número:");
        string entradaA = Console.ReadLine();

        Console.WriteLine("Ingrese el segundo número:");
        string entradaB = Console.ReadLine();

        double numA, numB;

        if (double.TryParse(entradaA, out numA) && double.TryParse(entradaB, out numB))
        {
            Console.WriteLine("El número máximo es: " + Math.Max(numA, numB));
            Console.WriteLine("El número mínimo es: " + Math.Min(numA, numB));
        }
        break;
}



