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
