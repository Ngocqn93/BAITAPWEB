namespace BAITAPWEB.Models.DanhSach
{
    public class ModelDanhSach
    {
        public string TenSanPham { get; set; }
        public int SoLuong { get; set; }
        public int DonGia { get; set; }
        public int TamTinh { get; set; }
        public ModelDanhSach() { }
        public ModelDanhSach(string tenSanPham, int soLuong, int gia)
        {
            TenSanPham = tenSanPham;
            SoLuong = soLuong;
            DonGia = gia;
            TamTinh = soLuong * gia;
        }
    }
}
