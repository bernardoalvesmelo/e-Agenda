using e_Agenda.Dominio.ModuloCompromisso;

namespace e_Agenda.Infra.Dados.Memoria.ModuloCompromisso
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
