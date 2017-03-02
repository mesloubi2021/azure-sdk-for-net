// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Logic.Models
{
    using Azure;
    using Management;
    using Logic;
    using Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The X12 validation override settings.
    /// </summary>
    public partial class X12ValidationOverride
    {
        /// <summary>
        /// Initializes a new instance of the X12ValidationOverride class.
        /// </summary>
        public X12ValidationOverride() { }

        /// <summary>
        /// Initializes a new instance of the X12ValidationOverride class.
        /// </summary>
        /// <param name="messageId">The message id on which the validation
        /// settings has to be applied.</param>
        /// <param name="validateEDITypes">The value indicating whether to
        /// validate EDI types.</param>
        /// <param name="validateXSDTypes">The value indicating whether to
        /// validate XSD types.</param>
        /// <param name="allowLeadingAndTrailingSpacesAndZeroes">The value
        /// indicating whether to allow leading and trailing spaces and
        /// zeroes.</param>
        /// <param name="validateCharacterSet">The value indicating whether to
        /// validate character Set.</param>
        /// <param name="trimLeadingAndTrailingSpacesAndZeroes">The value
        /// indicating whether to trim leading and trailing spaces and
        /// zeroes.</param>
        /// <param name="trailingSeparatorPolicy">The trailing separator
        /// policy. Possible values include: 'NotSpecified', 'NotAllowed',
        /// 'Optional', 'Mandatory'</param>
        public X12ValidationOverride(string messageId, bool validateEDITypes, bool validateXSDTypes, bool allowLeadingAndTrailingSpacesAndZeroes, bool validateCharacterSet, bool trimLeadingAndTrailingSpacesAndZeroes, TrailingSeparatorPolicy trailingSeparatorPolicy)
        {
            MessageId = messageId;
            ValidateEDITypes = validateEDITypes;
            ValidateXSDTypes = validateXSDTypes;
            AllowLeadingAndTrailingSpacesAndZeroes = allowLeadingAndTrailingSpacesAndZeroes;
            ValidateCharacterSet = validateCharacterSet;
            TrimLeadingAndTrailingSpacesAndZeroes = trimLeadingAndTrailingSpacesAndZeroes;
            TrailingSeparatorPolicy = trailingSeparatorPolicy;
        }

        /// <summary>
        /// Gets or sets the message id on which the validation settings has to
        /// be applied.
        /// </summary>
        [JsonProperty(PropertyName = "messageId")]
        public string MessageId { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether to validate EDI types.
        /// </summary>
        [JsonProperty(PropertyName = "validateEDITypes")]
        public bool ValidateEDITypes { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether to validate XSD types.
        /// </summary>
        [JsonProperty(PropertyName = "validateXSDTypes")]
        public bool ValidateXSDTypes { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether to allow leading and
        /// trailing spaces and zeroes.
        /// </summary>
        [JsonProperty(PropertyName = "allowLeadingAndTrailingSpacesAndZeroes")]
        public bool AllowLeadingAndTrailingSpacesAndZeroes { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether to validate character
        /// Set.
        /// </summary>
        [JsonProperty(PropertyName = "validateCharacterSet")]
        public bool ValidateCharacterSet { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether to trim leading and
        /// trailing spaces and zeroes.
        /// </summary>
        [JsonProperty(PropertyName = "trimLeadingAndTrailingSpacesAndZeroes")]
        public bool TrimLeadingAndTrailingSpacesAndZeroes { get; set; }

        /// <summary>
        /// Gets or sets the trailing separator policy. Possible values
        /// include: 'NotSpecified', 'NotAllowed', 'Optional', 'Mandatory'
        /// </summary>
        [JsonProperty(PropertyName = "trailingSeparatorPolicy")]
        public TrailingSeparatorPolicy TrailingSeparatorPolicy { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (MessageId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "MessageId");
            }
        }
    }
}

