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
    }
}
