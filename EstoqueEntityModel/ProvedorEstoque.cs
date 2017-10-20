namespace EstoqueEntityModel
{
    using System.ComponentModel.DataAnnotations;
    using System.Data.Entity;

    public class ProvedorEstoque : DbContext
    {
        public ProvedorEstoque()
            : base("name=ProvedorEstoque")
        {
        }

        public virtual DbSet<ProdutoEstoque> ProdutosEstoque { get; set; }
    }

    public class ProdutoEstoque
    {
        [Key, Required, StringLength(10, ErrorMessage = "NumeroProduto deve ter no máximo 10 caracteres")]
        public string NumeroProduto { get; set; }

        [StringLength(20, ErrorMessage = "NomeProduto deve ter no máximo 20 caracteres")]
        public string NomeProduto { get; set; }

        [StringLength(50, ErrorMessage = "DescricaoProduto deve ter no máximo 50 caracteres")]
        public string DescricaoProduto { get; set; }

        public decimal EstoqueProduto { get; set; }
    }
}