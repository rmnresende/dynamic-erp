using System;
using System.Collections.Generic;

namespace BaseManager.Models
{
    public abstract class Pessoa
    {
        public long Id { get; set; }
        public string NomeOuNomeFantasia { get; set; }
        public long dataCriacaoTimestamp { get; set; }
        public List<Endereco> Enderecos { get; set; }
        public List<Telefone> Telefones { get; set; }
        public TipoRelacionamentoComercial TipoRelacionamentoComercial { get; set; }
    }
}