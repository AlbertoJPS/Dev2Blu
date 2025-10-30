using PetShoes.Model.Animais;
using System.Collections.Generic;

namespace PetShoes.Model.Ninhada
{
    public class NinhadaResponseModel
    {
        public Guid Id { get; set; }
        public AnimalResponseModel Mae { get; set; }
        public List<AnimalResponseModel> Filhotes { get; set; }
    }
}