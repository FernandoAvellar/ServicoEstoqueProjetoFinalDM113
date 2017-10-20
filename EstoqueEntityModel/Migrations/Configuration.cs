namespace EstoqueEntityModel.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EstoqueEntityModel.ProvedorEstoque>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EstoqueEntityModel.ProvedorEstoque context)
        {
            ProdutoEstoque prod1 = new ProdutoEstoque { NumeroProduto = "1000", NomeProduto = "Produto 1", DescricaoProduto = "Este é o produto 1", EstoqueProduto = 100 };
            context.ProdutosEstoque.AddOrUpdate(prod1);

            ProdutoEstoque prod2 = new ProdutoEstoque { NumeroProduto = "2000", NomeProduto = "Produto 2", DescricaoProduto = "Este é o produto 2", EstoqueProduto = 10 };
            context.ProdutosEstoque.AddOrUpdate(prod2);

            ProdutoEstoque prod3 = new ProdutoEstoque { NumeroProduto = "3000", NomeProduto = "Produto 3", DescricaoProduto = "Este é o produto 3", EstoqueProduto = 200 };
            context.ProdutosEstoque.AddOrUpdate(prod3);

            ProdutoEstoque prod4 = new ProdutoEstoque { NumeroProduto = "4000", NomeProduto = "Produto 4", DescricaoProduto = "Este é o produto 4", EstoqueProduto = 300 };
            context.ProdutosEstoque.AddOrUpdate(prod4);

            ProdutoEstoque prod5 = new ProdutoEstoque { NumeroProduto = "5000", NomeProduto = "Produto 5", DescricaoProduto = "Este é o produto 5", EstoqueProduto = 400 };
            context.ProdutosEstoque.AddOrUpdate(prod5);

            ProdutoEstoque prod6 = new ProdutoEstoque { NumeroProduto = "6000", NomeProduto = "Produto 6", DescricaoProduto = "Este é o produto 6", EstoqueProduto = 500 };
            context.ProdutosEstoque.AddOrUpdate(prod6);

            ProdutoEstoque prod7 = new ProdutoEstoque { NumeroProduto = "7000", NomeProduto = "Produto 7", DescricaoProduto = "Este é o produto 7", EstoqueProduto = 30 };
            context.ProdutosEstoque.AddOrUpdate(prod7);

            ProdutoEstoque prod8 = new ProdutoEstoque { NumeroProduto = "8000", NomeProduto = "Produto 8", DescricaoProduto = "Este é o produto 8", EstoqueProduto = 30 };
            context.ProdutosEstoque.AddOrUpdate(prod8);

            ProdutoEstoque prod9 = new ProdutoEstoque { NumeroProduto = "9000", NomeProduto = "Produto 9", DescricaoProduto = "Este é o produto 9", EstoqueProduto = 400 };
            context.ProdutosEstoque.AddOrUpdate(prod9);

            ProdutoEstoque prod10 = new ProdutoEstoque { NumeroProduto = "10000", NomeProduto = "Produto 10", DescricaoProduto = "Este é o produto 10", EstoqueProduto = 2 };
            context.ProdutosEstoque.AddOrUpdate(prod10);

            context.SaveChanges();


        }
    }
}
