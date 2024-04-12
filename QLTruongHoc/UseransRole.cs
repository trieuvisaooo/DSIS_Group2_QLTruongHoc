﻿using Microsoft.EntityFrameworkCore.Query.Internal;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTruongHoc
{
    public partial class UseransRole : UserControl
    {
        public static OracleConnection conNow = Login.con;
        public static DataGridView grid1;
        public static DataGridView grid2;

        public UseransRole()
        {
            InitializeComponent();
            DBA_load_UserAndRole();
        }


        private void DBA_load_UserAndRole()
        {
            try
            {
                // Select table
                string selectTableSql = "SELECT USERNAME, USER_ID, CREATED FROM ALL_USERS ORDER BY USERNAME";
                OracleCommand command = new OracleCommand(selectTableSql, conNow);
                command.BindByName = true;
                command.Parameters.Add(new OracleParameter("owner", Login.username));
                OracleDataAdapter adapter = new OracleDataAdapter(command) { SuppressGetDecimalInvalidCastException = true };
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                userGrid.DataSource = dataTable;
                grid1 = userGrid;

                // Select View
                string selectViewSql = "SELECT role, role_id, password_required FROM DBA_ROLES";
                OracleCommand command1 = new OracleCommand(selectViewSql, conNow);
                command1.BindByName = true;
                command1.Parameters.Add(new OracleParameter("owner", Login.username));
                OracleDataAdapter adapter1 = new OracleDataAdapter(command1) { SuppressGetDecimalInvalidCastException = true };
                DataTable dataTable1 = new DataTable();
                adapter1.Fill(dataTable1);
                roleGrid.DataSource = dataTable1;
                grid2 = roleGrid;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void UseransRole_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // CREATE USER
            DBA_CreateUser dBA_CreateUser = new DBA_CreateUser();
            dBA_CreateUser.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DBA_CreateRole dBA_CreateRole = new DBA_CreateRole();
            dBA_CreateRole.Show();
        }
    }
}
