using PetShoes.Model.Adotantes;
using PetShoes.Model.Animais;

namespace PetShoes.Model.Adocao
{
    public class AdocaoResponseModel
    {
        public Guid Id { get; set; }
        public AdotanteResponseModel Adotante { get; set; }
        public AnimalResponseModel Animal { get; set; }
        public DateTime DataAdocao { get; set; }
    }
}