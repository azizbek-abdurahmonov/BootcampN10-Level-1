using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Channels;


HttpClient _client = new HttpClient();
var url = "https://islomapi.uz/api/present/day?region=Toshkent";

HttpResponseMessage response = await _client.GetAsync(url);

var obj = JsonSerializer.Deserialize<NamozVaqtlari>(response.Content.ReadAsStringAsync().Result);



public class NamozVaqtlari
{
    public string region { get; set; }
    public string date { get; set; }
    public string weekday { get; set; }
    public Times times { get; set; }
}


public class Times
{
    [JsonPropertyName("tong_saharlik")] public string bomdod { get; set; }
    public string quyosh { get; set; }
    public string peshin { get; set; }
    public string asr { get; set; }
    [JsonPropertyName("shom_iftor")] public string shom { get; set; }
    public string hufton { get; set; }
}