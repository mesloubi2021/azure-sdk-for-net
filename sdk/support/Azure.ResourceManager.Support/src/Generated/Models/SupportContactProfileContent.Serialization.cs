// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Support.Models
{
    public partial class SupportContactProfileContent : IUtf8JsonSerializable, IJsonModel<SupportContactProfileContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SupportContactProfileContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SupportContactProfileContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SupportContactProfileContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SupportContactProfileContent)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(FirstName))
            {
                writer.WritePropertyName("firstName"u8);
                writer.WriteStringValue(FirstName);
            }
            if (Optional.IsDefined(LastName))
            {
                writer.WritePropertyName("lastName"u8);
                writer.WriteStringValue(LastName);
            }
            if (Optional.IsDefined(PreferredContactMethod))
            {
                writer.WritePropertyName("preferredContactMethod"u8);
                writer.WriteStringValue(PreferredContactMethod.Value.ToString());
            }
            if (Optional.IsDefined(PrimaryEmailAddress))
            {
                writer.WritePropertyName("primaryEmailAddress"u8);
                writer.WriteStringValue(PrimaryEmailAddress);
            }
            if (Optional.IsCollectionDefined(AdditionalEmailAddresses))
            {
                writer.WritePropertyName("additionalEmailAddresses"u8);
                writer.WriteStartArray();
                foreach (var item in AdditionalEmailAddresses)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(PhoneNumber))
            {
                writer.WritePropertyName("phoneNumber"u8);
                writer.WriteStringValue(PhoneNumber);
            }
            if (Optional.IsDefined(PreferredTimeZone))
            {
                writer.WritePropertyName("preferredTimeZone"u8);
                writer.WriteStringValue(PreferredTimeZone);
            }
            if (Optional.IsDefined(Country))
            {
                writer.WritePropertyName("country"u8);
                writer.WriteStringValue(Country);
            }
            if (Optional.IsDefined(PreferredSupportLanguage))
            {
                writer.WritePropertyName("preferredSupportLanguage"u8);
                writer.WriteStringValue(PreferredSupportLanguage);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        SupportContactProfileContent IJsonModel<SupportContactProfileContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SupportContactProfileContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SupportContactProfileContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSupportContactProfileContent(document.RootElement, options);
        }

        internal static SupportContactProfileContent DeserializeSupportContactProfileContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string firstName = default;
            string lastName = default;
            PreferredContactMethod? preferredContactMethod = default;
            string primaryEmailAddress = default;
            IList<string> additionalEmailAddresses = default;
            string phoneNumber = default;
            string preferredTimeZone = default;
            string country = default;
            string preferredSupportLanguage = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("firstName"u8))
                {
                    firstName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastName"u8))
                {
                    lastName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("preferredContactMethod"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    preferredContactMethod = new PreferredContactMethod(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("primaryEmailAddress"u8))
                {
                    primaryEmailAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("additionalEmailAddresses"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    additionalEmailAddresses = array;
                    continue;
                }
                if (property.NameEquals("phoneNumber"u8))
                {
                    phoneNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("preferredTimeZone"u8))
                {
                    preferredTimeZone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("country"u8))
                {
                    country = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("preferredSupportLanguage"u8))
                {
                    preferredSupportLanguage = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SupportContactProfileContent(
                firstName,
                lastName,
                preferredContactMethod,
                primaryEmailAddress,
                additionalEmailAddresses ?? new ChangeTrackingList<string>(),
                phoneNumber,
                preferredTimeZone,
                country,
                preferredSupportLanguage,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SupportContactProfileContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SupportContactProfileContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SupportContactProfileContent)} does not support writing '{options.Format}' format.");
            }
        }

        SupportContactProfileContent IPersistableModel<SupportContactProfileContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SupportContactProfileContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSupportContactProfileContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SupportContactProfileContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SupportContactProfileContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
