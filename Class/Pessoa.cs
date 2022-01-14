namespace Cadastro_Pessoa.Class
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Documento { get; set; }
        
        public void TrocarNome(string novoNome)
        {
            Nome = novoNome;
        }
    }
}