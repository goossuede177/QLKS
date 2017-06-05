using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Qlks
{
    public partial class Vatdungphong : Form
    {
        public Vatdungphong()
        {
            InitializeComponent();
        }
        CauLenh cl = new CauLenh();
        SqlDataReader dr;
        DataTable dt;
        private void loaddulieu()
        {

            dt = cl.hienvatdung(0);
            dgv_VatDung.DataSource = dt.DefaultView;

        }

        private void Vatdungphong_Load(object sender, EventArgs e)
        {
            loaddulieu();
        }

       

        private void dgv_VatDung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
    }
    }

