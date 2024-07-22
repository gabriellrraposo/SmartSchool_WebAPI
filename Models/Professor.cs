namespace SmartSchool_WebAPI.Models
{
    public class Professor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Disciplina { get; set; }

        public Professor(int id, string nome, string sobrenome, string disciplina)
        {
            Id = id;
            Nome = nome;
            Sobrenome = sobrenome;
            Disciplina = disciplina;
        }

        public Professor()
        {

        }

    }
}
