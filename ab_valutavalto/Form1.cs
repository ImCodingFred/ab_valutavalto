﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void devizanemekRögzítéseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            devizarogz devizarogz = new devizarogz();
            devizarogz.ShowDialog();
        }

        private void árfolyamokRögzítéseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            arfolyamrogz arfolyamrogz = new arfolyamrogz();
            arfolyamrogz.ShowDialog();
        }

        private void valutaváltásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            valutavalto valutavalto = new valutavalto();
            valutavalto.ShowDialog();
        }
    }
}
