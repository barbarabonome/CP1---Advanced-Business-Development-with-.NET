namespace livraria_cp1;

public class Pedido
{
    public int Id { get; set; }
    public DateTime DataCriacao { get; private set; }
    public float ValorTotal { get; set; }
    
    public Pedido()
    {
        DataCriacao = DateTime.Now;
    }
}