using System;
using System.Text.Json.Serialization;

namespace Domain.Models
{
    public class PFActivity
    {
        [JsonConstructor]
        public PFActivity(string idA, string titleA, string descriptionA, DateTime expectedBeginA,
            DateTime expectedEndA, string idPj1, string idT1)
        {
            IdA = idA;
            TitleA = titleA;
            DescriptionA = descriptionA;
            ExpectedBeginA = expectedBeginA;
            ExpectedEndA = expectedEndA;
            IdPJ1 = idPj1;
            IdT1 = idT1;
        }

        public string IdA { get; set; }
        public string TitleA { get; set; }
        public string DescriptionA { get; set; }
        public DateTime ExpectedBeginA { get; set; }
        public DateTime ExpectedEndA { get; set; }
        public string IdPJ1 { get; set; }
        public string IdT1 { get; set; }

        public PFTag Tag { get; set; }
    }
}