namespace IntermediaryProject.Utils;

public class ReportData {
    public decimal ShoppingCosts { get; }
    public decimal SellingRevenue { get; }
    public decimal StorageCosts { get; }
    public decimal PreviousCapital { get; }
    public decimal CurrentCapital { get; }

    public ReportData(
        decimal shoppingCosts,
        decimal sellingRevenue,
        decimal storageCosts,
        decimal previousCapital,
        decimal currentCapital
    ) {
        ShoppingCosts = shoppingCosts;
        SellingRevenue = sellingRevenue;
        StorageCosts = storageCosts;
        PreviousCapital = previousCapital;
        CurrentCapital = currentCapital;
    }
}
