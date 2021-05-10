using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c_sharp_demo
{
    public partial class UserSaveForm : Form
    {
        public UserSaveForm()
        {
            InitializeComponent();

            ChangeMailAddressTextBoxEnabled();

            NoteLabel.Visible = BusinessRadioButton.Checked;
        }

        private void MailCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ChangeMailAddressTextBoxEnabled();
        }

        private void ChangeMailAddressTextBoxEnabled()
        {
            MailAddressLabel.Enabled = MailCheckBox.Checked;
            MailAddressTextBox.Enabled = MailCheckBox.Checked;
        }

        private void BusinessRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            NoteLabel.Visible = BusinessRadioButton.Checked;
        }
    }
}
