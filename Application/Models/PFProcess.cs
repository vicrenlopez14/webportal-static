using System;
using Application.Services;
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

        public async void FillFromId(string id)
        {
            var result = await new PfProcessService().GetObjectAsync(id);

            IdPR = result.IdPR;
            TitlePR = result.TitlePR;
            DescriptionPR = result.DescriptionPR;
            BeginDatePR = result.BeginDatePR;
            IdTag = result.IdTag;
            if (!string.IsNullOrEmpty(IdTag))
                Tag.FillFromId(IdTag);
            EndDatePR = result.EndDatePR;
        }


        public string IdPR { get; set; }
        public string TitlePR { get; set; }
        public string DescriptionPR { get; set; }
        public DateTime BeginDatePR { get; set; }
        public string IdTag { get; set; }
        public PFTag Tag { get; set; }
        public DateTime EndDatePR { get; set; }
    }
}