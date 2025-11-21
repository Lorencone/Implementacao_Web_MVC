namespace LHPet.Models
{
    public class Fornecedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public string Email { get; set; }
        public string Produto { get; set; }

        // Construtor
        public Fornecedor(int id, string nome, string cnpj, string email, string produto)
        {
            this.Id = id;
            this.Nome = nome;
            this.Cnpj = cnpj;
            this.Email = email;
            this.Produto = produto;           
        }

        /* Método para exibir informações do fornecedor
        public override string ToString()
        {
            return $"ID: {Id}, Nome: {Nome}, CNPJ: {Cnpj}, E-mail: {Email}, Produto: {Produto}";
        }*/
    }
}