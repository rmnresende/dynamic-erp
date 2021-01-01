using System.Collections.Generic;
using BaseManager.Models;

namespace BaseManager.Repository
{
    public class PessoaRepository : IPessoaRepository
    {
        public Pessoa RecuperarClientePeloId(long id)
        {
            var cliente = new PessoaFisica
            {
                Id = id,
                NomeOuNomeFantasia = "João",
                SobreNome = "Silva",
                Cpf = "0123456789",
                TipoRelacionamentoComercial = TipoRelacionamentoComercial.CLIENTE
            };

            return cliente;
        }

        public Pessoa RecuperarFornecedorPeloId(long id)
        {
            var fornecedor = new PessoaJuridica
            {
                Id = id,
                NomeOuNomeFantasia = "Omega Eletronica",
                RazaoSocial = "Omega Componentes Eletrônicos",
                Cnpj = "0123456789",
                TipoRelacionamentoComercial = TipoRelacionamentoComercial.FORNECEDOR
            };

            return fornecedor;
        }

        public IEnumerable<Pessoa> RecuperarCientes()
        {
            var cliente = new PessoaFisica
            {
                Id = 10,
                NomeOuNomeFantasia = "João",
                SobreNome = "Silva",
                Cpf = "0123456789",
                TipoRelacionamentoComercial = TipoRelacionamentoComercial.CLIENTE
            };

            var clienteFornecedor = new PessoaJuridica
            {
                Id = 50,
                NomeOuNomeFantasia = "Omega Eletronica",
                RazaoSocial = "Omega Componentes Eletrônicos",
                Cnpj = "0123456789",
                TipoRelacionamentoComercial = TipoRelacionamentoComercial.CLIENTE_E_FORNECEDOR
            };

            return new List<Pessoa>(){
                cliente,
                clienteFornecedor
            };
        }

        public IEnumerable<Pessoa> RecuperarFornecedores()
        {
            var cliente = new PessoaFisica
            {
                Id = 10,
                NomeOuNomeFantasia = "João",
                SobreNome = "Silva",
                Cpf = "0123456789",
                TipoRelacionamentoComercial = TipoRelacionamentoComercial.CLIENTE
            };

            var clienteFornecedor = new PessoaJuridica
            {
                Id = 50,
                NomeOuNomeFantasia = "Omega Eletronica",
                RazaoSocial = "Omega Componentes Eletrônicos",
                Cnpj = "0123456789",
                TipoRelacionamentoComercial = TipoRelacionamentoComercial.CLIENTE_E_FORNECEDOR
            };

            return new List<Pessoa>(){
                cliente,
                clienteFornecedor
            };
        }
    }
}