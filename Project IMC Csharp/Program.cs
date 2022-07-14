using System;


float A, P, imc;

Console.Write("Digite o seu peso:");
P = float.Parse(Console.ReadLine());


Console.Write("Digite o seu altura:");
A = float.Parse(Console.ReadLine());

imc = (P / (A * A));

if (imc <= 18.5)
{
    Console.WriteLine("Peso abaixo do normal");
}
else if ((imc > 18.5) && (imc < 25))
{
    Console.WriteLine("Peso normal");
}
else if ((imc >= 25) && (imc < 30))
{
    Console.WriteLine("Sobre o Peso");
}
else if ((imc >= 30) && (imc < 35))
{
    Console.WriteLine("Grau de Obesidade I");
}
else if ((imc >= 35) && (imc < 40))
{
    Console.WriteLine("Grau de Obesidade II");
}
else if (imc >= 40)
{
    Console.WriteLine("Obesidade Grau III");
}

