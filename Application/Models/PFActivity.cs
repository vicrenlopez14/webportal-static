using System;
using System.Collections.Generic;
using Application.Services;
using Newtonsoft.Json;
using Nito.AsyncEx.Synchronous;

namespace Application.Models
{
    public class PFActivity
    {
        [JsonConstructor]
        public PFActivity(string idA, string titleA, string descriptionA, DateTime expectedBeginA,
            DateTime expectedEndA, string idPj1, string idT1, byte[] pictureA)
        {
            IdA = idA;
            TitleA = titleA;
            DescriptionA = descriptionA;
            ExpectedBeginA = expectedBeginA;
            ExpectedEndA = expectedEndA;
            IdPJ1 = idPj1;
            IdT1 = idT1;
            PictureA = pictureA;
        }

        public PFActivity()
        {
        }

        public static PFActivity Initialize(string id)
        {
            var infoTask = new PFActivityService().GetObjectAsync(id);
            var result = infoTask.WaitAndUnwrapException();

            return result;
        }

        public static IEnumerable<PFActivity> InitializeFromProjectId(string projectId)
        {
            var infoTask = new PFActivityService().Search(new Dictionary<string, string>
            {
                {"IdPJ1", projectId},
            });
            var result = infoTask.WaitAndUnwrapException();

            return result;
        }

        public async void FillFromId(string id)
        {
            var result = await new PFActivityService().GetObjectAsync(id);

            IdA = result.IdA;
            TitleA = result.TitleA;
            DescriptionA = result.DescriptionA;
            ExpectedBeginA = result.ExpectedBeginA;
            ExpectedEndA = result.ExpectedEndA;
            IdPJ1 = result.IdPJ1;
            IdT1 = result.IdT1;
            if (!string.IsNullOrEmpty(IdT1))
                Tag.FillFromId(IdT1);
            PictureA = result.PictureA;
        }


        public string IdA { get; set; }
        public string TitleA { get; set; }
        public string DescriptionA { get; set; }
        public DateTime ExpectedBeginA { get; set; }
        public DateTime ExpectedEndA { get; set; }

        public byte[] PictureA { get; set; }

        public string IdPJ1 { get; set; }

        public string IdT1 { get; set; }

        public PFTag Tag { get; set; }
    }
}