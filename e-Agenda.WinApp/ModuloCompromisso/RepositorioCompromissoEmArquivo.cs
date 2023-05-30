namespace e_Agenda.WinApp.ModuloCompromisso
{
    public class RepositorioCompromissoEmArquivo : RepositorioEmArquivoBase<Compromisso>,
        IRepositorioCompromisso
    {
        private const string NOME_ARQUIVO_COMPROMISSOS = "C:\\temp\\compromissos\\dados-compromissos.bin";
        public RepositorioCompromissoEmArquivo() : base(NOME_ARQUIVO_COMPROMISSOS)
        {
        }

        public List<Compromisso> SelecionarAlternativa(Predicate<Compromisso> alternativa)
        {
            return base.listaRegistros.FindAll(alternativa);
        }
    }
}
