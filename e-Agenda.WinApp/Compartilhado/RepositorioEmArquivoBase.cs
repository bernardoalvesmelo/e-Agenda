using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace e_Agenda.WinApp.Compartilhado
{
    public class RepositorioEmArquivoBase<TEntidade>
        where TEntidade : EntidadeBase<TEntidade>
    {
        
        protected int contadorRegistros = 0;

        protected List<TEntidade> listaRegistros = new List<TEntidade>();

        protected string nomeArquivo = "registros";

        protected const string ARQUIVO_FORMATO = "bin";
        protected string NomeArquivo
        {
            get
            {
                return this.nomeArquivo;
            }
            set
            {
                this.nomeArquivo = value;
            }
        }

        public RepositorioEmArquivoBase(string nomeArquivo)
        {
            NomeArquivo = nomeArquivo + "." + ARQUIVO_FORMATO;
            if (File.Exists(NomeArquivo))
                CarregarRegistrosDoArquivo();
        }

        public virtual void Inserir(TEntidade registro)
        {
            contadorRegistros++;
            registro.id = contadorRegistros;
            listaRegistros.Add(registro);

            GravarRegistrosEmArquivo();
        }

        public virtual void Editar(TEntidade registroAtualizado)
        {
            TEntidade registroSelecionado = SelecionarPorId(registroAtualizado.id);

            registroSelecionado.AtualizarInformacoes(registroAtualizado);

            GravarRegistrosEmArquivo();
        }

        public virtual void Excluir(TEntidade registroSelecionado)
        {
            listaRegistros.Remove(registroSelecionado);

            GravarRegistrosEmArquivo();
        }

        public virtual TEntidade SelecionarPorId(int id)
        {
            TEntidade registro = listaRegistros.FirstOrDefault(x => x.id == id);

            return registro;
        }

        public virtual List<TEntidade> SelecionarTodos()
        {
            return listaRegistros;
        }

        protected virtual void CarregarRegistrosDoArquivo()
        {
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

            byte[] registroEmBytes = File.ReadAllBytes(NomeArquivo);

            MemoryStream registroStream = new MemoryStream(registroEmBytes);

            this.listaRegistros = (List<TEntidade>)serializador.Deserialize(registroStream);

            AtualizarContador();
        }

        protected virtual void CarregarRegistrosDoArquivoXml()
        {
            XmlSerializer serializador = new XmlSerializer(typeof(List<TEntidade>));

            byte[] registroEmBytes = File.ReadAllBytes(NomeArquivo);

            MemoryStream registroStream = new MemoryStream(registroEmBytes);

            this.listaRegistros = (List<TEntidade>)serializador.Deserialize(registroStream);

            AtualizarContador();
        }

        protected virtual void CarregarRegistrosDoArquivoJson()
        {
            JsonSerializerOptions opcoes = new JsonSerializerOptions();
            opcoes.IncludeFields = true;
            opcoes.ReferenceHandler = ReferenceHandler.Preserve;

            string arquivoJson = File.ReadAllText(NomeArquivo);
            this.listaRegistros = JsonSerializer.Deserialize<List<TEntidade>>(arquivoJson, opcoes);

            AtualizarContador();
        }

        protected virtual void AtualizarContador()
        {
            contadorRegistros = listaRegistros.Max(x => x.id);
        }

        protected virtual void GravarRegistrosEmArquivo()
        {
            switch(ARQUIVO_FORMATO)
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

            serializador.Serialize(registroStream, listaRegistros);

            byte[] registrosEmBytes = registroStream.ToArray();

            File.WriteAllBytes(NomeArquivo, registrosEmBytes);
        }


        protected virtual void GravarRegistrosEmArquivoXml()
        {
            XmlSerializer serializador = new XmlSerializer(typeof(List<TEntidade>));

            MemoryStream registroStream = new MemoryStream();

            serializador.Serialize(registroStream, listaRegistros);

            byte[] registrosEmBytes = registroStream.ToArray();

            File.WriteAllBytes(NomeArquivo, registrosEmBytes);
        }

        protected virtual void GravarRegistrosEmArquivoJson()
        {
            JsonSerializerOptions opcoes = new JsonSerializerOptions();
            opcoes.IncludeFields = true;
            opcoes.WriteIndented = true;
            opcoes.ReferenceHandler = ReferenceHandler.Preserve;

            string arquivoJson = JsonSerializer.Serialize(listaRegistros, opcoes);

            File.WriteAllText(NomeArquivo, arquivoJson);
        }
    }
}

