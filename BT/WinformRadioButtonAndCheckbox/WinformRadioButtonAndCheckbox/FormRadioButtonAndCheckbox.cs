using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformRadioButton
{
    public partial class FormRadioButtonAndCheckbox : Form
    {
        public FormRadioButtonAndCheckbox()
        {
            InitializeComponent();
            foreach( var rad in groupBoxColor.Controls.OfType<FlowLayoutPanel>().First().Controls.OfType<RadioButton>())
            {
                rad.CheckedChanged += new System.EventHandler(this.radColor_CheckedChanged);

            }
            radBlack.Checked = true;

            foreach (var chk in groupBoxFont.Controls.OfType<FlowLayoutPanel>().First().Controls.OfType<CheckBox>())
            {
                chk.CheckedChanged += new System.EventHandler(this.chkFont_CheckedChanged);

            }
        }

        private void radColor_CheckedChanged(object sender, EventArgs e)
        {
            var rad = groupBoxColor.Controls.OfType<FlowLayoutPanel>().First().Controls.OfType<RadioButton>().FirstOrDefault(e => e.Checked);
            if (rad != null)
            {
                this.lblLapTrinh.ForeColor = rad.ForeColor;
            }
        }

        private void chkFont_CheckedChanged(object sender, EventArgs e)
        {
            var chks = groupBoxFont.Controls.OfType<FlowLayoutPanel>().First().Controls.OfType<CheckBox>().Where(e => e.Checked);
            FontStyle newFontStle = FontStyle.Regular;
            foreach (var chk in chks)
            {
                 if(chk.Font.Bold!=false)
                    newFontStle |= FontStyle.Bold;
                if(chk.Font.Italic!=false)
                    newFontStle |= FontStyle.Italic;
                if(chk.Font.Underline!=false)
                    newFontStle |= FontStyle.Underline;
            }

            this.lblLapTrinh.Font = new Font(this.lblLapTrinh.Font.FontFamily, this.lblLapTrinh.Font.Size, newFontStle);

        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtNhapTen_TextChanged(object sender, EventArgs e)
        {
           
            this.lblLapTrinh.Text = this.txtNhapTen.Text;
            
        }

        
    }
}
