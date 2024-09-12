namespace API_MVC.Models
{
    public class CadAnimal : BaseModel
    {
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public List<CHabilidades> Habilidades { get; private set; } = [];
    }
    public class CHabilidades : BaseModel
    {
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
    }
}
