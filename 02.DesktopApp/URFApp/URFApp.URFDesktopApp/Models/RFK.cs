namespace URFApp.URFDesktopApp.Models;
public sealed class RFK //Entity
{
    //Domain-Driven Design => Approach => Yaklaşım
    //Property oluşturma
    public int Id { get; set; }
    public string Type { get; set; }
    public string Plate { get; set; }
    public decimal VehPrice { get; set; }
    public decimal OTV { get; set; }
    public decimal ComissionRate { get; set; }
    public decimal RCIComission { get; set; }   
    public DateTime? DeliveryDate { get; set; }
    public string IsCommercial { get; set; }
    public string ChasisNumber { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
    public string CommercialDesignation { get; set; }
    public string Customer { get; set; }
    public short Duration { get; set; }
    public string DealerBrand { get; set; }
    public string DealerNo { get; set; }
    public string DealerName { get; set; }
    public string GrossRV { get; set; }
    public decimal OTVInPercent { get; set; }
    public decimal VehPriceIncVAT { get; set; }
    public decimal VehPriceExcVAT { get; set; }
    public decimal OWLeasingCommission { get; set; }
    public decimal OWMaintenanceCommission { get; set; }
    public decimal CheckValue { get; set; }
    public decimal Total { get; set; }
    public decimal TotalInPercent { get; set; }
    public string MonthOfReporting { get; set; }
    public string Engine { get; set; }
    public string TYCLI { get; set; }
    public string MarketCode { get; set; }
    public string Channel { get; set; }
    public short ContractStatus { get; set; }
    public short StatusOfServiceContracts { get; set; }
    public string Model2 { get; set; }
    public string TYBien { get; set; }
    public string NatBien { get; set; }
    public decimal FundRate { get; set; }
    public string CTRRNW { get; set; }
}

