decimal valor, rendaComprovada, valorParcela, maiorParcelaPermitida;
int quantidadeParcelas;

Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine("-- Análise de Crédito --\n");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.Write("Valor desejado:  ");
valor = Convert.ToDecimal(Console.ReadLine());
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.Write("Quantidade de parcelas:  ");
quantidadeParcelas = Convert.ToInt32(Console.ReadLine());
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.Write("Renda comprovada:  ");
rendaComprovada = Convert.ToDecimal(Console.ReadLine());
Console.ResetColor();

valorParcela = valor / quantidadeParcelas;
maiorParcelaPermitida = rendaComprovada / 100 * 30;

Console.WriteLine();

Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine($"Parcela: {valorParcela:C}");
Console.WriteLine($"Maior parcela permitida: {maiorParcelaPermitida:C}");
Console.ResetColor();

Console.WriteLine();

if (valorParcela > maiorParcelaPermitida)
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("Empréstimo não autorizado.");
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Empréstimo autorizado.");
    Console.ResetColor();
}
