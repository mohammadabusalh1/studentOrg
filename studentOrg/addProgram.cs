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
    public partial class addProgram : Form
    {
        studentsOrgEntities db = new studentsOrgEntities();
        public addProgram()
        {
            InitializeComponent();
        }

        private void btAddProg_Click(object sender, EventArgs e)
        {
           
            String newProgramName = programName.Text;
           // db.Programes.Add(new Progress(newProgramName));

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
