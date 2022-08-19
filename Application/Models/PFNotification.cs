using System;
using Application.Services;

namespace Application.Models
{
    public class PFNotification
    {
        public PFNotification(string idN, string titleN, string descriptionN, DateTimeOffset dateTimeIssuedN, byte[] pictureN,
            string idPj2)
        {
            IdN = idN;
            TitleN = titleN;
            DescriptionN = descriptionN;
            DateTimeIssuedN = dateTimeIssuedN;
            PictureN = pictureN;
            IdPJ2 = idPj2;
        }

        public PFNotification()
        {
        }

        public async void FillFromId(string id)
        {
            var result = await new PFNotificationService().GetObjectAsync(id);

            IdN = result.IdN;
            TitleN = result.TitleN;
            DescriptionN = result.DescriptionN;
            DateTimeIssuedN = result.DateTimeIssuedN;
            PictureN = result.PictureN;
            IdPJ2 = result.IdPJ2;
            if (!string.IsNullOrEmpty(IdPJ2))
                Project.FillFromId(IdPJ2);
        }

        public string IdN { get; set; }
        public string TitleN { get; set; }
        public string DescriptionN { get; set; }
        public DateTimeOffset DateTimeIssuedN { get; set; }
        public byte[] PictureN { get; set; }

        public string IdPJ2 { get; set; }

        public PFProject Project { get; set; }
    }
}