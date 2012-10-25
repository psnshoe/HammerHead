using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            var login = new Form_Login();
            login.ShowDialog();
        }

        private void buttonAddPerson_Click(object sender, EventArgs e)
        {
            var add = new Form_AddPerson();
            add.ShowDialog();
        }

        private void buttonRemovePerson_Click(object sender, EventArgs e)
        {
            var remove = new Form_RemovePerson();
            remove.ShowDialog();
        }
    }
}
