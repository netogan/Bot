using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bot.MegaSenaJSON.Models
{
    public class ResponseResultado
    {
        [JsonProperty("proximoConcurso")]
        public long ProximoConcurso { get; set; }

        [JsonProperty("concursoAnterior")]
        public long ConcursoAnterior { get; set; }

        [JsonProperty("forward")]
        public object Forward { get; set; }

        [JsonProperty("mensagens")]
        public object[] Mensagens { get; set; }

        [JsonProperty("concurso")]
        public long Concurso { get; set; }

        [JsonProperty("data")]
        public long Data { get; set; }

        [JsonProperty("resultado")]
        public string Resultado { get; set; }

        [JsonProperty("ganhadores")]
        public long Ganhadores { get; set; }

        [JsonProperty("ganhadores_quina")]
        public long GanhadoresQuina { get; set; }

        [JsonProperty("ganhadores_quadra")]
        public long GanhadoresQuadra { get; set; }

        [JsonProperty("valor")]
        public double Valor { get; set; }

        [JsonProperty("valor_quina")]
        public double ValorQuina { get; set; }

        [JsonProperty("valor_quadra")]
        public double ValorQuadra { get; set; }

        [JsonProperty("acumulado")]
        public long Acumulado { get; set; }

        [JsonProperty("valor_acumulado")]
        public long ValorAcumulado { get; set; }

        [JsonProperty("dtinclusao")]
        public long Dtinclusao { get; set; }

        [JsonProperty("prox_final_zero")]
        public long ProxFinalZero { get; set; }

        [JsonProperty("ac_final_zero")]
        public double AcFinalZero { get; set; }

        [JsonProperty("proxConcursoFinal")]
        public object ProxConcursoFinal { get; set; }

        [JsonProperty("observacao")]
        public object Observacao { get; set; }

        [JsonProperty("rowguid")]
        public string Rowguid { get; set; }

        [JsonProperty("ic_conferido")]
        public long IcConferido { get; set; }

        [JsonProperty("de_local_sorteio")]
        public string DeLocalSorteio { get; set; }

        [JsonProperty("no_cidade")]
        public string NoCidade { get; set; }

        [JsonProperty("sg_uf")]
        public string SgUf { get; set; }

        [JsonProperty("vr_estimativa")]
        public long VrEstimativa { get; set; }

        [JsonProperty("dt_proximo_concurso")]
        public long DtProximoConcurso { get; set; }

        [JsonProperty("vr_acumulado_especial")]
        public double VrAcumuladoEspecial { get; set; }

        [JsonProperty("vr_arrecadado")]
        public double VrArrecadado { get; set; }

        [JsonProperty("ic_concurso_especial")]
        public bool IcConcursoEspecial { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("rateioProcessamento")]
        public bool RateioProcessamento { get; set; }

        [JsonProperty("sorteioAcumulado")]
        public bool SorteioAcumulado { get; set; }

        [JsonProperty("concursoEspecial")]
        public long ConcursoEspecial { get; set; }

        [JsonProperty("ganhadoresPorUf")]
        public GanhadoresPorUf[] GanhadoresPorUf { get; set; }

        [JsonProperty("resultadoOrdenado")]
        public string ResultadoOrdenado { get; set; }

        [JsonProperty("dataStr")]
        public string DataStr { get; set; }

        [JsonProperty("dt_proximo_concursoStr")]
        public string DtProximoConcursoStr { get; set; }
    }
}
