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
    public partial class devizarogz : Form
    {
        public devizarogz()
        {
            InitializeComponent();
        }

        private void tb_devkod_TextChanged(object sender, EventArgs e)
        {
            if (tb_devkod.TextLength>3)
            {
                tb_devkod.Text = tb_devkod.Text.Substring(0, 3);
                tb_devkod.SelectionStart = tb_devkod.TextLength;
                tb_devkod.SelectionLength = 0;
                db db = new db($"SELECT * FROM devizanemek where devkod = {tb_devkod.Text}");
                if (db.Dr.HasRows)
                {
                    MessageBox.Show("Már létezik ilyen deviza!");
                    tb_devkod.Text = null;
                    tb_devkod.Focus();
                }
            }
        }

        private void tb_devnev_TextChanged(object sender, EventArgs e)
        {
            if (tb_devnev.TextLength > 20)
            {
                tb_devnev.Text = tb_devnev.Text.Substring(0, 20);
                tb_devnev.SelectionStart = tb_devnev.TextLength;
                tb_devnev.SelectionLength = 0;
                
            }
        }

        private void btn_ment_Click(object sender, EventArgs e)
        {
            if (tb_devkod.TextLength==0)
            {
                MessageBox.Show("töltse ki a mezőt!");
                tb_devkod.Focus();
            }
            else if (tb_devnev.TextLength==0)
            {
                MessageBox.Show("töltse ki a mezőt!");
                tb_devnev.Focus();
            }
            else
            {
                try
                {
                    db db = new db($"INSERT INTO devizanemek(devkod,devnev) VALUES('{tb_devkod.Text}','{tb_devnev.Text}')");
                    db.Dr.Read();
                    MessageBox.Show("sikeres bevitel!");
                    tb_devkod.Text = null;
                    tb_devnev.Text= null;
                }
                catch
                {
                    MessageBox.Show("hibás művelet!");
                }
            }
        }

        private void btn_elvet_Click(object sender, EventArgs e)
        {
            MessageBox.Show("biztos elveti a műveletet?", "elvetés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
