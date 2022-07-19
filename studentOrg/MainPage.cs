using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studentOrg
{
    public partial class MainPage : Form
    {
        studentsOrgEntities db = new studentsOrgEntities();

        public MainPage()
        {
            InitializeComponent();
        }

        private void btEdetProgrameTable_Click(object sender, EventArgs e)
        {

            ManeageProgramTable progTable = new ManeageProgramTable();
            progTable.Show();


        }
    }
}
