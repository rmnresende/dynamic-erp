using System.Collections.Generic;
using BaseManager.Models;

namespace BaseManager.Repository
{
    public class PessoaRepository : IPessoaRepository
    {
        public PessoaJuridica RecuperarPessoaFisicaPeloId(long id)
        {
            throw new System.NotImplementedException();
        }

        public PessoaJuridica RecuperarPessoaJuridicaPeloId(long id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<PessoaFisica> RecuperarPessoasFisicas()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<PessoaJuridica> RecuperarPessoasJuridicas()
        {
            throw new System.NotImplementedException();
        }
    }
}