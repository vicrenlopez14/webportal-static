// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace WebAPI.Models
{
    /// <summary> The Admin. </summary>
    public partial class Admin
    {
        /// <summary> Initializes a new instance of Admin. </summary>
        public Admin()
        {
        }

        /// <summary> Initializes a new instance of Admin. </summary>
        /// <param name="idA"></param>
        /// <param name="nameA"></param>
        /// <param name="emailA"></param>
        /// <param name="telA"></param>
        /// <param name="passwordA"></param>
        /// <param name="pictureA"></param>
        /// <param name="idR1"></param>
        internal Admin(string idA, string nameA, string emailA, string telA, string passwordA, byte[] pictureA, string idR1)
        {
            IdA = idA;
            NameA = nameA;
            EmailA = emailA;
            TelA = telA;
            PasswordA = passwordA;
            PictureA = pictureA;
            IdR1 = idR1;
        }

        /// <summary> Gets or sets the id a. </summary>
        public string IdA { get; set; }
        /// <summary> Gets or sets the name a. </summary>
        public string NameA { get; set; }
        /// <summary> Gets or sets the email a. </summary>
        public string EmailA { get; set; }
        /// <summary> Gets or sets the tel a. </summary>
        public string TelA { get; set; }
        /// <summary> Gets or sets the password a. </summary>
        public string PasswordA { get; set; }
        /// <summary> Gets or sets the picture a. </summary>
        public byte[] PictureA { get; set; }
        /// <summary> Gets or sets the id r 1. </summary>
        public string IdR1 { get; set; }
    }
}
