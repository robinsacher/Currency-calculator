using System;
using System.Windows.Forms;

namespace Wärungsrechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Hier die Logik für die Währungsumrechnung
            double result = 0;

            if (double.TryParse(input_money.Text, out double money))
            {
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        CHF_Zu_Euro chf_zu_euro = new CHF_Zu_Euro();
                        result = chf_zu_euro.berechne(money);
                        break;
                    case 1:
                        CHF_Zu_Dollar chf_zu_dollar = new CHF_Zu_Dollar();
                        result = chf_zu_dollar.berechne(money);
                        break;
                    case 2:
                        Euro_Zu_CHF euro_zu_chf = new Euro_Zu_CHF();
                        result = euro_zu_chf.berechne(money);
                        break;
                    case 3:
                        Euro_Zu_Dollar euro_zu_dollar = new Euro_Zu_Dollar();
                        result = euro_zu_dollar.berechne(money);
                        break;
                    case 4:
                        Dollar_Zu_CHF dollar_zu_chf = new Dollar_Zu_CHF();
                        result = dollar_zu_chf.berechne(money);
                        break;
                    case 5:
                        Dollar_Zu_Euro dollar_zu_euro = new Dollar_Zu_Euro();
                        result = dollar_zu_euro.berechne(money);
                        break;
                    default:
                        break;
                }
            }
            output_money.Text = Convert.ToString(result);
        }

        private void input_money_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void output_money_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            
            double result = 0;

            if (double.TryParse(input_money.Text, out double money))
            {
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        CHF_Zu_Euro chf_zu_euro = new CHF_Zu_Euro();
                        result = chf_zu_euro.berechne(money);
                        break;
                    case 1:
                        CHF_Zu_Dollar chf_zu_dollar = new CHF_Zu_Dollar();
                        result = chf_zu_dollar.berechne(money);
                        break;
                    case 2:
                        Euro_Zu_CHF euro_zu_chf = new Euro_Zu_CHF();
                        result = euro_zu_chf.berechne(money);
                        break;
                    case 3:
                        Euro_Zu_Dollar euro_zu_dollar = new Euro_Zu_Dollar();
                        result = euro_zu_dollar.berechne(money);
                        break;
                    case 4:
                        Dollar_Zu_CHF dollar_zu_chf = new Dollar_Zu_CHF();
                        result = dollar_zu_chf.berechne(money);
                        break;
                    case 5:
                        Dollar_Zu_Euro dollar_zu_euro = new Dollar_Zu_Euro();
                        result = dollar_zu_euro.berechne(money);
                        break;
                    default:
                        break;
                }
            }
            output_money.Text = Convert.ToString(result);
        }
    }
}
