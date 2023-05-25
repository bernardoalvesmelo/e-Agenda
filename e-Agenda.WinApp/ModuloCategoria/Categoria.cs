using e_Agenda.WinApp.Compartilhado;
using e_Agenda.WinApp.ModuloDispesa;

namespace e_Agenda.WinApp.ModuloCategoria
{
    public class Categoria : EntidadeBase
    {
        public string titulo;
        public List<Dispesa> dispesas;

        public Categoria(string titulo)
        {
            this.titulo = titulo;
            this.dispesas = new List<Dispesa>();
        }

        public override string ToString()
        {
            return "Id: " + id + ", Titulo: " + titulo;
        }

        public override string[] Validar()
        {
            List<string> erros = new List<string>();
            if (titulo.Trim() == "")
            {
                erros.Add("Título não pode ser vazio");
            }
            return erros.ToArray();
        }
    }
}
