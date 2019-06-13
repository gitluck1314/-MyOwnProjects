using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ScoreManagement
{
    class DataLoad
    {
        //数据库连接字符串
        private static string strcon = @"server=localhost;User Id=root;password=lzb@gxm;database=XSCJDB;Character Set=utf8";
        //创建数据库连接对象
        private MySqlConnection sqlcon = new MySqlConnection(strcon);
        //实现程序初始化时载入数据
        public MySqlConnection initializeData(ComboBox _xh, ComboBox _kcm)
        {
            try
            {
                sqlcon.Open();
                string sql = "SELECT DISTINCT XH FROM XSB";
                MySqlCommand cmd = new MySqlCommand(sql, sqlcon);
                MySqlDataReader mdr = cmd.ExecuteReader();
                //读取并加载工号或学号
                while (mdr.Read())
                {
                    _xh.Items.Add(mdr[0]);
                }
                mdr.Close();
                sql = "SELECT DISTINCT KCM FROM KCM";
                cmd = new MySqlCommand(sql, sqlcon);
                mdr = cmd.ExecuteReader();

                //读取并加载课程
                while (mdr.Read())
                {
                    _kcm.Items.Add(mdr[0]);

                }
                mdr.Close();
                return sqlcon;//返回数据库连接对象
            }
            catch (Exception e){
                MessageBox.Show("初始化失败！错误信息为：\r\n" + e.ToString() + "异常");
                return null;
            }
        }

    }
}
