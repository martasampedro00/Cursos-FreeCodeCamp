Console.WriteLine($"Introduce tu rol (Administrador, Director o Usuario)");
string? entrada;
bool valido = false;
do
{
    entrada = Console.ReadLine();
    entrada = entrada.Trim().ToLower();
    if(entrada == "administrador" || entrada== "director" || entrada == "usuario")
    {
        valido = true;
    }
    else
    {
        Console.WriteLine($"El rol que has introducido, {entrada} no es valido. Introduce un rol valido (Administrador, Director o Usuario)");
    }
}while(valido == false);

Console.WriteLine($"Tu rol ({entrada}) ha sido aceptado");
