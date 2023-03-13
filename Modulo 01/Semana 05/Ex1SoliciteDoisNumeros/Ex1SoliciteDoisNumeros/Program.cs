try
{
    Console.WriteLine("Insira o primeiro número: ");
    decimal num1 = Convert.ToDecimal(Console.ReadLine());
    Console.WriteLine("Insira o segundo número: ");
    decimal num2 = Convert.ToDecimal(Console.ReadLine());

    decimal resultado = num1 / num2;
    Console.WriteLine($"Resultado da divisão: {resultado}");
    
}
catch (FormatException ex)
{
    Console.WriteLine($"Erro específico capturado: Não é possível usar letras. {ex}.");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine($"Erro específico capturado: Não é possível dividir por 0. {ex}.");
}
catch (Exception ex)
{
    Console.WriteLine($"Erro genérico capturado: {ex}.");
}
finally
{
    int num1 = 0;
    int num2 = 0;
}