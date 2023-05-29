namespace e_Agenda.WinApp.ModuloTarefa
{
    public class Tarefa: EntidadeBase<Tarefa>
    {
        public string titulo;
        public string prioridade;
        public DateTime dataCriacao;
        public DateTime dataConclusao;
        public List<Item> itens;
        public string Percentual {
            get 
            {
                double completados = itens.FindAll(i => i.completado).Count;
                return itens.Count > 0 ? $"{Math.Round((completados / itens.Count) * 100,2)}%" : 
                    "Sem Itens";
            } 
        }

        public string DataConclusao
        {
            get
            {
               return dataConclusao == new DateTime() ? "Não concluído" :
               dataConclusao.ToString("dd/MM/yyyy");
            }
        }

        public Tarefa(string titulo, string prioridade, DateTime dataCriacao)
        {
            this.titulo = titulo;
            this.prioridade = prioridade;
            this.dataCriacao = dataCriacao;
            this.itens = new List<Item>();
        }

        public override string[] Validar()
        {
            List<string> erros = new List<string>();
            if (titulo.Trim() == "")
            {
                erros.Add("Título não pode ser vazio");
            }
            string[] prioridades = { "Baixa", "Normal", "Alta" };
            if (!prioridades.Contains(prioridade))
            {
                erros.Add("Prioridade não definida");
            }
            if(dataConclusao != new DateTime() && dataCriacao > dataConclusao)
            {
                erros.Add("Data de conlusão não pode ser menor que data de criação");
            }
            return erros.ToArray();
        }

        public override string ToString()
        {
            string data = dataConclusao == new DateTime() ? "Não concluído" : 
                dataConclusao.ToString();
            return "Id: " + id + ", Título:" + titulo + ", Prioridade: " + prioridade +
                ", DataCriação: " + dataCriacao.ToString() + ", DataConclusão: " +
                data + ", Percentual Concluído: " + Percentual;
        }

        public override void AtualizarInformacoes(Tarefa tarefa)
        {
            this.titulo = tarefa.titulo;
            this.prioridade = tarefa.prioridade;
        }
    }
}
