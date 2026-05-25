Console.WriteLine("Hello, World!");
/*int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);*/

Console.WriteLine("Ingrese un numero para invertir:");
string s =Console.ReadLine();
int num=0;

    if (int.TryParse(s, out num))
    {
        if (num>0)
        {
            int invertido=0;
            int resto;
            int aux=num;
            while (aux>0)
            {
                resto=aux %10;
                invertido=(invertido * 10) + resto;
                aux=aux/10;
            }

        Console.WriteLine("El número invertido es: " + invertido);

        }
    }
    else 
    {
    Console.WriteLine("Error: Lo que ingresaste no es un número válido.");
    }




