using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Produto
{
    [ServiceContract(Namespace = "http://projetoavaliativo.dm113/01", Name = "IServicoEstoque")]
    public interface IServicoEstoque
    {
        [OperationContract]
        List<String> ListarProdutos();

        [OperationContract]
        Boolean IncluirProduto(ProdutoDado produto);

        [OperationContract]
        Boolean RemoverProduto(string NumeroProduto);

        [OperationContract]
        decimal ConsultarEstoque(string NumeroProduto);

        [OperationContract]
        Boolean AdicionarEstoque(string NumeroProduto, decimal Quantidade);

        [OperationContract]
        Boolean RemoverEstoque(string NumeroProduto, decimal Quantidade);

        [OperationContract]
        ProdutoDado VerProduto(string NumeroProduto);
    }

    [ServiceContract(Namespace = "http://projetoavaliativo.dm113/02", Name = "IServicoEstoque")]
    public interface IServicoEstoqueV2
    {
        [OperationContract]
        decimal ConsultarEstoque(string NumeroProduto);

        [OperationContract]
        Boolean AdicionarEstoque(string NumeroProduto, decimal Quantidade);

        [OperationContract]
        Boolean RemoverEstoque(string NumeroProduto, decimal Quantidade);
    }

    [DataContract]
    public class ProdutoDado
    {
        [DataMember]
        public string NumeroProduto;

        [DataMember]
        public string NomeProduto;

        [DataMember]
        public string DescricaoProduto;

        [DataMember]
        public decimal EstoqueProduto;
    }
}
