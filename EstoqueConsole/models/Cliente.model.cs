using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueConsole.models
{
    class ClienteModel
    {
        public int id { get; set; }
        public int idTelefone { get; set; }
        public int idEndereco { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public DateTime nascimento { get; set; }
        public string email { get; set; }

        public List<ClienteModel> listarClientes()
        {
            var db = new estoqueEntities();

            List<ClienteModel> clientes = new List<ClienteModel>();

            clientes = db.CLIENTE.Select(x => new ClienteModel
            {
                id = x.idCLIENTE,
                idTelefone = x.TELEFONE_idTELEFONE,
                idEndereco = x.ENDERECO_idENDERECO,
                nome = x.NOME_CLIENTE,
                cpf = x.CPF,
                nascimento = x.DATA_NASC,
                email = x.EMAIL
            }).ToList();

            return clientes;
        }

        public ClienteModel listarCliente(string nome)
        {
            var db = new estoqueEntities();

            var cliente = db.CLIENTE.Where(x => x.NOME_CLIENTE == nome)
            .Select(x => new ClienteModel
            {
                id = x.idCLIENTE,
                idTelefone = x.TELEFONE_idTELEFONE,
                idEndereco = x.ENDERECO_idENDERECO,
                nome = x.NOME_CLIENTE,
                cpf = x.CPF,
                nascimento = x.DATA_NASC,
                email = x.EMAIL
            }).First();

            return cliente;
        }

        public void cadastrarCliente(
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
            var db = new estoqueEntities();

            Telefone telefoneObj = new Telefone();
            int telefone = telefoneObj.cadastrarTelefone(telefoneFixo, celular);
            EnderecoModel enderecoObj = new EnderecoModel();
            int endereco = enderecoObj.cadastrarEndereco(logradouro, cep, numero, complemento,
                referencia, pais, estado, cidade, bairro, rua);

            var cliente = db.CLIENTE.Create();
            cliente.TELEFONE_idTELEFONE = telefone;
            cliente.ENDERECO_idENDERECO = endereco;
            cliente.NOME_CLIENTE = nome;
            cliente.CPF = cpf;
            cliente.DATA_NASC = nascimento;
            cliente.EMAIL = email;

            db.CLIENTE.Add(cliente);
            db.SaveChanges();
        }

        public void alterarCliente(
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
            var db = new estoqueEntities();

            Telefone telefoneObj = new Telefone();
            int telefone = telefoneObj.cadastrarTelefone(telefoneFixo, celular);
            EnderecoModel enderecoObj = new EnderecoModel();
            int endereco = enderecoObj.cadastrarEndereco(logradouro, cep, numero, complemento,
                referencia, pais, estado, cidade, bairro, rua);

            var cliente = db.CLIENTE.Where(x => x.idCLIENTE == idCliente).Select(x => x).First();

            cliente.TELEFONE_idTELEFONE = telefone;
            cliente.ENDERECO_idENDERECO = endereco;
            cliente.NOME_CLIENTE = nome;
            cliente.CPF = cpf;
            cliente.DATA_NASC = nascimento;
            cliente.EMAIL = email;

            db.SaveChanges();
        }

        public void removerCliente(int id)
        {
            var db = new estoqueEntities();
            var cliente = db.CLIENTE.Where(x => x.idCLIENTE == id).Select(x => x).First();
            db.CLIENTE.Remove(cliente);

            db.SaveChanges();
        }
    }
}
