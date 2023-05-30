namespace e_Agenda.WinApp.ModuloCompromisso
{
    public interface IRepositorioCompromisso : IRepositorioBase<Compromisso>
    {
        List<Compromisso> SelecionarAlternativa(Predicate<Compromisso> periodo);
    }
}
