using e_Agenda.WinApp.Compartilhado;
using e_Agenda.WinApp.ModuloCategoria;

namespace e_Agenda.WinApp.ModuloDispesa
{
    public class Dispesa : EntidadeBase
    {
        public string descricao;
        public decimal valor;
        public DateTime data;
        public FormasPagamento formaPagamento;

        public List<Categoria> categorias;


        public override string ToString()
        {
            return "Id: " + id + ", Descrição: " + descricao;
        }

        public override string[] Validar()
        {
            List<string> erros = new List<string>();
            if (descricao.Trim() == "")
            {
                erros.Add("Descrição não pode ser vazia");
            }
            return erros.ToArray();
        }
    }
}
