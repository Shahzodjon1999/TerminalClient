using OfficeOpenXml;
using Terminal.Shared.Response.DcResponse;

namespace TerminalClient.ExcportExcel
{
    public class ExcelOperations
    {
        public byte[] Edition(DcResponses? data)
        {
            ExcelPackage.LicenseContext = LicenseContext.Commercial;

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (var package = new ExcelPackage(new FileInfo("MyWorkbook.xlsx")))
            {
                var worksheet = package.Workbook.Worksheets.Add("Trans");

                // Add headers
                var date = DateTime.Now.ToString("dd.MM.yyyy");
                worksheet.Cells[1, 1].Value = " ";
                worksheet.Cells[1, 2].Value = "Trans_Date";
                worksheet.Cells[1, 3].Value = date;
                // Add other headers...
                int j = 0;
                // Add data
                foreach (var item in data.DcEnumramles)
                {
                    // var operation = data.DcEnumramles[];
                    worksheet.Cells[j + 2, 1].Value = j;
                    worksheet.Cells[j + 2, 2].Value = item.Amount;
                    worksheet.Cells[j + 2, 3].Value = item.AboutPay;
                    j++;
                }

                //for (int i = 0; i < data.DcEnumramles.Count(); i++)
                //{
                //    var operation = data.DcEnumramles;
                //    worksheet.Cells[i + 2, 1].Value = i;
                //    worksheet.Cells[i + 2, 2].Value = ;
                //    worksheet.Cells[i + 2, 3].Value = data.Count;
                //    // Add other data...
                //}

                MemoryStream XLSStream = new();
                //worksheet.SaveAs(XLSStream);

                // return XLSStream.ToArray();
                return package.GetAsByteArray();
            }
        }
    }
}
