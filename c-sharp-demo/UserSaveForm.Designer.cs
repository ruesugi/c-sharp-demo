﻿
namespace c_sharp_demo
{
    partial class UserSaveForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.IDLabel = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.MailCheckBox = new System.Windows.Forms.CheckBox();
            this.MailAddressLabel = new System.Windows.Forms.Label();
            this.MailAddressTextBox = new System.Windows.Forms.TextBox();
            this.PricePlanGroupBox = new System.Windows.Forms.GroupBox();
            this.BusinessRadioButton = new System.Windows.Forms.RadioButton();
            this.FreeRadioButton = new System.Windows.Forms.RadioButton();
            this.NoteLabel = new System.Windows.Forms.Label();
            this.EnableComboBox = new System.Windows.Forms.ComboBox();
            this.PricePlanGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(12, 9);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(16, 12);
            this.IDLabel.TabIndex = 0;
            this.IDLabel.Text = "ID";
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(34, 6);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(100, 19);
            this.IDTextBox.TabIndex = 1;
            // 
            // MailCheckBox
            // 
            this.MailCheckBox.AutoSize = true;
            this.MailCheckBox.Location = new System.Drawing.Point(14, 40);
            this.MailCheckBox.Name = "MailCheckBox";
            this.MailCheckBox.Size = new System.Drawing.Size(104, 16);
            this.MailCheckBox.TabIndex = 2;
            this.MailCheckBox.Text = "メールを送信する";
            this.MailCheckBox.UseVisualStyleBackColor = true;
            this.MailCheckBox.CheckedChanged += new System.EventHandler(this.MailCheckBox_CheckedChanged);
            // 
            // MailAddressLabel
            // 
            this.MailAddressLabel.AutoSize = true;
            this.MailAddressLabel.Location = new System.Drawing.Point(14, 63);
            this.MailAddressLabel.Name = "MailAddressLabel";
            this.MailAddressLabel.Size = new System.Drawing.Size(69, 12);
            this.MailAddressLabel.TabIndex = 3;
            this.MailAddressLabel.Text = "メールアドレス";
            // 
            // MailAddressTextBox
            // 
            this.MailAddressTextBox.Location = new System.Drawing.Point(89, 60);
            this.MailAddressTextBox.Name = "MailAddressTextBox";
            this.MailAddressTextBox.Size = new System.Drawing.Size(100, 19);
            this.MailAddressTextBox.TabIndex = 4;
            // 
            // PricePlanGroupBox
            // 
            this.PricePlanGroupBox.Controls.Add(this.BusinessRadioButton);
            this.PricePlanGroupBox.Controls.Add(this.FreeRadioButton);
            this.PricePlanGroupBox.Location = new System.Drawing.Point(14, 97);
            this.PricePlanGroupBox.Name = "PricePlanGroupBox";
            this.PricePlanGroupBox.Size = new System.Drawing.Size(200, 52);
            this.PricePlanGroupBox.TabIndex = 5;
            this.PricePlanGroupBox.TabStop = false;
            this.PricePlanGroupBox.Text = "プラン";
            // 
            // BusinessRadioButton
            // 
            this.BusinessRadioButton.AutoSize = true;
            this.BusinessRadioButton.Location = new System.Drawing.Point(102, 18);
            this.BusinessRadioButton.Name = "BusinessRadioButton";
            this.BusinessRadioButton.Size = new System.Drawing.Size(60, 16);
            this.BusinessRadioButton.TabIndex = 1;
            this.BusinessRadioButton.TabStop = true;
            this.BusinessRadioButton.Text = "ビジネス";
            this.BusinessRadioButton.UseVisualStyleBackColor = true;
            this.BusinessRadioButton.CheckedChanged += new System.EventHandler(this.BusinessRadioButton_CheckedChanged);
            // 
            // FreeRadioButton
            // 
            this.FreeRadioButton.AutoSize = true;
            this.FreeRadioButton.Location = new System.Drawing.Point(7, 19);
            this.FreeRadioButton.Name = "FreeRadioButton";
            this.FreeRadioButton.Size = new System.Drawing.Size(47, 16);
            this.FreeRadioButton.TabIndex = 0;
            this.FreeRadioButton.TabStop = true;
            this.FreeRadioButton.Text = "無料";
            this.FreeRadioButton.UseVisualStyleBackColor = true;
            // 
            // NoteLabel
            // 
            this.NoteLabel.AutoSize = true;
            this.NoteLabel.Location = new System.Drawing.Point(14, 156);
            this.NoteLabel.Name = "NoteLabel";
            this.NoteLabel.Size = new System.Drawing.Size(91, 12);
            this.NoteLabel.TabIndex = 6;
            this.NoteLabel.Text = "無制限で使えます";
            // 
            // EnableComboBox
            // 
            this.EnableComboBox.FormattingEnabled = true;
            this.EnableComboBox.Location = new System.Drawing.Point(14, 190);
            this.EnableComboBox.Name = "EnableComboBox";
            this.EnableComboBox.Size = new System.Drawing.Size(121, 20);
            this.EnableComboBox.TabIndex = 7;
            // 
            // UserSaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 311);
            this.Controls.Add(this.EnableComboBox);
            this.Controls.Add(this.NoteLabel);
            this.Controls.Add(this.PricePlanGroupBox);
            this.Controls.Add(this.MailAddressTextBox);
            this.Controls.Add(this.MailAddressLabel);
            this.Controls.Add(this.MailCheckBox);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.IDLabel);
            this.Name = "UserSaveForm";
            this.Text = "ユーザー登録";
            this.PricePlanGroupBox.ResumeLayout(false);
            this.PricePlanGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.CheckBox MailCheckBox;
        private System.Windows.Forms.Label MailAddressLabel;
        private System.Windows.Forms.TextBox MailAddressTextBox;
        private System.Windows.Forms.GroupBox PricePlanGroupBox;
        private System.Windows.Forms.RadioButton BusinessRadioButton;
        private System.Windows.Forms.RadioButton FreeRadioButton;
        private System.Windows.Forms.Label NoteLabel;
        private System.Windows.Forms.ComboBox EnableComboBox;
    }
}

