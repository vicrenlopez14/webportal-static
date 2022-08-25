// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace WebAPI.Models
{
    public partial class Activity : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(IdA))
            {
                if (IdA != null)
                {
                    writer.WritePropertyName("idA");
                    writer.WriteStringValue(IdA);
                }
                else
                {
                    writer.WriteNull("idA");
                }
            }
            if (Optional.IsDefined(TitleA))
            {
                if (TitleA != null)
                {
                    writer.WritePropertyName("titleA");
                    writer.WriteStringValue(TitleA);
                }
                else
                {
                    writer.WriteNull("titleA");
                }
            }
            if (Optional.IsDefined(DescriptionA))
            {
                if (DescriptionA != null)
                {
                    writer.WritePropertyName("descriptionA");
                    writer.WriteStringValue(DescriptionA);
                }
                else
                {
                    writer.WriteNull("descriptionA");
                }
            }
            if (Optional.IsDefined(ExpectedBeginA))
            {
                writer.WritePropertyName("expectedBeginA");
                writer.WriteObjectValue(ExpectedBeginA);
            }
            if (Optional.IsDefined(ExpectedEndA))
            {
                writer.WritePropertyName("expectedEndA");
                writer.WriteObjectValue(ExpectedEndA);
            }
            if (Optional.IsDefined(PictureA))
            {
                if (PictureA != null)
                {
                    writer.WritePropertyName("pictureA");
                    writer.WriteBase64StringValue(PictureA, "D");
                }
                else
                {
                    writer.WriteNull("pictureA");
                }
            }
            if (Optional.IsDefined(IdPj1))
            {
                if (IdPj1 != null)
                {
                    writer.WritePropertyName("idPj1");
                    writer.WriteStringValue(IdPj1);
                }
                else
                {
                    writer.WriteNull("idPj1");
                }
            }
            if (Optional.IsDefined(IdT1))
            {
                if (IdT1 != null)
                {
                    writer.WritePropertyName("idT1");
                    writer.WriteStringValue(IdT1);
                }
                else
                {
                    writer.WriteNull("idT1");
                }
            }
            writer.WriteEndObject();
        }

        internal static Activity DeserializeActivity(JsonElement element)
        {
            Optional<string> idA = default;
            Optional<string> titleA = default;
            Optional<string> descriptionA = default;
            Optional<DateOnly> expectedBeginA = default;
            Optional<DateOnly> expectedEndA = default;
            Optional<byte[]> pictureA = default;
            Optional<string> idPj1 = default;
            Optional<string> idT1 = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("idA"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        idA = null;
                        continue;
                    }
                    idA = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("titleA"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        titleA = null;
                        continue;
                    }
                    titleA = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("descriptionA"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        descriptionA = null;
                        continue;
                    }
                    descriptionA = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("expectedBeginA"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    expectedBeginA = DateOnly.DeserializeDateOnly(property.Value);
                    continue;
                }
                if (property.NameEquals("expectedEndA"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    expectedEndA = DateOnly.DeserializeDateOnly(property.Value);
                    continue;
                }
                if (property.NameEquals("pictureA"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        pictureA = null;
                        continue;
                    }
                    pictureA = property.Value.GetBytesFromBase64("D");
                    continue;
                }
                if (property.NameEquals("idPj1"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        idPj1 = null;
                        continue;
                    }
                    idPj1 = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("idT1"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        idT1 = null;
                        continue;
                    }
                    idT1 = property.Value.GetString();
                    continue;
                }
            }
            return new Activity(idA.Value, titleA.Value, descriptionA.Value, expectedBeginA.Value, expectedEndA.Value, pictureA.Value, idPj1.Value, idT1.Value);
        }
    }
}
