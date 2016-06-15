using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// additional code - this helps short cut some of the junk you would have to type if you didnt do it
// for example: System.Text.RegularExpressions.Regex.IsMatch
// also as it turns out, you don't need to do this to check for file extensions
// the OpenFileDialog has it built in
using System.Text.RegularExpressions;
using System.Data.OleDb;

namespace FM_eval
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public DataTable readCsv(string fileName)
        {
            DataTable dt = new DataTable("Data");
            using (OleDbConnection cn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\"" + System.IO.Path.GetDirectoryName(fileName) + "\";Extended Properties='text;HDR=yes;FMT=Delimited(,)';"))
            {
                using (OleDbCommand cmd = new OleDbCommand(string.Format("select * from [{0}]", new System.IO.FileInfo(fileName).Name), cn))
                {
                    cn.Open();
                    using(OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }
        OpenFileDialog ofd = new OpenFileDialog();

        private void fileBrowse_Click(object sender, EventArgs e)
        {
            ofd.Filter = "CSV|*.csv";
            // original before I found out about ofd.Filter
            //string pattern = ".*\\.csv$";
            //if (ofd.ShowDialog() == DialogResult.OK && Regex.IsMatch(ofd.FileName.Trim(), pattern, RegexOptions.IgnoreCase))
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //Console.Write(pattern);
                //Console.Write(ofd);
                fileTextBox.Text = ofd.FileName;
                dataGridView.DataSource = readCsv(ofd.FileName);
            }
            else
            {
                MessageBox.Show("Please select a CSV only", "FM Eval",MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
