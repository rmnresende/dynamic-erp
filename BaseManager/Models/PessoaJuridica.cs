namespace BaseManager.Models
{
    public class PessoaJuridica : Pessoa
    {
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public string InscEstatudal { get; set; }
    }
}