using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ScoreManagement
{
    public partial class FormMain : Form
    {
    
        private string strcon = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=XSCJDB;Integrated Security=True";
       
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
        
                string _sql1 = "select stuxh as '学号',stuname as '姓名',stuzy as '专业',stuxb as '性别',stucs as '出生日期',stuzxf as '学分',stubz as '备注' from XSB";
                SqlConnection conn1 = new SqlConnection(strcon);
                SqlDataAdapter comm1 = new SqlDataAdapter(_sql1, conn1);
                DataSet ds1 = new DataSet();
                comm1.Fill(ds1);
                StuDGV.DataSource = ds1.Tables[0].DefaultView;
            
                string _sql2 = "select tnum as '教师工号',username as '姓名',txb as '性别', roles as '权限' from Teacher";
                SqlConnection conn2 = new SqlConnection(strcon);
                SqlDataAdapter comm2 = new SqlDataAdapter(_sql2, conn2);
                DataSet ds2 = new DataSet();
                comm2.Fill(ds2);
                TeacherDGV.DataSource = ds2.Tables[0].DefaultView;
           
            
        }

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

        //
        //学生管理
        //
        private void StuDGV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow dgvRow = StuDGV.Rows[e.RowIndex];
            DataGridViewCellCollection dgvCC = dgvRow.Cells;
            stuXH.Text = dgvCC[0].Value.ToString();
            stuXM.Text = dgvCC[1].Value.ToString();
            stuZY.Text = dgvCC[2].Value.ToString();
            if (dgvCC[3].Value.ToString() == "男")
            {
                male.Checked = true;
            }
            else
            {
                female.Checked = true;
            }
            stuCS.Text = dgvCC[4].Value.ToString();
            stuZXF.Text = dgvCC[5].Value.ToString();
            stuBZ.Text = dgvCC[6].Value.ToString();
        }

        //
        //学生更新
        //
        private void stuUpdate_Click(object sender, EventArgs e)
        {
            string _sql = "select count(*) from XSB where stuxh ='" + stuXH.Text + "'";
            SqlConnection conn = new SqlConnection(strcon);
            SqlCommand cmd = new SqlCommand(_sql, conn);
           
            //检查是否有此学生记录，有就修改，无就添加
            try
            {
                conn.Open();
                int cnt = (int)cmd.ExecuteScalar();
                string sex =  male.Checked == true ? "男":"女";
                //修改记录
                if (cnt == 1)
                {
                    _sql = "update XSB set stuname =N'" + stuXM.Text + "',stuxb=N'" + sex + "',stucs=N'" + stuCS.Text + "',stuzy=N'" + stuZY.Text + "',stuzxf=" + float.Parse(stuZXF.Text) + ",stubz=N'" + stuBZ.Text + " 'where stuxh=N'" + stuXH.Text + "'";
                    stuXH.Text = "";
                    stuXM.Text = "";
                    stuZY.Text = "";
                    male.Checked = true;
                    stuCS.Text = "";
                    stuZXF.Text = "";
                    stuBZ.Text = "";
                }
                //添加新纪录
                else
                {
                    _sql = "insert into XSB values(' ',"+"'" + stuXH.Text + "','" + stuXM.Text + "', '" + stuCS.Text + "','" + stuZY.Text + "','" + stuBZ.Text + "','" + sex + "','" + float.Parse(stuZXF.Text) + "')";
                    stuXH.Text = "";
                    stuXM.Text = "";
                    stuZY.Text = "";
                    male.Checked = true;
                    stuCS.Text = "";
                    stuZXF.Text = "";
                    stuBZ.Text = "";
                }
                MessageBox.Show("更新成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmd = new SqlCommand(_sql, conn);
                cmd.ExecuteNonQuery();
                FormMain_Load(null, null);
            }
            finally
            {
                conn.Close();
            }

        }
        //
        //学生删除
        //
        private void stuDelete_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("确定要删除记录吗？", "删除", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (ret==DialogResult.Cancel) {
                return;
            }
            string _sql = "delete from XSB where stuxh='" + stuXH.Text + "'";
            SqlConnection conn = new SqlConnection(strcon);
            SqlCommand cmd = new SqlCommand(_sql, conn);
            try
            {
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                FormMain_Load(null, null);
                if (rows == 1)
                {
                    MessageBox.Show("删除成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    stuXH.Text = "";
                    stuXM.Text = "";
                    stuZY.Text = "";
                    male.Checked = true;
                    stuCS.Text = "";
                    stuZXF.Text = "";
                    stuBZ.Text = "";
                }
            }
            finally {
                conn.Close();
            }
        }
        //
        //学生管理取消
        //
        private void stuCancle_Click(object sender, EventArgs e)
        {
            stuXH.Text = "";
            stuXM.Text = "";
            stuZY.Text = "";
            male.Checked = true;
            stuCS.Text = "";
            stuZXF.Text = "";
            stuBZ.Text = "";
        }

        //
        //教师管理
        //
        private void TeacherDGV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow dgvRow = TeacherDGV.Rows[e.RowIndex];
            DataGridViewCellCollection dgvCC = dgvRow.Cells;
            tnum.Text = dgvCC[0].Value.ToString();
            username.Text = dgvCC[1].Value.ToString();
            if (dgvCC[2].Value.ToString() == "男")
            {
                male.Checked = true;
            }
            else
            {
                female.Checked = true;
            }
            roles.Text = dgvCC[3].Value.ToString();
        }
        //
        //教师更新
        //
        private void upd_Click(object sender, EventArgs e)
        {
            string _sql = "select count(*) from Teacher where tnum ='" + tnum.Text + "'";
            SqlConnection conn = new SqlConnection(strcon);
            SqlCommand cmd = new SqlCommand(_sql, conn);
            
            //检查是否有此学生记录，有就修改，无就添加
            try
            {
                conn.Open();
                int cnt = (int)cmd.ExecuteScalar();
                string sex = Tmale.Checked ? "男" : "女";

                //修改记录
                if (cnt == 1)
                {
                    _sql = "update Teacher set username =N'" + username.Text + "',tnum=N'" + tnum.Text + "',roles=N'" + roles.Text + "',txb=N'" + sex  +" 'where tnum=N'" + tnum.Text + "'";
                }
                //添加新纪录
                else
                {
                    _sql = "insert into Teacher values(' '," + "N'" + username.Text + "',N'" + tnum.Text + "', N'" + roles.Text + "', N'" + sex + "')";
                }
                MessageBox.Show("更新成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmd = new SqlCommand(_sql, conn);
                cmd.ExecuteNonQuery();
                FormMain_Load(null, null);
            }
            finally
            {
                conn.Close();
            }
        }
        //
        //教师删除
        //
        private void del_Click(object sender, EventArgs e)
        {

            DialogResult ret = MessageBox.Show("确定要删除记录吗？", "删除", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (ret == DialogResult.Cancel)
            {
                return;
            }
            string _sql = "delete from teacher where tnum='" + tnum.Text + "'";
            SqlConnection conn = new SqlConnection(strcon);
            SqlCommand cmd = new SqlCommand(_sql, conn);
            try
            {
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                FormMain_Load(null, null);
                if (rows == 1)
                {
                    MessageBox.Show("删除成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            finally
            {
                conn.Close();
            }
            tnum.Text = "";
            username.Text = "";
            male.Checked = true;
            Tfemale.Checked = true;
            roles.Text = "";
        }
        //
        //教师管理取消
        //
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            tnum.Text = "";
            username.Text = "";
            male.Checked = true;
            Tfemale.Checked = true;
            roles.Text = "";
        }

    }
}
