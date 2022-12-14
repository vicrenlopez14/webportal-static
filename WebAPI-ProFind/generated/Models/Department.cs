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

    public partial class Department
    {
        /// <summary>
        /// Initializes a new instance of the Department class.
        /// </summary>
        public Department()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Department class.
        /// </summary>
        public Department(int? idDp = default(int?), string nameDp = default(string))
        {
            IdDp = idDp;
            NameDp = nameDp;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "idDp")]
        public int? IdDp { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "nameDp")]
        public string NameDp { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (NameDp != null)
            {
                if (NameDp.Length > 30)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "NameDp", 30);
                }
                if (NameDp.Length < 0)
                {
                    throw new ValidationException(ValidationRules.MinLength, "NameDp", 0);
                }
            }
        }
    }
}
