using System;

namespace Application.Models
{
    public class PFNotification
    {
        public PFNotification(string idN, string titleN, string descriptionN, DateTime dateTimeIssuedN, byte[] pictureN,
            string idPj2)
        {
            IdN = idN;
            TitleN = titleN;
            DescriptionN = descriptionN;
            DateTimeIssuedN = dateTimeIssuedN;
            PictureN = pictureN;
            IdPJ2 = idPj2;
        }

        public string IdN { get; set; }
        public string TitleN { get; set; }
        public string DescriptionN { get; set; }
        public DateTime DateTimeIssuedN { get; set; }
        public byte[] PictureN { get; set; }
        private string _idPJ2;

        public string IdPJ2
        {
            get => _idPJ2;
            set
            {
                _idPJ2 = value;
                Project = PFProject.Initialize(_idPJ2);
            }
        }

        public PFProject Project { get; set; }
    }
}