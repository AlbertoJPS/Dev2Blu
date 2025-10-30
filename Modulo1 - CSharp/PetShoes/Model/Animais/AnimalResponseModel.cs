namespace PetShoes.Model.Animais
{
    public class AnimalResponseModel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Cor { get; set; }
        public int IdadeEmMeses { get; set; }

        public Guid? MaeId { get; set; }
    }
}
