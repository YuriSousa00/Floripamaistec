List<string> frutas = new List<string>();
bool continuar = true;

while(continuar)
{
    Console.Write("Digite o nome de uma fruta: ");
    frutas.Add(Console.ReadLine());
    Console.Write("Você quer continuar? ");
    string resposta = Console.ReadLine();

    if (frutas.Count() == 15)
    {
        continuar = false;
        Console.Write("Fim da Lista");
        break;
        
    }

    if (resposta == "nao" || resposta == "n")
    {
        continuar = false;
    }   
}

frutas.Sort();

foreach (string fruta in frutas)
{
    Console.WriteLine(fruta);
}