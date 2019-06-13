using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoreManagement
{
    public partial class Form1 : Form
    {
      
       
        public Form1()
        {
            InitializeComponent();
        }

        FormStudent fStudent = new FormStudent();//学生主页面
        FormTeacher fTeacher = new FormTeacher();//教师主页面
        FormMain fMain = new FormMain();//管理员页面

        /// <summary>
        /// 学生信息查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Login.roles);
            if (Login.roles == "学生")
            {
                fStudent.Show();
            }
            else {
                SearchForm searchForm = new SearchForm();
                searchForm.Show();
            }
            
        }
        /// <summary>
        /// 学生信息修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ModifyFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifyForm modifyForm = new ModifyForm();
            modifyForm.Show();
            
        }
        /// <summary>
        /// 学生成绩录入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ScoreFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Login.roles);

            if (Login.roles.Trim() == "教师")
            {
                fTeacher.Show();
            }
            else
            {
                MessageBox.Show("您没有操作权限！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// 课程查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
             KCSearch kcsearch = new KCSearch();
             kcsearch.Show();

        }

        /// <summary>
        /// 课程修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Login.roles == "教师")
            {
                fTeacher.Show();
            }
            else
            {
                MessageBox.Show("您没有操作权限！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// 权限管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 权限管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Login.roles);
            if (Login.roles == "管理员")
            {
                fMain.Show();
            }
            else
            {
                MessageBox.Show("您没有操作权限！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

      
    }
}
