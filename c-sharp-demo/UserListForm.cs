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
    public partial class UserListForm : Form
    {
        public UserListForm()
        {
            InitializeComponent();
            if (System.IO.File.Exists("user_data.csv"))
            {
                var lines = System.IO.File.ReadAllLines("user_data.csv", Encoding.UTF8);
                foreach (var line in lines)
                {
                    var data = line.Split(',');

                    UserDataGrid.ColumnCount = 5;
                    UserDataGrid.Columns[0].HeaderText = "ID";
                    UserDataGrid.Columns[1].HeaderText = "メール送信";
                    UserDataGrid.Columns[2].HeaderText = "メールアドレス";
                    UserDataGrid.Columns[3].HeaderText = "プラン";
                    UserDataGrid.Columns[4].HeaderText = "有効/無効";

                    UserDataGrid.Rows.Add(data[0], data[1], data[2], data[3], data[4]);
                }
            }
        }
    }
}
