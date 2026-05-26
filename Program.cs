Console.WriteLine("Hello, World!");
/*int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);*/

/*Console.WriteLine("Ingrese un numero para invertir:");
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
*/
//● Obtener la longitud de la cadena y muestre por pantalla.

Console.WriteLine("Ingrese una cadena de texto");
string? texto = Console.ReadLine();
if (texto != null)
{
    int longitud = texto.Length;
    Console.WriteLine("\nLongitud de la cadena: " + longitud);
}
Console.WriteLine("\nIngrese una segunda cadena de texto");
string? texto2 = Console.ReadLine();
if (texto != null && texto2 != null)
{
    // Concatenar cadenas
    string textoCompleto = texto + " " + texto2;
    Console.WriteLine("\nCadenas concatenadas: " + textoCompleto);
    // Subcadena
    string subcadena = texto.Substring(0, 3);
    Console.WriteLine("\nSubcadena: " + subcadena);
    foreach(char caracter in textoCompleto)
    {
        Console.WriteLine("\nCaracter: "+caracter);
    };
    Console.WriteLine("\nIngrese la palabra a buscar ");
    string? buscada = Console.ReadLine();
    int contador = 0;
    if(buscada != null)
    {
        string[] palabras = textoCompleto.Split(' ');
        foreach(string palabra in palabras)
        {
            if (buscada == palabra)
            {
                contador++;
            }
            
        }
        Console.WriteLine("\nOcurrencias: "+contador);
        Console.WriteLine("\nCadena completa MAYUS: "+ (textoCompleto.ToUpper()));
        Console.WriteLine("\nCadena completa MAYUS: "+ (textoCompleto.ToLower()));
    }
}

Console.WriteLine("\nIngrese una oracion usando como separador '/'");
string? texto3 = Console.ReadLine();
if(texto3 != null)
{
    string[] partes = texto3.Split("/");
    foreach(string parte in partes)
    {
        Console.WriteLine("Palabra: "+parte);
    }
}
