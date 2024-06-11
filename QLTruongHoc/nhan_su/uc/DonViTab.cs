using Oracle.ManagedDataAccess.Client;
using QLTruongHoc.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTruongHoc.nhan_su.uc
{
    public partial class DonViTab : UserControl
    {
        public DonViTab()
        {
            InitializeComponent();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM QLTH.UV_QLTH_DONVI_FORM";
            OracleDataAdapter da = new OracleDataAdapter(sql, Session.Instance.OracleConnection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            CustomizeColumnHeaders();
        }

        private void CustomizeColumnHeaders()
        {
            // Change column headers to custom names
            dataGridView1.Columns["MADV"].HeaderText = "Mã Đơn Vị";
            dataGridView1.Columns["TENDV"].HeaderText = "Tên Đơn Vị";
            dataGridView1.Columns["TDV"].HeaderText = "Trưởng Đơn Vị";

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string search = searchTextBox.Text;
            search = search.ToLower();
            if (search.Length > 0)
            {
                string sql = $"SELECT * FROM QLTH.UV_QLTH_DONVI_FORM WHERE TENDV LIKE LOWER('%{search}%')";
                OracleDataAdapter da = new OracleDataAdapter(sql, Session.Instance.OracleConnection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                CustomizeColumnHeaders();
            }
        }
    }
}
