Console.WriteLine("Introduzca un valor entre 5 y 10:");
string? lectura;
int numero = 0;
bool valido = false;
do
{
    lectura = Console.ReadLine();
    valido = int.TryParse(lectura, out numero);

    if (valido)
    {
        if(numero >=5 && numero <= 10)
            valido = true;
        else{
            Console.WriteLine($"Has introducido {numero}. Introduce un numero entre 5 y 10.");
            valido = false;
        }
           
    }
    else
    {
        Console.WriteLine("Valor no valido, vuelva a introducir otro:");
        valido = false;
    }
        

}while(valido == false);

Console.WriteLine($"Valor {numero} es valido");