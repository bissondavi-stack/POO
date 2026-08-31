public class Hiena 
{
    private string? especie;
    private bool? ri;
    private string? regiao;
    public string? Especie
    {
        get { return especie; }
        set { especie = value; }
    }
    public bool? Ri;
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
    private string? nome;
    private int? idade;
    private bool? vivo;
    private string? medo;

    public string? Nome
    {
        get { return nome;}
        set { nome = value;}
    }
    public int? Idade
    {
        get {return idade;}
        set
        {
            if (value >=0)
                idade = value;
 
        }
    }
    public bool? Vivo;
    public string? Medo
    {
        get { return medo;}
        set { medo = value;}   
    }

    
}

public class Pokemon 
{
    private string? nome;
    private string? tipo;
    private int? num_pokedex;

    private string? Nome
    {
        get { return nome;}
        set { nome = value;}
    }    
    private string? Tipo
    {
        get { return tipo;}
        set { tipo = value;}
    }
    private int? NumPokedex;
}    
