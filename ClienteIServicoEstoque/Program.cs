using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using Produto.ServicoEstoque;

namespace ClienteIServicoEstoque
{
    class Program
    {
        static void Main(string[] args)
        {
            ServicoEstoqueClient proxy = new ServicoEstoqueClient("BasicHttpBinding_IServicoEstoque");

            Console.WriteLine("Pressione qualquer tecla para inciar os testes! Aguarde antes a incialização do servidor!");
            Console.ReadLine();

            // Adicionando um novo produto

            //Apagar antes o produto caso o mesmo já tenha sido criado em testes anteriores!
            proxy.RemoverProduto("1111");

            Console.WriteLine();
            Console.WriteLine("Teste 1: Adicionar um novo produto cujo o nome será Produto 11");

            ProdutoDado produto11 = new ProdutoDado();
            produto11.NumeroProduto = "1111";
            produto11.NomeProduto = "Produto 11";
            produto11.DescricaoProduto = "Este é o produto 11";
            produto11.EstoqueProduto = 11;

            exibeResultadoDaOperacao(proxy.IncluirProduto(produto11));

            Console.WriteLine();

            // Removendo o produto 10

            //Criando antes o produto 10 para não dar falha na remoção
            ProdutoDado produto10 = new ProdutoDado();
            produto10.NumeroProduto = "10000";
            produto10.NomeProduto = "Produto 10";
            produto10.DescricaoProduto = "Este é o produto 10";
            produto10.EstoqueProduto = 2;
            proxy.IncluirProduto(produto10);

            Console.WriteLine();
            Console.WriteLine("Teste 2: Remover o produto 10");
            exibeResultadoDaOperacao(proxy.RemoverProduto("10000"));
            Console.WriteLine();


            //Listar todos os produtos
            Console.WriteLine();
            Console.WriteLine("Teste 3 - Listar todos os produtos");
            String[] produtos = proxy.ListarProdutos();
            foreach(string p in produtos)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine();

            //Mostrar detalhes do produto 2
            Console.WriteLine();
            Console.WriteLine("Teste 4: Mostrar detalhes do produto 2");
            ProdutoDado produto2 = proxy.VerProduto("2000");
            exibeDetalhesProduto(produto2);
            Console.WriteLine();

            //Adicionar 10 unidades para o prouto 2
            Console.WriteLine();
            Console.WriteLine("Teste 5: Adicionar 10 unidades do produto 2");
            exibeResultadoDaOperacao(proxy.AdicionarEstoque("2000", 10));
            Console.WriteLine();

            //Verificar novo estoque do produto 2
            Console.WriteLine();
            Console.WriteLine("Teste 6: Verificar novo estoque do produto 2");
            Console.WriteLine("Novo estoque do produto 2: " + proxy.ConsultarEstoque("2000"));
            Console.WriteLine();

            //Verificar estoque atual do produto 1
            Console.WriteLine();
            Console.WriteLine("Teste 7: Verificar estoque atual do produto 1");
            Console.WriteLine("Estoque atual do produto 1: " + proxy.ConsultarEstoque("1000"));
            Console.WriteLine();

            //Remover 20 unidades do estoque do prouto 1
            Console.WriteLine();
            Console.WriteLine("Teste 7: Remover 20 unidades do estoque do prouto 1");
            exibeResultadoDaOperacao(proxy.RemoverEstoque("1000", 20));
            Console.WriteLine();

            //Verificar novo estoque do produto 1
            Console.WriteLine();
            Console.WriteLine("Teste 8: Verificar novo estoque do produto 1");
            Console.WriteLine("Novo estoque do produto 1: " + proxy.ConsultarEstoque("1000"));
            Console.WriteLine();

            //Mostrar detalhes do produto 1
            Console.WriteLine();
            Console.WriteLine("Teste 4: Mostrar detalhes do produto 1");
            ProdutoDado produto1 = proxy.VerProduto("1000");
            exibeDetalhesProduto(produto1);
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Testes encerrados, Pressione qualquer tecla para fechar a janela!");
            Console.ReadLine();
            Console.Clear();

        }

        private static void exibeDetalhesProduto(ProdutoDado p)
        {
            Console.WriteLine("Numero do Produto: " + p.NumeroProduto);
            Console.WriteLine("Nome do Produto: " + p.NomeProduto);
            Console.WriteLine("Descrição do Produto: " + p.DescricaoProduto);
            Console.WriteLine("Quantidade em estoque do Produto: " + p.EstoqueProduto);
        }

        private static void exibeResultadoDaOperacao(Boolean b)
        {
            string resultado = b ? "Operação realizada com sucessso!" : "Falha na realização da operação!";
            Console.WriteLine(resultado);
        }
    }
}
