using System.Collections.Generic;
using BaseManager.Models;

namespace BaseManager.Repository
{
    public interface IPessoaRepository
    {
        IEnumerable<PessoaJuridica> RecuperarPessoasJuridicas();
        IEnumerable<PessoaFisica> RecuperarPessoasFisicas();
        PessoaJuridica RecuperarPessoaJuridicaPeloId(long id);
        PessoaJuridica RecuperarPessoaFisicaPeloId(long id);
    }
}