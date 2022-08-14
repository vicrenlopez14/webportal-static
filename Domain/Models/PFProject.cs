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
    }
}