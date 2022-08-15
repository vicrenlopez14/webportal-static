using System;
using System.Collections.Generic;
using Application.Services;
using Newtonsoft.Json;

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
            infoTask.Wait();

            return infoTask.Result;
        }

        public static IEnumerable<PFActivity> InitializeFromProjectId(string projectId)
        {
            var infoTask = new PFActivityService().Search(new Dictionary<string, string>
            {
                {"IdPJ1", projectId},
            });
            infoTask.Wait();

            return infoTask.Result;
        }

        public string IdA { get; set; }
        public string TitleA { get; set; }
        public string DescriptionA { get; set; }
        public DateTime ExpectedBeginA { get; set; }
        public DateTime ExpectedEndA { get; set; }

        public byte[] PictureA { get; set; }

        public string IdPJ1 { get; set; }

        private string _idT1;

        public string IdT1
        {
            get => _idT1;
            set
            {
                _idT1 = value;
                Tag = PFTag.Initialize(_idT1);
            }
        }

        public PFTag Tag { get; set; }
    }
}