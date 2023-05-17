using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace e_Agenda.WinApp.ModuloCompromisso
{
    public partial class ListagemCompromissoControl : UserControl
    {
        public ListagemCompromissoControl()
        {
            InitializeComponent();
        }

        public void AtualizarRegistros(List<Compromisso> compromissos)
        {
            listCompromisso.Items.Clear();

            foreach (Compromisso item in compromissos)
            {
                listCompromisso.Items.Add(item);
            }
        }

        public Compromisso ObterCompromissoSelecionado()
        {
            return (Compromisso)listCompromisso.SelectedItem;
        }

    }
}
