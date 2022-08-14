using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Domain.Models
{
    public class PFProfessional
    {
        public PFProfessional(string idP, string nameP, DateTime dateBirthP, string emailP, string passwordP,
            string sexP, string idCu1, string idJ1, string idPfs1, string idDp1)
        {
            IdP = idP;
            NameP = nameP;
            DateBirthP = dateBirthP;
            EmailP = emailP;
            PasswordP = passwordP;
            SexP = sexP;
            IdCU1 = idCu1;
            IdJ1 = idJ1;
            IdPFS1 = idPfs1;
            IdDP1 = idDp1;
        }

        public PFProfessional()
        {
        }

        [Column("IdP")] public string IdP { get; set; }
        [Column("NameP")] public string NameP { get; set; }
        [Column("DateBirthP")] public DateTime DateBirthP { get; set; }
        [Column("EmailP")] public string EmailP { get; set; }
        [Column("PasswordP")] public string PasswordP { get; set; }
        [Column("SexP")] public string SexP { get; set; }
        [Column("IdCU1")] public string IdCU1 { get; set; }
        public PFCurriculum Curriculum { get; set; }
        [Column("IdJ1")] public string IdJ1 { get; set; }
        public PFJob Job { get; set; }
        [Column("IdPFS1")] public string IdPFS1 { get; set; }
        public PFProfession Profession { get; set; }
        [Column("IdDP1")] public string IdDP1 { get; set; }
        public PFDepartment Department { get; set; }
    }
}