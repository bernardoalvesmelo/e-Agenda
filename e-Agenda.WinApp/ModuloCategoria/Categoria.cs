using e_Agenda.WinApp.ModuloDespesa;

namespace e_Agenda.WinApp.ModuloCategoria
{
    public class Categoria : EntidadeBase<Categoria>
    {
        public string titulo;
        public List<Despesa> despesas;

        public Categoria(string titulo)
        {
            this.titulo = titulo;
            this.despesas = new List<Despesa>();
        }

        public override void AtualizarInformacoes(Categoria categoria)
        {
            this.titulo = categoria.titulo;
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
