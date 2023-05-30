using System.Runtime.Serialization.Formatters.Binary;

namespace e_Agenda.WinApp.Compartilhado
{
    public class RepositorioEmArquivoBase<TEntidade>
        where TEntidade : EntidadeBase<TEntidade>
    {
        
        protected int contadorRegistros = 0;

        protected List<TEntidade> listaRegistros = new List<TEntidade>();

        protected string nomeArquivo = "C:\\temp\\registros\\dados-registros.bin";

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
            NomeArquivo = nomeArquivo;
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
            BinaryFormatter serializador = new BinaryFormatter();

            byte[] registroEmBytes = File.ReadAllBytes(NomeArquivo);

            MemoryStream registroStream = new MemoryStream(registroEmBytes);

            this.listaRegistros = (List<TEntidade>)serializador.Deserialize(registroStream);

            AtualizarContador();
        }

        protected virtual void AtualizarContador()
        {
            contadorRegistros = listaRegistros.Max(x => x.id);
        }

        protected virtual void GravarRegistrosEmArquivo()
        {
            BinaryFormatter serializador = new BinaryFormatter();

            MemoryStream registroStream = new MemoryStream();

            serializador.Serialize(registroStream, listaRegistros);

            byte[] registrosEmBytes = registroStream.ToArray();

            File.WriteAllBytes(NomeArquivo, registrosEmBytes);
        }
    }
}

