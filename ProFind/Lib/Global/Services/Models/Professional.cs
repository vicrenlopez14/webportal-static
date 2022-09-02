using System;

namespace ProFind.Lib.Global.Services.Models
{
    public partial class Professional
    {
        private string v1;
        private string text1;
        private string dayFormat;
        private string text2;
        private string password;
        private bool v2;
        private bool v3;
        private string text3;
        private string text4;
        private string text5;
        private string text6;
        private int v4;
        private DateTimeOffset? date;
        private byte[] imageBytes;
        private byte[] curriculo;
        private int? ids;
        private int? idDp;

        public Professional(string v1, string text1, string dayFormat, string text2, string password, bool v2, bool v3, string text3, string text4, string text5, string text6, int v4, DateTimeOffset? date, byte[] imageBytes, byte[] curriculo, int? ids, int? idDp)
        {
            this.v1 = v1;
            this.text1 = text1;
            this.dayFormat = dayFormat;
            this.text2 = text2;
            this.password = password;
            this.v2 = v2;
            this.v3 = v3;
            this.text3 = text3;
            this.text4 = text4;
            this.text5 = text5;
            this.text6 = text6;
            this.v4 = v4;
            this.date = date;
            this.imageBytes = imageBytes;
            this.curriculo = curriculo;
            this.ids = ids;
            this.idDp = idDp;
        }

        public override string ToString() => NameP;
    }
}
