class Program
{
    static void Main(string[] args)
    {
        Hiena hiena1 = new Hiena("Hiena-malhada", true, "África");
        Hiena hiena2 = new Hiena("Hiena-listrada", false, "Ásia");

        Console.WriteLine("======HIENAS======");

        Console.WriteLine(hiena1);
        Console.WriteLine();

        Console.WriteLine(hiena2);
        Console.WriteLine();


        hiena1.Especie = "Hiena-castanha";
        hiena1.Regiao = "África do Sul";

        Console.WriteLine("===== HIENA 1 ALTERADA =====");
        Console.WriteLine(hiena1);
        Console.WriteLine();



        LoserClub pessoa1 = new LoserClub("Bill", 13, true, "perder quem ama");
        LoserClub pessoa2 = new LoserClub("Richie", 13, true, "Palhaço");

        Console.WriteLine("======LOSER CLUB======");

        Console.WriteLine(pessoa1);
        Console.WriteLine();

        Console.WriteLine(pessoa2);
        Console.WriteLine();


        pessoa1.Idade = 14;
        pessoa1.Medo = "Aranhas";

        Console.WriteLine("===== PESSOA 1 ALTERADA =====");
        Console.WriteLine(pessoa1);
        Console.WriteLine();


        Pokemon pokemon1 = new Pokemon("Pikachu", "Elétrico", 25);
        Pokemon pokemon2 = new Pokemon("Charmander", "Fogo", 4);

        Console.WriteLine("===== POKEMONS =====");

        Console.WriteLine(pokemon1);
        Console.WriteLine();

        Console.WriteLine(pokemon2);
        Console.WriteLine();


        pokemon1.Nome = "Raichu";
        pokemon1.NumPokedex = 26;

        Console.WriteLine("===== POKEMON 1 ALTERADO =====");
        Console.WriteLine(pokemon1);
        Console.WriteLine();
    }
}
