using Produto;
using Produto.ServicoEstoque;
using System;

namespace ClienteIServicoEstoqueV2
{
    class Program
    {
        static void Main(string[] args)
        {
            ServicoEstoqueClient proxy = new ServicoEstoqueClient("ws2007HttpBinding_IServicoEstoqueV2");

            Console.WriteLine("Pressione qualquer tecla para inciar os testes! Aguarde antes a incialização do servidor!");
            Console.ReadLine();

            //Verificar o estoque atual do produto 1
            Console.WriteLine();
            Console.WriteLine("Teste 1: Verificar estoque atual do produto 1");
            Console.WriteLine("Estoque atual do produto 1: " + proxy.ConsultarEstoque("1000"));
            Console.WriteLine();

            //Adicionar 20 unidades do prouto 1
            Console.WriteLine();
            Console.WriteLine("Teste 2: Adicionar 20 unidades do produto 1");
            exibeResultadoDaOperacao(proxy.AdicionarEstoque("1000", 20));
            Console.WriteLine();

            //Verificar novo estoque do produto 1
            Console.WriteLine();
            Console.WriteLine("Teste 3: Verificar novo estoque do produto 1");
            Console.WriteLine("Novo estoque do produto 1: " + proxy.ConsultarEstoque("1000"));
            Console.WriteLine();

            //Verificar o estoque atual do produto 5
            Console.WriteLine();
            Console.WriteLine("Teste 4: Verificar estoque atual do produto 5");
            Console.WriteLine("Estoque atual do produto 5: " + proxy.ConsultarEstoque("5000"));
            Console.WriteLine();

            //Remover 10 unidades do prouto 5
            Console.WriteLine();
            Console.WriteLine("Teste 5: Remover 10 unidades do produto 5");
            exibeResultadoDaOperacao(proxy.RemoverEstoque("5000", 10));
            Console.WriteLine();

            //Verificar novo estoque do produto 5
            Console.WriteLine();
            Console.WriteLine("Teste 6: Verificar novo estoque do produto 5");
            Console.WriteLine("Novo estoque do produto 5: " + proxy.ConsultarEstoque("5000"));
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
