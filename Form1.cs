using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            calculate.Enabled = false;
            calculate.BackColor = Color.Gray;
        }


        private void calculate_Click(object sender, EventArgs e)
        {

            int dayMinutes = 0;
            int nightMinutes = 0;
            int dayMinutesOver = 0;
            int nightMinutesOver = 0;
            double cost = 0;

            if (regular.Checked)
            {
                dayMinutes = Convert.ToInt32(day.Text);

                if (dayMinutes > 50)
                {
                    dayMinutesOver = dayMinutes - 50;
                    cost = 10 + (dayMinutesOver * 0.2);
                }
                else
                {
                    cost = 10;
                }

                cost = Math.Round(cost, 2);
                output.Text = "Cost: $ " + cost.ToString() + "\n" + "Day Minutes Over: " + dayMinutesOver.ToString();
            }
            else if (premium.Checked)
            {
                dayMinutes = Convert.ToInt32(day.Text);
                nightMinutes = Convert.ToInt32(night.Text);

                cost = 25;

                if (dayMinutes > 75)
                {
                    dayMinutesOver = dayMinutes - 75;
                    cost += dayMinutesOver * 0.1;
                }

                if (nightMinutes > 100)
                {
                    nightMinutesOver = nightMinutes - 100;
                    cost += nightMinutesOver * 0.05;
                }

                cost = Math.Round(cost, 2);
                output.Text = "Cost: $ " + cost.ToString() + "\n" +
                    "Day Minutes Over: " + dayMinutesOver.ToString() + "\n" +
                    "Night Minutes Over: " + nightMinutesOver.ToString();
            }
            else
            {
                output.Text = "No plan selected";
            }
        }

        private void day_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(day.Text, out int number))
            {
                calculate.Enabled = false;
                calculate.BackColor = Color.Gray;
            }
            else
            {
                calculate.Enabled = true;
                calculate.BackColor = Color.DarkOrange;
            }
        }

        private void night_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(night.Text, out int number))
            {
                calculate.Enabled = false;
                calculate.BackColor = Color.Gray;
            }
            else
            {
                calculate.Enabled = true;
                calculate.BackColor = Color.DarkOrange;
            }
        }

        private void regular_CheckedChanged(object sender, EventArgs e)
        {
            night.Enabled = false;
        }

        private void premium_CheckedChanged(object sender, EventArgs e)
        {
            night.Enabled = true;
        }
    }
}
