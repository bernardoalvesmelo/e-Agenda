namespace e_Agenda.Dominio.ModuloCompromisso
{
    public interface IRepositorioCompromisso : IRepositorioBase<Compromisso>
    {
        List<Compromisso> SelecionarAlternativa(Predicate<Compromisso> periodo);
    }
}
