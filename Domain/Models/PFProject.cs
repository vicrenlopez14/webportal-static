using System.Text.Json.Serialization;

namespace Domain.Models
{
    public class PFProject
    {
        [JsonConstructor]
        public PFProject(string id, string title, string description)
        {
            Id = id;
            Title = title;
            Description = description;
        }


        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}