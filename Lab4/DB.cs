using System;
using System.Collections.Generic;
using System.Data;
using System.Configuration; // Thư viện đọc App.config
using Npgsql;

namespace WindowsFormsApp1.eshop
{
    public static class DB
    {
        // Lấy chuỗi kết nối tên "shopDB" từ App.config
        public static string connectionString = ConfigurationManager.ConnectionStrings["shop"].ConnectionString;

        // Hàm mở kết nối
        public static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(connectionString);
        }

        #region --- HÀM THỰC THI CHUNG ---

        // Hàm thực thi TRUY VẤN dữ liệu (SELECT)
        public static DataTable GetData(string sql, NpgsqlParameter[] parameters = null)
        {
            using (NpgsqlConnection conn = GetConnection())
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        // Hàm thực thi THÊM / SỬA / XÓA (INSERT, UPDATE, DELETE)
        public static int ExecuteNonQuery(string sql, NpgsqlParameter[] parameters = null)
        {
            using (NpgsqlConnection conn = GetConnection())
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        #endregion

        #region --- NGIỆM VỤ QUẢN LÝ SẢN PHẨM ---

        // 1. Thêm sản phẩm mới
        public static bool ThemSanPham(string maSP, string tenSP, string maNhom, string nhaSX, string hinhAnh, string moTa, string thongSo, decimal giaBan, int soLuongTon, bool tinhTrang)
        {
            string sql = @"INSERT INTO SanPham (MaSP, TenSP, MaNhom, TenNhaSX, HinhAnh, MoTa, ThongSoKyThuat, GiaBan, SoLuongTon, TinhTrang) 
                           VALUES (@MaSP, @TenSP, @MaNhom, @TenNhaSX, @HinhAnh, @MoTa, @ThongSoKyThuat, @GiaBan, @SoLuongTon, @TinhTrang)";

            NpgsqlParameter[] p = {
                new NpgsqlParameter("@MaSP", maSP),
                new NpgsqlParameter("@TenSP", tenSP),
                new NpgsqlParameter("@MaNhom", maNhom),
                new NpgsqlParameter("@TenNhaSX", nhaSX),
                new NpgsqlParameter("@HinhAnh", (object)hinhAnh ?? DBNull.Value),
                new NpgsqlParameter("@MoTa", (object)moTa ?? DBNull.Value),
                new NpgsqlParameter("@ThongSoKyThuat", (object)thongSo ?? DBNull.Value),
                new NpgsqlParameter("@GiaBan", giaBan),
                new NpgsqlParameter("@SoLuongTon", soLuongTon),
                new NpgsqlParameter("@TinhTrang", tinhTrang)
            };
            return ExecuteNonQuery(sql, p) > 0;
        }

        // 2. Cập nhật sản phẩm
        public static bool SuaSanPham(string maSP, string tenSP, string maNhom, string nhaSX, string hinhAnh, string moTa, string thongSo, decimal giaBan, int soLuongTon, bool tinhTrang)
        {
            string sql = @"UPDATE SanPham 
                           SET TenSP = @TenSP, MaNhom = @MaNhom, TenNhaSX = @TenNhaSX, HinhAnh = @HinhAnh, 
                               MoTa = @MoTa, ThongSoKyThuat = @ThongSoKyThuat, GiaBan = @GiaBan, 
                               SoLuongTon = @SoLuongTon, TinhTrang = @TinhTrang
                           WHERE MaSP = @MaSP";

            NpgsqlParameter[] p = {
                new NpgsqlParameter("@MaSP", maSP),
                new NpgsqlParameter("@TenSP", tenSP),
                new NpgsqlParameter("@MaNhom", maNhom),
                new NpgsqlParameter("@TenNhaSX", nhaSX),
                new NpgsqlParameter("@HinhAnh", (object)hinhAnh ?? DBNull.Value),
                new NpgsqlParameter("@MoTa", (object)moTa ?? DBNull.Value),
                new NpgsqlParameter("@ThongSoKyThuat", (object)thongSo ?? DBNull.Value),
                new NpgsqlParameter("@GiaBan", giaBan),
                new NpgsqlParameter("@SoLuongTon", soLuongTon),
                new NpgsqlParameter("@TinhTrang", tinhTrang)
            };
            return ExecuteNonQuery(sql, p) > 0;
        }

        // 3. Xóa sản phẩm
        public static bool XoaSanPham(string maSP)
        {
            string sql = "DELETE FROM SanPham WHERE MaSP = @MaSP";
            NpgsqlParameter[] p = { new NpgsqlParameter("@MaSP", maSP) };
            return ExecuteNonQuery(sql, p) > 0;
        }

        #endregion
    } // Đóng ngoặc public static class DB
}     // Đóng ngoặc namespace WindowsFormsApp1.eshop