using System.Xml.Schema;

Console.WriteLine("Hello, World!");
Console.WriteLine("Ingrese el valor que desea invertir: ");
int numeroParaInvertir;
int numeroInvertido=0;
int aux;
//Ejercicio 1
while(!int.TryParse(Console.ReadLine(), out numeroParaInvertir))// me permite evitar que la consola tire error al ingresar una letra
{
    Console.WriteLine("No valido. Ingrese un numero entero por favor.");
}
aux = numeroParaInvertir;
if (numeroParaInvertir < 10 && numeroParaInvertir>-10)
{
    Console.WriteLine($"El numero  {numeroParaInvertir} no se puede invertir ya que es de un solo digito");
}
else
{

    do{
        numeroInvertido = (numeroInvertido*10) + (aux%10);
        aux/=10; 
    }while(aux!=0);
    Console.WriteLine($"Numero ingresado: {numeroParaInvertir}");
    Console.WriteLine($"Numero invertido: {numeroInvertido}");
}
//------------------------------
//Ejercicio 2/3
int opcion=0;
do
{

    Console.WriteLine("==================================================");
    Console.WriteLine("       CALCULADORA V1     ");
    Console.WriteLine("==================================================");
    Console.WriteLine(" Seleccione la operacion que desea realizar:");
    Console.WriteLine();
    Console.WriteLine("   [1] -> SUMAR");
    Console.WriteLine("   [2] -> RESTAR");
    Console.WriteLine("   [3] -> MULTIPLICAR");
    Console.WriteLine("   [4] -> DIVIDIR ");
    Console.WriteLine("   [5] -> FUNCIONES MATEMÁTICAS (Un solo numero)");
    Console.WriteLine("   [6] -> DETERMINAR MÁXIMO Y MÍNIMO (Dos numeros)");
    Console.WriteLine("   [7] -> SALIR DEL PROGRAMA");
    Console.WriteLine("==================================================");
    Console.Write(" >> Ingrese su opcion (1-7): ");
    while (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 7)
    {
        Console.Write("Opcion no valida. Ingrese un numero del 1 al 7: ");
    }
    if(opcion !=7)
    {
        double num1=0, num2=0, resultado=0;
        string operacion="";
        if (opcion == 5)
        {
            Console.WriteLine("Ingrese el valor: ");
            while (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.Write("Ingrese un numero valido: ");
            }
        }
        else
        {
            Console.WriteLine("Ingrese el primer valor");
            while (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.Write("Ingrese un numero valido: ");
            }
            Console.WriteLine("Ingrese el segundo valor: ");
            while (!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.Write("Ingrese un numero valido: ");
            }     
        }

        switch (opcion)
        {
            case 1:
                resultado = num1 + num2;
                operacion = "suma";
            break;
        
            case 2:
                resultado = num1 - num2;
                operacion = "resta";
            break;
        
            case 3:
                resultado = num1 * num2;
                operacion = "multiplicacion";

            break;
        
            case 4:
                if (num2 != 0)
                {
                    resultado = num1/num2;
                    operacion = "division";
                }
            break;
            case 5:
                Console.WriteLine($"       RESULTADOS PARA EL NUMERO: {num1}           ");
                Console.WriteLine($"Valor absoluto: {Math.Abs(num1)}");
                Console.WriteLine($"Cuadrado: {Math.Pow(num1, 2)}");
                if (num1 >= 0) {
                    Console.WriteLine($"Raiz cuadrada: {Math.Sqrt(num1):F2}");
                } else {
                    Console.WriteLine($"Raiz cuadrada de un numero negativo no existe en los reales");
                }
                Console.WriteLine($"Seno: {Math.Sin(num1):F2}");
                Console.WriteLine($"Coseno: {Math.Cos(num1):F2}");
                Console.WriteLine($"Parte entera: {Math.Truncate(num1)}");
            break;
            case 6:
                Console.WriteLine($"El numero MAXIMO entre {num1} y {num2} es: {Math.Max(num1, num2)}");
                Console.WriteLine($"El numero MINIMO entre {num1} y {num2} es: {Math.Min(num1, num2)}");
            break;
        }
        if(opcion == 4 && num2 == 0)
        {
            Console.WriteLine("Error. El denominador no puede ser 0");
        }
        else if(opcion != 5 && opcion != 6)
        {
            Console.WriteLine($"El resultado de la {operacion} entre los numeros {num1} y {num2} es {resultado}");//Ejercicio 4 punto de string y num
        }
        Console.WriteLine("presione enter para continuar");
        Console.ReadLine();        
    }


}while(opcion != 7);

//-------
//Ejercicio 4 //

string? frase = "";
string? fraseSeg = "";
string? fraseConcatenada = "";
string? subcadena = "";
string? palabraBuscada = "";
Console.WriteLine("Ingrese la frase: ");
frase = Console.ReadLine();
Console.WriteLine($"La frase ingresada es: {frase}");
Console.WriteLine($"Su longitud es de: {frase.Length} ");
Console.WriteLine("Ingrese la segunda frase: ");
fraseSeg = Console.ReadLine();
fraseConcatenada = $"{frase} {fraseSeg}"; 
Console.WriteLine($"La frase concatenada es: {fraseConcatenada}");
subcadena = frase.Substring(1, 4);
Console.WriteLine($"La subcadena es: {subcadena}");
if (!string.IsNullOrWhiteSpace(frase))
{
    Console.WriteLine("\nRecorriendo la cadena caracter por caracter:");
    foreach (char letra in frase)
    {
        Console.WriteLine($"=={letra}==");
    }
}
Console.WriteLine("Ingrese la palabra buscada: ");
palabraBuscada = Console.ReadLine();
if (!string.IsNullOrWhiteSpace(frase) && !string.IsNullOrWhiteSpace(palabraBuscada))
{
    if (frase.Contains(palabraBuscada))
    {
        Console.WriteLine($"La palabra {palabraBuscada} si esta en la frase.");       
    }
    else
    {
        Console.WriteLine($"La palabra {palabraBuscada} no se encuentra en la frase ingresada.");
    }

}
if (!string.IsNullOrWhiteSpace(frase))
{
    string? textoMayusculas = frase.ToUpper();
    string? textoMinusculas = frase.ToLower();
    Console.WriteLine($"Texto original:  {frase}");
    Console.WriteLine($"En mayuscula:   {textoMayusculas}");
    Console.WriteLine($"En minúsculas:   {textoMinusculas}");
}
if (!string.IsNullOrWhiteSpace(frase))
{
    string[] elementosSeparados = frase.Split(',');

    Console.WriteLine($"Se detectaron {elementosSeparados.Length} elementos en la cadena:");

    for (int i = 0; i < elementosSeparados.Length; i++)
    {
        string elemento = elementosSeparados[i].Trim(); 
        Console.WriteLine($"[Elemento {i + 1}] -> {elemento}");
    }
}
Console.WriteLine("Ingrese la ecuacion");
string? ecuacion = Console.ReadLine();
if (!string.IsNullOrWhiteSpace(ecuacion))
{
    ecuacion = ecuacion.Replace(" ", "");
    char operador = ' ';
    if (ecuacion.Contains('+'))
    {
         operador = '+';
    }
    else if (ecuacion.Contains('-'))
    { 
        operador = '-';
    }
    else if (ecuacion.Contains('*'))
    {
         operador = '*';
    }
    else if (ecuacion.Contains('/')) 
    {
        operador = '/';
    }
    if (operador == ' ')
    {
        Console.WriteLine("No se detecto un operador valido en la ecuacion.");
    }
    else
    {
        string[] partes = ecuacion.Split(operador);
        if (partes.Length == 2)
        {
            double num3, num4;
            bool esNum1Valido = double.TryParse(partes[0], out num3);
            bool esNum2Valido = double.TryParse(partes[1], out num4);

            if (esNum1Valido && esNum2Valido)
            {
                double resultado = 0;
                bool operacionValida = true;

                switch (operador)
                {
                    case '+':
                        resultado = num3 + num4;
                        break;
                    case '-':
                        resultado = num3 - num4;
                        break;
                    case '*':
                        resultado = num3 * num4;
                        break;
                    case '/':
                        if (num4 != 0)
                        {
                            resultado = num3 / num4;
                        }
                        else
                        {
                            Console.WriteLine("Error: Division indefinida.");
                            operacionValida = false;
                        }
                        break;
                }

                if (operacionValida)
                {
                    Console.WriteLine($"Ecuacion procesada con exito:");
                    Console.WriteLine($"Primer operando:  {num3}");
                    Console.WriteLine($"Operador:         {operador}");
                    Console.WriteLine($"Segundo operando: {num4}");
                    Console.WriteLine($"El resultado de {ecuacion} es: {resultado}");
                }
            }
            else
            {
                Console.WriteLine("Error: Uno o ambos componentes de la ecuacion no son numeros validos.");
            }
        }
        else
        {
            Console.WriteLine("Error: La ecuacion debe ser simple");
        }
    }
}

