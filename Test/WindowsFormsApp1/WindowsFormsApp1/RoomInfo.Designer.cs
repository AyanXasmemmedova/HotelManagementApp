namespace WindowsFormsApp1
{
    partial class RoomInfo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteRoombtn = new System.Windows.Forms.Button();
            this.EditRoomBtn = new System.Windows.Forms.Button();
            this.AddRoomBtn = new System.Windows.Forms.Button();
            this.Noradio = new System.Windows.Forms.RadioButton();
            this.Yesradio = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.RoomCounttb = new System.Windows.Forms.TextBox();
            this.RoomNumbertb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RoomPricetb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.RoomSearchtb = new System.Windows.Forms.TextBox();
            this.RoomGridview = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomGridview)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1403, 116);
            this.panel1.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.OliveDrab;
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(1302, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 38);
            this.button3.TabIndex = 1;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monospac821 BT", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(538, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room Info";
            // 
            // DeleteRoombtn
            // 
            this.DeleteRoombtn.BackColor = System.Drawing.Color.Red;
            this.DeleteRoombtn.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteRoombtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DeleteRoombtn.Location = new System.Drawing.Point(24, 758);
            this.DeleteRoombtn.Name = "DeleteRoombtn";
            this.DeleteRoombtn.Size = new System.Drawing.Size(234, 49);
            this.DeleteRoombtn.TabIndex = 23;
            this.DeleteRoombtn.Text = "DELETE";
            this.DeleteRoombtn.UseVisualStyleBackColor = false;
            this.DeleteRoombtn.Click += new System.EventHandler(this.DeleteRoombtn_Click);
            // 
            // EditRoomBtn
            // 
            this.EditRoomBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.EditRoomBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditRoomBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.EditRoomBtn.Location = new System.Drawing.Point(24, 673);
            this.EditRoomBtn.Name = "EditRoomBtn";
            this.EditRoomBtn.Size = new System.Drawing.Size(234, 47);
            this.EditRoomBtn.TabIndex = 22;
            this.EditRoomBtn.Text = "EDIT";
            this.EditRoomBtn.UseVisualStyleBackColor = false;
            this.EditRoomBtn.Click += new System.EventHandler(this.EditRoomBtn_Click);
            // 
            // AddRoomBtn
            // 
            this.AddRoomBtn.BackColor = System.Drawing.Color.DarkGreen;
            this.AddRoomBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddRoomBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddRoomBtn.Location = new System.Drawing.Point(22, 593);
            this.AddRoomBtn.Name = "AddRoomBtn";
            this.AddRoomBtn.Size = new System.Drawing.Size(234, 50);
            this.AddRoomBtn.TabIndex = 21;
            this.AddRoomBtn.Text = "ADD";
            this.AddRoomBtn.UseVisualStyleBackColor = false;
            this.AddRoomBtn.Click += new System.EventHandler(this.AddRoomBtn_Click);
            // 
            // Noradio
            // 
            this.Noradio.AutoSize = true;
            this.Noradio.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.Noradio.Location = new System.Drawing.Point(161, 505);
            this.Noradio.Name = "Noradio";
            this.Noradio.Size = new System.Drawing.Size(64, 30);
            this.Noradio.TabIndex = 20;
            this.Noradio.TabStop = true;
            this.Noradio.Text = "NO";
            this.Noradio.UseVisualStyleBackColor = true;
            // 
            // Yesradio
            // 
            this.Yesradio.AutoSize = true;
            this.Yesradio.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.Yesradio.Location = new System.Drawing.Point(22, 505);
            this.Yesradio.Name = "Yesradio";
            this.Yesradio.Size = new System.Drawing.Size(67, 30);
            this.Yesradio.TabIndex = 19;
            this.Yesradio.TabStop = true;
            this.Yesradio.Text = "YES";
            this.Yesradio.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(19, 465);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 26);
            this.label4.TabIndex = 18;
            this.label4.Text = "Free:";
            // 
            // RoomCounttb
            // 
            this.RoomCounttb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.RoomCounttb.Location = new System.Drawing.Point(21, 275);
            this.RoomCounttb.Multiline = true;
            this.RoomCounttb.Name = "RoomCounttb";
            this.RoomCounttb.Size = new System.Drawing.Size(282, 43);
            this.RoomCounttb.TabIndex = 17;
            // 
            // RoomNumbertb
            // 
            this.RoomNumbertb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.RoomNumbertb.Location = new System.Drawing.Point(21, 166);
            this.RoomNumbertb.Multiline = true;
            this.RoomNumbertb.Name = "RoomNumbertb";
            this.RoomNumbertb.Size = new System.Drawing.Size(282, 43);
            this.RoomNumbertb.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(18, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 30);
            this.label3.TabIndex = 15;
            this.label3.Text = "Room Count:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(21, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 30);
            this.label2.TabIndex = 14;
            this.label2.Text = "Room number:";
            // 
            // RoomPricetb
            // 
            this.RoomPricetb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.RoomPricetb.Location = new System.Drawing.Point(26, 390);
            this.RoomPricetb.Multiline = true;
            this.RoomPricetb.Name = "RoomPricetb";
            this.RoomPricetb.Size = new System.Drawing.Size(282, 43);
            this.RoomPricetb.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(23, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 30);
            this.label5.TabIndex = 24;
            this.label5.Text = "Room Price:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Blue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(551, 147);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 37);
            this.button2.TabIndex = 29;
            this.button2.Text = "Return";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(397, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 38);
            this.button1.TabIndex = 28;
            this.button1.Text = "SEARCH";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RoomSearchtb
            // 
            this.RoomSearchtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RoomSearchtb.Location = new System.Drawing.Point(982, 146);
            this.RoomSearchtb.Multiline = true;
            this.RoomSearchtb.Name = "RoomSearchtb";
            this.RoomSearchtb.Size = new System.Drawing.Size(400, 35);
            this.RoomSearchtb.TabIndex = 27;
            this.RoomSearchtb.Text = " ";
            // 
            // RoomGridview
            // 
            this.RoomGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RoomGridview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.RoomGridview.Location = new System.Drawing.Point(397, 206);
            this.RoomGridview.Name = "RoomGridview";
            this.RoomGridview.RowHeadersWidth = 51;
            this.RoomGridview.RowTemplate.Height = 24;
            this.RoomGridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RoomGridview.Size = new System.Drawing.Size(985, 618);
            this.RoomGridview.TabIndex = 26;
            this.RoomGridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RoomGridview_CellClick);
            // 
            // RoomInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1403, 825);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RoomSearchtb);
            this.Controls.Add(this.RoomGridview);
            this.Controls.Add(this.RoomPricetb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DeleteRoombtn);
            this.Controls.Add(this.EditRoomBtn);
            this.Controls.Add(this.AddRoomBtn);
            this.Controls.Add(this.Noradio);
            this.Controls.Add(this.Yesradio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RoomCounttb);
            this.Controls.Add(this.RoomNumbertb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RoomInfo";
            this.Text = "RoomInfo";
            this.Load += new System.EventHandler(this.RoomInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomGridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DeleteRoombtn;
        private System.Windows.Forms.Button EditRoomBtn;
        private System.Windows.Forms.Button AddRoomBtn;
        private System.Windows.Forms.RadioButton Noradio;
        private System.Windows.Forms.RadioButton Yesradio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox RoomCounttb;
        private System.Windows.Forms.TextBox RoomNumbertb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox RoomPricetb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox RoomSearchtb;
        private System.Windows.Forms.DataGridView RoomGridview;
    }
}