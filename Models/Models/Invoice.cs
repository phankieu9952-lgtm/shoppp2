namespace shoppp2.Models;

public class Invoice
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public int EmployeeId { get; set; }
    public string CustomerName { get; set; } = string.Empty;
    public string CustomerPhone { get; set; } = string.Empty;
    public decimal TotalAmount { get; set; }
}