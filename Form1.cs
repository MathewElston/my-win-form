using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        String UserInput = "";
        public Form1()
        {
            InitializeComponent();

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void AddButton_Click(object sender, EventArgs e)
        {
            ToDoList.Text = UserInput;
            Console.WriteLine(UserInput);
            ToDoList.Items.Add(UserInput);

            ItemInput.Clear();



        }

        private void ItemInput_TextChanged(object sender, EventArgs e)
        {
            UserInput = ((TextBox)sender).Text;
            Console.WriteLine(UserInput);

        }
    }
}