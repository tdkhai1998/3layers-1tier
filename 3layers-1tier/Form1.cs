using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace _3layers_1tier
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_load_all_Click(object sender, EventArgs e)
        {
            dGrV_main.DataSource = SachBUS.LoadAll();
        }

       

        private void btn_insert_Click(object sender, EventArgs e)
        {
            InsertNew fm = new InsertNew();
            fm.ShowDialog();
        }
        private void Edit(Sach s)
        {
            InsertNew fm = new InsertNew(s);
            fm.ShowDialog();
        }
    }
}
