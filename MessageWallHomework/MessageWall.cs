using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageWallHomework
{
    public partial class MessageWall : Form
    {
        BindingList<string> messages = new BindingList<string>();
        public MessageWall()
        {
            InitializeComponent();
            WireUpList();
        }
        private void WireUpList()
        {
            messageDisplay.DataSource = messages;
        }
        private void FullName()
        {
            string fullName = firstNameText.Text + " " + lastNameText.Text;
            messages.Add(fullName);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void firstNameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastNameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void messageDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addMessage_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(firstNameText.Text) || string.IsNullOrWhiteSpace(lastNameText.Text))
            {
                MessageBox.Show("Pleas enter a message before adding to the list.",
                    "Blank Message Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FullName();
                firstNameText.Text = "";
                lastNameText.Text = "";
            }
            messageDisplay.Focus();

        }

        private void MessageWall_Load(object sender, EventArgs e)
        {

        }
    }
}
