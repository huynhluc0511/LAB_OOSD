using System;

using System.Data;

using System.Configuration;

using Npgsql; // Thư viện kết nối PostgreSQL



namespace QuanLyKhachSan

{

    public static class Db

    {

        public static string ConnectionString => ConfigurationManager.ConnectionStrings["QuanLyKhachSanDB"].ConnectionString;



        // Mở kết nối tới PostgreSQL

        public static NpgsqlConnection OpenConnection()

        {

            var cn = new NpgsqlConnection(ConnectionString);

            cn.Open();

            return cn;

        }



        // Truy vấn dữ liệu (SELECT) trả về DataTable

        public static DataTable Query(string sql, params NpgsqlParameter[] ps)

        {

            using (var cn = OpenConnection())

            using (var cmd = new NpgsqlCommand(sql, cn))

            using (var da = new NpgsqlDataAdapter(cmd))

            {

                if (ps != null && ps.Length > 0)

                    cmd.Parameters.AddRange(ps);

                var dt = new DataTable();

                da.Fill(dt);

                return dt;

            }

        }



        // Thực thi lệnh Thêm, Sửa, Xóa (INSERT, UPDATE, DELETE)

        public static int Execute(string sql, params NpgsqlParameter[] ps)

        {

            using (var cn = OpenConnection())

            using (var cmd = new NpgsqlCommand(sql, cn))

            {

                if (ps != null && ps.Length > 0)

                    cmd.Parameters.AddRange(ps);

                return cmd.ExecuteNonQuery();

            }

        }



        // Lấy 1 giá trị đơn lẻ (COUNT, SUM...)

        public static object Scalar(string sql, params NpgsqlParameter[] ps)

        {

            using (var cn = OpenConnection())

            using (var cmd = new NpgsqlCommand(sql, cn))

            {

                if (ps != null && ps.Length > 0)

                    cmd.Parameters.AddRange(ps);

                return cmd.ExecuteScalar();

            }

        }

    }

}