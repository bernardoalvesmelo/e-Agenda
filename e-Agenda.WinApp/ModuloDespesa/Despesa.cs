using e_Agenda.WinApp.Compartilhado;
using e_Agenda.WinApp.ModuloCategoria;

namespace e_Agenda.WinApp.ModuloDespesa
{
    public class Despesa : EntidadeBase
    {
        public string descricao;
        public decimal valor;
        public DateTime data;
        public FormasPagamentoEnum formaPagamento;

        public List<Categoria> categorias;

        public Despesa(string descricao, decimal valor, DateTime data, FormasPagamentoEnum formaPagamento)
        {
            this.descricao = descricao;
            this.valor = valor;
            this.data = data;
            this.formaPagamento = formaPagamento;
            this.categorias = new List<Categoria>();
        }

        public override string ToString()
        {
            return "Id: " + id + ", Descrição: " + descricao + ", Valor: R$" 
                + Math.Round(valor, 2) + ", Data: " + data.Date 
                + ", Pagamento: " + formaPagamento;
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
