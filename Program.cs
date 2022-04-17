string sexo;
double altura, pesoIdeal;

Console.WriteLine("Digite sua altura em m..........:");
altura = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Sexo [M]asculino / [F]eminino...:");
sexo = Console.ReadLine()!.ToUpper().Trim();

if (sexo != "M" && sexo != "F")
{
    Console.WriteLine("Não possuo fórmula para cálculo.");
}
else
{}
if (sexo == "M")
{
    pesoIdeal = altura * 72.7 - 58.0;
}
else
{
     pesoIdeal = altura * 62.1 - 44.7;
}

Console.WriteLine($"Seu peso ideal é {pesoIdeal:N1}kg.");
