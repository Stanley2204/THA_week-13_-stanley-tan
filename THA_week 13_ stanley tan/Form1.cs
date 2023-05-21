using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace THA_week_13__stanley_tan
{
    public partial class Form1 : Form
    {
        MySqlConnection connect = new MySqlConnection();
        MySqlCommand command = new MySqlCommand();
        MySqlDataAdapter data = new MySqlDataAdapter();
        string con = "server=localhost;uid=root;pwd=;database=premier_league";
        string sql;
        DataTable one = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
