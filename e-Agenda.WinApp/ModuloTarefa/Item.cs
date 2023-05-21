namespace e_Agenda.WinApp.ModuloTarefa
{
    public class Item
    {
        public int id;
        public string descricao;
        public bool completado;

        public Item(string descricao, bool completado)
        {
            this.descricao = descricao;
            this.completado = completado;
        }

        public override string ToString()
        {
            return descricao + (completado ? ", Completo": ", Incompleto");
        }
    }
}
