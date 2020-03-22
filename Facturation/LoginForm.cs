using Facturation.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturation
{
    public partial class LoginForm : Form
    {
        bool available = false;
        String informationSplashScreen;
        public static DataSet ds = new DataSet();
        public static SqlDataAdapter da;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (available is true)
            {
                pictureBox2.Image = Facturation.Properties.Resources.HideEYE;
                available = PassworldInput.isPassword = false;
            }
            else
            {
                pictureBox2.Image = Facturation.Properties.Resources.ShowEYE;
                available = PassworldInput.isPassword = true;
            }
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            //string req = ("select * from UserX");
            //da = new SqlDataAdapter(req, CNX.cn);
            //ds = new DataSet();
            //da.Fill(ds, "UserX");

            //for (int i = 0; i < ds.Tables["UserX"].Rows.Count; i++)
            //{
            //    if (ds.Tables["UserX"].Rows[i][1].ToString() == bunifuMaterialTextbox1.Text && ds.Tables["UserX"].Rows[i][2].ToString() == bunifuMaterialTextbox2.Text)
            //    {

            //        Dashboard f2 = new Dashboard();
            //        this.Hide();
            //        f2.Show();
            //        break;

            //    }
            //    else
            //    {
            //        IncorrectWIN IN = new IncorrectWIN();
            //        IN.ShowDialog();
            //        break;
            //    }
            //}
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            //if (Clicked == false)
            //{
            //    bunifuMaterialTextbox4.Show();
            //    label6.Show();
            //    bunifuButton1.Text = "Click To Reset";

            //    for (int i = 0; i < 5; i++)
            //    {
            //        bunifuButton1.Top += 8;
            //        bunifuButton2.Top += 8;
            //    }
            //}


            //if (Clicked == true)
            //{
            //    string req = ("select * from UserX");
            //    da = new SqlDataAdapter(req, CNX.cn);
            //    ds = new DataSet();
            //    da.Fill(ds, "UserX");

            //    for (int i = 0; i < ds.Tables["UserX"].Rows.Count; i++)
            //    {
            //        if (ds.Tables["UserX"].Rows[i][5].ToString() == bunifuMaterialTextbox4.Text)
            //        {
            //            label7.Text = "Reset Instructions Has Been Sent";
            //            label7.ForeColor = System.Drawing.ColorTranslator.FromHtml("#0384F9");
            //            label7.Show();
            //            break;

            //        }
            //        else
            //        {
            //            label7.Text = "Doesn't Exist in Our Servers";
            //            label7.Show();
            //            label7.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FF0000");

            //            for (int y = 0; y < 5; y++)
            //            {
            //                label7.Left += 5;
            //                System.Threading.Thread.Sleep(75);
            //                label7.Left -= 5;
            //                System.Threading.Thread.Sleep(75);
            //            }
            //            break;
            //        }
            //    }
        }

        private void bunifuMaterialTextbox4_Leave(object sender, EventArgs e)
        {
            using (Facturation_DBEntities db = new Facturation_DBEntities())
            {
                var secretaire = db.SECRETAIREs.Where(secretairee => secretairee.email.Equals(EmailInput.Text)).FirstOrDefault();
                if (!(secretaire is null))
                {
                    informationSplashScreen = $"secrétaire : {secretaire.nom} {secretaire.prenom} !";
                    pictureVerificationEmail.Image = Facturation.Properties.Resources.verified;
                }
                else
                {
                    var admin = db.ADMINNs.Where(adminn => adminn.email.Equals(EmailInput.Text)).FirstOrDefault();
                    if (!(admin is null))
                    {
                        informationSplashScreen = $"administrateur : {admin.nom} {admin.prenom}";
                        pictureVerificationEmail.Image = Facturation.Properties.Resources.verified;
                    }
                    else
                        pictureVerificationEmail.Image = Facturation.Properties.Resources.NotVerified;
                }
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (Facturation_DBEntities db = new Facturation_DBEntities())
            {
                var admin = db.ADMINNs.Where(adminn => adminn.email.Equals(EmailInput.Text) && adminn.mdp.Equals(PassworldInput.Text)).FirstOrDefault();
                if (!(admin is null))
                {
                    MessageBox.Show("admin is not null");
                    Form1 form = new Form1
                    {
                        IsAdmin = true
                    };
                    form.Show();
                    this.Close();
                }
                else
                {
                    SECRETAIRE secretaire = db.SECRETAIREs.Where(secretairee => secretairee.email.Equals(EmailInput.Text) && secretairee.mdp.Equals(PassworldInput.Text)).FirstOrDefault();
                    if (!(secretaire is null))
                    {
                        MessageBox.Show("secretair is not null");
                        Form1 form = new Form1
                        {
                            IsAdmin = false
                        };
                        form.Show();
                        this.Close();
                    }
                    else
                        labelError.Visible = true;
                }
            }
        }

        private void LabelOublie_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            (new RecuperationForm(EmailInput.Text)).Show();
        }
    }
}
