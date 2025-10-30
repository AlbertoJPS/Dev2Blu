using PetShoes.Model.Animais;

namespace PetShoes.Model.Adotantes
{
    public class AdotanteResponseModel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Documento { get; set; }

        public List<AnimalResponseModel> AnimaisAdotados { get; set; } = new List<AnimalResponseModel>();
    }
}