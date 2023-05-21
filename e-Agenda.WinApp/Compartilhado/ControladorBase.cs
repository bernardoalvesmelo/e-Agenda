namespace e_Agenda.WinApp.Compartilhado
{
    public abstract class ControladorBase
    {
        public abstract string ToolTipInserir { get; }

        public abstract string ToolTipEditar { get; }

        public virtual string ToolTipFiltrar { get { return "Filtro indisponível"; } }

        public virtual string ToolTipExibir { get { return "Exibição indisponível"; } }

        public virtual string ToolTipAdicionar { get { return "Adição indisponível"; } }

        public abstract string ToolTipExcluir { get; }

        public abstract void Inserir();

        public abstract void Editar();

        public abstract void Excluir();

        public virtual void AdicionarItem()
        {

        }

        public abstract UserControl ObterListagem();

        public abstract string ObterTipoCadastro();
    }

}
