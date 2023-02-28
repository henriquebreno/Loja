using Loja.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja
{
    public partial class Form1 : Form
    {
        private ITestRepository Repository;
        public Form1(ITestRepository testRepository)
        {
            Repository = testRepository;
            InitializeComponent(Repository);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbl_none_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load_2(object sender, EventArgs e)
        {

        }

        private void Form1_Load_3(object sender, EventArgs e)
        {

        }
    }
}
