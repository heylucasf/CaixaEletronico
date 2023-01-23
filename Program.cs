Console.WriteLine("Iniciando QUESTAO 03 \nEscreva um algoritmo que simule o funcionamento de um caixa eletrônico\n");

int n100, n50, n20, n10, n5, n2, resto;

Console.WriteLine("Informe o valor de Saque em cédulas: ");
var valor = int.Parse(Console.ReadLine());

resto = valor;

n100 = resto / 100;
resto -= n100*100;

n50 = resto / 50;
resto -= n50 * 50;

n20 = resto / 20;
resto -= n20 * 20;

n10 = resto / 10;
resto -= n10 * 10;

n5 = resto / 5;
resto -= n5 * 5;

n2 = resto / 2;
resto -= n20 * 2;

Console.WriteLine($"Notas necessárias para saque de R$ {valor}:");
Console.WriteLine($"Notas de R$100: {n100}");
Console.WriteLine($"Notas de R$50:  {n50}");
Console.WriteLine($"Notas de R$20:  {n20}" );
Console.WriteLine($"Notas de R$10:  {n10}");
Console.WriteLine($"Notas de R$5:   {n5}");
Console.WriteLine($"Notas de R$2:   {n2}");
Console.Read();