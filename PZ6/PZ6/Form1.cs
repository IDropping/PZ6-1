using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PZ6
{
    public partial class Form1 : Form
    {
        private Knigs _book;
        public Form1()
        {
            InitializeComponent();
            _book = new Knigs();
            _book.Initialize();

            dataGridView1.DataSource = _book.Years.ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
