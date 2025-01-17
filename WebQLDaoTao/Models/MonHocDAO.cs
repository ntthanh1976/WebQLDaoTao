using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
namespace WebQLDaoTao.Models
{
    public class MonHocDAO
    {
        //phuong thuc doc tat ca mon hoc
        public List<MonHoc> getAll()
        {
            List<MonHoc> ds = new List<MonHoc>();
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["QLDaoTao_ConStr"].ConnectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from monhoc", conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                MonHoc mh = new MonHoc { MaMH = rd["mamh"].ToString(), 
                    TenMH = rd["tenmh"].ToString(), SoTiet= int.Parse(rd["sotiet"].ToString()) };
                ds.Add(mh);
            }
            return ds;
        }

        //phuong thuc thêm môn học
        public int Update(MonHoc mh)
        {
            //1.Mo ket noi CSDL
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["QLDaoTao_ConStr"].ConnectionString);
            conn.Open();
            //2.tao truy van
            SqlCommand cmd = new SqlCommand("update monhoc set tenmh=@tenmh, sotiet=@sotiet where mamh=@mamh", conn);
            cmd.Parameters.AddWithValue("@tenmh",mh.TenMH);
            cmd.Parameters.AddWithValue("@sotiet", mh.SoTiet);
            cmd.Parameters.AddWithValue("@mamh", mh.MaMH);
            //3.thuc thi ket qua;
            return cmd.ExecuteNonQuery();
        }

    }
}