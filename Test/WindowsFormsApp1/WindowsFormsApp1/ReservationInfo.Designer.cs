namespace WindowsFormsApp1
{
    partial class ReservationInfo
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
            this.RoomNumbercb = new System.Windows.Forms.ComboBox();
            this.ClientNamecb = new System.Windows.Forms.ComboBox();
            this.DeleteRoombtn = new System.Windows.Forms.Button();
            this.AddRoomBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DateOut = new System.Windows.Forms.DateTimePicker();
            this.DateIn = new System.Windows.Forms.DateTimePicker();
            this.ReserIdtb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ReservationSearchtb = new System.Windows.Forms.TextBox();
            this.ReservationGridview = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReservationGridview)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1410, 116);
            this.panel1.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.OliveDrab;
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(1312, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 38);
            this.button3.TabIndex = 2;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monospac821 BT", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(443, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reservation Info";
            // 
            // RoomNumbercb
            // 
            this.RoomNumbercb.FormattingEnabled = true;
            this.RoomNumbercb.Location = new System.Drawing.Point(30, 416);
            this.RoomNumbercb.Name = "RoomNumbercb";
            this.RoomNumbercb.Size = new System.Drawing.Size(242, 24);
            this.RoomNumbercb.TabIndex = 40;
            // 
            // ClientNamecb
            // 
            this.ClientNamecb.FormattingEnabled = true;
            this.ClientNamecb.Location = new System.Drawing.Point(33, 304);
            this.ClientNamecb.Name = "ClientNamecb";
            this.ClientNamecb.Size = new System.Drawing.Size(242, 24);
            this.ClientNamecb.TabIndex = 39;
            // 
            // DeleteRoombtn
            // 
            this.DeleteRoombtn.BackColor = System.Drawing.Color.Red;
            this.DeleteRoombtn.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteRoombtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DeleteRoombtn.Location = new System.Drawing.Point(33, 679);
            this.DeleteRoombtn.Name = "DeleteRoombtn";
            this.DeleteRoombtn.Size = new System.Drawing.Size(234, 49);
            this.DeleteRoombtn.TabIndex = 38;
            this.DeleteRoombtn.Text = "DELETE";
            this.DeleteRoombtn.UseVisualStyleBackColor = false;
            this.DeleteRoombtn.Click += new System.EventHandler(this.DeleteRoombtn_Click);
            // 
            // AddRoomBtn
            // 
            this.AddRoomBtn.BackColor = System.Drawing.Color.DarkGreen;
            this.AddRoomBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddRoomBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddRoomBtn.Location = new System.Drawing.Point(33, 586);
            this.AddRoomBtn.Name = "AddRoomBtn";
            this.AddRoomBtn.Size = new System.Drawing.Size(234, 50);
            this.AddRoomBtn.TabIndex = 37;
            this.AddRoomBtn.Text = "ADD";
            this.AddRoomBtn.UseVisualStyleBackColor = false;
            this.AddRoomBtn.Click += new System.EventHandler(this.AddRoomBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 535);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 22);
            this.label6.TabIndex = 36;
            this.label6.Text = "CheckOut:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 477);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 22);
            this.label5.TabIndex = 35;
            this.label5.Text = "CheckIn:";
            // 
            // DateOut
            // 
            this.DateOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateOut.Location = new System.Drawing.Point(128, 531);
            this.DateOut.Name = "DateOut";
            this.DateOut.Size = new System.Drawing.Size(154, 24);
            this.DateOut.TabIndex = 34;
            this.DateOut.ValueChanged += new System.EventHandler(this.DateOut_ValueChanged);
            // 
            // DateIn
            // 
            this.DateIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateIn.Location = new System.Drawing.Point(128, 473);
            this.DateIn.Name = "DateIn";
            this.DateIn.Size = new System.Drawing.Size(154, 24);
            this.DateIn.TabIndex = 33;
            this.DateIn.ValueChanged += new System.EventHandler(this.DateIn_ValueChanged);
            // 
            // ReserIdtb
            // 
            this.ReserIdtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.ReserIdtb.Location = new System.Drawing.Point(33, 200);
            this.ReserIdtb.Multiline = true;
            this.ReserIdtb.Name = "ReserIdtb";
            this.ReserIdtb.Size = new System.Drawing.Size(247, 39);
            this.ReserIdtb.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(28, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 26);
            this.label4.TabIndex = 31;
            this.label4.Text = "Room Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(28, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 26);
            this.label3.TabIndex = 30;
            this.label3.Text = "Client Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(28, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 26);
            this.label2.TabIndex = 29;
            this.label2.Text = "Reservation Id:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Blue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(552, 150);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 37);
            this.button2.TabIndex = 44;
            this.button2.Text = "Return";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(398, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 38);
            this.button1.TabIndex = 43;
            this.button1.Text = "SEARCH";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ReservationSearchtb
            // 
            this.ReservationSearchtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReservationSearchtb.Location = new System.Drawing.Point(983, 149);
            this.ReservationSearchtb.Multiline = true;
            this.ReservationSearchtb.Name = "ReservationSearchtb";
            this.ReservationSearchtb.Size = new System.Drawing.Size(400, 35);
            this.ReservationSearchtb.TabIndex = 42;
            this.ReservationSearchtb.Text = " ";
            // 
            // ReservationGridview
            // 
            this.ReservationGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReservationGridview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ReservationGridview.Location = new System.Drawing.Point(398, 209);
            this.ReservationGridview.Name = "ReservationGridview";
            this.ReservationGridview.RowHeadersWidth = 51;
            this.ReservationGridview.RowTemplate.Height = 24;
            this.ReservationGridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ReservationGridview.Size = new System.Drawing.Size(985, 602);
            this.ReservationGridview.TabIndex = 41;
            this.ReservationGridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ReservationGridview_CellClick);
            // 
            // ReservationInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1410, 827);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ReservationSearchtb);
            this.Controls.Add(this.ReservationGridview);
            this.Controls.Add(this.RoomNumbercb);
            this.Controls.Add(this.ClientNamecb);
            this.Controls.Add(this.DeleteRoombtn);
            this.Controls.Add(this.AddRoomBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DateOut);
            this.Controls.Add(this.DateIn);
            this.Controls.Add(this.ReserIdtb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReservationInfo";
            this.Text = "ReservationInfo";
            this.Load += new System.EventHandler(this.ReservationInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReservationGridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox RoomNumbercb;
        private System.Windows.Forms.ComboBox ClientNamecb;
        private System.Windows.Forms.Button DeleteRoombtn;
        private System.Windows.Forms.Button AddRoomBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DateOut;
        private System.Windows.Forms.DateTimePicker DateIn;
        private System.Windows.Forms.TextBox ReserIdtb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ReservationSearchtb;
        private System.Windows.Forms.DataGridView ReservationGridview;
    }
}