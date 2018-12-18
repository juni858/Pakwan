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

namespace PakwanPOS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_signin_Click(object sender, EventArgs e)
        {
            if (textBox_PasswordSignIN.Text != "" && textBox_userNamesignIn.Text != "")
            {
                SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\muham\Source\Repos\Pakwan\PakwanPOS\PakwanPOS\DB.mdf;Integrated Security=True");
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select Name,AccountType FROM [User] where userID='" + textBox_userNamesignIn.Text + "' and Password='" + textBox_PasswordSignIN.Text + "'", sqlConnection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    tableLayoutPanel1.Visible = true;
                    flowLayoutPanel1.Visible = true;
                }
                else
                {
                    MessageBox.Show("Incorrect User Name or Password");
                }
            }
            else
            {
                MessageBox.Show("Empty Fields");
            }

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            tableLayoutPanel1.Visible = false;
            flowLayoutPanel1.Visible = false;
        }
    }
}
