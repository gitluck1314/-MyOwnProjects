using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoreManagement
{
    public partial class KCSearch : Form
    {
        //保存查询字符串
        private string sql = "";
        private string connStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=XSCJDB;Integrated Security=True";

        public KCSearch()
        {
            InitializeComponent();
        }
        private void KCSearch_Loade(object sender, EventArgs e)
        {
            string _sql = "select distinct kch from KCB";
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(_sql, conn);
            try
            {
                //160950214
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                //读取课程号
                while (dr.Read())
                {
                    kch.Items.Add(dr[0]);
                }
                kch.SelectedIndex = 0;
                dr.Close();

            }
            finally
            {
                conn.Close();
            }
        }
        private void MakeSalStr()
        {
            //清空上次的查询字符串
            sql = "";
            if (kcm.Text.Trim() != string.Empty)
            {
                sql = " and kcm like N'%" + kcm.Text.Trim() + "%'";
            }
            if (kch.Text.Trim() != string.Empty)
            {
                sql += " and kch like N'%" + kch.Text.Trim() + "%'";
            }
        }

        private void kbSeach_Click(object sender, EventArgs e)
        {
            //获取查询字符串
            MakeSalStr();
            string _sql = "select kcm as '课程名',kch as '课程号',xq as '开课时间',xs as '学时',xf as '学分' from KCB where 1=1" + sql;
            SqlConnection conn = new SqlConnection(connStr);
            SqlDataAdapter sda = new SqlDataAdapter(_sql, conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            KCDGV.DataSource = ds.Tables[0].DefaultView;
        }

       
    }
}
