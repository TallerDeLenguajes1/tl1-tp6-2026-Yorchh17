# Respuestas Teóricas - Ejercicio 4

### ¿String es un tipo por valor o un tipo por referencia?
En C#, `string` es un **tipo por referencia**Específicamente, la palabra clave `string` funciona como un alias para la clase `System.String`
A diferencia de los tipos por valor (que guardan el dato directamente), las variables de tipo referencia almacenan la dirección de memoria donde se encuentra la instancia del tipo
### ¿Qué secuencias de escape tiene el tipo string?
Las secuencias de escape se utilizan para representar caracteres especiales dentro de una cadena de texto, y se inician con una barra invertida (`\`). Algunas de las más comunes en C# son:
* `\n`: Salto de línea.
* `\t`: Tabulación.
* `\\`: Inserta una barra invertida literal.
* `\"`: Inserta comillas dobles dentro del texto.
* `\0`: Representa un carácter nulo insertado dentro de la cadena.

### ¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?
Ambos caracteres son prefijos que modifican cómo el compilador lee la cadena de texto:
El carácter @ (Literal Textual / Verbatim): Le dice al compilador que ignore por completo las secuencias de escape (como \n o \t) y lea todo el texto de manera literal, tal cual lo escribiste. Es extremadamente útil cuando tenés que guardar rutas de archivos en Windows.
Ejemplo sin @: string ruta = "C:\\tp6\\Program.cs"; (Tenés que poner doble barra).
Ejemplo con @: string ruta = @"C:\tp6\Program.cs"; (Lo escribís natural).

**El carácter `$` (Interpolación):** Permite incrustar variables directamente dentro de la cadena usando llaves `{}` en lugar de concatenar con el signo `+`Es la forma más moderna y legible de armar mensajes.
  string saludo = $"Hola, {nombre}!"; // Salida: Hola, Ana!

  # Expresiones Regulares (Regex) - Ejercicio 5

### ¿Qué son y cómo funcionan las expresiones regulares?
Las expresiones regulares (comúnmente llamadas **Regex** o **RegExp**) son secuencias de caracteres que forman un **patrón de búsqueda**. 
Funcionan como una plantilla o regla abstracta que el motor de programación utiliza para analizar un texto y buscar coincidencias. En lugar de buscar una palabra exacta (como "hola"), te permiten buscar patrones lógicos (por ejemplo: "buscar cualquier palabra que empiece con una letra mayúscula, seguida de 3 números y que termine en un punto").

### ¿Funcionan únicamente en C#?
**No, en absoluto.** Las expresiones regulares son un estándar universal en la informática. Están implementadas de forma nativa en prácticamente todos los lenguajes de programación modernos (JavaScript, Python, Java, PHP, C++, etc.). Además, se usan en herramientas de línea de comandos (como `grep` en Linux), motores de bases de datos (SQL) y editores de código (como Visual Studio Code) para hacer búsquedas avanzadas.

### ¿En qué casos le parecen útiles? (3 Ejemplos)
1. **Validación de datos de entrada:** Es su uso más común. Sirven para comprobar rápidamente si lo que ingresó un usuario tiene el formato correcto (ej: verificar que un email contenga un `@` y un dominio, o que una contraseña tenga al menos una mayúscula y un número).
2. **Extracción de información (Data Mining / Scraping):** Permiten escanear un documento gigante o el código HTML de una página web y "rescatar" solo los datos que nos interesan (ej: extraer todos los números de teléfono o todos los links de un texto enorme, ignorando el resto).
3. **Búsqueda y reemplazo complejo:** Permiten hacer cambios masivos en el texto basados en patrones. (Ej: buscar un documento entero que tiene fechas en formato `DD/MM/AAAA` y cambiarlas todas automáticamente al formato `AAAA-MM-DD`).

### ¿Cómo se hace uso de estas en C#?
Para usar expresiones regulares en C#, primero se debe importar el espacio de nombres correspondiente agregando `using System.Text.RegularExpressions;` al principio del archivo. 

La herramienta principal es la clase **`Regex`**. Se puede utilizar de manera estática para validaciones rápidas, por ejemplo usando el método `Regex.IsMatch()` que devuelve `true` o `false` si el texto cumple con el patrón.

**Ejemplo básico en C#:**
```csharp
using System.Text.RegularExpressions;

// Patrón básico para validar si un texto tiene solo números
string patron = @"^[0-9]+$"; 
string textoUsuario = "12345";

bool esValido = Regex.IsMatch(textoUsuario, patron);

if (esValido) 
{
    Console.WriteLine("El texto contiene solo números.");
}
