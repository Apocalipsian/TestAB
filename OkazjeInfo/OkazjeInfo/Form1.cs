using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkazjeInfo
{
    public partial class Form1 : Form
    {

  


        public Form1()
        {
            InitializeComponent();
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tESTABToolStripMenuItem_Click(object sender, EventArgs e)
        {
            testAB testab = new testAB();
            testab.Show();
        }

        private void sORTOWANIEPRODUKTÓWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sortowanie sort = new sortowanie();
            sort.Show();
        }

        private void uRLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            urls url = new urls();
            url.Show();
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scraper sc = new scraper();
            sc.Show();
        }

        private void dToolStripMenuItem_Click(object sender, EventArgs e)
        {
            duplikaty multi = new duplikaty();
            multi.Show();
        }

        private void fILTRYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filtry filtry = new filtry();
            filtry.Show();
        }
    }
}
