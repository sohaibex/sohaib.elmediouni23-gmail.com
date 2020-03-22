using Bunifu.Framework.UI;
using Facturation.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturation
{
    public partial class Form1 : Form
    {
        public bool IsAdmin { get; set; }
        public Form1()
        {
            InitializeComponent();
            IsAdmin = true;
        }

        private void BunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            ActiveButton(((BunifuFlatButton)sender).Name);
            this.ucStatistique1.LoadData();
            this.ucStatistique1.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.Hide();
            //(new LoginForm()).Show();
            if (!IsAdmin)
                this.flatBtn_gestion.Text = "    Gestion des               clients";
        }

        private void flatBtn_gestion_AdminClick(object sender, EventArgs e)
        {
            ActiveButton(((BunifuFlatButton)sender).Name);
            if (IsAdmin)
                this.panelChoix.BringToFront();
            //else
            //pour les secretaires 
            //ouvrir directement interface de saisie : client
        }

        private void tileBtnIngenieur_Click(object sender, EventArgs e)
        {
            //interface saisie des ingénieurs
        }

        private void tileBtnSecrtr_Click(object sender, EventArgs e)
        {
            //interface saisie des secretaires
        }

        private void tileBtnClient_Click(object sender, EventArgs e)
        {
            //interface saisie des clients
        }

        private void ActiveButton(string btnName)
        {
            foreach (Control c in containerButton.Controls)
                if (c is BunifuFlatButton btn)
                    if (!(btn.Name.Equals(btnName)))
                        btn.Normalcolor = Color.Transparent;
                    else
                        btn.Normalcolor = System.Drawing.Color.FromArgb
                            (
                            ((int)(((byte)(106)))),
                            ((int)(((byte)(131)))),
                            ((int)(((byte)(245))))
                            );
        }

        private void flatBtn_home_Click(object sender, EventArgs e)
        {
            ActiveButton(((BunifuFlatButton)sender).Name);
        }

        private void flatBtn_saisie_Click(object sender, EventArgs e)
        {
            ActiveButton(((BunifuFlatButton)sender).Name);
        }

        private void flatBtn_impression_Click(object sender, EventArgs e)
        {
            ActiveButton(((BunifuFlatButton)sender).Name);
        }
    }
}
