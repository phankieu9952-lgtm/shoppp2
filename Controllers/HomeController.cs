using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using shoppp2.Models;

namespace shoppp2.Controllers;

public class HomeController : Controller
{
    // 1. Trang chủ (Index)
    public IActionResult Index()
    {
        ViewBag.Message = "Chào mừng bạn đến với hệ thống quản lý bán hàng Shop!";
        return View();
    }

    // 2. Danh mục loại sản phẩm (Category)
    public IActionResult Category()
    {
        var categories = new List<Category>
        {
            new Category { Id = 1, Name = "Điện thoại", Description = "Các dòng điện thoại thông minh chính hãng" },
            new Category { Id = 2, Name = "Laptop", Description = "Máy tính xách tay học tập, văn phòng và gaming" },
            new Category { Id = 3, Name = "Phụ kiện", Description = "Tai nghe, cáp sạc, chuột và bàn phím" }
        };
        return View(categories);
    }

    // 3. Danh sách sản phẩm trong kho (Product)
    public IActionResult Product()
    {
        var products = new List<Product>
        {
            new Product { Id = 101, Name = "iPhone 15 Pro Max", CategoryId = 1, Price = 29990000, StockQuantity = 12, ImageFileName = "iphone15pro.jpg", IsActive = true },
            new Product { Id = 102, Name = "Samsung Galaxy S24 Ultra", CategoryId = 1, Price = 26990000, StockQuantity = 18, ImageFileName = "s24ultra.jpg", IsActive = true },
            new Product { Id = 103, Name = "Laptop Dell Inspiron 15", CategoryId = 2, Price = 18500000, StockQuantity = 7, ImageFileName = "dell15.jpg", IsActive = true },
            new Product { Id = 104, Name = "Chuột không dây Logitech", CategoryId = 3, Price = 450000, StockQuantity = 50, ImageFileName = "logitech.jpg", IsActive = true }
        };
        return View(products);
    }

    // 4. Danh sách nhân viên (Employee)
    public IActionResult Employee()
    {
        var employees = new List<Employee>
        {
            new Employee { Id = 1, FullName = "Nguyễn Văn An", Phone = "0905123456", Email = "an.nv@shop.com", UserId = "USR001", IsActive = true },
            new Employee { Id = 2, FullName = "Trần Thị Bình", Phone = "0918765432", Email = "binh.tt@shop.com", UserId = "USR002", IsActive = true },
            new Employee { Id = 3, FullName = "Lê Hoàng Cường", Phone = "0932112233", Email = "cuong.lh@shop.com", UserId = "USR003", IsActive = false }
        };
        return View(employees);
    }

    // 5. Hóa đơn (Invoice)
    public IActionResult Invoice()
    {
        var invoices = new List<Invoice>
        {
            new Invoice { Id = 5001, CreatedAt = DateTime.Now.AddDays(-1), EmployeeId = 1, CustomerName = "Phạm Quỳnh Mai", CustomerPhone = "0978111222", TotalAmount = 30440000 },
            new Invoice { Id = 5002, CreatedAt = DateTime.Now, EmployeeId = 2, CustomerName = "Vũ Đức Huy", CustomerPhone = "0964333444", TotalAmount = 18500000 }
        };
        return View(invoices);
    }

    // 6. Chi tiết hóa đơn (InvoiceDetail)
    public IActionResult InvoiceDetail()
    {
        var invoiceDetails = new List<InvoiceDetail>
        {
            new InvoiceDetail { Id = 1, InvoiceId = 5001, ProductId = 101, Quantity = 1, UnitPrice = 29990000 },
            new InvoiceDetail { Id = 2, InvoiceId = 5001, ProductId = 104, Quantity = 1, UnitPrice = 450000 },
            new InvoiceDetail { Id = 3, InvoiceId = 5002, ProductId = 103, Quantity = 1, UnitPrice = 18500000 }
        };
        return View(invoiceDetails);
    }
}