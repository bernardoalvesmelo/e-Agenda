namespace e_Agenda.WinApp.ModuloCompromisso
{
    public class RepositorioCompromisso
    {
        List<Compromisso> compromissos = new List<Compromisso>();
        private static int contador;

        public void Inserir(Compromisso compromisso)
        {
            contador++;
            compromisso.id = contador;
            compromissos.Add(compromisso);
        }

        public List<Compromisso> SelecionarTodos()
        {
            return compromissos;
        }
        
        public List<Compromisso> SelecionarAlternativa(Predicate<Compromisso> alternativa)
        {
            return compromissos.FindAll(alternativa);
        }

        public void Editar(Compromisso compromisso)
        {
        Compromisso compromissoSelecionado = SelecionarPorId(compromisso.id);

        compromissoSelecionado.assunto = compromisso.assunto;
        compromissoSelecionado.local = compromisso.local;
        compromissoSelecionado.data = compromisso.data;
        compromissoSelecionado.horaInicio = compromisso.horaInicio;
        compromissoSelecionado.horaTermino = compromisso.horaTermino;
        compromissoSelecionado.contatoCompromisso = compromisso.contatoCompromisso;
        }

        public Compromisso SelecionarPorId(int id)
        {
            return compromissos.FirstOrDefault(x => x.id == id);
        }

        public void Excluir(Compromisso compromisso)
        {
            compromissos.Remove(compromisso);
        }
    }
}
