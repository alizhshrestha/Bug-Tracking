namespace BugTracking.View
{
    partial class Chatbox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_message = new LollipopTextBox();
            this.lollipopLabel2 = new LollipopLabel();
            this.btn_send = new LollipopButton();
            this.list_view_chat = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // txt_message
            // 
            this.txt_message.FocusedColor = "#508ef5";
            this.txt_message.FontColor = "#999999";
            this.txt_message.IsEnabled = true;
            this.txt_message.Location = new System.Drawing.Point(15, 422);
            this.txt_message.MaxLength = 32767;
            this.txt_message.Multiline = false;
            this.txt_message.Name = "txt_message";
            this.txt_message.ReadOnly = false;
            this.txt_message.Size = new System.Drawing.Size(163, 24);
            this.txt_message.TabIndex = 2;
            this.txt_message.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_message.UseSystemPasswordChar = false;
            // 
            // lollipopLabel2
            // 
            this.lollipopLabel2.AutoSize = true;
            this.lollipopLabel2.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel2.Location = new System.Drawing.Point(12, 402);
            this.lollipopLabel2.Name = "lollipopLabel2";
            this.lollipopLabel2.Size = new System.Drawing.Size(69, 17);
            this.lollipopLabel2.TabIndex = 3;
            this.lollipopLabel2.Text = "Message:";
            // 
            // btn_send
            // 
            this.btn_send.BackColor = System.Drawing.Color.Transparent;
            this.btn_send.BGColor = "#508ef5";
            this.btn_send.FontColor = "#ffffff";
            this.btn_send.Location = new System.Drawing.Point(191, 422);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(53, 21);
            this.btn_send.TabIndex = 5;
            this.btn_send.Text = "Send";
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // list_view_chat
            // 
            this.list_view_chat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.list_view_chat.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.list_view_chat.Depth = 0;
            this.list_view_chat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_view_chat.FullRowSelect = true;
            this.list_view_chat.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.list_view_chat.Location = new System.Drawing.Point(12, 75);
            this.list_view_chat.MouseLocation = new System.Drawing.Point(-1, -1);
            this.list_view_chat.MouseState = MaterialSkin.MouseState.OUT;
            this.list_view_chat.Name = "list_view_chat";
            this.list_view_chat.OwnerDraw = true;
            this.list_view_chat.Size = new System.Drawing.Size(222, 310);
            this.list_view_chat.TabIndex = 6;
            this.list_view_chat.UseCompatibleStateImageBehavior = false;
            this.list_view_chat.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "From";
            this.columnHeader1.Width = 97;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Message";
            this.columnHeader2.Width = 124;
            // 
            // Chatbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 450);
            this.Controls.Add(this.list_view_chat);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.lollipopLabel2);
            this.Controls.Add(this.txt_message);
            this.Name = "Chatbox";
            this.Text = "Chatbox";
            this.Load += new System.EventHandler(this.Chatbox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private LollipopTextBox txt_message;
        private LollipopLabel lollipopLabel2;
        private LollipopButton btn_send;
        private MaterialSkin.Controls.MaterialListView list_view_chat;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}