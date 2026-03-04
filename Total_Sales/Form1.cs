namespace Total_Sales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                // implement try catch
                try
                {
                    // create a 1d array that will read from the text file
                    string[] allLines = File.ReadAllLines("TotalSales.txt");

                    // storing the lines
                    double[] sales = new double[allLines.Length];

                    double sum = 0;
                    int count = 0;

                    // create a for each loop to read the lines and convert them to double
                    foreach (string line in allLines)
                    {
                        sales[count] = Convert.ToDouble(line);

                        // calc the sum
                        sum += sales[count];  // sum = sum + sales[count]

                        // display the current value in the list box
                        listDisplay.Items.Add(sales[count]);

                        // increment the counter
                        count++;
                    }

                    // display the total sales in the listbox
                    listDisplay.Items.Add($"Total Sales: {sum:C}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
