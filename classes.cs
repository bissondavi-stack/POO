public class Hiena 
{
    private string? Especie;
    private bool? Ri;
    private string? Regiao;
    public string? especie;
    public bool? ri;
    public string? regiao;

    public string? Especie
    {
        get { return especie; }
        set { especie = value; }
    }

    public bool? Ri
    {
        get { return ri; }
        set { ri = value; }
    }

    public string? Regiao
    {
        get { return regiao; }
        set { regiao = value; }
    }

    public Hiena(string especie, bool ri, string regiao)
    {
        Especie = especie;
        Ri = ri;
        Regiao = regiao;
    }
 
    public void exibirinfo()
    {
        Console.Write($"Hiena");
        Console.WriteLine($"Espécie: {especie}");
        Console.WriteLine($"Ri: {ri}");
        Console.WriteLine($"Regiao: {regiao}");
    }
}

public class LoserClub 
{
    private string? Nome;
    private int? Idade;
    private bool? Vivo;
    private string? Medo;
    
    public string? nome;
    public int? idade;
    public bool? vivo;
    public string? medo;

    public string? Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public int? Idade
    {
        get { return idade; }
        set
        {
            if (value >= 0)
                idade = value;
        }
    }

    public bool? Vivo
    {
        get { return vivo; }
        set { vivo = value; }
    }

    public string? Medo
    {
        get { return medo; }
        set { medo = value; }
    }

    public LoserClub(string nome, int idade, bool vivo, string medo)
    {
        Nome = nome;
        Idade = idade;
        Vivo = vivo;
        Medo = medo;
    }

    public void exibirinfo()
    {
        Console.Write($"Clube dos otario, membros:");
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Idade: {idade}");
        Console.WriteLine($"Vivo: {vivo}");
        Console.WriteLine($"Medo: {medo}");
    }
}

public class Pokemon 
{
    private string? Nome;
    private string? Tipo;
    private int? NumPokedex;

    public string? nome;
    public string? tipo;
    public int? num_pokedex;

    public string? Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public string? Tipo
    {
        get { return tipo; }
        set { tipo = value; }
    }

    public int? NumPokedex
    {
        get { return num_pokedex; }
        set { num_pokedex = value; }
    }

    public Pokemon(string nome, string tipo, int num_pokedex)
    {
        Nome = nome;
        Tipo = tipo;
        NumPokedex = num_pokedex;
    }

    public void exibirinfo()
    {
         Console.Write($"pokedex");
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Tipo: {tipo}");
        Console.WriteLine($"Número Pokedex: {num_pokedex}");
    }
}
