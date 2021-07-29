using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PRG251_ST_Shane_Bekker_.classes;

namespace PRG251_ST_Shane_Bekker_
{
    public partial class frmbind1 : Form
    {
        #region Fields

        private DataHandler Data = new DataHandler();
        private BindingSource source = new BindingSource();

        #endregion Fields

        #region Constructors

        public frmbind1()
        {
            InitializeComponent();
        }

        #endregion Constructors



        #region Methods

        private void btn1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnall_Click(object sender, EventArgs e)
        {
            source.DataSource = Data.Origin;
            dbgrid1.DataSource = source;
        }

        private void btnBus_Click(object sender, EventArgs e)
        {
            source.DataSource = Data.Abuse_bus;
            dbgrid1.DataSource = source;
        }

        private void btnf_Click(object sender, EventArgs e)
        {
            source.MoveFirst();
        }

        private void btnlast_Click(object sender, EventArgs e)
        {
            source.MoveLast();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            source.MoveNext();
        }

        private void btnprior_Click(object sender, EventArgs e)
        {
            source.MovePrevious();
        }

        private void btnSuv_Click(object sender, EventArgs e)
        {
            source.DataSource = Data.Abuse_suv;
            dbgrid1.DataSource = source;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            source.DataSource = Data.Origin;

            dbgrid1.DataSource = source;
            dbgrid1.Columns[1].DefaultCellStyle.Format = "c";
            dbgrid1.Columns[4].DefaultCellStyle.Format = "c";
            nlble.Text = "";
            prlble.Text = "";
            lbletype.Text = "";
            lblediscount.Text = "";
        }

        #endregion Methods

        private void btnsearch_Click(object sender, EventArgs e)
        {
            Car a = new Car();
            a = null;
            foreach (Car item in Data.Origin)
            {
                if (item.Name.ToLower() == txtbx.Text.ToLower())
                {
                    a = item;
                }
            }
            if (a is null)
            {
                MessageBox.Show("This is invalid:\n" + txtbx.Text + "\nEnter a valid name");
            }
            else
            {
                nlble.Text = a.Name;
                prlble.Text = Convert.ToString(a.Price);
                lbletype.Text = a.type;
                lblediscount.Text = Convert.ToString(a.Discounted);
            }
        }
    }
}