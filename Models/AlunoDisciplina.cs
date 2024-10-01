namespace SmartSchool_WebAPI.Models
{
    public class AlunoDisciplina
    {
        public AlunoDisciplina() {}
        public AlunoDisciplina(int alunoid, int disciplinaid)
        {
            AlunoId = alunoid;
            DisciplinaId = disciplinaid;
        }
        public int AlunoId { get; set; }
        public Aluno Aluno { get; set; }
        public int DisciplinaId { get; set; }
        public Disciplina Disciplina { get; set; }
    }
}
