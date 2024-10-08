namespace SMSGateWay;

public class SendSms
{
    public async Task<bool> SendSmsAsync(string BaseApi, string apiKey, string messageBody, string number)
    {
        using HttpClient _httpClient = new HttpClient();
        // Define the API endpoint
        var apiUrl = $"{BaseApi}?api_key={apiKey}&msg={messageBody}&to={number}";

        // Send a POST request with JSON data
        HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);

        // Check if the request was successful
        return response.IsSuccessStatusCode;
    }
}
