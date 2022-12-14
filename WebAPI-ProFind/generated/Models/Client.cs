// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace WebAPI.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class Client
    {
        /// <summary>
        /// Initializes a new instance of the Client class.
        /// </summary>
        public Client()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Client class.
        /// </summary>
        public Client(string idC = default(string), string nameC = default(string), string emailC = default(string), string passwordC = default(string), byte[] pictureC = default(byte[]))
        {
            IdC = idC;
            NameC = nameC;
            EmailC = emailC;
            PasswordC = passwordC;
            PictureC = pictureC;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "idC")]
        public string IdC { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "nameC")]
        public string NameC { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "emailC")]
        public string EmailC { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "passwordC")]
        public string PasswordC { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pictureC")]
        public byte[] PictureC { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (IdC != null)
            {
                if (IdC.Length > 21)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "IdC", 21);
                }
                if (IdC.Length < 0)
                {
                    throw new ValidationException(ValidationRules.MinLength, "IdC", 0);
                }
            }
            if (NameC != null)
            {
                if (NameC.Length > 50)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "NameC", 50);
                }
                if (NameC.Length < 0)
                {
                    throw new ValidationException(ValidationRules.MinLength, "NameC", 0);
                }
            }
            if (EmailC != null)
            {
                if (EmailC.Length > 50)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "EmailC", 50);
                }
                if (EmailC.Length < 0)
                {
                    throw new ValidationException(ValidationRules.MinLength, "EmailC", 0);
                }
            }
            if (PasswordC != null)
            {
                if (PasswordC.Length > 64)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "PasswordC", 64);
                }
                if (PasswordC.Length < 0)
                {
                    throw new ValidationException(ValidationRules.MinLength, "PasswordC", 0);
                }
            }
        }
    }
}
