

using EstoqueConsole.controllers;
using EstoqueConsole.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EstoqueConsole.controllers
{
    class Cliente
    {
        public void CadastrarClientes(
            int telefoneFixo,
            int celular,
            string nome,
            string cpf,
            DateTime nascimento,
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
            ClienteModel clientes = new ClienteModel();
            clientes.cadastrarCliente(
                telefoneFixo,
                celular,
                nome,
                cpf,
                nascimento,
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

        public void AlterarClientes(
            int idCliente,
            int telefoneFixo,
            int celular,
            string nome,
            string cpf,
            DateTime nascimento,
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
            ClienteModel clientes = new ClienteModel();
            clientes.alterarCliente(int idCliente,
                telefoneFixo,
                celular,
                nome,
                cpf,
                nascimento,
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
        public void RemoverCliente(int id)
        {
            var cliente = new ClienteModel();
            cliente.removerCliente(id);
        }

        public void ListarCliente(string nome)
        {
            var clientes = new ClienteModel();
            clientes.listarCliente(nome);
        }

    }
}
