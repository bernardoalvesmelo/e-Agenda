namespace e_Agenda.WinApp.Compartilhado
{
    public abstract class ControladorBase
    {
        public abstract string ToolTipInserir { get; }

        public abstract string ToolTipEditar { get; }

        public virtual string ToolTipFiltrar { get { return "Filtro indisponível"; } }

        public virtual string ToolTipAdicionar { get { return "Adição indisponível"; } }

        public virtual string ToolTipConcluir { get { return "Conclusão indisponível"; } }

        public abstract string ToolTipExcluir { get; }

        public abstract bool InserirAbilitado { get; }

        public abstract bool EditarAbilitado { get; }

        public abstract bool ExcluirAbilitado { get; }

        public abstract bool FiltrarAbilitado { get; }

        public abstract bool ConcluirAbilitado { get; }

        public abstract bool AdicionarAbilitado { get; }

        public abstract void Inserir();

        public abstract void Editar();

        public abstract void Excluir();

        public virtual void Filtrar()
        {

        }

        public virtual void AdicionarItem()
        {

        }

        public virtual void Concluir()
        {

        }
        
        public abstract UserControl ObterListagem();

        public abstract string ObterTipoCadastro();
    }

}
