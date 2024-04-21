// 3 - faça um programa que leia os 3 lados de um triangulo e informe o tipo dele: escaleno, isósceles ou equilátero.

double lado1, lado2, lado3;

Console.Write("Digite o valor do lado 1: ");
lado1 = double.Parse(Console.ReadLine());

Console.Write("Digite o valor do Lado 2: ");
lado2 = double.Parse(Console.ReadLine());

Console.Write("Digite o valor do Lado 3: ");
lado3 = double.Parse(Console.ReadLine());

if (lado1 <= 0 || lado2 <= 0 || lado3 <= 0)
{
    Console.WriteLine("Um dos valores não é válido para o lado de um triângulo");
}
else if (lado1 == lado2 && lado3 == lado1)
{
    Console.WriteLine("O triângulo é equilátero");

}
else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
{
    Console.WriteLine("O triângulo é isósceles ");
}
else
{
    Console.WriteLine("O triângulo é escaleno ");
}
