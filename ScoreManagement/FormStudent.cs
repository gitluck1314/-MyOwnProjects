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
    public partial class FormStudent : Form
    {
        private string strcon = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=XSCJDB;Integrated Security=True";

        public FormStudent()
        {
            InitializeComponent();
        }
        private void FormStudent_Load(object sender, EventArgs e) {

            string sn = Login.sn;
            MessageBox.Show(sn);
            string _sql = "select stuxh as '学号',stuname as '姓名',stuzy as '专业',stuxb as '性别',stucs as '出生日期',stuzxf as '学分',stubz as '备注' from XSB where stuxh='"+ sn + "'";
            SqlConnection conn = new SqlConnection(strcon);
            SqlDataAdapter da = new SqlDataAdapter(_sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "usertable");
            MessageBox.Show(ds.Tables["usertable"].Rows[0][2].ToString());
            //160950214 
            stuXH.Text = ds.Tables["usertable"].Rows[0][0].ToString();
            stuXM.Text = ds.Tables["usertable"].Rows[0][1].ToString();
            stuZY.Text = ds.Tables["usertable"].Rows[0][2].ToString();
            male.Checked = ds.Tables["usertable"].Rows[0][3].ToString()=="男"? true:false;
            female.Checked = ds.Tables["usertable"].Rows[0][3].ToString() == "女" ? true : false;
            stuCS.Text = ds.Tables["usertable"].Rows[0][4].ToString();
            stuZXF.Text = ds.Tables["usertable"].Rows[0][5].ToString();
            stuBZ.Text = ds.Tables["usertable"].Rows[0][6].ToString();
            

            string _sql2 = "select kcm as '课程名',cj as '成绩',xf as '学分' from CJB,KCB where CJB.stuxh='" + sn + "' and CJB.kch=KCB.kch";
            SqlConnection conn2 = new SqlConnection(strcon);
            SqlDataAdapter comm2 = new SqlDataAdapter(_sql2, conn2);
            DataSet ds2 = new DataSet();
            comm2.Fill(ds2);
            cjDGV.DataSource = ds2.Tables[0].DefaultView;


        }

        private void outbtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定退出系统？", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
                Login l = new Login();
                l.Visible = true;
            }
        }

        private void cjDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
