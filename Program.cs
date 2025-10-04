Console.Clear();

decimal gastosMensais, valorAInvestir;
double dividendYield;

Console.WriteLine("--- Vivendo de dividendos ---\n");
Console.Write("Gastos mensis (em R$)...:");
gastosMensais = Convert.ToDecimal(Console.ReadLine());

Console.Write("Rendimento de dividendos (%)...:");
dividendYield = Convert.ToDouble(Console.ReadLine());

valorAInvestir = gastosMensais / Convert.ToDecimal(dividendYield / 100);


Console.WriteLine($"\nPara receber {gastosMensais:C} por mês com rendimentos de {dividendYield:N1}% você precisa ter investdo {valorAInvestir:C}.");
