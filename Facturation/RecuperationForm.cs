using Facturation.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturation
{
    public partial class RecuperationForm : Form
    {
        public RecuperationForm()
        {
            InitializeComponent();
        }

        public RecuperationForm(string email) : this()
        {
            this.Email_Input.Text = email;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Validation(String personne = "", bool valid = false)
        {
            if (valid)
            {
                pictureVerificationEmail.Image = Facturation.Properties.Resources.verified;
                this.labelMsg.Text = "Email correct";
                this.labelMsg.ForeColor = Color.SeaGreen;
                this.labelExplication.Text = $"Chére Mr/Mme {personne} : votre mot de passe vous sera envoyé imédiatement à votre adresse Email <{Email_Input.Text}> .La connexion à Internet est indispensable.";
                this.labelExplication.Font = new Font("Constantia", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
                this.Email_Input.Enabled = this.BtnSoumettre.Enabled = false;
            }
            else
            {
                pictureVerificationEmail.Image = Facturation.Properties.Resources.NotVerified;
                this.labelMsg.Text = "Email inexistant dans notre system ..";
                this.labelMsg.ForeColor = Color.Red;
            }
        }

        private void EnvoyerEmail(String email, String motDePasse)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("App.Facturation@gmail.com");
                //mail.To.Add("tonysosabx51@gmail.com"); just for testing
                mail.To.Add(email);
                mail.Subject = "Récupération de vos identifiants FacturApp";
                mail.Body = $"Vous avez récement envoyer une requéte de récupération de votre mot de passe.\nVoici vos identifiants et prenez y bien soin.\n\n\n -Email/Username : {email}\n -Mot de passe : {motDePasse}\n\n La demande a été faite le {DateTime.Now}.\n\n     ***Veuillez contactez les developpeurs de l'application en répondant à cet email uniquement si la demande de récupération n'a pas été faites par vous !***";

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("App.Facturation@gmail.com", "google1234$");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnSoumettre_Click(object sender, EventArgs e)
        {
            using (Facturation_DBEntities db = new Facturation_DBEntities())
            {
                var admin = db.ADMINNs.Where(adminn => adminn.email.Equals(Email_Input.Text)).FirstOrDefault();
                if (!(admin is null))
                {
                    Validation(admin.nom + " " + admin.prenom, true);
                    EnvoyerEmail(admin.email, admin.mdp);
                }
                else
                {
                    var secretaire = db.SECRETAIREs.Where(secretairee => secretairee.email.Equals(Email_Input.Text)).FirstOrDefault();
                    if (!(secretaire is null))
                    {
                        Validation(secretaire.nom + " " + secretaire.prenom, true);
                        EnvoyerEmail(secretaire.email, secretaire.mdp);
                    }
                    else
                        Validation();
                }
            }
        }
    }
}
