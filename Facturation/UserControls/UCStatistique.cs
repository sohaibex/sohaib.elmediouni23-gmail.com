using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facturation.Data.Database;
using Bunifu.DataViz.WinForms;
using Facturation.Data.Entities;

namespace Facturation.UserControls
{
    public partial class UCStatistique : UserControl
    {
        public UCStatistique()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            Canvas canvas;
            DataPoint dataPoint = new DataPoint(BunifuDataViz._type.Bunifu_doughnut);
            using (Facturation_DBEntities db = new Facturation_DBEntities())
            {
                int pourcentageClientEntreprises = db.CLIENTs.Where(client => client.NumeroSerie.StartsWith("En")).Count();
                dataPoint.addLabely("Entreprises", pourcentageClientEntreprises);
                int pourcentageClientParticuler = db.CLIENTs.Where(client => client.NumeroSerie.StartsWith("Pa")).Count();
                dataPoint.addLabely("Particuler", pourcentageClientParticuler);
                canvas = new Canvas();
                canvas.addData(dataPoint);
                bunifuDataViz1.Render(canvas);
                dataPoint.clear();

                this.LB_NbrClient.Text = db.CLIENTs.Count<CLIENT>().ToString();
                this.LB_NbrIngenieur.Text = db.INGENIEURs.Count<INGENIEUR>().ToString();
                this.LB_FactureImp.Text = db.FACTURATIONs.Where(facture => facture.EstImprime == true).ToList().Count<FACTURATION>().ToString();
                this.LB_FactureNoImp.Text = db.FACTURATIONs.Where(facture => facture.EstImprime == false).ToList().Count<FACTURATION>().ToString();
                this.LB_NbrPieces.Text = db.PIECEs.Count<PIECE>().ToString();
                IdentityVerification();

                OutilConnect.Connect();
                OutilConnect.sqlCommand = new System.Data.SqlClient.SqlCommand("select top 1 LblVille , count(*) as countt from client c inner join ville v on c.Id_Class# = v.IdVille group by LblVille order by countt desc", OutilConnect.sqlConnection);
                OutilConnect.reader = OutilConnect.sqlCommand.ExecuteReader();
                OutilConnect.table = new DataTable();
                OutilConnect.table.Load(OutilConnect.reader);
                this.LB_VilleMax.Text = OutilConnect.table.Rows[0]["LblVille"].ToString();
                OutilConnect.reader.Close();
                OutilConnect.sqlCommand = new System.Data.SqlClient.SqlCommand("select top 1 c.NomAgenceOuClient , count(*) as countt from Appel a inner join CLIENT c on c.NumeroSerie = a.IdClient# group by c.NomAgenceOuClient order by countt desc", OutilConnect.sqlConnection);
                OutilConnect.reader = OutilConnect.sqlCommand.ExecuteReader();
                OutilConnect.table.Load(OutilConnect.reader);
                this.LB_ClientEx.Text = String.IsNullOrEmpty(OutilConnect.table.Rows[0]["NomAgenceOuClient"].ToString()) ?
                 "Digital Factory" : OutilConnect.table.Rows[0]["NomAgenceOuClient"].ToString();
                OutilConnect.reader.Close();
                OutilConnect.DeConnect();
            }
        }

        private void IdentityVerification()
        {
            if (!Program.form.IsAdmin)
                this.label10.Visible = this.label11.Visible = this.LB_NbrSecrtr.Visible = this.LB_NbrAdmin.Visible = false;
            else
            {
                using (Facturation_DBEntities db = new Facturation_DBEntities())
                {
                    this.LB_NbrSecrtr.Text = db.SECRETAIREs.Count<SECRETAIRE>().ToString();
                    this.LB_NbrAdmin.Text = db.ADMINNs.Count<ADMINN>().ToString();
                }
            }
        }
    }
}
