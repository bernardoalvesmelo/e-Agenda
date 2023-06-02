using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

using e_Agenda.Dominio.ModuloContato;
using e_Agenda.Dominio.ModuloCompromisso;
using e_Agenda.Dominio.ModuloTarefa;
using e_Agenda.Dominio.ModuloCategoria;
using e_Agenda.Dominio.ModuloDespesa;

namespace e_Agenda.Infra.Dados.Arquivo.Compartilhado
{
    [Serializable]
    public class ContextoDados
    {
        public const string ARQUIVO_FORMATO = "xml";

        private const string NOME_ARQUIVO = "Compartilhado\\e-Agenda." + ARQUIVO_FORMATO;

        public List<Contato> contatos;

        public List<Compromisso> compromissos;

        public List<Tarefa> tarefas;

        public List<Categoria> categorias;

        public List<Despesa> despesas;

        public ContextoDados()
        {
            contatos = new List<Contato>();
            compromissos = new List<Compromisso>();
            tarefas = new List<Tarefa>();
            categorias = new List<Categoria>();
            despesas = new List<Despesa>();
        }

        private static ContextoDados instancia;

        public static ContextoDados Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ContextoDados();
                    instancia.CarregarRegistrosDoArquivo();
                }
                return instancia;
            }
        }

        public virtual void CarregarRegistrosDoArquivo()
        {
            if (!File.Exists(NOME_ARQUIVO))
            {
                return;
            }
            switch (ARQUIVO_FORMATO)
            {
                case "bin":
                    CarregarRegistrosDoArquivoBin();
                    break;
                case "xml":
                    CarregarRegistrosDoArquivoXml();
                    break;
                case "json":
                    CarregarRegistrosDoArquivoJson();
                    break;
            }
        }

        protected virtual void CarregarRegistrosDoArquivoBin()
        {
            BinaryFormatter serializador = new BinaryFormatter();

            byte[] registroEmBytes = File.ReadAllBytes(NOME_ARQUIVO);

            if(registroEmBytes.Length < 2)
            {
                return;
            }

            MemoryStream registroStream = new MemoryStream(registroEmBytes);

            ContextoDados contexto = (ContextoDados)serializador.Deserialize(registroStream);

            AtualizarListas(contexto);

            ConsertarInconsistencias();
        }

        protected virtual void CarregarRegistrosDoArquivoXml()
        {
            XmlSerializer serializador = new XmlSerializer(typeof(ContextoDados));

            byte[] registroEmBytes = File.ReadAllBytes(NOME_ARQUIVO);

            if(registroEmBytes.Length < 2)
            {
                return;
            }

            MemoryStream registroStream = new MemoryStream(registroEmBytes);

            ContextoDados contexto = (ContextoDados)serializador.Deserialize(registroStream);

            AtualizarListas(contexto);

            ConsertarInconsistencias();
        }

        protected virtual void CarregarRegistrosDoArquivoJson()
        {
            JsonSerializerOptions opcoes = ObterConfiguracoes();

            string arquivoJson = File.ReadAllText(NOME_ARQUIVO);
            if(arquivoJson.Length <= 10)
            {
                return;
            }
            ContextoDados contexto = JsonSerializer.Deserialize<ContextoDados>(arquivoJson, opcoes);

            AtualizarListas(contexto);
        }

        private void AtualizarListas(ContextoDados contexto)
        {
            this.despesas = contexto.despesas;
            this.categorias = contexto.categorias;
            this.contatos = contexto.contatos;
            this.compromissos = contexto.compromissos;
            this.tarefas = contexto.tarefas;
        }

        public virtual void GravarRegistrosEmArquivo()
        {
            switch (ARQUIVO_FORMATO)
            {
                case "bin":
                    GravarRegistrosEmArquivoBin();
                    break;
                case "xml":
                    GravarRegistrosEmArquivoXml();
                    break;
                case "json":
                    GravarRegistrosEmArquivoJson();
                    break;
            }
        }

        protected virtual void GravarRegistrosEmArquivoBin()
        {
            BinaryFormatter serializador = new BinaryFormatter();

            MemoryStream registroStream = new MemoryStream();

            serializador.Serialize(registroStream, this);

            byte[] registrosEmBytes = registroStream.ToArray();

            File.WriteAllBytes(NOME_ARQUIVO, registrosEmBytes);
        }


        protected virtual void GravarRegistrosEmArquivoXml()
        {
            XmlSerializer serializador = new XmlSerializer(typeof(ContextoDados));

            MemoryStream registroStream = new MemoryStream();

            serializador.Serialize(registroStream, this);

            byte[] registrosEmBytes = registroStream.ToArray();

            File.WriteAllBytes(NOME_ARQUIVO, registrosEmBytes);
        }

        protected virtual void GravarRegistrosEmArquivoJson()
        {
            JsonSerializerOptions opcoes = ObterConfiguracoes();

            string arquivoJson = JsonSerializer.Serialize(this, opcoes);

            File.WriteAllText(NOME_ARQUIVO, arquivoJson);
        }

        private static JsonSerializerOptions ObterConfiguracoes()
        {
            JsonSerializerOptions opcoes = new JsonSerializerOptions();
            opcoes.IncludeFields = true;
            opcoes.WriteIndented = true;
            opcoes.ReferenceHandler = ReferenceHandler.Preserve;

            return opcoes;
        }

        private void ConsertarInconsistencias()
        {
            foreach (Despesa despesa in this.despesas)
            {
                List<Categoria> categorias = new List<Categoria>();
                foreach (Categoria categoria in despesa.categorias)
                {
                    categorias.Add(this.categorias.Find(c => c.id == categoria.id));
                }
                despesa.categorias = categorias;
            }
            foreach (Compromisso compromisso in this.compromissos)
            {
                compromisso.contatoCompromisso = this.contatos
                    .Find(c => c.id == compromisso.id);
            }
        }
    }
}
