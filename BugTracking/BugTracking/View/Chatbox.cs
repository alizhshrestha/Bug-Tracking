using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BugTracking.Controller;
using BugTracking.Model;
using MaterialSkin;
using MaterialSkin.Controls;
using MySql.Data.MySqlClient;

namespace BugTracking.View
{
    public partial class Chatbox : MaterialForm
    {
        string username, message;

        public Chatbox(String username)
        {
            this.username = username;

            // Create a material theme manager and add the form to manage (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );



            InitializeComponent();
        }


        private void Chatbox_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = DatabaseController.connectToDb();
            String query = "select username, message from chat_box";
            conn.Open();
            using (conn)
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        string[] row = {(String)reader["username"], (String)reader["message"]};
                        var listViewItem = new ListViewItem(row);
                        list_view_chat.Items.Add(listViewItem);
                    }
                }
            }

            conn.Close();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            message = txt_message.Text;
            ChatBox chat_box = new ChatBox(message, username);
            ChatBoxController.insertMessageToDatabase(chat_box);
            MessageBox.Show("Successfully inserted");
            list_view_chat.Refresh();
            this.Hide();
            Chatbox cb = new Chatbox(this.username);
            cb.Show();
        }
    }
}
