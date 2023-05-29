using e_Agenda.WinApp.Compartilhado;

namespace e_Agenda.WinApp.ModuloCompromisso
{
    public class RepositorioCompromisso : RepositorioBase<Compromisso>
    {
        
        public List<Compromisso> SelecionarAlternativa(Predicate<Compromisso> alternativa)
        {
            return base.listaRegistros.FindAll(alternativa);
        }
    }
}
