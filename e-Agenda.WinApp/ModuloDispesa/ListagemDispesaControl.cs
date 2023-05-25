using e_Agenda.WinApp.ModuloContato;

namespace e_Agenda.WinApp.ModuloDispesa
{
    public partial class ListagemDispesaControl : UserControl
    {
        public ListagemDispesaControl()
        {
            InitializeComponent();
        }

        public void AtualizarRegistros(List<Dispesa> dispesas)
        {
            listDispesas.Items.Clear();

            foreach (Dispesa item in dispesas)
            {
                listDispesas.Items.Add(item);
            }
        }

        public Dispesa ObterDispesaSelecionada()
        {
            return (Dispesa)listDispesas.SelectedItem;
        }
    }
}
