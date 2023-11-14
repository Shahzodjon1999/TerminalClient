using Microsoft.JSInterop;
using Terminal.Shared.Response.DcResponse;

namespace TerminalClient.ExcportExcel
{
    public class Excel
    {
        public async Task GenerateWeatherForecastAsync(IJSRuntime js,
                                              DcResponses? data,
                                               string filename = "export.xlsx")
        {
            var weatherForecast = new ExcelOperations();
            var XLSStream = weatherForecast.Edition(data);

            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XLSStream);
        }
    }
}
