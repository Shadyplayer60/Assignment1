namespace Assignment1
{
    public partial class Assignment1 : Form
    {
        // Constant for pay per hour
        private const double pph = 10.50;

        public Assignment1()
        {

            InitializeComponent();
        }

        private void Assignment1_Load(object sender, EventArgs e)
        {

        }

        private void Bnsummarize_Click(object sender, EventArgs e)
        {
            try
            {
                // Parse the hours worked from the HoursWorkedTextBox
                int hoursWorked = int.Parse(tbxHoursworked.Text);

                // Calculate total pay
                double totalPay = hoursWorked * pph;

                // Set the color back to default for normal messages
                lblSummary.ForeColor = System.Drawing.Color.Black;

                // Display the Summary message using string interpolation
                lblSummary.Text = $"{tbxFirstname.Text} {tbxLastname.Text} worked {hoursWorked} hours at {pph:C} an hour for a total of {totalPay:C}.";
            }
            catch (Exception )
            {
                // Handle exceptions (invalid input for Hours Worked)
                lblSummary.ForeColor = System.Drawing.Color.Red;
                lblSummary.Text = "Invalid input for hours worked. Please enter a valid number.";
            }
        }

        private void Bnclear_Click(object sender, EventArgs e)
        {
            tbxFirstname.Clear();
            tbxLastname.Clear();
            tbxHoursworked.Clear();
            lblSummary.Text = string.Empty;
        }
    }
}
