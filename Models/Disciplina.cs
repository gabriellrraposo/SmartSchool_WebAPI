﻿namespace SmartSchool_WebAPI.Models
{
    public class Disciplina
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int ProfessorId { get; set; }
        public Professor? Professor { get; set; }
        public IEnumerable<AlunoDisciplina> AlunosDisciplinas { get; set; }


        public Disciplina() {}
        public Disciplina(int id, string nome, int professorid)
        {
            Id = id;
            Nome = nome;
            ProfessorId = professorid;
        }

    }
}
