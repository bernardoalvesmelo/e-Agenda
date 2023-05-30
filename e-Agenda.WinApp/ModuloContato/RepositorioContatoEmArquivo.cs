namespace e_Agenda.WinApp.ModuloContato
{
    public class RepositorioContatoEmArquivo : RepositorioEmArquivoBase<Contato>,
        IRepositorioContato
    {
        private const string NOME_ARQUIVO_CONTATOS = "C:\\temp\\contatos\\dados-contatos.bin";
        public RepositorioContatoEmArquivo() : base(NOME_ARQUIVO_CONTATOS)
        {
        }
    }
}
