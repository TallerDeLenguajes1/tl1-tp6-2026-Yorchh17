using System.Reflection.Metadata;

Console.WriteLine("Hello, World!");
/*int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);*/

Console.WriteLine("Seleccione una opcion: 1-Sumar 2-Restar 3-Multiplicar 4-Dividir");
string opcionElegida= Console.ReadLine();
int i=0;

Console.WriteLine("Ingrese los numeros");
int a,b;
Console.WriteLine("Ingrese a:");
string valorA =Console.ReadLine();
Console.WriteLine("Ingrese b:");
string valorB= Console.ReadLine();
bool resultadoa= int.TryParse(valorA, out a);
bool resultadob=int.TryParse(valorB, out b);


if ( int.TryParse(opcionElegida, out i))
{
    switch (i)
    {
        case 1:
            int resultadoSuma=a+b;
            Console.WriteLine("Resultado de la suma: "+resultadoSuma);
        break;
         case 2:
            int resultadoResta=a-b;
            Console.WriteLine("Resultado de la Resta: "+resultadoResta);
        break;
         case 3:
            int resultadoMulti=a*b;
            Console.WriteLine("Resultado de la Multiplicacion "+ resultadoMulti);
        break;
         case 4:
            if (b==0)
            {
            Console.WriteLine("No se puede divisir el Denominador es 0");
            
            }
            int resultadoDivi=a/b;
            Console.WriteLine("Resultado de la Division: "+resultadoDivi);
        break;
        
    }
}