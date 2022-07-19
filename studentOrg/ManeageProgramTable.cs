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
    public partial class ManeageProgramTable : Form
    {

        studentsOrgEntities db = new studentsOrgEntities();

        public ManeageProgramTable()
        {
            InitializeComponent();
        }

        private void ManeageProgramTable_Load(object sender, EventArgs e)
        {
            var names = db.Programes.ToList();
            dvPrograme.DataSource = names;
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            int id =(int) dvPrograme.SelectedRows[0].Cells["id"].Value;
            var row = db.Programes.FirstOrDefault(p => p.id == id);
            db.Programes.Remove(row);
            db.SaveChanges();
            refrish();

        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            refrish();
        }

        void refrish()
        {
            var names = db.Programes.ToList();
            dvPrograme.DataSource = names;

        }

        private void btAdd_Click(object sender, EventArgs e)
        {

            addProgram addProgram = new addProgram();
            addProgram.Show();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {

        }
    }
}
