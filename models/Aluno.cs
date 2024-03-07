
namespace SistemaEscolar.models
{
    public class Aluno : Pessoa
    {
        public string Curso { get; set; }
        public string Periodo { get; set; }
        public string Turma { get; set; }
        public string Turno { get; set; }
    }
}