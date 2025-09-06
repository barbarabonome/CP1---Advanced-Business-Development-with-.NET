namespace livraria_cp1;

public class PedidoLivro
{
    public int Id { get; set; }
    public int LivroId { get; set; }
    public int PedidoId { get; set; }
    public virtual Livro Livro { get; set; }
    public virtual Pedido Pedido { get; set; }
    public float PrecoUnitario { get; set; }
    public float PrecoVenda { get; set; }
    public int QtdeItem { get; set; }
}