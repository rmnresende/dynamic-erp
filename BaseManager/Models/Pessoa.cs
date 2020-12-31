using System;
using System.Collections.Generic;

namespace BaseManager.Models
{
    public abstract class Pessoa
    {
        string NomeOuNomeFantasia { get; set; }
        long dataCriacaoTimestamp { get; set; }
        List<Endereco> Enderecos { get; set; }
        List<Telefone> Telefones { get; set; }
        TipoRelacionamentoComercial TipoRelacionamentoComercial { get; set; }
    }
}