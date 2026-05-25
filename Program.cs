using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Threading.Tasks.Dataflow;

Console.WriteLine("Hello, World!");
/*int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);*/


int continuar = 1; 

do 
{
    Console.WriteLine("Seleccione una opcion: 1-Sumar 2-Restar 3-Multiplicar 4-Dividir 5-Propiedades 6-Max-Min");
    string opcionElegida = Console.ReadLine();
    int i = 0;

    Console.WriteLine("Ingrese los numeros");
    
    Console.WriteLine("Ingrese a:");
    string valorA = Console.ReadLine();
    
    Console.WriteLine("Ingrese b:");
    string valorB = Console.ReadLine();
    
    int a, b;
    bool resultadoa = int.TryParse(valorA, out a);
    bool resultadob = int.TryParse(valorB, out b);

    if (resultadoa && resultadob)
    {
        if (int.TryParse(opcionElegida, out i))
        {
            switch (i)
            {
                case 1:
                    int resultadoSuma = a + b;
                    Console.WriteLine("Resultado de la suma: " + resultadoSuma);
                    break;
                case 2:
                    int resultadoResta = a - b;
                    Console.WriteLine("Resultado de la Resta: " + resultadoResta);
                    break;
                case 3:
                    int resultadoMulti = a * b;
                    Console.WriteLine("Resultado de la Multiplicacion: " + resultadoMulti);
                    break;
                case 4:
                    if (b == 0)
                    {
                        Console.WriteLine("Error: No se puede dividir, el denominador es 0");
                    }
                    else
                    {
                        int resultadoDivi = a / b;
                        Console.WriteLine("Resultado de la Division: " + resultadoDivi);
                    }
                    break;
                case 5:
                    Console.WriteLine("Ingrese un numero para calcular propiedades:");
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
                    else
                    {
                        Console.WriteLine("Error: Valor inválido.");
                    }
                    break;
                case 6: 
                    Console.WriteLine("El número máximo es: " + Math.Max(a, b));
                    Console.WriteLine("El número mínimo es: " + Math.Min(a, b));
                    break;
                default:
                    Console.WriteLine("La opción elegida no existe en el menú.");
                    break;
            }
        }
        else 
        {
            Console.WriteLine("Opción de menú inválida.");
        }
    }
    else
    {
        Console.WriteLine("Error: Ingresaste letras o símbolos en lugar de números.");
    }

    Console.WriteLine("\n¿Desea realizar otra operacion? 1-SI / 2-NO");
    string c = Console.ReadLine();
    
    bool ok = int.TryParse(c, out continuar);
    
    if (!ok) 
    {
        continuar = 0; 
    }

} while (continuar == 1);