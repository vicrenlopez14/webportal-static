using System.Text.Json.Serialization;

namespace Domain.Models
{
    public class PFProject
    {
        [JsonConstructor]
        public PFProject(string idPj, string titlePj, string descriptionPj)
        {
            IdPJ = idPj;
            TitlePJ = titlePj;
            DescriptionPJ = descriptionPj;
        }

        public string IdPJ { get; set; }
        public string TitlePJ { get; set; }
        public string DescriptionPJ { get; set; }

        public string IdPS1 { get; set; }

        public PFProjectStatus Status { get; set; }

        public string IdP1 { get; set; }

        public PFProfessional ResponsibleProfessional { get; set; }

        public string IdC1 { get; set; }

        public PFClient ResponsibleClient { get; set; }
    }
}