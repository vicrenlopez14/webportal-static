// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace WebAPI.Models
{
    public partial class Notification : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(IdN))
            {
                if (IdN != null)
                {
                    writer.WritePropertyName("idN");
                    writer.WriteStringValue(IdN);
                }
                else
                {
                    writer.WriteNull("idN");
                }
            }
            if (Optional.IsDefined(TitleN))
            {
                if (TitleN != null)
                {
                    writer.WritePropertyName("titleN");
                    writer.WriteStringValue(TitleN);
                }
                else
                {
                    writer.WriteNull("titleN");
                }
            }
            if (Optional.IsDefined(DescriptionN))
            {
                if (DescriptionN != null)
                {
                    writer.WritePropertyName("descriptionN");
                    writer.WriteStringValue(DescriptionN);
                }
                else
                {
                    writer.WriteNull("descriptionN");
                }
            }
            if (Optional.IsDefined(DateTimeIssuedN))
            {
                writer.WritePropertyName("dateTimeIssuedN");
                writer.WriteObjectValue(DateTimeIssuedN);
            }
            if (Optional.IsDefined(PictureN))
            {
                if (PictureN != null)
                {
                    writer.WritePropertyName("pictureN");
                    writer.WriteBase64StringValue(PictureN, "D");
                }
                else
                {
                    writer.WriteNull("pictureN");
                }
            }
            if (Optional.IsDefined(IdPj2))
            {
                if (IdPj2 != null)
                {
                    writer.WritePropertyName("idPj2");
                    writer.WriteStringValue(IdPj2);
                }
                else
                {
                    writer.WriteNull("idPj2");
                }
            }
            writer.WriteEndObject();
        }

        internal static Notification DeserializeNotification(JsonElement element)
        {
            Optional<string> idN = default;
            Optional<string> titleN = default;
            Optional<string> descriptionN = default;
            Optional<DateOnly> dateTimeIssuedN = default;
            Optional<byte[]> pictureN = default;
            Optional<string> idPj2 = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("idN"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        idN = null;
                        continue;
                    }
                    idN = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("titleN"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        titleN = null;
                        continue;
                    }
                    titleN = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("descriptionN"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        descriptionN = null;
                        continue;
                    }
                    descriptionN = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dateTimeIssuedN"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    dateTimeIssuedN = DateOnly.DeserializeDateOnly(property.Value);
                    continue;
                }
                if (property.NameEquals("pictureN"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        pictureN = null;
                        continue;
                    }
                    pictureN = property.Value.GetBytesFromBase64("D");
                    continue;
                }
                if (property.NameEquals("idPj2"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        idPj2 = null;
                        continue;
                    }
                    idPj2 = property.Value.GetString();
                    continue;
                }
            }
            return new Notification(idN.Value, titleN.Value, descriptionN.Value, dateTimeIssuedN.Value, pictureN.Value, idPj2.Value);
        }
    }
}
