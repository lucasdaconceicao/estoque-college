using EstoqueConsole.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueConsole.controllers
{
    class Fornecedor
    {
        public void CadastrarFornecedores(
                int telefoneFixo,
                int celular,
                string razaoSocial,
                string fantasia,
                int cnpj,
                int inscricaoEstadual,
                string email,
                string logradouro,
                int cep,
                int numero,
                string complemento,
                string referencia,
                string pais,
                string estado,
                string cidade,
                string bairro,
                string rua
            )
        {
            FornecedorModel fornecedor = new FornecedorModel();
            fornecedor.cadastrarFornecedor(
             telefoneFixo,
             celular,
             razaoSocial,
             fantasia,
             cnpj,
             inscricaoEstadual,
             email,
             logradouro,
             cep,
             numero,
             complemento,
             referencia,
             pais,
             estado,
             cidade,
             bairro,
             rua
             );
        }

        public void AlterarFornecedores(
            int idFornecedor,
            int telefoneFixo,
            int celular,
            string razaoSocial,
            string fantasia,
            int cnpj,
            int inscricaoEstadual,
            string email,
            string logradouro,
            int cep,
            int numero,
            string complemento,
            string referencia,
            string pais,
            string estado,
            string cidade,
            string bairro,
            string rua
        )
        {
            FornecedorModel fornecedor = new FornecedorModel();
            fornecedor.alterarFornecedor(
             idFornecedor,
             telefoneFixo,
             celular,
             razaoSocial,
             fantasia,
             cnpj,
             inscricaoEstadual,
             email,
             logradouro,
             cep,
             numero,
             complemento,
             referencia,
             pais,
             estado,
             cidade,
             bairro,
             rua
         );
        }

        public void RemoverFornecedor(int id)
        {
            var fornecedor = new FornecedorModel();
            fornecedor.removerFornecedor(id);
        }

        public FornecedorModel Listarfornecedor(string fantasia)
        {
            var fornecedor = new FornecedorModel();
            return fornecedor.listarFornecedor(fantasia);
        }

    }
}
