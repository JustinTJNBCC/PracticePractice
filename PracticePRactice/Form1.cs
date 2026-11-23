namespace PracticePRactice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Change the color of the label for fun
            lblGrade.BackColor = Color.YellowGreen;
        }

        int[] ids = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        string[] students = { "Jimmy", "Jummy", "Kingson", "Prince","Sindy", "Lincoln", "James", "Lopin", "Higgins", "Luke"};
        int[] grades = { 85, 12, 63, 45, 85, 100, 52, 63, 96, 52};
    }
}
