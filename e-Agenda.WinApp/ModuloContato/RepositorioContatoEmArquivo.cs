namespace e_Agenda.WinApp.ModuloContato
{
    public class RepositorioContatoEmArquivo : RepositorioEmArquivoBase<Contato>,
        IRepositorioContato
    {
        
        public RepositorioContatoEmArquivo()
        {
        }

        protected override List<Contato> ObterRegistros()
        {
            return base.contexto.contatos;
        }
    }
}
