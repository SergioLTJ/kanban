using AnotherJiraRestClient;
using AnotherJiraRestClient.JiraModel;
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
        public Form1()
        {
            InitializeComponent();

            //var jira = new JiraClient(new JiraAccount() { User = "sergio.tomio", Password = "456123@Capivara", ServerUrl = "http://jira.senior.com.br" });
            //var issuesProjeto = jira.GetIssuesByJql("project = SDE AND type in (Story, Bug) AND status != Done ORDER BY Rank ASC", 0, Int32.MaxValue, new[] { "key", "summary" });

            //var issuesBacklog = issuesProjeto.issues
            //    .Where(issue => issue.fields.customfield_10004 == null ||
            //                    !issue.fields.customfield_10004.Any(sprint => sprint.Contains("completeDate=<null>")));

            var issuesBacklog = new List<Issue>()
            {
                new Issue() { key = "SDE-123", fields = new Fields() { summary = "Teste" } },
                new Issue() { key = "SDE-321", fields = new Fields() { summary = "Teste2" } },
                new Issue() { key = "SDE-456", fields = new Fields() { summary = "Teste3" } },
            };

            foreach (var issue in issuesBacklog)
            {
                lstIssues.Items.Add(issue.key + " - " + issue.fields.summary);
            }

            this.ResizeEnd += Resize;

            Resize(null, null);
        }

        private void Resize(object sender, EventArgs e)
        {
            var margem = 10;

            var topo1 = PercentualTopoTab(0.25f) + margem;
            var topo2 = PercentualTopoTab(0.50f) + margem;
            var topo3 = PercentualTopoTab(0.75f) + margem;

            var esquerda1 = PercentualDireitaTab(0.25f) + margem;
            var esquerda2 = PercentualDireitaTab(0.50f) + margem;
            var esquerda3 = PercentualDireitaTab(0.75f) + margem;

            label1.Location = new Point(tabPage1.Left + 10, topo1);
            label2.Location = new Point(tabPage1.Left + 10, topo2);
            label3.Location = new Point(tabPage1.Left + 10, topo3);
            
            label4.Location = new Point(esquerda1, tabPage1.Top + 10);
            label5.Location = new Point(esquerda2, tabPage1.Top + 10);
            label6.Location = new Point(esquerda3, tabPage1.Top + 10);

            var largura = esquerda2 - esquerda1;
            var altura = topo2 - topo1;

            var metadeLargura = largura / 2;
            var metadeAltura = altura / 2;

            var tamanho = new Size(largura, altura);

            lstBP.Location = new Point(esquerda1 - metadeLargura, topo1 - metadeAltura);
            lstBP.Size = tamanho;
            lstMP.Location = new Point(esquerda2 - metadeLargura, topo1 - metadeAltura);
            lstMP.Size = tamanho;
            lstAP.Location = new Point(esquerda3 - metadeLargura, topo1 - metadeAltura);
            lstAP.Size = tamanho;

            lstBM.Location = new Point(esquerda1 - metadeLargura, topo2 - metadeAltura);
            lstBM.Size = tamanho;
            lstMM.Location = new Point(esquerda2 - metadeLargura, topo2 - metadeAltura);
            lstMM.Size = tamanho;
            lstAM.Location = new Point(esquerda3 - metadeLargura, topo2 - metadeAltura);
            lstAM.Size = tamanho;

            lstBG.Location = new Point(esquerda1 - metadeLargura, topo3 - metadeAltura);
            lstBG.Size = tamanho;
            lstMG.Location = new Point(esquerda2 - metadeLargura, topo3 - metadeAltura);
            lstMG.Size = tamanho;
            lstAG.Location = new Point(esquerda3 - metadeLargura, topo3 - metadeAltura);
            lstAG.Size = tamanho;
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
