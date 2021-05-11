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
            InitializePricePlan();
            InitializeEnableSetting();
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
            ChangeNoteLabelVisible();
        }

        private void ChangeNoteLabelVisible()
        {
            NoteLabel.Visible = BusinessRadioButton.Checked;
        }

        private void InitializePricePlan()
        {
            FreeRadioButton.Checked = true;
            ChangeNoteLabelVisible();
        }

        private void InitializeEnableSetting()
        {
            EnableComboBox.Items.Add("有効");
            EnableComboBox.Items.Add("無効");
            EnableComboBox.SelectedIndex = 0;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("保存しますか？",
                                                  "確認",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                using (var sw = new System.IO.StreamWriter("user_data.csv", true, Encoding.UTF8))
                {
                    sw.Write(IDTextBox.Text + ",");
                    sw.Write(MailCheckBox.Checked + ",");
                    sw.Write(MailAddressTextBox.Text + ",");
                    if (BusinessRadioButton.Checked)
                    {
                        sw.Write(1 + ",");
                    }
                    else
                    {
                        sw.Write(0 + ",");
                    }
                    sw.Write(EnableComboBox.Text);
                    sw.WriteLine("");

                }
                StatusText.Text = "保存しました";
            }
            else
            {
                StatusText.Text = "キャンセルしました";
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
