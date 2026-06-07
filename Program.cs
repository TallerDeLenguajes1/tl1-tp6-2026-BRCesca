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
//Ejercicio 2
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
    Console.WriteLine("   [5] -> SALIR DEL PROGRAMA");
    Console.WriteLine("==================================================");
    Console.Write(" >> Ingrese su opcion (1-5): ");
    while (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 5)
    {
        Console.Write("Opcion no valida. Ingrese un numero del 1 al 5: ");
    }
    if(opcion !=5)
    {
        double num1, num2, resultado=0;
        string operacion="";
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
        }
        if(opcion == 4 && num2 == 0)
        {
            Console.WriteLine("Error. El denominador no puede ser 0");
        }
        else
        {
            Console.WriteLine($"El resultado de la {operacion} entre los numeros {num1} y {num2} es {resultado}");
        }
        Console.WriteLine("presione enter para continuar");
        Console.ReadLine();        
    }


}while(opcion != 5);

