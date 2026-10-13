using System;
using System.Data;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

public class DatabaseService
{
    
    private const string ChuoiKetNoi =
        @"Server=(localdb)\MSSQLLocalDB; Database=QuanLyHieuThuoc; Trusted_Connection=True; TrustServerCertificate=True;";

    public async Task<bool> KiemTraTenDangNhapToanTaiAsync(string tenDangNhap)
    {
        const string sql = "SELECT COUNT(1) FROM Users WHERE TenDangNhap = @ten";
        using var conn = new SqlConnection(ChuoiKetNoi);
        using var cmd = new SqlCommand(sql, conn);
        cmd.Parameters.Add("@ten", SqlDbType.NVarChar, 20).Value = tenDangNhap;

        await conn.OpenAsync();
        int count = (int)await cmd.ExecuteScalarAsync();
        return count > 0;
    }

    public async Task<bool> DangKyNguoiDungAsync(string tenDN, string matKhauBam, string salt,
        string chucVu, string sdt, string cccd, DateTime? ngaySinh)
    {
        const string sql = @"
            INSERT INTO Users (TenDangNhap, MatKhauBam, Salt, ChucVu, SoDienThoai, SoCCCD, NgaySinh)
            VALUES (@ten, @bam, @salt, @chucVu, @sdt, @cccd, @ngaySinh)";

        using var conn = new SqlConnection(ChuoiKetNoi);
        using var cmd = new SqlCommand(sql, conn);

        cmd.Parameters.Add("@ten", SqlDbType.NVarChar, 20).Value = tenDN;
        cmd.Parameters.Add("@bam", SqlDbType.NVarChar, 64).Value = matKhauBam;
        cmd.Parameters.Add("@salt", SqlDbType.NVarChar, 32).Value = salt;
        cmd.Parameters.Add("@chucVu", SqlDbType.NVarChar, 50).Value = chucVu;
        cmd.Parameters.Add("@sdt", SqlDbType.VarChar, 10).Value = sdt;
        cmd.Parameters.Add("@cccd", SqlDbType.VarChar, 12).Value = (object)cccd ?? DBNull.Value;
        cmd.Parameters.Add("@ngaySinh", SqlDbType.Date).Value = (object)ngaySinh ?? DBNull.Value;

        await conn.OpenAsync();
        int rows = await cmd.ExecuteNonQueryAsync();
        return rows > 0;
    }

    public async Task<(string Salt, string MatKhauBam, string ChucVu)?> LayThongTinDangNhapAsync(string tenDN)
    {
        const string sql = "SELECT Salt, MatKhauBam, ChucVu FROM Users WHERE TenDangNhap = @ten";
        using var conn = new SqlConnection(ChuoiKetNoi);
        using var cmd = new SqlCommand(sql, conn);
        cmd.Parameters.Add("@ten", SqlDbType.NVarChar, 20).Value = tenDN;

        await conn.OpenAsync();
        using var reader = await cmd.ExecuteReaderAsync();
        if (await reader.ReadAsync())
        {
            return (reader.GetString(0), reader.GetString(1), reader.GetString(2));
        }
        return null;
    }

    public async Task CapNhatLanDangNhapCuoiAsync(string tenDN)
    {
        const string sql = "UPDATE Users SET LanDangNhapCuoi = SYSDATETIME() WHERE TenDangNhap = @ten";
        using var conn = new SqlConnection(ChuoiKetNoi);
        using var cmd = new SqlCommand(sql, conn);
        cmd.Parameters.Add("@ten", SqlDbType.NVarChar, 20).Value = tenDN;

        await conn.OpenAsync();
        await cmd.ExecuteNonQueryAsync();
    }
}