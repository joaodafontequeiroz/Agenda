namespace WebApi.RetornoPadrao;


public class  RetornoPadrao<T>  
{
    public T Data {get; set;}
    public string? Mensagem { get; set; }
    public bool DeuCerto { get; set; }
}