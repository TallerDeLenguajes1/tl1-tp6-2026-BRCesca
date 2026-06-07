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


