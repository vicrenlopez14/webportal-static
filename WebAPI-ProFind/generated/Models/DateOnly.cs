// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace WebAPI.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class DateOnly
    {
        /// <summary>
        /// Initializes a new instance of the DateOnly class.
        /// </summary>
        public DateOnly()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DateOnly class.
        /// </summary>
        public DateOnly(int? year = default(int?), int? month = default(int?), int? day = default(int?), int? dayOfWeek = default(int?), int? dayOfYear = default(int?), int? dayNumber = default(int?))
        {
            Year = year;
            Month = month;
            Day = day;
            DayOfWeek = dayOfWeek;
            DayOfYear = dayOfYear;
            DayNumber = dayNumber;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "year")]
        public int? Year { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "month")]
        public int? Month { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "day")]
        public int? Day { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dayOfWeek")]
        public int? DayOfWeek { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dayOfYear")]
        public int? DayOfYear { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dayNumber")]
        public int? DayNumber { get; private set; }

    }
}
