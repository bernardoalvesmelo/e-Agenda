using System.Text.RegularExpressions;

namespace e_Agenda.Dominio.ModuloContato
{
    [Serializable]
    public class Contato : EntidadeBase<Contato>
    {
 
        public string nome;
        public string telefone;
        public string email;
        public string cargo;
        public string empresa;

        public Contato()
        {

        }
        public Contato(string nome, string telefone, string email, string cargo, string empresa)
        {
            this.nome = nome;
            this.telefone = telefone;
            this.email = email;
            this.cargo = cargo; 
            this.empresa = empresa;
        }

        public override void AtualizarInformacoes(Contato contato)
        {
            this.nome = contato.nome;
            this.telefone = contato.telefone;
            this.email = contato.email;
            this.cargo = contato.cargo;
            this.empresa = contato.empresa;
        }

        public override string ToString()
        {
            return "Id: " + id + ", Nome: " + nome + ", Telefone: " + telefone + 
                ", Email:" + email + ", Cargo: " + cargo + ", Empresa: " + empresa;
        }

        public override string[] Validar()
        {
            List<string> erros = new List<string>();
            if (nome.Trim() == "")
            {
                erros.Add("Nome não pode ser vazio");
            }
            if (telefone.Trim() == "")
            {
                erros.Add("Telefone não pode ser vazio");
            }
            if (email.Trim() == "")
            {
                erros.Add("Nome não pode ser vazio");
            }
            if (cargo.Trim() == "")
            {
                erros.Add("Cargo não pode ser vazio");
            }
            if (empresa.Trim() == "")
            {
                erros.Add("Empresa não pode ser vazio");
            }
            if (!Regex.IsMatch(telefone,
                @"^\(?([0-9]{2})\)?[-. ]?([0-9]{5})[-. ]?([0-9]{4})$"))
            {
                erros.Add("Telefone está com formato incorreto");
            }
            if (!Regex.IsMatch(email,
                "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*"))
            {
                erros.Add("Email está com formato incorreto");
            }
            return erros.ToArray();
        }
    }
}
