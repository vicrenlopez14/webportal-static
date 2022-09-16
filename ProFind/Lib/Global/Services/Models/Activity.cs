using System;
using System.Collections.Generic;

namespace ProFind.Lib.Global.Services
{
    public partial class Activity
    {
        public Activity()
        {

        }


        public Activity(string idA, string titleA, string descriptionA, DateTimeOffset? expectedBeginA, DateTimeOffset? expectedEndA, byte[] pictureA, string idPj1, string idT1, Project idPj1Navigation, Tag idT1Navigation, ICollection<Activitycomment> activitycomments, ICollection<Supportticket> supporttickets)
        {
            IdA = idA;
            TitleA = titleA;
            DescriptionA = descriptionA;
            ExpectedBeginA = expectedBeginA;
            ExpectedEndA = expectedEndA;
            PictureA = pictureA;
            IdPj1 = idPj1;
            IdT1 = idT1;
            IdPj1Navigation = idPj1Navigation;
            IdT1Navigation = idT1Navigation;
            Activitycomments = activitycomments;
            Supporttickets = supporttickets;
        }

        public override string ToString() => TitleA;
    }
}
