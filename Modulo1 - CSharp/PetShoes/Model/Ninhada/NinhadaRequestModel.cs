using PetShoes.Model.Animais;
using System.Collections.Generic;

namespace PetShoes.Model.Ninhada
{
    public class NinhadaRequestModel
    {
        public Guid MaeId { get; set; }
        public List<AnimalRequestModel> Filhotes { get; set; }
    }
}