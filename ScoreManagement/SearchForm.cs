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
    public partial class SearchForm : Form
    {
        //保存查询字符串
        private string sql = "";
        private string connStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=XSCJDB;Integrated Security=True";

        public SearchForm()
        {
            InitializeComponent();
        }

         private void SearchForm_Load(object sender, EventArgs e)
        {
            string _sql = "select stuxh as '学号',stuname as '姓名',stuzy as '专业',stuxb as '性别'," + "stucs as '出生日期',stuzxf as '学分',stubz as '备注' from XSB";
            SqlConnection conn = new SqlConnection(connStr);
            SqlDataAdapter sda = new SqlDataAdapter(_sql, conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
          
            StuDGV.DataSource = ds.Tables[0].DefaultView;
            stuZY.SelectedIndex = 0;

            string sql1 = "select distinct stuzy from XSB";
            SqlConnection conn1 = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(sql1, conn1);
            try
            {
                //160950214
                conn1.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                //读取专业名
                while (dr.Read())
                {
                    stuZY.Items.Add(dr[0]);
                }
                stuZY.SelectedIndex = 0;
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
            if (stuXH.Text.Trim() != string.Empty)
            {
                sql = " and stuxh like N'%" + stuXH.Text.Trim() + "%'";
            }
            if (stuXM.Text.Trim() != string.Empty)
            {
                sql += " and stuname like N'%" + stuXM.Text.Trim() + "%'";
            }
            if (stuZY.Text != "所有专业")
            {
                sql += " and stuzy=N'" + stuZY.Text.Trim() + "'";
            }
        }
        private void search_btn_Click(object sender, EventArgs e)
        {
            //获取查询字符串
            MakeSalStr();
            string _sql = "select stuxh as '学号',stuname as '姓名',stuzy as '专业',stuxb as '性别',stucs as '出生日期',stuzxf as '总学分',stubz as '备注' from XSB where 1=1" + sql;
            SqlConnection conn = new SqlConnection(connStr);
            SqlDataAdapter sda = new SqlDataAdapter(_sql, conn);
            DataSet ds = new DataSet();
            sda.Fill(ds); 
            StuDGV.DataSource = ds.Tables[0].DefaultView;
        }

      

        private void StuDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string _sql = "select XSB.stuname as '姓名',KCB.kcm as '课程',CJB.cj as '成绩',KCB.xf as '学分' from XSB,KCB,CJB" + " where XSB.stuxh=CJB.stuxh and KCB.KCH=CJB.KCH" + " and XSB.stuxh='" + StuDGV.Rows[e.RowIndex].Cells[0].Value + "'";
            SqlConnection conn = new SqlConnection(connStr);
            SqlDataAdapter sda = new SqlDataAdapter(_sql, conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            CourseForm courseFrm = new CourseForm();
            courseFrm.stuKCDGV.DataSource = ds.Tables[0].DefaultView;
            courseFrm.ShowDialog();

        }
    }
}
