using e_Agenda.Dominio.ModuloCompromisso;

namespace e_Agenda.Infra.Dados.Arquivo.ModuloCompromisso
{
    public class RepositorioCompromissoEmArquivo : RepositorioEmArquivoBase<Compromisso>,
        IRepositorioCompromisso
    {
      
        public RepositorioCompromissoEmArquivo()
        {
        }

        public List<Compromisso> SelecionarAlternativa(Predicate<Compromisso> alternativa)
        {
            return ObterRegistros().FindAll(alternativa);
        }

        protected override List<Compromisso> ObterRegistros()
        {
            return base.contexto.compromissos;
        }
    }
}
