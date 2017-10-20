using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Produto;

namespace ProvedorEstoqueHost
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost ProvedorEstoqueHost = new ServiceHost(typeof(ServicoEstoque));
            ProvedorEstoqueHost.Open();
            Console.WriteLine("Servico Rodando, pressione uma tecla quando desejar encerrá-lo!");
            Console.ReadLine();
            Console.WriteLine("Encerrando Servico");
            ProvedorEstoqueHost.Close();
        }
    }
}
