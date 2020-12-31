namespace BaseManager.Models
{
    public class Telefone
    {
        public OperadoraTelefonia Operadora { get; set; }
        public string Numero { get; set; }
        public int DDD { get; set; }
        public int ramal { get; set; }
        public TipoTelefone Tipo;

    }
}