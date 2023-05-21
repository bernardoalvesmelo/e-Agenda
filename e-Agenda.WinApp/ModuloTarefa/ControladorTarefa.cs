﻿using e_Agenda.WinApp.Compartilhado;

namespace e_Agenda.WinApp.ModuloTarefa
{
    public class ControladorTarefa : ControladorBase
    {
        private RepositorioTarefa repositorioTarefa;
        private ListagemTarefaControl listagemTarefa;

        public ControladorTarefa(RepositorioTarefa repositorioTarefa)
        {
            this.repositorioTarefa = repositorioTarefa;
        }
        public override string ToolTipInserir { get { return "Inserir nova Tarefa"; } }

        public override string ToolTipEditar { get { return "Editar Tarefa existente"; } }

        public override string ToolTipExcluir { get { return "Excluir Tarefa existente"; } }

        public override string ToolTipAdicionar { get { return "Adicionar Item de Tarefa existente"; } }

        public override string ToolTipFiltrar { get { return "Filtrar lista de Tarefas existentes"; } }

        public override string ToolTipConcluir { get { return "Concluir Item ou Tarefa existente"; } }

        public override bool InserirAbilitado { get { return true; } }

        public override bool EditarAbilitado { get { return true; } }

        public override bool ExcluirAbilitado { get { return true; } }

        public override bool FiltrarAbilitado { get { return true; } }

        public override bool ConcluirAbilitado { get { return true; } }

        public override bool AdicionarAbilitado { get { return true; } }

        public override void Inserir()
        {
            TelaTarefaForm telaTarefa = new TelaTarefaForm();

            DialogResult opcaoEscolhida = telaTarefa.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Tarefa tarefa = telaTarefa.Tarefa;
                repositorioTarefa.Inserir(tarefa);

                CarregarTarefas();
            }
        }

        public override void Editar()
        {
            Tarefa tarefa = listagemTarefa.ObterTarefaSelecionada();

            if (tarefa == null)
            {
                MessageBox.Show($"Selecione uma tarefa primeiro!",
                    "Edição de Tarefas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            TelaTarefaForm telaTarefa = new TelaTarefaForm();
            telaTarefa.DesabilitarDataCriacao();
            telaTarefa.Tarefa = tarefa;

            DialogResult opcaoEscolhida = telaTarefa.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioTarefa.Editar(telaTarefa.Tarefa);

                CarregarTarefas();
            }
        }

        public override void AdicionarItem()
        {
            Tarefa tarefa = listagemTarefa.ObterTarefaSelecionada();

            if (tarefa == null)
            {
                MessageBox.Show($"Selecione uma tarefa primeiro!",
                    "Adição de Itens",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            TelaTarefaListaForm telaTarefa = new TelaTarefaListaForm();
            telaTarefa.ListaItens = tarefa.itens;
            telaTarefa.CarregarItens();

            DialogResult opcaoEscolhida = telaTarefa.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioTarefa.InserirItem(tarefa, telaTarefa.Item);

                CarregarTarefas();
            }
        }

        public override void Filtrar()
        {
            Tarefa tarefa = listagemTarefa.ObterTarefaSelecionada();

            if (tarefa == null)
            {
                MessageBox.Show($"Selecione uma tarefa primeiro!",
                    "Adição de Itens",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            TelaTarefaFiltroForm telaTarefa = new TelaTarefaFiltroForm();

            DialogResult opcaoEscolhida = telaTarefa.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
               List<Tarefa> tarefas;
               switch(telaTarefa.Alternativa)
               {
                    case 1:
                        tarefas = repositorioTarefa.SelecionarAlternativa(t => t.Percentual == "100%");
                        break;
                    case 2:
                        tarefas = repositorioTarefa.SelecionarAlternativa(t => t.Percentual != "100%");
                        break;
                    case 3:
                        tarefas = repositorioTarefa.SelecionarPrioridadeOrdenada();
                        break;
                    default:
                        tarefas = repositorioTarefa.SelecionarTodos();
                        break;
                }
                listagemTarefa.AtualizarRegistros(tarefas);
            }
        }

        public override void Concluir()
        {
            Tarefa tarefa = listagemTarefa.ObterTarefaSelecionada();

            if (tarefa == null)
            {
                MessageBox.Show($"Selecione uma tarefa primeiro!",
                    "Conclusão de Tarefas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            if (tarefa.itens.Count == 0)
            {
                MessageBox.Show($"A tarefa não possui itens!",
                    "Conclusão de Tarefas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            if (tarefa.dataConclusao != new DateTime())
            {
                MessageBox.Show($"A tarefa já foi concluída!",
                    "Conclusão de Tarefas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            TelaTarefaCompletadoForm telaTarefa = new TelaTarefaCompletadoForm();
            telaTarefa.ListaItens = tarefa.itens.FindAll(t => !t.completado);
            telaTarefa.CarregarItens();

            DialogResult opcaoEscolhida = telaTarefa.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                tarefa.dataConclusao = telaTarefa.DataConclusao;
                repositorioTarefa.ConcluirItem(tarefa, telaTarefa.Item);

                CarregarTarefas();
            }
        }

        public override void Excluir()
        {
            Tarefa tarefa = listagemTarefa.ObterTarefaSelecionada();

            if (tarefa == null)
            {
                MessageBox.Show($"Selecione uma tarefa primeiro!",
                    "Exclusão de Tarefas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir a tarefa {tarefa.titulo}?", 
                "Exclusão de Tarefas",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioTarefa.Excluir(tarefa);

                CarregarTarefas();
            }
        }

        private void CarregarTarefas()
        {
            List<Tarefa> tarefas = repositorioTarefa.SelecionarTodos();

            listagemTarefa.AtualizarRegistros(tarefas);
        }

        public override UserControl ObterListagem()
        {
            if (listagemTarefa == null)
                listagemTarefa = new ListagemTarefaControl();

            CarregarTarefas();

            return listagemTarefa;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Tarefas";
        }
    }
}
