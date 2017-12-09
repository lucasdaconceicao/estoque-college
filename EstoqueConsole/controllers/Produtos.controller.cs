using EstoqueConsole.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueConsole.controllers
{
    class Produtos
    {
        public void CadastrarProduto(string nome, int codBarras, int grupo, string unidade)
        {
            ProdutoModel produto = new ProdutoModel();
            produto.cadastrarProduto(nome, codBarras, grupo, unidade);
        }

        public void AlterarProduto(int codigo, string nome, int codBarras, int grupo, string unidade)
        {
            ProdutoModel produto = new ProdutoModel();
            produto.alterarProduto( codigo,  nome,  codBarras,  grupo,  unidade);
        }

        public void ExcluirProduto(int codigo)
        {
            var prod = new ProdutoModel();
            prod.removerProduto(codigo);
        }
    }
}
