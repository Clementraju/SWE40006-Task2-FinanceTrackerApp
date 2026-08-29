namespace FinanceTrackerApp.Models

{

    public class FinanceDashboard

    {

        public decimal TotalBalance { get; set; }

        public decimal MonthlyIncome { get; set; }

        public decimal MonthlyExpenses { get; set; }

        public decimal MonthlySavings { get; set; }

        public string EnvironmentName { get; set; } = string.Empty;

        public List<Transaction> Transactions { get; set; } = new();

    }

    public class Transaction

    {

        public string Description { get; set; } = string.Empty;

        public decimal Amount { get; set; }

        public string Type { get; set; } = string.Empty;

    }

}
