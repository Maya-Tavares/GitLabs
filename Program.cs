// somar 1,2 + 3,4

var operacao = args[0];
var n1 = Convert.ToDouble(args[1]);
var n2 = Convert.ToDouble(args[2]);

// dotnet run -- ['Somar' '1,2' '3,4']

if (operacao == "Somar")
{
    Console.WriteLine(n1 + n2);
}
