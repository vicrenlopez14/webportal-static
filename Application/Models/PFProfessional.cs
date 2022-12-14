using System;
using Application.Services;
using Newtonsoft.Json;
using Nito.AsyncEx.Synchronous;

namespace Application.Models
{
    public class PFProfessional
    {
        [JsonConstructor]
        public PFProfessional(string idP, string nameP, DateTimeOffset dateBirthP, string emailP, string passwordP, bool activeP, bool sexP, string duip, string afpp, string isssp, string zipCodeP, string salaryP, DateTimeOffset hiringDateP, byte[] pictureP, byte[] curriculum, string idPfs1, PFProfession profession, string idDp1, PFDepartment department, string idWdt1, PFWorkDayType workDayType)
        {
            IdP = idP;
            NameP = nameP;
            DateBirthP = dateBirthP;
            EmailP = emailP;
            PasswordP = passwordP;
            ActiveP = activeP;
            SexP = sexP;
            DUIP = duip;
            AFPP = afpp;
            ISSSP = isssp;
            ZipCodeP = zipCodeP;
            SalaryP = salaryP;
            HiringDateP = hiringDateP;
            PictureP = pictureP;
            Curriculum = curriculum;
            IdPFS1 = idPfs1;
            Profession = profession;
            IdDP1 = idDp1;
            Department = department;
            IdWDT1 = idWdt1;
            WorkDayType = workDayType;
        }

        public PFProfessional()
        {
            
        }

        public async void FillFromId(string id)
        {
            var result = await new PFProfessionalService().GetObjectAsync(id);

            IdP = result.IdP;
            NameP = result.NameP;
            DateBirthP = result.DateBirthP;
            EmailP = result.EmailP;
            PasswordP = result.PasswordP;
            ActiveP = result.ActiveP;
            SexP = result.SexP;
            DUIP = result.DUIP;
            AFPP = result.AFPP;
            ISSSP = result.ISSSP;
            ZipCodeP = result.ZipCodeP;
            SalaryP = result.SalaryP;
            HiringDateP = result.HiringDateP;
            PictureP = result.PictureP;
            Curriculum = result.Curriculum;
            IdPFS1 = result.IdPFS1;
            if (!string.IsNullOrEmpty(IdPFS1))
                Profession.FillFromId(IdPFS1);
            IdDP1 = result.IdDP1;
            if (!string.IsNullOrEmpty(IdDP1))
                Department.FillFromId(IdDP1);
            IdWDT1 = result.IdWDT1;
            if (!string.IsNullOrEmpty(IdWDT1))
                WorkDayType.FillFromId(IdWDT1);
        }

        public async void FillUp()
        {
            if (!string.IsNullOrEmpty(IdPFS1))
                Profession.FillFromId(IdPFS1);
            if (!string.IsNullOrEmpty(IdDP1))
                Department.FillFromId(IdDP1);
            if (!string.IsNullOrEmpty(IdWDT1))
                WorkDayType.FillFromId(IdWDT1);
        }

        public string IdP { get; set; }
        public string NameP { get; set; }
        public DateTimeOffset DateBirthP { get; set; }
        public string EmailP { get; set; }
        public string PasswordP { get; set; }
        public bool ActiveP { get; set; }
        public bool SexP { get; set; }

        public string DUIP { get; set; }

        public string AFPP { get; set; }

        public string ISSSP { get; set; }

        public string ZipCodeP { get; set; }

        public string SalaryP { get; set; }

        public DateTimeOffset HiringDateP { get; set; }

        public byte[] PictureP { get; set; }


        public string IdCU1 { get; set; }

        public byte[] Curriculum { get; set; }


        public string IdPFS1 { get; set; }
        public PFProfession Profession { get; set; }


        public string IdDP1 { get; set; }
        public PFDepartment Department { get; set; }


        public string IdWDT1 { get; set; }
        public PFWorkDayType WorkDayType { get; set; }
        public object PictureC { get; set; }
    }

    public class LoginProfessional
    {
        [JsonConstructor]
        public LoginProfessional(string emailP, string passwordP)
        {
            EmailP = emailP;
            PasswordP = passwordP;
        }

        public LoginProfessional()
        {
        }

        public string EmailP { get; }
        public string PasswordP { get; }
    }
}