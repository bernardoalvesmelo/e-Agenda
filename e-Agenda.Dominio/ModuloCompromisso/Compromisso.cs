using e_Agenda.Dominio.ModuloContato;

namespace e_Agenda.Dominio.ModuloCompromisso
{
    [Serializable]
    public class Compromisso : EntidadeBase<Compromisso>
    {
        public string assunto;
        public string local;
        public DateTime data;
        public DateTime horaInicio;
        public DateTime horaTermino;
        public Contato contatoCompromisso;

        public string Contato
        {
            get
            {
                return contatoCompromisso == null ?
                "Sem Contato" : contatoCompromisso.nome;
            }
        }

        public Compromisso()
        {

        }

        public Compromisso(string assunto, string local, DateTime data, DateTime horaInicio, DateTime horaTermino, Contato contatoCompromisso)
        {
            this.assunto = assunto;
            this.local = local;
            this.data = data;
            this.horaInicio = horaInicio;
            this.horaTermino = horaTermino;
            this.contatoCompromisso = contatoCompromisso;
        }

        public override string[] Validar()
        {
            List<string> erros = new List<string>();
            if (assunto.Trim() == "")
            {
                erros.Add("Assunto não pode ser vazio");
            }
            if (local.Trim() == "")
            {
                erros.Add("Local não pode ser vazio");
            }
            if(horaInicio > horaTermino)
            {
                erros.Add("Hora de início não pode ser maior que hora de término");
            }
            return erros.ToArray();
        }

        public override string ToString()
        {
            string contato = contatoCompromisso == null ?
                " |Sem Contato|" : ", Contato: " + contatoCompromisso.nome;
            return "Id: " + id + ", Assunto: " + assunto + ", Local: " + local +
                ", Data: " + data.ToString() + ", HoraInício: " + horaInicio.ToString("HH:mm") + 
                ", HoraTérmino: " + horaTermino.ToString("HH:mm") + contato;
        }

        public override void AtualizarInformacoes(Compromisso compromisso)
        {
            this.assunto = compromisso.assunto;
            this.local = compromisso.local;
            this.data = compromisso.data;
            this.horaInicio = compromisso.horaInicio;
            this.horaTermino = compromisso.horaTermino;
            this.contatoCompromisso = compromisso.contatoCompromisso;
        }
    }
}
