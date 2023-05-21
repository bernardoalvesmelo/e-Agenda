namespace e_Agenda.WinApp.ModuloTarefa
{
    public class Tarefa
    {
        public int id;
        public string titulo;
        public string prioridade;
        public DateTime dataCriacao;
        public DateTime dataConclusao;
        public List<Item> itens;
        public string Percentual {
            get 
            {
                int completados = itens.FindAll(i => i.completado).Count;
                return itens.Count > 0 ? $"{completados / itens.Count * 100}%" : "Sem Itens";
            } 
        }

        public Tarefa(string titulo, string prioridade, DateTime dataCriacao)
        {
            this.id = id;
            this.titulo = titulo;
            this.prioridade = prioridade;
            this.dataCriacao = dataCriacao;
            this.itens = new List<Item>();
        }

        public override string ToString()
        {
            string data = dataConclusao == new DateTime() ? "Não concluído" : 
                dataConclusao.ToString();
            return "Id: " + id + ", Título:" + titulo + ", Prioridade: " + prioridade +
                ", DataCriação: " + dataCriacao.ToString() + ", DataConclusão: " +
                data + ", Percentual Concluído: " + Percentual;
        }
    }
}
