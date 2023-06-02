using e_Agenda.Dominio.ModuloContato;

namespace e_Agenda.Infra.Dados.Arquivo.ModuloContato
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
