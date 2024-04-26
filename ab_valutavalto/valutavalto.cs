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
    public partial class valutavalto : Form
    {
        public valutavalto()
        {
            InitializeComponent();
        }
        string devkod = "";
        private void cbload()
        {
            cb_deviza.Items.Clear();
            db db = new db($"SELECT arfolyamok.devkod from arfolyamok where arfolyamok.datum = '{dateTimePicker1.Value.ToString("yyyy-MM-dd")}' ");
            while (db.Dr.Read())
            {
                db db1 = new db($"Select devnev from devizanemek where devkod='{db.Dr[0]}'");
                db1.Dr.Read();
                cb_deviza.Items.Add($"{db.Dr[0]} - {db1.Dr[0]}");
            }

        }

        private void valutavalto_Load(object sender, EventArgs e)
        {
            cbload();
        }

        private void cb_deviza_SelectedIndexChanged(object sender, EventArgs e)
        {
            devkod =cb_deviza.SelectedItem.ToString().Substring(0,cb_deviza.SelectedItem.ToString().IndexOf(' '));
            db db = new db($"Select devegyseg,hufegyseg from arfolyamok where devkod = '{devkod}'");
            db.Dr.Read();
            l_devegseg.Text = db.Dr[0].ToString();
            l_hufegys.Text = db.Dr[1].ToString();
            rb_fromhuf.Text = $"HUF - {devkod}";
            rb_tohuf.Text = $"{devkod} - HUF";
            l_dev.Text = $"{devkod}";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            cbload();
        }

        private void rb_fromhuf_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_fromhuf.Checked)
            {
                l_arrow.Text = "- - - >";
            }
            else 
            {
                l_arrow.Text = "< - - -";
            }
            szamolas();
        }

        private void tb_osszeg_TextChanged(object sender, EventArgs e)
        {
            if (tb_osszeg.TextLength>0)
            {
                szamolas();
            }
        }

        private void szamolas()
        {
            if (tb_osszeg.TextLength > 0)
            {
                try
                {
                    int a = int.Parse(tb_osszeg.Text);
                    if (rb_fromhuf.Checked)
                    {
                        l_hufertek.Text = tb_osszeg.Text;
                        l_devertek.Text = (double.Parse(tb_osszeg.Text) / double.Parse(l_hufegys.Text)).ToString();
                    }
                    else
                    {
                        l_hufertek.Text = (double.Parse(tb_osszeg.Text) * double.Parse(l_hufegys.Text)).ToString();
                        l_devertek.Text = tb_osszeg.Text;
                    }
                }
                catch
                {
                    MessageBox.Show("Csak számot adjon meg!");
                    tb_osszeg.Focus();
                    tb_osszeg.Clear();
                }
            }
        }

        private void btn_elvet_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ment_Click(object sender, EventArgs e)
        {
            if (tb_osszeg.TextLength==0)
            {
                MessageBox.Show("Adjon meg értéket!");
                tb_osszeg.Focus();
            }
            else if (cb_deviza.SelectedIndex==0)
            {
                MessageBox.Show("Adjon meg értéket!");
                cb_deviza.Focus();
            }
            else
            {
                try
                {
                    string a="",b="";
                    a = rb_fromhuf.Checked ? "f" : "d";
                    db db = new db($"insert into valtasok(datum,ftbol,devkod,osszeg) Values('{dateTimePicker1.Value.ToString("yyyy-MM-dd")}','{a}','{devkod}','{tb_osszeg.Text:0,00}')");
                    db.Dr.Read();
                    MessageBox.Show("sikeres művelet!");

                }
                catch
                {
                    MessageBox.Show("Hibás művelet!");
                }
            }
        }
    }
}
