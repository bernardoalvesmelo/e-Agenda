namespace e_Agenda.WinApp.ModuloContato
{
    public class RepositorioContatoEmArquivo : RepositorioEmArquivoBase<Contato>,
        IRepositorioContato
    {
        private const string NOME_ARQUIVO_CONTATOS = "ModuloContato\\contatos";
        public RepositorioContatoEmArquivo() : base(NOME_ARQUIVO_CONTATOS)
        {
        }
    }
}
