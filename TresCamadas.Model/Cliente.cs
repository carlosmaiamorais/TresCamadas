namespace TresCamadas.Model
{
    public class Cliente
    {
        public long Id { get; set; }
        public string Cpf { get; set; } 
        public string Nome { get; set; }
        public int Idade { get; set; }
        public DateTime DataNascimento { get; set; } 
    }
}
