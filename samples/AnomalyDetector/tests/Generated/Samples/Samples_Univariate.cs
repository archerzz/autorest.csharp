// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading.Tasks;
using AnomalyDetector;
using AnomalyDetector.Models;
using Azure;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace AnomalyDetector.Samples
{
    public partial class Samples_Univariate
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Univariate_DetectUnivariateEntireSeries_ShortVersion()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            Univariate client = new AnomalyDetectorClient(endpoint, credential).GetUnivariateClient(apiVersion: "v1.1");

            using RequestContent content = RequestContent.Create(new
            {
                series = new object[]
            {
new
{
value = 123.45F,
}
            },
            });
            Response response = client.DetectUnivariateEntireSeries(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("period").ToString());
            Console.WriteLine(result.GetProperty("expectedValues")[0].ToString());
            Console.WriteLine(result.GetProperty("upperMargins")[0].ToString());
            Console.WriteLine(result.GetProperty("lowerMargins")[0].ToString());
            Console.WriteLine(result.GetProperty("isAnomaly")[0].ToString());
            Console.WriteLine(result.GetProperty("isNegativeAnomaly")[0].ToString());
            Console.WriteLine(result.GetProperty("isPositiveAnomaly")[0].ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Univariate_DetectUnivariateEntireSeries_ShortVersion_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            Univariate client = new AnomalyDetectorClient(endpoint, credential).GetUnivariateClient(apiVersion: "v1.1");

            using RequestContent content = RequestContent.Create(new
            {
                series = new object[]
            {
new
{
value = 123.45F,
}
            },
            });
            Response response = await client.DetectUnivariateEntireSeriesAsync(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("period").ToString());
            Console.WriteLine(result.GetProperty("expectedValues")[0].ToString());
            Console.WriteLine(result.GetProperty("upperMargins")[0].ToString());
            Console.WriteLine(result.GetProperty("lowerMargins")[0].ToString());
            Console.WriteLine(result.GetProperty("isAnomaly")[0].ToString());
            Console.WriteLine(result.GetProperty("isNegativeAnomaly")[0].ToString());
            Console.WriteLine(result.GetProperty("isPositiveAnomaly")[0].ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Univariate_DetectUnivariateEntireSeries_ShortVersion_Convenience()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            Univariate client = new AnomalyDetectorClient(endpoint, credential).GetUnivariateClient(apiVersion: "v1.1");

            UnivariateDetectionOptions options = new UnivariateDetectionOptions(new TimeSeriesPoint[]
            {
new TimeSeriesPoint(123.45F)
            });
            Response<UnivariateEntireDetectionResult> response = client.DetectUnivariateEntireSeries(options);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Univariate_DetectUnivariateEntireSeries_ShortVersion_Convenience_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            Univariate client = new AnomalyDetectorClient(endpoint, credential).GetUnivariateClient(apiVersion: "v1.1");

            UnivariateDetectionOptions options = new UnivariateDetectionOptions(new TimeSeriesPoint[]
            {
new TimeSeriesPoint(123.45F)
            });
            Response<UnivariateEntireDetectionResult> response = await client.DetectUnivariateEntireSeriesAsync(options);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Univariate_DetectUnivariateEntireSeries_AllParameters()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            Univariate client = new AnomalyDetectorClient(endpoint, credential).GetUnivariateClient(apiVersion: "v1.1");

            using RequestContent content = RequestContent.Create(new
            {
                series = new object[]
            {
new
{
timestamp = "2022-05-10T18:57:31.2311892Z",
value = 123.45F,
}
            },
                granularity = "yearly",
                customInterval = 1234,
                period = 1234,
                maxAnomalyRatio = 123.45F,
                sensitivity = 1234,
                imputeMode = "auto",
                imputeFixedValue = 123.45F,
            });
            Response response = client.DetectUnivariateEntireSeries(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("period").ToString());
            Console.WriteLine(result.GetProperty("expectedValues")[0].ToString());
            Console.WriteLine(result.GetProperty("upperMargins")[0].ToString());
            Console.WriteLine(result.GetProperty("lowerMargins")[0].ToString());
            Console.WriteLine(result.GetProperty("isAnomaly")[0].ToString());
            Console.WriteLine(result.GetProperty("isNegativeAnomaly")[0].ToString());
            Console.WriteLine(result.GetProperty("isPositiveAnomaly")[0].ToString());
            Console.WriteLine(result.GetProperty("severity")[0].ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Univariate_DetectUnivariateEntireSeries_AllParameters_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            Univariate client = new AnomalyDetectorClient(endpoint, credential).GetUnivariateClient(apiVersion: "v1.1");

            using RequestContent content = RequestContent.Create(new
            {
                series = new object[]
            {
new
{
timestamp = "2022-05-10T18:57:31.2311892Z",
value = 123.45F,
}
            },
                granularity = "yearly",
                customInterval = 1234,
                period = 1234,
                maxAnomalyRatio = 123.45F,
                sensitivity = 1234,
                imputeMode = "auto",
                imputeFixedValue = 123.45F,
            });
            Response response = await client.DetectUnivariateEntireSeriesAsync(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("period").ToString());
            Console.WriteLine(result.GetProperty("expectedValues")[0].ToString());
            Console.WriteLine(result.GetProperty("upperMargins")[0].ToString());
            Console.WriteLine(result.GetProperty("lowerMargins")[0].ToString());
            Console.WriteLine(result.GetProperty("isAnomaly")[0].ToString());
            Console.WriteLine(result.GetProperty("isNegativeAnomaly")[0].ToString());
            Console.WriteLine(result.GetProperty("isPositiveAnomaly")[0].ToString());
            Console.WriteLine(result.GetProperty("severity")[0].ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Univariate_DetectUnivariateEntireSeries_AllParameters_Convenience()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            Univariate client = new AnomalyDetectorClient(endpoint, credential).GetUnivariateClient(apiVersion: "v1.1");

            UnivariateDetectionOptions options = new UnivariateDetectionOptions(new TimeSeriesPoint[]
            {
new TimeSeriesPoint(123.45F)
{
Timestamp = DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"),
}
            })
            {
                Granularity = TimeGranularity.Yearly,
                CustomInterval = 1234,
                Period = 1234,
                MaxAnomalyRatio = 123.45F,
                Sensitivity = 1234,
                ImputeMode = ImputeMode.Auto,
                ImputeFixedValue = 123.45F,
            };
            Response<UnivariateEntireDetectionResult> response = client.DetectUnivariateEntireSeries(options);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Univariate_DetectUnivariateEntireSeries_AllParameters_Convenience_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            Univariate client = new AnomalyDetectorClient(endpoint, credential).GetUnivariateClient(apiVersion: "v1.1");

            UnivariateDetectionOptions options = new UnivariateDetectionOptions(new TimeSeriesPoint[]
            {
new TimeSeriesPoint(123.45F)
{
Timestamp = DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"),
}
            })
            {
                Granularity = TimeGranularity.Yearly,
                CustomInterval = 1234,
                Period = 1234,
                MaxAnomalyRatio = 123.45F,
                Sensitivity = 1234,
                ImputeMode = ImputeMode.Auto,
                ImputeFixedValue = 123.45F,
            };
            Response<UnivariateEntireDetectionResult> response = await client.DetectUnivariateEntireSeriesAsync(options);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Univariate_DetectUnivariateLastPoint_ShortVersion()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            Univariate client = new AnomalyDetectorClient(endpoint, credential).GetUnivariateClient(apiVersion: "v1.1");

            using RequestContent content = RequestContent.Create(new
            {
                series = new object[]
            {
new
{
value = 123.45F,
}
            },
            });
            Response response = client.DetectUnivariateLastPoint(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("period").ToString());
            Console.WriteLine(result.GetProperty("suggestedWindow").ToString());
            Console.WriteLine(result.GetProperty("expectedValue").ToString());
            Console.WriteLine(result.GetProperty("upperMargin").ToString());
            Console.WriteLine(result.GetProperty("lowerMargin").ToString());
            Console.WriteLine(result.GetProperty("isAnomaly").ToString());
            Console.WriteLine(result.GetProperty("isNegativeAnomaly").ToString());
            Console.WriteLine(result.GetProperty("isPositiveAnomaly").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Univariate_DetectUnivariateLastPoint_ShortVersion_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            Univariate client = new AnomalyDetectorClient(endpoint, credential).GetUnivariateClient(apiVersion: "v1.1");

            using RequestContent content = RequestContent.Create(new
            {
                series = new object[]
            {
new
{
value = 123.45F,
}
            },
            });
            Response response = await client.DetectUnivariateLastPointAsync(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("period").ToString());
            Console.WriteLine(result.GetProperty("suggestedWindow").ToString());
            Console.WriteLine(result.GetProperty("expectedValue").ToString());
            Console.WriteLine(result.GetProperty("upperMargin").ToString());
            Console.WriteLine(result.GetProperty("lowerMargin").ToString());
            Console.WriteLine(result.GetProperty("isAnomaly").ToString());
            Console.WriteLine(result.GetProperty("isNegativeAnomaly").ToString());
            Console.WriteLine(result.GetProperty("isPositiveAnomaly").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Univariate_DetectUnivariateLastPoint_ShortVersion_Convenience()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            Univariate client = new AnomalyDetectorClient(endpoint, credential).GetUnivariateClient(apiVersion: "v1.1");

            UnivariateDetectionOptions options = new UnivariateDetectionOptions(new TimeSeriesPoint[]
            {
new TimeSeriesPoint(123.45F)
            });
            Response<UnivariateLastDetectionResult> response = client.DetectUnivariateLastPoint(options);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Univariate_DetectUnivariateLastPoint_ShortVersion_Convenience_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            Univariate client = new AnomalyDetectorClient(endpoint, credential).GetUnivariateClient(apiVersion: "v1.1");

            UnivariateDetectionOptions options = new UnivariateDetectionOptions(new TimeSeriesPoint[]
            {
new TimeSeriesPoint(123.45F)
            });
            Response<UnivariateLastDetectionResult> response = await client.DetectUnivariateLastPointAsync(options);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Univariate_DetectUnivariateLastPoint_AllParameters()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            Univariate client = new AnomalyDetectorClient(endpoint, credential).GetUnivariateClient(apiVersion: "v1.1");

            using RequestContent content = RequestContent.Create(new
            {
                series = new object[]
            {
new
{
timestamp = "2022-05-10T18:57:31.2311892Z",
value = 123.45F,
}
            },
                granularity = "yearly",
                customInterval = 1234,
                period = 1234,
                maxAnomalyRatio = 123.45F,
                sensitivity = 1234,
                imputeMode = "auto",
                imputeFixedValue = 123.45F,
            });
            Response response = client.DetectUnivariateLastPoint(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("period").ToString());
            Console.WriteLine(result.GetProperty("suggestedWindow").ToString());
            Console.WriteLine(result.GetProperty("expectedValue").ToString());
            Console.WriteLine(result.GetProperty("upperMargin").ToString());
            Console.WriteLine(result.GetProperty("lowerMargin").ToString());
            Console.WriteLine(result.GetProperty("isAnomaly").ToString());
            Console.WriteLine(result.GetProperty("isNegativeAnomaly").ToString());
            Console.WriteLine(result.GetProperty("isPositiveAnomaly").ToString());
            Console.WriteLine(result.GetProperty("severity").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Univariate_DetectUnivariateLastPoint_AllParameters_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            Univariate client = new AnomalyDetectorClient(endpoint, credential).GetUnivariateClient(apiVersion: "v1.1");

            using RequestContent content = RequestContent.Create(new
            {
                series = new object[]
            {
new
{
timestamp = "2022-05-10T18:57:31.2311892Z",
value = 123.45F,
}
            },
                granularity = "yearly",
                customInterval = 1234,
                period = 1234,
                maxAnomalyRatio = 123.45F,
                sensitivity = 1234,
                imputeMode = "auto",
                imputeFixedValue = 123.45F,
            });
            Response response = await client.DetectUnivariateLastPointAsync(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("period").ToString());
            Console.WriteLine(result.GetProperty("suggestedWindow").ToString());
            Console.WriteLine(result.GetProperty("expectedValue").ToString());
            Console.WriteLine(result.GetProperty("upperMargin").ToString());
            Console.WriteLine(result.GetProperty("lowerMargin").ToString());
            Console.WriteLine(result.GetProperty("isAnomaly").ToString());
            Console.WriteLine(result.GetProperty("isNegativeAnomaly").ToString());
            Console.WriteLine(result.GetProperty("isPositiveAnomaly").ToString());
            Console.WriteLine(result.GetProperty("severity").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Univariate_DetectUnivariateLastPoint_AllParameters_Convenience()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            Univariate client = new AnomalyDetectorClient(endpoint, credential).GetUnivariateClient(apiVersion: "v1.1");

            UnivariateDetectionOptions options = new UnivariateDetectionOptions(new TimeSeriesPoint[]
            {
new TimeSeriesPoint(123.45F)
{
Timestamp = DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"),
}
            })
            {
                Granularity = TimeGranularity.Yearly,
                CustomInterval = 1234,
                Period = 1234,
                MaxAnomalyRatio = 123.45F,
                Sensitivity = 1234,
                ImputeMode = ImputeMode.Auto,
                ImputeFixedValue = 123.45F,
            };
            Response<UnivariateLastDetectionResult> response = client.DetectUnivariateLastPoint(options);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Univariate_DetectUnivariateLastPoint_AllParameters_Convenience_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            Univariate client = new AnomalyDetectorClient(endpoint, credential).GetUnivariateClient(apiVersion: "v1.1");

            UnivariateDetectionOptions options = new UnivariateDetectionOptions(new TimeSeriesPoint[]
            {
new TimeSeriesPoint(123.45F)
{
Timestamp = DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"),
}
            })
            {
                Granularity = TimeGranularity.Yearly,
                CustomInterval = 1234,
                Period = 1234,
                MaxAnomalyRatio = 123.45F,
                Sensitivity = 1234,
                ImputeMode = ImputeMode.Auto,
                ImputeFixedValue = 123.45F,
            };
            Response<UnivariateLastDetectionResult> response = await client.DetectUnivariateLastPointAsync(options);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Univariate_DetectUnivariateChangePoint_ShortVersion()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            Univariate client = new AnomalyDetectorClient(endpoint, credential).GetUnivariateClient(apiVersion: "v1.1");

            using RequestContent content = RequestContent.Create(new
            {
                series = new object[]
            {
new
{
value = 123.45F,
}
            },
                granularity = "yearly",
            });
            Response response = client.DetectUnivariateChangePoint(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Univariate_DetectUnivariateChangePoint_ShortVersion_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            Univariate client = new AnomalyDetectorClient(endpoint, credential).GetUnivariateClient(apiVersion: "v1.1");

            using RequestContent content = RequestContent.Create(new
            {
                series = new object[]
            {
new
{
value = 123.45F,
}
            },
                granularity = "yearly",
            });
            Response response = await client.DetectUnivariateChangePointAsync(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Univariate_DetectUnivariateChangePoint_ShortVersion_Convenience()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            Univariate client = new AnomalyDetectorClient(endpoint, credential).GetUnivariateClient(apiVersion: "v1.1");

            UnivariateChangePointDetectionOptions options = new UnivariateChangePointDetectionOptions(new TimeSeriesPoint[]
            {
new TimeSeriesPoint(123.45F)
            }, TimeGranularity.Yearly);
            Response<UnivariateChangePointDetectionResult> response = client.DetectUnivariateChangePoint(options);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Univariate_DetectUnivariateChangePoint_ShortVersion_Convenience_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            Univariate client = new AnomalyDetectorClient(endpoint, credential).GetUnivariateClient(apiVersion: "v1.1");

            UnivariateChangePointDetectionOptions options = new UnivariateChangePointDetectionOptions(new TimeSeriesPoint[]
            {
new TimeSeriesPoint(123.45F)
            }, TimeGranularity.Yearly);
            Response<UnivariateChangePointDetectionResult> response = await client.DetectUnivariateChangePointAsync(options);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Univariate_DetectUnivariateChangePoint_AllParameters()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            Univariate client = new AnomalyDetectorClient(endpoint, credential).GetUnivariateClient(apiVersion: "v1.1");

            using RequestContent content = RequestContent.Create(new
            {
                series = new object[]
            {
new
{
timestamp = "2022-05-10T18:57:31.2311892Z",
value = 123.45F,
}
            },
                granularity = "yearly",
                customInterval = 1234,
                period = 1234,
                stableTrendWindow = 1234,
                threshold = 123.45F,
            });
            Response response = client.DetectUnivariateChangePoint(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("period").ToString());
            Console.WriteLine(result.GetProperty("isChangePoint")[0].ToString());
            Console.WriteLine(result.GetProperty("confidenceScores")[0].ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Univariate_DetectUnivariateChangePoint_AllParameters_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            Univariate client = new AnomalyDetectorClient(endpoint, credential).GetUnivariateClient(apiVersion: "v1.1");

            using RequestContent content = RequestContent.Create(new
            {
                series = new object[]
            {
new
{
timestamp = "2022-05-10T18:57:31.2311892Z",
value = 123.45F,
}
            },
                granularity = "yearly",
                customInterval = 1234,
                period = 1234,
                stableTrendWindow = 1234,
                threshold = 123.45F,
            });
            Response response = await client.DetectUnivariateChangePointAsync(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("period").ToString());
            Console.WriteLine(result.GetProperty("isChangePoint")[0].ToString());
            Console.WriteLine(result.GetProperty("confidenceScores")[0].ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Univariate_DetectUnivariateChangePoint_AllParameters_Convenience()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            Univariate client = new AnomalyDetectorClient(endpoint, credential).GetUnivariateClient(apiVersion: "v1.1");

            UnivariateChangePointDetectionOptions options = new UnivariateChangePointDetectionOptions(new TimeSeriesPoint[]
            {
new TimeSeriesPoint(123.45F)
{
Timestamp = DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"),
}
            }, TimeGranularity.Yearly)
            {
                CustomInterval = 1234,
                Period = 1234,
                StableTrendWindow = 1234,
                Threshold = 123.45F,
            };
            Response<UnivariateChangePointDetectionResult> response = client.DetectUnivariateChangePoint(options);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Univariate_DetectUnivariateChangePoint_AllParameters_Convenience_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            Univariate client = new AnomalyDetectorClient(endpoint, credential).GetUnivariateClient(apiVersion: "v1.1");

            UnivariateChangePointDetectionOptions options = new UnivariateChangePointDetectionOptions(new TimeSeriesPoint[]
            {
new TimeSeriesPoint(123.45F)
{
Timestamp = DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"),
}
            }, TimeGranularity.Yearly)
            {
                CustomInterval = 1234,
                Period = 1234,
                StableTrendWindow = 1234,
                Threshold = 123.45F,
            };
            Response<UnivariateChangePointDetectionResult> response = await client.DetectUnivariateChangePointAsync(options);
        }
    }
}
