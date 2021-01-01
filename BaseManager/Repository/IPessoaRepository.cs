using System.Collections.Generic;
using BaseManager.Models;

namespace BaseManager.Repository
{
    public interface IPessoaRepository
    {
        IEnumerable<Pessoa> RecuperarFornecedores();
        IEnumerable<Pessoa> RecuperarCientes();
        Pessoa RecuperarFornecedorPeloId(long id);
        Pessoa RecuperarClientePeloId(long id);
    }
}