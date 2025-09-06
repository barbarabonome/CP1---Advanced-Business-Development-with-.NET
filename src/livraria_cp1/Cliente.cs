namespace livraria_cp1;

public class Cliente
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string? Email { get; set; }
    public string Telefone { get; set; }
    public DateTime DataCriacao { get; private set; }
    
    public Cliente()
    {
        DataCriacao = DateTime.Now;
    }
}