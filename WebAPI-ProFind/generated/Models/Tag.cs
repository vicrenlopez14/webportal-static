// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace WebAPI.Models
{
    /// <summary> The Tag. </summary>
    public partial class Tag
    {
        /// <summary> Initializes a new instance of Tag. </summary>
        public Tag()
        {
        }

        /// <summary> Initializes a new instance of Tag. </summary>
        /// <param name="idT"></param>
        /// <param name="nameT"></param>
        /// <param name="idPj1"></param>
        internal Tag(string idT, string nameT, string idPj1)
        {
            IdT = idT;
            NameT = nameT;
            IdPj1 = idPj1;
        }

        /// <summary> Gets or sets the id t. </summary>
        public string IdT { get; set; }
        /// <summary> Gets or sets the name t. </summary>
        public string NameT { get; set; }
        /// <summary> Gets or sets the id pj 1. </summary>
        public string IdPj1 { get; set; }
    }
}
