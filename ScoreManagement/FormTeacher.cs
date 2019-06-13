﻿using System;
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
    public partial class FormTeacher : Form
    {
        private string connStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=XSCJDB;Integrated Security=True";

        public FormTeacher()
        {
            InitializeComponent();
        }
        private void FormTeacher_Load(object sender, EventArgs e)
        {
            string _sql = "select distinct stuzy from XSB";
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(_sql, conn);
            try
            {
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                //读取专业名
                while (dr.Read())
                {
                    stuZY.Items.Add(dr[0]);
                }
                stuZY.SelectedIndex = 0;
                dr.Close();


                //读取课程名
                _sql = "select kcm from KCB";
                cmd = new SqlCommand(_sql, conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    stuKCM.Items.Add(dr[0]);
                }
                dr.Close();


                //读取课程号
                string sql1 = "select kch from KCB";
                cmd = new SqlCommand(sql1, conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    kch.Items.Add(dr[0]);
                }
                dr.Close();
            }
            finally
            {
                conn.Close();
            }


        }
        /// <summary>
        /// 课程号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void kch_SelectedIndexChanged(object sender, EventArgs e)
        {
            string _sql = "select * from KCB where kch=N'" + kch.Text + "'";
            SqlConnection conn = new SqlConnection(connStr);
            SqlDataAdapter da = new SqlDataAdapter(_sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "usertable");
           
            //160950214 
            kcm.Text = ds.Tables["usertable"].Rows[0][1].ToString();
            kcxf.Text = ds.Tables["usertable"].Rows[0][2].ToString();
            ks.Text = ds.Tables["usertable"].Rows[0][3].ToString();
            xq.Text = ds.Tables["usertable"].Rows[0][4].ToString();
        }

        //
        //专业学号联动
        //
        private void stuZY_SelectedIndexChanged(object sender, EventArgs e)
        {
            string _sql = "select stuxh from XSB where stuzy =N'" + stuZY.Text + "'";
            //清空现有学号
            stuXH.Items.Clear();
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(_sql, conn);
            try
            {
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                //读取相应的学号
                while (dr.Read())
                {
                    stuXH.Items.Add(dr[0]);
                }
                dr.Close();
                _sql = "select XSB.stuxh as '学号',XSB.stuname as '姓名',KCB.kcm as '课程名',CJB.cj as '成绩'," + "KCB.xf as '学分',KCB.xs as '学时',KCB.xq as '开课学期'"
                    + " from XSB,KCB,CJB" + " where XSB.stuxh =CJB.stuxh and KCB.kch=CJB.kch and XSB.stuzy=N'" + stuZY.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(_sql, conn);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                StuCJ_DGV.DataSource = ds.Tables[0].DefaultView;
            }
            finally
            {
                conn.Close();

            }
           
        }

        //
        //某学生莫一门课程的成绩
        //
        private void stuXH_SelectedIndexChanged(object sender, EventArgs e)
        {
            string _sql = "select XSB.stuxh as '学号',XSB.stuname as '姓名',KCB.kcm as '课程名',CJB.cj as '成绩'," + "KCB.xf as '学分'," + "KCB.xs as '学时',KCB.xq as '开课学期'"
                        + " from XSB,KCB,CJB" + " where CJB.stuxh=N'" + stuXH.Text + "'and CJB.stuxh=XSB.stuxh and CJB.kch=KCB.kch";
            if (stuKCM.Text.Trim() != string.Empty)
            {
                _sql += " and KCB.kcm='" + stuKCM.Text + "'";
            }
            SqlConnection conn = new SqlConnection(connStr);
            SqlDataAdapter sda = new SqlDataAdapter(_sql, conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            StuCJ_DGV.DataSource = ds.Tables[0].DefaultView;
        }

        private void stuKCM_SelectedIndexChanged(object sender, EventArgs e)
        {
            string _sql = "select XSB.stuxh as '学号',XSB.stuname as '姓名',KCB.kcm as '课程名',CJB.cj as '成绩'," + "KCB.xf as '学分'," + "KCB.xs as '学时',KCB.xq as '开课学期'"
                        + " from XSB,KCB,CJB" + " where KCB.kcm=N'" + stuKCM.Text + "'and CJB.stuxh=XSB.stuxh and CJB.kch=KCB.kch";
            if (stuXH.Text.Trim() != string.Empty)
            {
                _sql += " and XSB.stuxh='" + stuXH.Text + "'";
            }
            SqlConnection conn = new SqlConnection(connStr);
            SqlDataAdapter sda = new SqlDataAdapter(_sql, conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            StuCJ_DGV.DataSource = ds.Tables[0].DefaultView;
        }
       
        private void StuCJ_DGV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //获得选中的记录行
            DataGridViewRow dgvRow = StuCJ_DGV.Rows[e.RowIndex];
            //获得单元格集合
            DataGridViewCellCollection dgvCC = dgvRow.Cells;
            //获得单元格数据
            stuXM.Text = dgvCC[1].Value.ToString();
            stuCJ.Text = dgvCC[3].Value.ToString();
            stuXF.Text = dgvCC[4].Value.ToString();
            stuKCM.SelectedItem = dgvCC[2].Value;
            stuXH.SelectedItem = dgvCC[0].Value;
        }
        /// <summary>
        /// 成绩录入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void upd_Click(object sender, EventArgs e)
        {
            string _sql = "select count(*) from CJB where CJB.stuxh=N'" + stuXH.Text + "' and CJB.kch=(select kch from KCB where kcm=N'" + stuKCM.Text + "')";
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(_sql, conn);
            //检查是否有此学生记录，有就修改，无则添加
            try 
            {
                conn.Open();
                int cnt = (int)cmd.ExecuteScalar();
                //修改记录
                if (cnt == 1)
                {
                    _sql = "update CJB set CJB.cj=N'" + stuCJ.Text + "' where CJB.stuxh=N'" + stuXH.Text + "' and CJB.kch=(select kch from KCB where kcm=N'" + stuKCM.Text + "')";
                }
                //添加新记录
                else
                {
                    string _sql2 = "select kch from KCB where kcm=N'" + stuKCM.Text + "'";
                    SqlCommand cmd2 = new SqlCommand(_sql2, conn);
                    MessageBox.Show(cmd2.ExecuteScalar().ToString());
                    _sql = "insert into CJB (stuxh,kch,cj) values(N'"+stuXH.Text+"','" + cmd2.ExecuteScalar().ToString() + "',N'"+stuCJ.Text+"')";
                }
                cmd = new SqlCommand(_sql, conn);
                cmd.ExecuteNonQuery();
                stuXH_SelectedIndexChanged(null, null);
                MessageBox.Show("更新成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                conn.Close();
            }
        }
        /// <summary>
        /// 成绩删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void del_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("确定要删除记录吗？", "删除", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (ret == DialogResult.Cancel)
            {
                return;
            }
            string _sql = "delete from CJB where stuxh=N'" + stuXH.Text + "' and kch=(select kch from KCB where kcm=N'" + stuKCM.Text + "')";
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(_sql, conn);
            try
            {
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                stuXH_SelectedIndexChanged(null, null);
                if (rows == 1)
                {
                    MessageBox.Show("删除成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            finally
            {
                conn.Close();
            }
        }
        /// <summary>
        /// 成绩取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void cancle_Click(object sender, EventArgs e)
        {
            stuCJ.Text = "";
            stuXM.Text = "";
            stuXF.Text = "";
        }

        /// <summary>
        /// 退出登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void outBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定退出系统？", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
                Login l = new Login();
                l.Visible = true;
            }
        }

        /// <summary>
        /// 新开课程
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void kbUpd_Click(object sender, EventArgs e)
        {
            string _sql = "select count(*) from KCB where KCB.kch=N'"+kch.Text+"'";
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(_sql, conn);
            //检查是否有此课程记录，有就修改，无则添加
            try
            {
                conn.Open();
                int cnt = (int)cmd.ExecuteScalar();
                MessageBox.Show(cnt.ToString());
                //修改记录
                if (cnt == 1)
                {
                    _sql = "update KCB set KCB.kcm=N'" + kcm.Text + "' , KCB.xf='" + int.Parse(kcxf.Text) + "',KCB.xq=N'" + xq.Text + "',KCB.xs='" + int.Parse(ks.Text) + "'  where KCB.kch=N'" + kch.Text + "'";
                }
                //添加新记录
                else
                {
                    _sql = "insert into KCB (kch,kcm,xf,xq,xs) values(N'" + kch.Text + "',N'" + kcm.Text + "','" + int.Parse(kcxf.Text) + "',N'" + xq.Text + "','"+int.Parse(ks.Text)+"')";
                }
                cmd = new SqlCommand(_sql, conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("更新成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                kcm.Text = "";
                kcxf.Text = "";
                ks.Text = "";
                xq.Text = "";
                kch.Text = "";
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// 删除课程
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void kbDel_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("确定要删除记录吗？", "删除", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (ret == DialogResult.Cancel)
            {
                return;
            }
            string _sql = "delete from KCB where kch=N'" + kch.Text + "'";
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(_sql, conn);
            try
            {
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows == 1)
                {
                    MessageBox.Show("删除成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    kcm.Text = "";
                    kcxf.Text = "";
                    ks.Text = "";
                    xq.Text = "";
                    kch.Text = "";
                }
            }
            finally
            {
                conn.Close();
            }
        }

        private void kbCancle_Click(object sender, EventArgs e)
        {
            kcm.Text = "";
            kcxf.Text = "";
            ks.Text = "";
            xq.Text = "";
            kch.Text = "";
        }

       
    }
}
