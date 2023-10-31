using Microsoft.EntityFrameworkCore;
using MyRestaurantApp.Context;
using MyRestaurantApp.Models;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LicenseContext = OfficeOpenXml.LicenseContext;

namespace MyRestaurantApp;

public partial class FrmReport : Form
{
    public FrmReport()
    {
        InitializeComponent();
    }

    private void btnReport_Click(object sender, EventArgs e)
    {
        DateTime startDate = DateTime.Now;
        DateTime endDate = DateTime.Now;

        var result1 = DateTime.TryParse(dPStart.Text, out startDate);
        var result2 = DateTime.TryParse(dPEnd.Text, out endDate);

        if (!result1 || !result2)
        {
            MessageBox.Show("Geçersiz tarih girdiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (endDate.Date < startDate.Date)
        {
            MessageBox.Show("Başlangıç tarihi bitiş tarihinden büyük olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        dG1.Rows.Clear();

        gB1.Visible = true;

        ApplicationDbContext context = new();
        List<PaymentHistory> paymentHistories = context.PaymentHistories
            .Where(p => p.PaymentDate.Date >= startDate.Date &&
                        p.PaymentDate.Date <= endDate.Date)
            .Include(p => p.Product)
            .ToList();

        lblRevenue.Text = "Toplam Ciro: " + paymentHistories.Sum(s => s.Price).ToString("#,##0.00") + " ₺";
        lbCreditCartRevenue.Text = "Toplam K.K. Ciro: " +
                    paymentHistories
                        .Where(p => p.PaymentType == PaymentType.CreditCart)
                        .Sum(s => s.Price).ToString("#,##0.00") + " ₺";
        lbCashRevenue.Text = "Toplam Nakit Ciro: " +
                    paymentHistories
                        .Where(p => p.PaymentType == PaymentType.Cash)
                        .Sum(s => s.Price).ToString("#,##0.00") + " ₺";

        var groupedByProduct = paymentHistories
            .GroupBy(p => p.ProductId)
            .Select(group => new
            {
                ProductId = group.Key,
                ProductName = group.First().Product.Name, // İlk öğenin ürün adını al
                Payments = group.ToList() // Bu ürüne ait tüm ödemeler
            })
            .ToList();

        foreach (var product in groupedByProduct)
        {
            dG1.Rows.Add();
            int index = dG1.Rows.Count - 1;
            dG1.Rows[index].Cells[0].Value = product.ProductName; //Ürün Adı
            dG1.Rows[index].Cells[1].Value = product.Payments.Count(); //Ürün Satış Adedi
            dG1.Rows[index].Cells[2].Value = product.Payments.Sum(s => s.Price); //Ürün Toplam Kazanç
        }
    }

    private void btnExportExcel_Click(object sender, EventArgs e)
    {
        // EPPlus lisansı için
        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

        using (var package = new ExcelPackage())
        {
            var worksheet = package.Workbook.Worksheets.Add("Sayfa1");

            // Hücreye değer atama
            worksheet.Cells[1, 1].Value = "Başlangıç Tarihi";
            worksheet.Cells[2, 1].Value = dPStart.Text;
            worksheet.Cells[1, 2].Value = "Bitiş Tarihi";
            worksheet.Cells[2, 2].Value = dPEnd.Text;

            worksheet.Cells[4, 1].Value = lblRevenue.Text;
            worksheet.Cells[5, 1].Value = lbCreditCartRevenue.Text;
            worksheet.Cells[6, 1].Value = lbCashRevenue.Text;

            // Dosyayı kaydetme
            var fileInfo = new FileInfo(@"C:\YMYP2\02.DesktopApp\MyRestaurantApp\Exports\report.xlsx");

            package.SaveAs(fileInfo);

            MessageBox.Show("Raporunuz hazır. Klasörden kontrol edebilirsiniz: " + @"C:\YMYP2\02.DesktopApp\MyRestaurantApp\Exports\report.xlsx", "Rapor Hazır", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}