using OfficeOpenXml;

namespace TerminalClient.ExcportExcel
{
    public class Utils
    {
        public static ExcelPackage CreateExcelPackege()
        {
            var paskage = new ExcelPackage();
            paskage.Workbook.Properties.Title = "Title";
            paskage.Workbook.Properties.Author = "Author";
            paskage.Workbook.Properties.Subject = "Subject";
            paskage.Workbook.Properties.Keywords = "Keywords";

            var worksheet = paskage.Workbook.Worksheets.Add("Employee");

            worksheet.Cells[1, 1].Value = "Id";
            worksheet.Cells[1, 2].Value = "Name";
            worksheet.Cells[1, 3].Value = "Gender";
            worksheet.Cells[1, 4].Value = "Salary(in $)";


            var numberformat = "#.##0";
            var dataCellStyleName = "TableNumber";
            var numstyle = paskage.Workbook.Styles.CreateNamedStyle(dataCellStyleName);
            numstyle.Style.Numberformat.Format = numberformat;

            worksheet.Cells[2, 1].Value = 1;
            worksheet.Cells[2, 2].Value = "Haytham";
            worksheet.Cells[2, 3].Value = "M";
            worksheet.Cells[2, 4].Value = 50000;
            worksheet.Cells[2, 4].Style.Numberformat.Format = numberformat;

            worksheet.Cells[2, 1].Value = 2;
            worksheet.Cells[2, 2].Value = "Hdfgdg";
            worksheet.Cells[2, 3].Value = "M";
            worksheet.Cells[2, 4].Value = 50000;
            worksheet.Cells[2, 4].Style.Numberformat.Format = numberformat;

            var tbl = worksheet.Tables.Add(new ExcelAddressBase(fromRow: 1, fromCol: 1, toRow: 4, toColumn: 4), "Data");

            tbl.ShowHeader = true;
            tbl.TableStyle = OfficeOpenXml.Table.TableStyles.Dark9;
            tbl.ShowTotal = true;
            tbl.Columns[3].DataCellStyleName = dataCellStyleName;
            tbl.Columns[3].TotalsRowFunction = OfficeOpenXml.Table.RowFunctions.Sum;
            worksheet.Cells[5, 4].Style.Numberformat.Format = numberformat;

            worksheet.Cells[1, 1, 4, 4].AutoFitColumns();
            return paskage;
        }
    
    }
}
