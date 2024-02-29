using System;

class Program
{
    static void Main()
    {
        // Tạo ra 3 sản phẩm
        Product product1 = new Product { MaSP = "SP001", TenSP = "Điện thoại", GiaTien = 5000000, SoLuong = 50, DonVi = "chiếc" };
        Product product2 = new Product { MaSP = "SP002", TenSP = "Laptop", GiaTien = 15000000, SoLuong = 20, DonVi = "cái" };
        Product product3 = new Product { MaSP = "SP003", TenSP = "Tai nghe", GiaTien = 1000000, SoLuong = 100, DonVi = "cặp" };

        // In thông tin sản phẩm
        Console.WriteLine("Thông tin sản phẩm 1:");
        Console.WriteLine($"Mã SP: {product1.MaSP}");
        Console.WriteLine($"Tên SP: {product1.TenSP}");
        Console.WriteLine($"Giá tiền: {product1.GiaTien} VND");
        Console.WriteLine($"Số lượng: {product1.SoLuong} {product1.DonVi}");
        product1.KiemTraHang();
        Console.WriteLine();

        Console.WriteLine("Thông tin sản phẩm 2:");
        Console.WriteLine($"Mã SP: {product2.MaSP}");
        Console.WriteLine($"Tên SP: {product2.TenSP}");
        Console.WriteLine($"Giá tiền: {product2.GiaTien} VND");
        Console.WriteLine($"Số lượng: {product2.SoLuong} {product2.DonVi}");
        product2.KiemTraHang();
        Console.WriteLine();

        Console.WriteLine("Thông tin sản phẩm 3:");
        Console.WriteLine($"Mã SP: {product3.MaSP}");
        Console.WriteLine($"Tên SP: {product3.TenSP}");
        Console.WriteLine($"Giá tiền: {product3.GiaTien} VND");
        Console.WriteLine($"Số lượng: {product3.SoLuong} {product3.DonVi}");
        product3.KiemTraHang();
    }
}
