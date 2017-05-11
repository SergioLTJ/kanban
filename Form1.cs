using AnotherJiraRestClient;
using AnotherJiraRestClient.JiraModel;
using PiKanban.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PiKanban
{
    public partial class Form1 : Form
    {
        private List<IssueLista> _issues;
        private List<ListBox> _listasIssues;
        private IssueLista _issueSelecionada;

        public Form1()
        {
            InitializeComponent();

            _issues = new List<IssueLista>();

            _listasIssues = new List<ListBox>
            {
                lstBP,
                lstMP,
                lstAP,
                lstBM,
                lstMM,
                lstAM,
                lstBG,
                lstMG,
                lstAG
            };

            var jira = new JiraClient(new JiraAccount() { User = "sergio.tomio", Password = "456123@Capivara", ServerUrl = "http://jira.senior.com.br" });
            var issuesBacklog = jira.GetIssuesByJql("project = SDE AND type in (Story, Bug) AND status NOT IN (Done, Closed)  AND ((sprint not in openSprints() and sprint not in futureSprints()) or sprint IS EMPTY) ORDER BY RANK ASC", 0, Int32.MaxValue, new[] { "key", "summary" }).issues;

            //var issuesBacklog = issuesProjeto.issues
            //    .Where(issue => issue.fields.customfield_10004 == null ||
            //                    !issue.fields.customfield_10004.Any(sprint => sprint.Contains("completeDate=<null>")));

            //var issuesBacklog = new List<Issue>()
            //{
            //    new Issue() { key = "SDE-123", fields = new Fields() { summary = "Teste" } },
            //    new Issue() { key = "SDE-321", fields = new Fields() { summary = "Teste2" } },
            //    new Issue() { key = "SDE-456", fields = new Fields() { summary = "Teste3" } },
            //    new Issue() { key = "SDE-1", fields = new Fields() { summary = "Teste" } },
            //    new Issue() { key = "SDE-2", fields = new Fields() { summary = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" } },
            //    new Issue() { key = "SDE-3", fields = new Fields() { summary = "Teste3" } },
            //    new Issue() { key = "SDE-5", fields = new Fields() { summary = "Teste" } },
            //    new Issue() { key = "SDE-4", fields = new Fields() { summary = "Teste2" } },
            //    new Issue() { key = "SDE-6", fields = new Fields() { summary = "Teste3" } },
            //    new Issue() { key = "SDE-7", fields = new Fields() { summary = "Teste" } },
            //    new Issue() { key = "SDE-8", fields = new Fields() { summary = "Teste2" } },
            //    new Issue() { key = "SDE-9", fields = new Fields() { summary = "Teste3" } },
            //    new Issue() { key = "SDE-87", fields = new Fields() { summary = "Teste" } },
            //    new Issue() { key = "SDE-53", fields = new Fields() { summary = "Teste2" } },
            //    new Issue() { key = "SDE-64", fields = new Fields() { summary = "Teste3" } },
            //    new Issue() { key = "SDE-25", fields = new Fields() { summary = "Teste" } },
            //    new Issue() { key = "SDE-333", fields = new Fields() { summary = "Teste2" } },
            //    new Issue() { key = "SDE-477", fields = new Fields() { summary = "Teste3" } },
            //    new Issue() { key = "SDE-864", fields = new Fields() { summary = "Teste" } },
            //    new Issue() { key = "SDE-12356", fields = new Fields() { summary = "Teste2" } },
            //    new Issue() { key = "SDE-7777", fields = new Fields() { summary = "Teste3" } },
            //};

            foreach (var issue in issuesBacklog)
            {
                var issueLista = new IssueLista(issue.key, issue.fields.summary);
                _issues.Add(issueLista);

                lstIssues.Items.Add(issueLista.Chave, issueLista.ToString(), 0);
            }

            this.Resize += AtualizarTamanhos;

            tabControl1.MouseUp += DeselecionarIssue;
            lstIssues.MouseUp += DeselecionarIssue;
            tabPage1.MouseUp += DeselecionarIssue;

            lblTamP.MouseUp += DeselecionarIssue;
            lblTamM.MouseUp += DeselecionarIssue;
            lblTamG.MouseUp += DeselecionarIssue;
            lblConB.MouseUp += DeselecionarIssue;
            lblConM.MouseUp += DeselecionarIssue;
            lblConA.MouseUp += DeselecionarIssue;

            lstIssues.ItemSelectionChanged += LstIssues_ItemSelectionChanged;
            lstIssues.MouseDown += LstIssues_MouseClick;
            lstIssues.DrawItem += LstIssues_DrawItem;

            LigarEventos(lstBP, ConhecimentoTecnico.BAIXO, Tamanho.PEQUENA, lblConB, lblTamP);
            LigarEventos(lstMP, ConhecimentoTecnico.MEDIO, Tamanho.PEQUENA, lblConM, lblTamP);
            LigarEventos(lstAP, ConhecimentoTecnico.ALTO, Tamanho.PEQUENA, lblConA, lblTamP);

            LigarEventos(lstBM, ConhecimentoTecnico.BAIXO, Tamanho.MEDIA, lblConB, lblTamM);
            LigarEventos(lstMM, ConhecimentoTecnico.MEDIO, Tamanho.MEDIA, lblConM, lblTamM);
            LigarEventos(lstAM, ConhecimentoTecnico.ALTO, Tamanho.MEDIA, lblConA, lblTamM);

            LigarEventos(lstBG, ConhecimentoTecnico.BAIXO, Tamanho.GRANDE, lblConB, lblTamG);
            LigarEventos(lstMG, ConhecimentoTecnico.MEDIO, Tamanho.GRANDE, lblConM, lblTamG);
            LigarEventos(lstAG, ConhecimentoTecnico.ALTO, Tamanho.GRANDE, lblConA, lblTamG);

            AtualizarTamanhos(null, null);
        }

        private void LigarEventos(ListBox listaIssues, ConhecimentoTecnico conhecimento, Tamanho tamanho, Label labelConhecimento, Label labelTamanho)
        {
            listaIssues.MouseEnter += (s, e) => MudarCorLabelsVermelho(labelConhecimento, labelTamanho);
            listaIssues.MouseLeave += (s, e) => MudarCorLabelPreto(labelConhecimento, labelTamanho);
            listaIssues.MouseUp += (s, e) => AtualizarIssueSelecionada(listaIssues, conhecimento, tamanho, labelConhecimento, labelTamanho);
        }

        private void AtualizarIssueSelecionada(ListBox listaIssues, ConhecimentoTecnico conhecimento, Tamanho tamanho, Label labelConhecimento, Label labelTamanho)
        {
            if (_issueSelecionada != null)
            {
                _issueSelecionada.ConhecimentoTecnico = conhecimento;
                _issueSelecionada.Tamanho = tamanho;

                // Adicionar a issue selecionada para a lista em que ela foi jogada.
                listaIssues.Items.Add(_issueSelecionada);
                
                // Atualiza a descrição da issue na lista principal com o seu conhecimento técnico/tamanho.
                lstIssues.SelectedItems[0].Text = _issueSelecionada.ToString();

                // Deseleciona a issue.
                lstIssues.SelectedItems.Clear();

                // Remove a issue de outras listas que ela pode estar.
                foreach (var item in _listasIssues)
                {
                    if (item != listaIssues)
                    {
                        var issueAtual = item.Items.Cast<IssueLista>().FirstOrDefault(issue => issue.Chave == _issueSelecionada.Chave);

                        if (issueAtual != null)
                            item.Items.Remove(issueAtual);
                    }
                }

                MudarCorLabelPreto(labelConhecimento, labelTamanho);

                _issueSelecionada = null;
            }
        }

        private void LstIssues_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = false;
            var cor = e.Item.Selected ? Color.Red : Color.Black;
            e.Graphics.DrawString(e.Item.Text, e.Item.Font, new SolidBrush(cor), new RectangleF(e.Bounds.X, e.Bounds.Y, lstIssues.Bounds.Width - 10, e.Bounds.Height));
            e.Graphics.DrawLine(Pens.Black, lstIssues.Bounds.Left, e.Bounds.Bottom, lstIssues.Bounds.Right, e.Bounds.Bottom);
        }

        private void LstIssues_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            TratarCliqueLista();
        }

        private void LstIssues_MouseClick(object sender, MouseEventArgs e)
        {
            TratarCliqueLista();
        }

        private void TratarCliqueLista()
        {
            if (lstIssues.SelectedItems.Count > 0)
            {
                var issueSelecionada = _issues.FirstOrDefault(issue => issue.Chave == lstIssues.SelectedItems[0].Name);
                _issueSelecionada = issueSelecionada;
            }
        }

        private void DeselecionarIssue(object sender, MouseEventArgs e)
        {
            _issueSelecionada = null;
        }

        private void MudarCorLabelsVermelho(Label labelConhecimento, Label labelTamanho)
        {
            if (_issueSelecionada != null)
            {
                labelConhecimento.ForeColor = Color.Red;
                labelTamanho.ForeColor = Color.Red;
            }
        }

        private void MudarCorLabelPreto(Label labelConhecimento, Label labelTamanho)
        {
            if (_issueSelecionada != null)
            {
                labelConhecimento.ForeColor = Color.Black;
                labelTamanho.ForeColor = Color.Black;
            }
        }

        private void AtualizarTamanhos(object sender, EventArgs e)
        {
            var margem = 10;

            var topo1 = PercentualTopoTab(0.25f) + margem;
            var topo2 = PercentualTopoTab(0.50f) + margem;
            var topo3 = PercentualTopoTab(0.75f) + margem;

            var esquerda1 = PercentualDireitaTab(0.25f) + margem;
            var esquerda2 = PercentualDireitaTab(0.50f) + margem;
            var esquerda3 = PercentualDireitaTab(0.75f) + margem;

            lblTamP.Location = new Point(tabPage1.Left + 10, topo1);
            lblTamM.Location = new Point(tabPage1.Left + 10, topo2);
            lblTamG.Location = new Point(tabPage1.Left + 10, topo3);
            
            lblConA.Location = new Point(esquerda1, tabPage1.Top + 10);
            lblConM.Location = new Point(esquerda2, tabPage1.Top + 10);
            lblConB.Location = new Point(esquerda3, tabPage1.Top + 10);

            var largura = esquerda2 - esquerda1;
            var altura = topo2 - topo1;

            var metadeLargura = largura / 2;
            var metadeAltura = altura / 2;

            var tamanho = new Size(largura, altura);

            lstAP.Location = new Point(esquerda1 - metadeLargura, topo1 - metadeAltura);
            lstAP.Size = tamanho;
            lstMP.Location = new Point(esquerda2 - metadeLargura, topo1 - metadeAltura);
            lstMP.Size = tamanho;
            lstBP.Location = new Point(esquerda3 - metadeLargura, topo1 - metadeAltura);
            lstBP.Size = tamanho;

            lstAM.Location = new Point(esquerda1 - metadeLargura, topo2 - metadeAltura);
            lstAM.Size = tamanho;
            lstMM.Location = new Point(esquerda2 - metadeLargura, topo2 - metadeAltura);
            lstMM.Size = tamanho;
            lstBM.Location = new Point(esquerda3 - metadeLargura, topo2 - metadeAltura);
            lstBM.Size = tamanho;

            lstAG.Location = new Point(esquerda1 - metadeLargura, topo3 - metadeAltura);
            lstAG.Size = tamanho;
            lstMG.Location = new Point(esquerda2 - metadeLargura, topo3 - metadeAltura);
            lstMG.Size = tamanho;
            lstBG.Location = new Point(esquerda3 - metadeLargura, topo3 - metadeAltura);
            lstBG.Size = tamanho;
        }

        private int PercentualDireitaTab(float percentual)
        {
            return (int)((tabPage1.Right - tabPage1.Left) * percentual);
        }

        private int PercentualTopoTab(float percentual)
        {
            return (int)((tabPage1.Bottom - tabPage1.Top) * percentual);
        }
    }
}
