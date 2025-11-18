string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] idPedidos = orderStream.Split(",");
Array.Sort(idPedidos);

foreach(string item in idPedidos)
{
    if(item.Length == 4)
    {
        Console.WriteLine(item);
    }else
        Console.WriteLine($"{item}\t-Error");
}