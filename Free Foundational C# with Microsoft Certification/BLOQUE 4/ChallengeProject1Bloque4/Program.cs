const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

int indexInicio = input.IndexOf("<span>");
int indexFinal = input.IndexOf("</span>");

int posicionesTotales = indexFinal - indexInicio - 6;

quantity = input.Substring(indexInicio + 6, posicionesTotales);

indexInicio = input.IndexOf("<div>");
indexFinal = input.IndexOf("</div>");

posicionesTotales = indexFinal - indexInicio - 5;

output = input.Substring(indexInicio + 5, posicionesTotales);

Console.WriteLine($"Quantity: {quantity}");
Console.WriteLine($"Output: {output}");