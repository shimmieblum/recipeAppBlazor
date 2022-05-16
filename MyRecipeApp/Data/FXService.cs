using System.Xml;
using Halak;
using Newtonsoft.Json;

namespace MyRecipeApp.Data;


public class FXService
{
    public static async Task<double> GetSterlingToDollarAsync(double amountToConvert)
    {
        using var client = new HttpClient();
        var url = $"https://api.exchangerate.host/convert?from=GBP&to=USD&amount={amountToConvert}&places=2";
        var response = await client.GetStringAsync(url);
        var result = JsonConvert.DeserializeObject<FXResponse>(response);
        if (result is null || !result.Success || result is null)
            throw new ApplicationException("failure in fx service");
        return result.Result;
    }
}