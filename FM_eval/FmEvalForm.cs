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
using System.IO;
using System.Collections;

namespace FM_eval
{
    public partial class FmEvalForm : Form
    {
       // private 
        public FmEvalForm()
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

                        var allLines = File.ReadAllLines(fileName);
                        var query = from line in allLines
                                    let data = line.Split(',')
                                    select new
                                    {
                                        PlayerName = data[0],
                                        Aggression = Int32.Parse(data[1]),
                                        WorkRate = Int32.Parse(data[2])
                                    };
                        //int Count = 0;

                        List<Player> players = new List<Player>();

                        foreach (var s in query)
                        {
                            //Count++;
                            Player newPlayer = new Player();
                            newPlayer.PlayerName = s.PlayerName;
                            newPlayer.Aggression = s.Aggression;
                            newPlayer.WorkRate = s.WorkRate;
                            players.Add(newPlayer);
                            
                        }

                        //playersDataSet.Lo

                    }
                }
            }
            return dt;
        }
        OpenFileDialog ofd = new OpenFileDialog();

        private void fileBrowse_Click(object sender, EventArgs e)
        {
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void importCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ofd.Filter = "CSV|*.csv";
            // original before I found out about ofd.Filter
            //string pattern = ".*\\.csv$";
            //if (ofd.ShowDialog() == DialogResult.OK && Regex.IsMatch(ofd.FileName.Trim(), pattern, RegexOptions.IgnoreCase))
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //Console.Write(pattern);
                //Console.Write(ofd);
                toolStripFilePath.Text = ofd.FileName;
                dataGridView.DataSource = readCsv(ofd.FileName);
            }
            else
            {
                MessageBox.Show("Please select a CSV only", "FM Eval", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
        }
    }
}
