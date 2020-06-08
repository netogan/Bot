using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bot.MegaSenaJSON.Models
{
    public class GanhadoresPorUf
    {
        [JsonProperty("proximoConcurso")]
        public object ProximoConcurso { get; set; }

        [JsonProperty("concursoAnterior")]
        public object ConcursoAnterior { get; set; }

        [JsonProperty("forward")]
        public object Forward { get; set; }

        [JsonProperty("mensagens")]
        public object[] Mensagens { get; set; }

        [JsonProperty("coLoteria")]
        public long CoLoteria { get; set; }

        [JsonProperty("nuConcurso")]
        public long NuConcurso { get; set; }

        [JsonProperty("sgUf")]
        public string SgUf { get; set; }

        [JsonProperty("qtGanhadores")]
        public long QtGanhadores { get; set; }

        [JsonProperty("noCidade")]
        public string NoCidade { get; set; }

        [JsonProperty("total")]
        public object Total { get; set; }

        [JsonProperty("icCanalEletronico")]
        public bool IcCanalEletronico { get; set; }
    }
}
