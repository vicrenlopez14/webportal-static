using System;
using Newtonsoft.Json;

namespace Application.Models
{
    public class PFProcess
    {
        [JsonConstructor]
        public PFProcess(string idPR, string titlePR, string descriptionPR, DateTime beginDatePR,
            string idTag, DateTime endDatePR)
        {
            IdPR = idPR;
            TitlePR = titlePR;
            DescriptionPR = descriptionPR;
            BeginDatePR = beginDatePR;
            IdTag = idTag;
            EndDatePR = endDatePR;
        }

        public PFProcess()
        {
        }

        public string IdPR { get; set; }
        public string TitlePR { get; set; }
        public string DescriptionPR { get; set; }
        public DateTime BeginDatePR { get; set; }
        public string IdTag { get; set; }
        public DateTime EndDatePR { get; set; }
    }
}