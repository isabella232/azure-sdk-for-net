// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    public partial class BigDataPoolResourceInfoListResult
    {
        internal static BigDataPoolResourceInfoListResult DeserializeBigDataPoolResourceInfoListResult(JsonElement element)
        {
            Optional<string> nextLink = default;
            Optional<IReadOnlyList<BigDataPoolResourceInfo>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<BigDataPoolResourceInfo> array = new List<BigDataPoolResourceInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BigDataPoolResourceInfo.DeserializeBigDataPoolResourceInfo(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new BigDataPoolResourceInfoListResult(nextLink.Value, Optional.ToList(value));
        }
    }
}
