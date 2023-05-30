namespace e_Agenda.WinApp.ModuloCompromisso
{
    public class RepositorioCompromissoEmMemoria : RepositorioEmMemoriaBase<Compromisso>, 
        IRepositorioCompromisso
    {
        
        public List<Compromisso> SelecionarAlternativa(Predicate<Compromisso> alternativa)
        {
            return base.listaRegistros.FindAll(alternativa);
        }
    }
}
