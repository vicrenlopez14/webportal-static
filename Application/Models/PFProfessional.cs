using System;
using Application.Services;
using Newtonsoft.Json;

namespace Application.Models
{
    public class PFProfessional
    {
        [JsonConstructor]
        public PFProfessional(string idP, string nameP, DateTime dateBirthP, string emailP, string passwordP,
            string sexP, string idCu1, string idPfs1, string idDp1)
        {
            IdP = idP;
            NameP = nameP;
            DateBirthP = dateBirthP;
            EmailP = emailP;
            PasswordP = passwordP;
            SexP = sexP;
            IdCU1 = idCu1;
            IdPFS1 = idPfs1;
            IdDP1 = idDp1;
        }

        public PFProfessional()
        {
        }

        public static PFProfessional Initialize(string id)
        {
            var infoTask = new PfProfessionalService().GetObjectAsync(id);
            infoTask.Wait();

            return infoTask.Result;
        }

        public string IdP { get; set; }
        public string NameP { get; set; }
        public DateTime DateBirthP { get; set; }
        public string EmailP { get; set; }
        public string PasswordP { get; set; }
        public string SexP { get; set; }

        public string DUIP { get; set; }

        public string AFPP { get; set; }

        public string ISSSP { get; set; }

        public string ZipCodeP { get; set; }

        public string SalaryP { get; set; }

        public DateTime HiringDate { get; set; }

        private string _idCU1;

        public string IdCU1
        {
            get => _idCU1;
            set
            {
                _idCU1 = value;
                Curriculum = PFCurriculum.Initialize(_idCU1);
            }
        }

        public PFCurriculum Curriculum { get; set; }

        private string _idPFS1;

        public string IdPFS1
        {
            get => _idPFS1;
            set
            {
                _idPFS1 = value;
                Profession = PFProfession.Initialize(_idPFS1);
            }
        }

        public PFProfession Profession { get; set; }

        private string _idDP1;

        public string IdDP1
        {
            get => _idDP1;
            set
            {
                _idDP1 = value;
                Department = PFDepartment.Initialize(_idDP1);
            }
        }

        public PFDepartment Department { get; set; }

        private string _idWDT1;

        public string IdWDT1
        {
            get => _idWDT1;
            set
            {
                _idWDT1 = value;
                WorkDayType = PFWorkDayType.Initialize(_idWDT1);
            }
        }

        public PFWorkDayType WorkDayType { get; set; }
    }
}