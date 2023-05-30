namespace e_Agenda.WinApp.ModuloTarefa
{
    [Serializable]
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
        public string[] Validar()
        {
            List<string> erros = new List<string>();
            if (descricao.Trim() == "")
            {
                erros.Add("Descrição não pode ser vazia");
            }
            return erros.ToArray();
        }

        public override string ToString()
        {
            return descricao + (completado ? ", Completo": ", Incompleto");
        }
    }
}
