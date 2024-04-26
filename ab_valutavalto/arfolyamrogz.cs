using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ab_valutavalto
{
    public partial class arfolyamrogz : Form
    {
        public arfolyamrogz()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void arfolyamrogz_Load(object sender, EventArgs e)
        {
            cbload();
        }

        private void cbload()
        {
            db db = new db($"SELECT devizanemek.devkod from devizanemek where devkod not in (SELECT arfolyamok.devkod from arfolyamok where datum = '{dateTimePicker1.Value.ToString("yyyy-MM-dd")}') ");
            while (db.Dr.Read())
            {
                cb_devnem.Items.Add(db.Dr[0]);
            }
            
        }

        private void tb_devegys_TextChanged(object sender, EventArgs e)
        {
            if (tb_devegys.TextLength>0)
            {
                try
                {
                    int a = int.Parse(tb_devegys.Text);
                }
                catch
                {
                    tb_devegys.Text = null;
                    tb_devegys.Focus();
                    MessageBox.Show("Csak számot adjon meg!");
                }
            }
        }

        private void tb_hufegys_TextChanged(object sender, EventArgs e)
        {
            if (tb_hufegys.TextLength > 0)
            {
                try
                {
                    double a = double.Parse(tb_hufegys.Text);
                }
                catch
                {
                    tb_hufegys.Text = null;
                    tb_hufegys.Focus();
                    MessageBox.Show("Csak számot adjon meg!");
                }
            }
        }

        private void btn_ment_Click(object sender, EventArgs e)
        {
            if (tb_devegys.TextLength==0)
            {
                tb_devegys.Focus();
                MessageBox.Show("töltse ki a mezőt!");
            }
            else if (tb_hufegys.TextLength==0)
            {
                tb_hufegys.Focus();
                MessageBox.Show("töltse ki a mezőt!");
            }
            else
            {
                try
                {
                    db db = new db($"INSERT INTO arfolyamok(datum,devkod,devegyseg,hufegyseg) VALUES('{dateTimePicker1.Value.ToString("yyyy-MM-dd")}','{cb_devnem.SelectedItem.ToString()}','{tb_devegys.Text}','{tb_hufegys.Text}')");
                    db.Dr.Read();
                    MessageBox.Show("sikeres művelet!");
                }
                catch
                {
                    MessageBox.Show("Hibás művelet!");

                }
            }
        }

        private void cb_devnem_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            cbload();
        }

        private void btn_elvet_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
