namespace DateTimeChecker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set form properties
            this.Text = "Date Time Checker";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Are you sure to exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            e.Cancel = (result == DialogResult.No);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Code for label1 click event
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Code for label2 click event
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Code for label3 click event
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Clear button
            txtDay.Clear();
            txtMonth.Clear();
            txtYear.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Check button
            int day, month, year;

            if (int.TryParse(txtDay.Text, out day) &&
                int.TryParse(txtMonth.Text, out month) &&
                int.TryParse(txtYear.Text, out year))
            {
                if (IsValidDate(day, month, year))
                {
                    MessageBox.Show($"{day}/{month}/{year} is correct date time!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"{day}/{month}/{year} is NOT correct date time!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Input data for Day, Month, or Year is incorrect format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsValidDate(int day, int month, int year)
        {
            if (month < 1 || month > 12 || day < 1)
            {
                return false;
            }

            int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (IsLeapYear(year))
            {
                daysInMonth[1] = 29;
            }

            return day <= daysInMonth[month - 1];
        }

        private bool IsLeapYear(int year)
        {
            if (year % 400 == 0) return true;
            if (year % 100 == 0) return false;
            return year % 4 == 0;
        }
    }
}
