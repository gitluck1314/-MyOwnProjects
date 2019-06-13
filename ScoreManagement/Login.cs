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
    public partial class Login : Form
    {
        static public string sn, sub, major, sname,roles;//定义两个静态变量
        
        public Login()
        {
            InitializeComponent();
        }

        // FormStudent fStudent = new FormStudent();//学生主页面
        // FormTeacher fTeacher = new FormTeacher();//教师主页面
        // FormMain fMain = new FormMain();//管理员页面
        Form1 f1 = new Form1();

        //
        //登录按钮
        //
        private void SignUp_Click(object sender, EventArgs e)
        {
            if (!ValidateInfo()) return;//用静态方法验证信息
            string strcon = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=XSCJDB;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strcon);
            conn.Open();
            if (username.Text==""|| password.Text=="") { MessageBox.Show("请不要遗漏信息！ "); }
            //
            //管理员权限
            //
            if (rbtnmanager.Checked) {
                //MessageBox.Show(rbtnmanager.Text.Trim() + username.Text.Trim() + password.Text.Trim());
                string cstr = "select * from Login where roles=N'管理员' and username=N'"+username.Text.Trim()+"' and password=N'"+password.Text.Trim()+"'";
                SqlCommand comm = new SqlCommand(cstr, conn);
                SqlDataReader dr = comm.ExecuteReader();
                Boolean langS = dr.Read();            
                Boolean flag = (langS.Equals(true) ? true : false);
             
                if (flag)
                {               
                    sn = username.Text.Trim();
                    roles = rbtnmanager.Text.Trim();
                    MessageBox.Show(roles);

                    // fMain.Show();
                    f1.Show();
                    this.Visible = false;
                }
                
            }
            //
            //教师权限
            //
            if (rbtnteacher.Checked) {
                string cstr = "select * from Login where roles=N'教师' and username=N'" + username.Text.Trim() + "' and password=N'" + password.Text.Trim() + "'";
                SqlCommand comm = new SqlCommand(cstr, conn);
                SqlDataReader dr = comm.ExecuteReader();
                Boolean langS = dr.Read();
                Boolean flag = (langS.Equals(true) ? true : false);
                if (flag)
                {

                    sn = username.Text.Trim();
                    roles = rbtnteacher.Text.Trim();
                    MessageBox.Show(roles+"denglu");
                    f1.Show();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("输入有误， 请重新输入！ ");
                    username.Text = "";
                    password.Text = "";
                    rbtnteacher.Checked = false;
                }
            } 
            //
            //学生权限
            //
            if (rbtnstudent.Checked) {
                string cstr = "select * from Login where roles=N'学生' and username=N'" + username.Text.Trim() + "' and password=N'" + password.Text.Trim() + "'";
                SqlCommand comm = new SqlCommand(cstr, conn);
                SqlDataReader dr = comm.ExecuteReader();
                Boolean langS = dr.Read();
                Boolean flag = (langS.Equals(true) ? true : false);
                if (flag)
                {
                    sn = username.Text.Trim();
                    roles = rbtnstudent.Text.Trim();
                    f1.Show();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("输入有误， 请重新输入！ ");
                    username.Text = "";
                    password.Text = "";
                    rbtnstudent.Checked = false;
                }
            }
            conn.Close();
            conn.Dispose();
        }


        //
        //取消登录
        //
        private void Cancle_butn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //
        //验证信息
        //
        private bool ValidateInfo() {
            bool b = true;
            if (string.IsNullOrWhiteSpace(username.Text)) {
                MessageBox.Show("用户名为学号/工号，用户名不能为空！");
            }
            if (rbtnmanager.Checked == false && rbtnstudent.Checked == false && rbtnteacher.Checked == false)
            {
                MessageBox.Show("请选择身份信息", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return b;
        }
    }
}
