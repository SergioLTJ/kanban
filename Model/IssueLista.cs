using System;

namespace PiKanban.Model
{
    public class IssueLista
    {
        public IssueLista(string chave, string descricao)
        {
            Chave = chave;
            Descricao = descricao;
        }

        public string Chave { get; set; }

        public string Descricao { get; set; }

        public Tamanho? Tamanho { get; set; }

        public ConhecimentoTecnico? ConhecimentoTecnico { get; set; }

        public override string ToString()
        {
            return String.Format(
                "{0} - {1} | {2}/{3}",
                Chave,
                Descricao,
                (this.Tamanho.HasValue ? (char)this.Tamanho.Value : '?'),
                (this.ConhecimentoTecnico.HasValue ? (char)this.ConhecimentoTecnico.Value : '?'));
        }
    }
}
