namespace e_Agenda.WinApp.ModuloTarefa
{
    public class Tarefa
    {
        public int id;
        public string titulo;
        public string prioridade;
        public DateTime dataCriacao;
        public DateTime dataConclusao;
        public decimal Percentual { get; set; }

        public Tarefa(string titulo, string prioridade, DateTime dataCriacao)
        {
            this.id = id;
            this.titulo = titulo;
            this.prioridade = prioridade;
            this.dataCriacao = dataCriacao;
        }

        public override string ToString()
        {
            return "Id: " + id + ", Título:" + titulo + ", Prioridade: " + prioridade +
                ", DataCriação: " + dataCriacao.ToString() + ", DataConclusão: " +
                dataConclusao.ToString() + ", Percentual Concluído: " + Percentual;
        }
    }
}
