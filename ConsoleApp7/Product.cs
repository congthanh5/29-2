using System;

class Product
{
    public string MaSP { get; set; }
    public string TenSP { get; set; }
    public decimal GiaTien { get; set; }
    public int SoLuong { get; set; }
    public string DonVi { get; set; }

    public void TangSoLuong(int soLuongTang)
    {
        SoLuong += soLuongTang;
    }

    public void GiamSoLuong(int soLuongGiam)
    {
        if (SoLuong - soLuongGiam >= 0)
        {
            SoLuong -= soLuongGiam;
        }
        else
        {
            Console.WriteLine("Không đủ số lượng để giảm.");
        }
    }

    public void ThayDoiGiaTien(decimal giaTienMoi)
    {
        GiaTien = giaTienMoi;
    }

    public void KiemTraHang()
    {
        if (SoLuong > 0)
        {
            Console.WriteLine($"Sản phẩm {TenSP} còn hàng.");
        }
        else
        {
            Console.WriteLine($"Sản phẩm {TenSP} hết hàng.");
        }
    }
}
