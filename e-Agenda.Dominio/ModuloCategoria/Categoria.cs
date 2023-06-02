namespace e_Agenda.Dominio.ModuloCategoria
{
    [Serializable]
    public class Categoria : EntidadeBase<Categoria>
    {
        public string titulo;

        public Categoria()
        {

        }
        public Categoria(string titulo)
        {
            this.titulo = titulo;
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
