double consumo, horasPorDia;
decimal custo, estimativaPorMes;

Console.WriteLine(" Custo de Energia \n");

Console.WriteLine("Consumo do aparelho (em kWh/mês):");
consumo = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Horas de uso por dia:");
horasPorDia = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Custo da energia (emR$/kWh):");
custo = Convert.ToDecimal(Console.ReadLine());

estimativaPorMes = Convert.ToDecimal(consumo *horasPorDia) * custo;

Console.WriteLine($"\nCusto estimado: {estimativaPorMes:C}");
