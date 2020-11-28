using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_SwitchCase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btn_months_Click(object sender, EventArgs e)
        {
            string month = textBox1.Text.ToLower();
            string answer = "";
            switch (month)
            {
                case "aralık":
                case "ocak":
                case "şubat":
                    answer = "Kış";
                    break;
                case "mart":
                case "nisan":
                case "mayıs":
                    answer = "ilkbahar";
                    break;
                case "haziran":
                case "temmuz":
                case "ağustos":
                    answer = "yaz";
                    break;
                case "eylül":
                case "ekim":
                case "kasım":
                    answer = "sonbahar";
                    break;
                default:
                    answer = "unexpected season name.";
                    break;
            }
            MessageBox.Show(answer);
        } 
        // month to season switch operator
        private void btn_season1_Click(object sender, EventArgs e)
        {
            string month = textBox1.Text.ToLower();
            string answer = "";
            if (month == "aralık" || month == "ocak" || month == "şubat")
            {
                answer = "Kış.";
            }
            else if (month == "mart" || month == "nisan" || month == "mayıs")
            {
                answer = "İlkbahar.";
            }
            else if (month == "haziran" || month == "temmuz" || month == "ağustos")
            {
                answer = "Yaz.";
            }
            else if (month == "eylül" || month == "ekim" || month == "kasım")
            {
                answer = "sonbahar.";
            }
            else answer = "month not recognized.";
            MessageBox.Show(answer);
        }
        // month to season if else operator
        private void btn_months2_Click(object sender, EventArgs e)
        {
            string season = textBox1.Text.ToLower();
            string answer = "";
            switch (season)
            {
                case "kış":
                    answer = "Aralık - Ocak - Şubat";
                    break;
                case "ilkbahar":
                    answer = "Mart - Nisan - Mayıs";
                    break;
                case "yaz":
                    answer = "Haziran - Temmuz - Ağustos";
                    break;
                case "sonbahar":
                    answer = "Eylül - Ekim - Kasım";
                    break;
                default:
                    answer = "unexpected season name.";
                    break;
            }
            MessageBox.Show(answer);

        }
        // season to month switch operator
        private void btn_score_Click(object sender, EventArgs e)
        {
            string lscore = "Your lettered score is {0}";
            if (int.TryParse(textBox1.Text, out int score))
            {
                switch(score)
                {
                    case int _score when _score >= 0 && _score <= 100:
                            switch(_score)
                            {
                                case int _score_ when _score_ <= 30:
                                        lscore = string.Format(lscore, "FF");
                                        break;
                                case int _score_ when _score_ <= 50:
                                        lscore = string.Format(lscore, "DD");
                                        break;
                                case int _score_ when _score_ <= 70:
                                        lscore = string.Format(lscore, "CC");
                                        break;
                                case int _score_ when _score_ <= 85:
                                        lscore = string.Format(lscore, "BB");
                                        break;
                                default:
                                        lscore = string.Format(lscore, "AA");
                                        break;
                            }
                            break;
                     break;
                }
                MessageBox.Show("Processed.");
            } 
            else
                MessageBox.Show("Can't process.");
        }
        // score to lettered score with switch operator.
 


    }
}
