using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputingProbabilities
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void About_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.Columns.Add("Author name");
            listView1.Columns.Add("E-mail");
            listView1.Columns.Add("Web page");
            listView1.FullRowSelect = true;
            listView1.Show();

            ListViewItem lviItem = new ListViewItem("Marius Iulian MIHAILESCU");
            lviItem.SubItems.Add("marius.mihailescu@hotmail.com");
            lviItem.SubItems.Add("https://www.linkedin.com/in/mariusiulianmihailescu/");

            ListViewItem lviItem1 = new ListViewItem("Stefania Loredana NITA");
            lviItem1.SubItems.Add("stefania.nita@outlook.com");
            lviItem1.SubItems.Add("https://www.linkedin.com/in/stefania-loredana-nita-076257b4/");

            listView1.Items.Add(lviItem);
            listView1.Items.Add(lviItem1);

            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
