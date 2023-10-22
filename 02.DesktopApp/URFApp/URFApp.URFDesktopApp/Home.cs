using OfficeOpenXml;
using URFApp.URFDesktopApp.Context;
using URFApp.URFDesktopApp.Models;

namespace URFApp.URFDesktopApp;

public partial class Home : Form
{
    public Home()
    {
        InitializeComponent();
    }

    private void btnExcelRead_Click(object sender, EventArgs e)
    {
        OpenFileDialog openFileDialog = new()
        {
            Filter = "Excel Files|*.xls;*.xlsx;*.xlsm",
            Title = "Select an Excel File"
        };

        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            string filePath = openFileDialog.FileName;

            FileInfo existingFile = new(filePath);
            using (ExcelPackage package = new(existingFile))
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                SaveRFKFromWorkSheet("Avis", worksheet);

                MessageBox.Show("Data Imported Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }

    private void SaveRFKFromWorkSheet(string type, ExcelWorksheet worksheet)
    {
        int rowCount = worksheet.Dimension.Rows;
        int ColCount = worksheet.Dimension.Columns;

        for (int row = 2; row <= rowCount; row++)
        {
            RFK rfk = new(); //instance türetme
            if (worksheet.Cells[row, 1].Value == null) continue;
            rfk.Type = type;
            rfk.Plate = worksheet.Cells[row, 1].Value.ToString();
            rfk.VehPrice = ConvertStringToDecimal(worksheet.Cells[row, 2].Value.ToString());
            rfk.OTV = ConvertStringToDecimal(worksheet.Cells[row, 3].Value.ToString());
            rfk.ComissionRate = ConvertStringToDecimal(worksheet.Cells[row, 4].Value);
            rfk.RCIComission = ConvertStringToDecimal(worksheet.Cells[row, 5].Value);
            rfk.DeliveryDate = ConvertStringDoubleToDateTime(worksheet.Cells[row, 6].Value);
            rfk.IsCommercial = worksheet.Cells[row, 7].Value.ToString();
            rfk.ChasisNumber = worksheet.Cells[row, 8].Value.ToString();
            rfk.Brand = worksheet.Cells[row, 9].Value.ToString();
            rfk.Model = worksheet.Cells[row, 10].Value.ToString();
            rfk.CommercialDesignation = worksheet.Cells[row, 11].Value.ToString();
            rfk.Customer = worksheet.Cells[row, 12].Value.ToString();
            rfk.Duration = Convert.ToInt16(worksheet.Cells[row, 13].Value);
            rfk.DealerBrand = worksheet.Cells[row, 14].Value.ToString();
            rfk.DealerNo = worksheet.Cells[row, 15].Value.ToString();
            rfk.DealerName = worksheet.Cells[row, 16].Value.ToString();
            rfk.GrossRV = worksheet.Cells[row, 17].Value.ToString();
            rfk.OTVInPercent = ConvertStringToDecimal(worksheet.Cells[row, 18].Value);
            rfk.VehPriceIncVAT = ConvertStringToDecimal(worksheet.Cells[row, 19].Value);
            rfk.VehPriceExcVAT = ConvertStringToDecimal(worksheet.Cells[row, 20].Value);
            rfk.OWLeasingCommission = ConvertStringToDecimal(worksheet.Cells[row, 21].Value);
            rfk.OWMaintenanceCommission = ConvertStringToDecimal(worksheet.Cells[row, 22].Value);
            rfk.CheckValue = ConvertStringToDecimal(worksheet.Cells[row, 23].Value);
            rfk.Total = ConvertStringToDecimal(worksheet.Cells[row, 24].Value);
            rfk.TotalInPercent = ConvertStringToDecimal(worksheet.Cells[row, 25].Value);
            rfk.MonthOfReporting = worksheet.Cells[row, 26].Value.ToString();
            rfk.Engine = worksheet.Cells[row, 27].Value.ToString();
            rfk.TYCLI = worksheet.Cells[row, 28].Value.ToString();
            rfk.MarketCode = worksheet.Cells[row, 29].Value.ToString();
            rfk.Channel = worksheet.Cells[row, 30].Value.ToString();
            rfk.ContractStatus = Convert.ToInt16(worksheet.Cells[row, 31].Value.ToString());
            rfk.StatusOfServiceContracts = Convert.ToInt16(worksheet.Cells[row, 32].Value);
            rfk.Model2 = worksheet.Cells[row, 33].Value.ToString();
            rfk.TYBien = worksheet.Cells[row, 34].Value.ToString();
            rfk.NatBien = worksheet.Cells[row, 35].Value.ToString();
            rfk.FundRate = ConvertStringToDecimal(worksheet.Cells[row, 36].Value);
            rfk.CTRRNW = worksheet.Cells[row, 37].Value.ToString();

            //Entity Framework Core bir ORM => Object Relational Mapping
            AppDbContext con = new();
            con.RFKs.Add(rfk);
            con.SaveChanges(); //performans açýsýndan daha yavaþtýr

            //performans açýsýndan daha hýzlýdýr
            #region SQL Data Connection ile Çalýþma 
            //SqlConnection conn = new(@"Data Source=DESKTOP-3BJ5GK9\SQLEXPRESS;Initial Catalog=URFDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;");
            //conn.Open();
            //string sql = @"Insert Into                                            
            //                        RFK_Avises(Plate, VehPrice, OTV, ComissionRate, RCIComission, DeliveryDate, IsCommercial, ChasisNumber, Brand, Model, CommercialDesignation, Customer, Duration, DealerBrand, DealerNo,DealerName, GrossRV, OTVInPercent, VehPriceIncVat, VehPriceExcVat, OWLeasingCommission, OWMaintenanceCommission, CheckValue, Total, TotalInPercent, MonthOfReporting, Engine, TYCLI, MarketCode, Channel, ContractStatus, StatusOfServiceContracts, Model2, TYBien, NATBien, FundRate, CTRRNW) Values(
            //                        @plate,
            //                        @vehPrice,      
            //                        @otv,
            //                        @comissionRate,
            //                        @rciComission,
            //                        @deliveryDate,
            //                        @isCommercial,
            //                        @chasisNumber,
            //                        @brand,
            //                        @model, 
            //                        @commercialDesignation,
            //                        @customer,
            //                        @duration,
            //                        @dealerBrand,
            //                        @dealerNo,
            //                        @dealerName,
            //                        @grossRV,
            //                        @otvInPercent,
            //                        @vehPriceIncVAT,
            //                        @vehPriceExcVAT,
            //                        @owLeasingCommission,
            //                        @owMaintenanceCommission,
            //                        @check,
            //                        @total,
            //                        @totalInPercent,
            //                        @monthOfReporting,
            //                        @engine,
            //                        @tyCLI,
            //                        @marketCode,
            //                        @channel,
            //                        @contractStatus,
            //                        @statusOfServiceContracts,
            //                        @model2,
            //                        @tyBien,
            //                        @natBien,
            //                        @fundRate,
            //                        @ctrRNW)";
            //SqlCommand cmd = new(sql, conn);
            //cmd.Parameters.AddWithValue("@plate", plate);
            //cmd.Parameters.AddWithValue("@vehPrice", vehPrice);
            //cmd.Parameters.AddWithValue("@otv", otv);
            //cmd.Parameters.AddWithValue("@comissionRate", comissionRate);
            //cmd.Parameters.AddWithValue("@rciComission", rciComission);
            //cmd.Parameters.AddWithValue("@deliveryDate", deliveryDate);
            //cmd.Parameters.AddWithValue("@isCommercial", isCommercial);
            //cmd.Parameters.AddWithValue("@chasisNumber", chasisNumber);
            //cmd.Parameters.AddWithValue("@brand", brand);
            //cmd.Parameters.AddWithValue("@model", model);
            //cmd.Parameters.AddWithValue("@commercialDesignation", commercialDesignation);
            //cmd.Parameters.AddWithValue("@customer", customer);
            //cmd.Parameters.AddWithValue("@duration", duration);
            //cmd.Parameters.AddWithValue("@dealerBrand", dealerBrand);
            //cmd.Parameters.AddWithValue("@dealerNo", dealerNo);
            //cmd.Parameters.AddWithValue("@dealerName", dealerName);
            //cmd.Parameters.AddWithValue("@grossRV", grossRV);
            //cmd.Parameters.AddWithValue("@otvInPercent", otvInPercent);
            //cmd.Parameters.AddWithValue("@vehPriceIncVAT", vehPriceIncVAT);
            //cmd.Parameters.AddWithValue("@vehPriceExcVAT", vehPriceExcVAT);
            //cmd.Parameters.AddWithValue("@owLeasingCommission", owLeasingCommission);
            //cmd.Parameters.AddWithValue("@owMaintenanceCommission", owMaintenanceCommission);
            //cmd.Parameters.AddWithValue("@check", check);
            //cmd.Parameters.AddWithValue("@total", total);
            //cmd.Parameters.AddWithValue("@totalInPercent", totalInPercent);
            //cmd.Parameters.AddWithValue("@monthOfReporting", monthOfReporting);
            //cmd.Parameters.AddWithValue("@engine", engine);
            //cmd.Parameters.AddWithValue("@tyCLI", tyCLI);
            //cmd.Parameters.AddWithValue("@marketCode", marketCode);
            //cmd.Parameters.AddWithValue("@channel", channel);
            //cmd.Parameters.AddWithValue("@contractStatus", contractStatus);
            //cmd.Parameters.AddWithValue("@statusOfServiceContracts", statusOfServiceContracts);
            //cmd.Parameters.AddWithValue("@model2", model2);
            //cmd.Parameters.AddWithValue("@tyBien", tyBien);
            //cmd.Parameters.AddWithValue("@natBien", natBien);
            //cmd.Parameters.AddWithValue("@fundRate", fundRate);
            //cmd.Parameters.AddWithValue("@ctrRNW", ctrRNW);
            //cmd.ExecuteNonQuery();
            //conn.Close();
            #endregion
        }
    }

    private void SaveEWFromWorkSheet(ExcelWorksheet worksheet)
    {

    }

    private decimal ConvertStringToDecimal(object value)
    {
        if (value == null) return 0;

        if (string.IsNullOrEmpty(value.ToString().Trim())) return 0;

        string valueString = value.ToString().Trim();

        decimal result = 0;
        var convertResult = decimal.TryParse(valueString.Trim(), out result);
        if (!convertResult) return 0; //asdasdasd

        return result;
    }

    private DateTime? ConvertStringDoubleToDateTime(object value)
    {
        if (value == null) return null;
        if (string.IsNullOrEmpty(value.ToString().Trim())) return null;

        double excelDate;
        var convertResult = double.TryParse(value.ToString().Trim(), out excelDate);
        if (convertResult == false) return null;

        DateTime realDate = DateTime.FromOADate(excelDate);

        return realDate;
    }

    private void btnLPReadExcel_Click(object sender, EventArgs e)
    {
        OpenFileDialog openFileDialog = new()
        {
            Filter = "Excel Files|*.xls;*.xlsx;*.xlsm",
            Title = "Select an Excel File"
        };

        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            string filePath = openFileDialog.FileName;

            FileInfo existingFile = new(filePath);
            using (ExcelPackage package = new(existingFile))
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                ExcelWorksheet worksheet = package.Workbook.Worksheets[1];               
                SaveRFKFromWorkSheet("LP", worksheet);

                MessageBox.Show("Data Imported Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

