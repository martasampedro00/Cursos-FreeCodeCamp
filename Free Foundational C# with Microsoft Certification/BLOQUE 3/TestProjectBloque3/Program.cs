/*string permission = "Admin|Manager";
int level = 70;

if (permission.Contains("Admin"))
{
    if(level > 55)
        Console.WriteLine("Welcome, Super Admin user.");
    else
        Console.WriteLine("Welcome, Admin user.");
}else if(permission.Contains("Manager"))
{
    if(level >= 20)
        Console.WriteLine("Contact an Admin for access.");
    else
        Console.WriteLine("You do not have sufficient privileges.");
}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
}*/

/*int[] numbers = { 4, 8, 15, 16, 23, 42 };
int total = 0;
bool found = false;

foreach (int number in numbers)
{
    total += number;

    if (number == 42)
        found = true;
}

if (found) 
    Console.WriteLine("Set contains 42");

Console.WriteLine($"Total: {total}");*/

/*int employeeLevel = 100;
string employeeName = "John Smith";

string title = "";

switch (employeeLevel)
{
    case 100:
    case 200:
        title = "Senior Associate";
        break;
    case 300:
        title = "Manager";
        break;
    case 400:
        title = "Senior Manager";
        break;
    default:
        title = "Associate";
        break;
}

Console.WriteLine($"{employeeName}, {title}");*/

// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
/*string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

switch (product[0])
{
    case "01":
        type = "Sweat shirt";
        break;

    case "02":
        type = "T-Shirt";
        break;

    case "03":
        type = "Sweat pants";
        break;
    default:
        type = "Other";
        break;
}

switch (product[1])
{
    case "BL":
        color = "Black";
        break;

    case "MN":
        color = "Maroon";
        break;

    default:
        color = "White";
        break;
}

switch (product[2])
{
    case "S":
        size = "Small";
        break;

    case "M":
        size = "Medium";
        break;

    case "L":
        size = "Large";
        break;

    default:
        size = "One Size Fits All";
        break;
}

Console.WriteLine($"Product: {size} {color} {type}");*/

int monstruo = 10;
int heroe = 10;
int turno = 0; //0 heroe // 1 monstruo

do
{
    Random dado = new Random();
    int resta = dado.Next(1,11);

    monstruo -= resta;
    Console.WriteLine($"El monstruo ha perdido {resta} de vida");
    Console.WriteLine($"La salud restante del monstruo es {monstruo}");

    if(monstruo <= 0) continue;

    heroe -= resta;
    Console.WriteLine($"El heroe ha perdido {resta} de vida");
    Console.WriteLine($"La salud restante del hereo es {heroe}");


}while(monstruo > 0 && heroe > 0);

if(monstruo <= 0)
    Console.WriteLine("Ha ganado el heroe");
else
    Console.WriteLine("Ha ganado el monstruo");