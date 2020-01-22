using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace uygulama
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGtr_Click(object sender, EventArgs e)
        {
            grdGoster.DataSource = clsDB.veriCek();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
