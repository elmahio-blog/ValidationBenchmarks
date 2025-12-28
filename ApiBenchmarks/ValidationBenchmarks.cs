using System.Text;
using BenchmarkDotNet.Attributes;

namespace ApiBenchmarks;
[MemoryDiagnoser]
public class ValidationBenchmarks
{
    private HttpClient _client8 = default!;
    private HttpClient _client10 = default!;
    private StringContent _invalidPayload = default!;

    [GlobalSetup]
    public void Setup()
    {
        _client8 = new HttpClient
        {
            BaseAddress = new Uri("http://localhost:5008")
        };

        _client10 = new HttpClient
        {
            BaseAddress = new Uri("http://localhost:5010")
        };

        var json = """
                   {
                       "deviceId": "",
                       "temperature": 120,
                       "batteryLevel": 150,
                       "timestamp": null
                   }
                   """;

        _invalidPayload = new StringContent(
            json,
            Encoding.UTF8,
            "application/json"
        );
    }

    [Benchmark]
    public async Task Net8_Invalid_Model()
        => await _client8.PostAsync("/devices", _invalidPayload);

    [Benchmark]
    public async Task Net10_Invalid_Model()
        => await _client10.PostAsync("/devices", _invalidPayload);
}