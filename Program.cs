
int n1 = Int32.MinValue;
int n2 = Int32.MaxValue;
int aux;

do
{
    if(n1 != Int32.MinValue || n2 != Int32.MaxValue)
    {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine($"O fim ({n2}) não pode ser menor que o início ({n1})");
        Console.ResetColor();
        Console.WriteLine();
    }
   
    Console.Write("Início: ");
    Int32.TryParse(Console.ReadLine()!, out n1);

    Console.Write("Fim: ");
    Int32.TryParse(Console.ReadLine()!, out n2);

}

while(n1 > n2);

aux = n1;
Console.WriteLine();

while(aux <= n2)
{
    Console.Write($"{aux} ");
    aux++;
}

Console.WriteLine();
Console.WriteLine($"Esta foi a sequência númerica de {n1} a {n2} ");
Console.WriteLine();