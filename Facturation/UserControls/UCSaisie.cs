using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms;
using Bunifu.Framework.UI;

namespace Facturation.UserControls
{
    public partial class UCSaisie : UserControl
    {
        public UCSaisie()
        {
            InitializeComponent();
        }

        private void BunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.bunifuMaterialTextbox1.Text))
                this.pictureBox1.Image = null;
            else if (this.bunifuMaterialTextbox1.Text.Equals("529674"))
            {
                this.pictureBox1.Image = Facturation.Properties.Resources.valid;
                this.bunifuMaterialTextbox4.Text = "Mohammed SQAT";
                this.bunifuMaterialTextbox5.Text = "Immeuble MWA";
            }
            else
            {
                this.pictureBox1.Image = Facturation.Properties.Resources.notValid;
                this.bunifuMaterialTextbox4.Text = "";
                this.bunifuMaterialTextbox4.Text = "";

            }

        }

        private void BunifuButton1_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("Page2");
        }

        private void BunifuButton2_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("Page1");
        }

        private void BunifuButton1_Click_1(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("Page3");
        }

        private void BunifuCheckBox_event(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            IEnumerable<Label> controls = flowLayoutPanel1.Controls.OfType<Label>();
            if (controls.Where(c => c.Text.Equals((sender as BunifuCheckBox).BindingControl.Text)).FirstOrDefault() == null)
            {
                Label label = new Label()
                {
                    BackColor = Color.Silver,
                    Font = new System.Drawing.Font("Perpetua", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                    Padding = new System.Windows.Forms.Padding(2),
                    Text = (sender as BunifuCheckBox).BindingControl.Text,
                    Size = (sender as BunifuCheckBox).BindingControl.Size,
                };
                BunifuElipse b = new BunifuElipse()
                {
                    ElipseRadius = 20,
                    TargetControl = label,
                };
                this.flowLayoutPanel1.Controls.Add(label);
            }
            else
                this.flowLayoutPanel1.Controls.Remove(controls.Where(c => c.Text.Equals((sender as BunifuCheckBox).BindingControl.Text)).FirstOrDefault());
        }

        private void BunifuButton3_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("Page2");
        }

        private void Page2_Click(object sender, EventArgs e)
        {
            //bunifuDatePicker3
        }
    }
}
