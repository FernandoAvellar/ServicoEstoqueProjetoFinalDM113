using EstoqueEntityModel;
using Produto;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Text;

namespace Produto
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class ServicoEstoque : IServicoEstoque, IServicoEstoqueV2
    {
        public bool AdicionarEstoque(string NumeroProduto, decimal Quantidade)
        {
            try
            {
                using (ProvedorEstoque database = new ProvedorEstoque())
                {
                    ProdutoEstoque produto = database.ProdutosEstoque.First(p => p.NumeroProduto.Equals(NumeroProduto));
                    produto.EstoqueProduto += Quantidade;
                    database.SaveChanges();
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        public decimal ConsultarEstoque(string NumeroProduto)
        {
            try
            {
                using (ProvedorEstoque database = new ProvedorEstoque())
                {
                    ProdutoEstoque produto = database.ProdutosEstoque.First(p => p.NumeroProduto.Equals(NumeroProduto));
                    return produto.EstoqueProduto;
                }
            }
            catch
            {
                return -1;
            }
        }

        public bool IncluirProduto(ProdutoDado produto)
        {
            try
            {
                using (ProvedorEstoque database = new ProvedorEstoque())
                {
                    ProdutoEstoque p = new ProdutoEstoque();

                    p.NumeroProduto = produto.NumeroProduto;
                    p.NomeProduto = produto.NomeProduto;
                    p.DescricaoProduto = produto.DescricaoProduto;
                    p.EstoqueProduto = produto.EstoqueProduto;

                    database.ProdutosEstoque.Add(p);
                    database.SaveChanges();
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        public List<string> ListarProdutos()
        {
            List<string> lista = new List<string>();
            try
            {
                using (ProvedorEstoque database = new ProvedorEstoque())
                {
                    List<ProdutoEstoque> produtos = database.ProdutosEstoque.ToList();
                    foreach(ProdutoEstoque p in produtos)
                    {
                        lista.Add(p.NomeProduto);
                    }
                }
            }
            catch
            {
                return lista;
            }
            return lista;
        }

        public bool RemoverEstoque(string NumeroProduto, decimal Quantidade)
        {
            try
            {
                using (ProvedorEstoque database = new ProvedorEstoque())
                {
                    ProdutoEstoque produto = database.ProdutosEstoque.First(p => p.NumeroProduto.Equals(NumeroProduto));
                    produto.EstoqueProduto -= Quantidade;
                    database.SaveChanges();
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool RemoverProduto(string NumeroProduto)
        {
            try
            {
                using (ProvedorEstoque database = new ProvedorEstoque())
                {
                    database.ProdutosEstoque.Remove(database.ProdutosEstoque.Find(NumeroProduto));
                    database.SaveChanges();
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        public ProdutoDado VerProduto(string NumeroProduto)
        {
            ProdutoDado produto = new ProdutoDado();
            try
            {
                using (ProvedorEstoque database = new ProvedorEstoque())
                {
                    ProdutoEstoque p = database.ProdutosEstoque.Find(NumeroProduto);
                    
                    produto.NumeroProduto = p.NumeroProduto;
                    produto.NomeProduto = p.NomeProduto;
                    produto.DescricaoProduto = p.DescricaoProduto;
                    produto.EstoqueProduto = p.EstoqueProduto;

                    return produto;
                }
            }
            catch
            {
                return produto;
            }
        }
    }
}
