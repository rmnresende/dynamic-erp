namespace BaseManager.Models
{
    public class PessoaFisica : Pessoa
    {
        public string SobreNome { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
    }
}