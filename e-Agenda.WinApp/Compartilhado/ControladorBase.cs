namespace e_Agenda.WinApp.Compartilhado
{
    public abstract class ControladorBase
    {
        public abstract string ToolTipInserir { get; }

        public abstract string ToolTipEditar { get; }

        public abstract string ToolTipExcluir { get; }

        public virtual string ToolTipFiltrar { get { return "Filtro indisponível"; } }

        public virtual string ToolTipAdicionar { get { return "Adição indisponível"; } }

        public virtual string ToolTipConcluir { get { return "Conclusão indisponível"; } }

        public virtual string ToolTipVisualizar { get { return "Visualização indisponível"; } }

        public virtual bool InserirHabilitado { get { return true; } }

        public virtual bool EditarHabilitado { get { return true; } }

        public virtual bool ExcluirHabilitado { get { return true; } }

        public virtual bool FiltrarHabilitado { get { return false; } }

        public virtual bool ConcluirHabilitado { get { return false; } }

        public virtual bool AdicionarHabilitado { get { return false; } }

        public virtual bool VisualizarHabilitado { get { return false; } }

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

        public virtual void Visualizar()
        {

        }
        
        public abstract UserControl ObterListagem();

        public abstract string ObterTipoCadastro();
    }

}
