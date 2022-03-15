using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IniFiles f = new IniFiles("./set.ini");
            string demo = f.IniReadValue("SectionDemoTest", "UserName");
            this.textBox1.Text = demo;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string filePath = @"E:\Test\set.ini";
            //写入节点1
            INIHelper.Write("s1", "1", "a", filePath);
            INIHelper.Write("s1", "2", "b", filePath);
            INIHelper.Write("s1", "3", "c", filePath);
            //写入节点2
            INIHelper.Write("s2", "4", "d", filePath);
            INIHelper.Write("s2", "5", "e", filePath);
            //改节点值（就是重写一遍）
            INIHelper.Write("s1", "3", "c3", filePath);
            //读取节点1中的key为1的值
            //string value = INIHelper.Read("s1", "1", "789", filePath);
            ////删除节点 / 键
            //INIHelper.DeleteKey("s1", "2", filePath);//删除节点s1中key为2的值
            //INIHelper.DeleteSection("s1", filePath);//删除节点s2
        }
    }
}
