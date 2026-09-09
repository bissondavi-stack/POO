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
