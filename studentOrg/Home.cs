using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace studentOrg
{
    public partial class Home : Form
    {
        studentsOrgEntities db = new studentsOrgEntities();
        String name = "Ml";
        String password = "Ml";
        int count;

        public Home()
        {
            count = db.counters.FirstOrDefault(p => p.id == 1).count;
            InitializeComponent();
            if (count >= 4)
            {
                panel1.Visible = false;
                panel3.Visible = true;
            }
            else
            {
                panel1.Visible = true;
                panel3.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

           
            if(name == tbName.Text && password == tbPass.Text)
            {

                MainPage page = new MainPage();
                page.MdiParent = this;
                panel2.Visible = false;
                page.Show();


            }
            else
            {

                tlMassege.Visible = false;
                count = db.counters.FirstOrDefault(p => p.id == 1).count;
                if (count >= 4)
                {
                    panel1.Visible = false;
                    panel3.Visible = true;
                }

                Console.WriteLine(count);
                tlMassege.Visible = true;
               db.counters.FirstOrDefault(p => p.id == 1).count++;
               db.SaveChanges();
            }


        }

        private void newPass_Click(object sender, EventArgs e)
        {

            string fromMail = "abusalhm102@gmail.com";
            string fromPassword = "dnktxnaellfcugck";

            MailMessage message = new MailMessage(fromMail, "abusalhm106@gmail.com", "New password", "Your Password is: " + password);
            message.IsBodyHtml = false;

            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(fromMail, fromPassword),
                EnableSsl = true,
            };

            smtpClient.Send(message);

            db.counters.FirstOrDefault(p => p.id == 1).count = 0;
            db.SaveChanges();

            Thread.Sleep(1000);

            panel1.Visible = true;
            tlMassege.Visible = false;
            panel3.Visible = false;
            MessageBox.Show("تم ارسال كلمة المرور الى بريدك");

        }
    }
}
