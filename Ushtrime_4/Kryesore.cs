using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Ushtrime_4
{
    public partial class Kryesore : Form
    {
        public Kryesore()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Skedar sk = new Skedar();
            DataTable dt = sk.Lexo("C:\\Users\\GRKN\\Documents\\Ushtrime_4\\Ushtrime_4\\Emails.csv");
            Ruaj r = new Ruaj();
            foreach (DataRow row in dt.Rows)
            {
                string ad = row.Field<string>(0); 
                string su = row.Field<string>(1);
                string tr = row.Field<string>(2);
                r.ShtoNeTabele(ad, su, tr);
            }
        }
    }
}
