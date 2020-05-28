using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcOptGain
{
    public partial class CalcOptGain : Form
    {
        public CalcOptGain()
        {
            InitializeComponent();
            AirDensity.Text = "1.225";
            coeff.Text = "1.12";
            Kopt.ReadOnly = true;
            RatedTorque.ReadOnly = true;
            MaxTorque.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double KoptValue;
            if (AirDensity.Text == "" || Diameter.Text == "" || Cpmax.Text == "" || LambdaOpt.Text == "")
            {
                MessageBox.Show("参数不全", "警告",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                KoptValue = 0.5 * Convert.ToDouble(AirDensity.Text) * Convert.ToDouble(Cpmax.Text) * Math.PI
                    * Math.Pow(Convert.ToDouble(Diameter.Text)/2, 5) / Math.Pow(Convert.ToDouble(LambdaOpt.Text), 3);
                Kopt.Text = Convert.ToString(KoptValue);
            }           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in this.Controls)
            {
                if (ctr is TextBox)
                {
                    ctr.Text = "";
                }
            }
            AirDensity.Text = "1.225";
            coeff.Text = "1.12";
        }

        private void label9_Click(object sender, EventArgs e)
        {
            RatedTorque.Text = Convert.ToString(Convert.ToDouble(RatedPlusLossPower.Text) / (Convert.ToDouble(RatedSpeed.Text)*2*Math.PI/60));
        }

        private void label8_Click(object sender, EventArgs e)
        {
            MaxTorque.Text =Convert.ToString( Convert.ToDouble(coeff.Text) * Convert.ToDouble(RatedPlusLossPower.Text) / (Convert.ToDouble(RatedSpeed.Text) * 2 * Math.PI / 60) );
        }
    }
}
