namespace BM_dekoder
{
    partial class Form1
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
            this.ip1 = new System.Windows.Forms.TextBox();
            this.ip2 = new System.Windows.Forms.TextBox();
            this.message = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.btn_dekod = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.dataGridView_send = new System.Windows.Forms.DataGridView();
            this.datagrid_ip1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datagrid_ip2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datagrid_message = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datagrid_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dategrid_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_send)).BeginInit();
            this.SuspendLayout();
            // 
            // ip1
            // 
            this.ip1.Location = new System.Drawing.Point(35, 32);
            this.ip1.Name = "ip1";
            this.ip1.Size = new System.Drawing.Size(100, 20);
            this.ip1.TabIndex = 0;
            // 
            // ip2
            // 
            this.ip2.Location = new System.Drawing.Point(35, 67);
            this.ip2.Name = "ip2";
            this.ip2.Size = new System.Drawing.Size(100, 20);
            this.ip2.TabIndex = 2;
            // 
            // message
            // 
            this.message.Location = new System.Drawing.Point(36, 101);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(100, 20);
            this.message.TabIndex = 3;
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(166, 29);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 23);
            this.btn_send.TabIndex = 4;
            this.btn_send.Text = "Küldés";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // btn_dekod
            // 
            this.btn_dekod.Location = new System.Drawing.Point(166, 65);
            this.btn_dekod.Name = "btn_dekod";
            this.btn_dekod.Size = new System.Drawing.Size(75, 23);
            this.btn_dekod.TabIndex = 5;
            this.btn_dekod.Text = "Dekódolás";
            this.btn_dekod.UseVisualStyleBackColor = true;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(166, 99);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 6;
            this.btn_exit.Text = "Kilépés";
            this.btn_exit.UseVisualStyleBackColor = true;
            // 
            // dataGridView_send
            // 
            this.dataGridView_send.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_send.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.datagrid_ip1,
            this.datagrid_ip2,
            this.datagrid_message,
            this.datagrid_date,
            this.dategrid_number});
            this.dataGridView_send.Location = new System.Drawing.Point(12, 160);
            this.dataGridView_send.Name = "dataGridView_send";
            this.dataGridView_send.Size = new System.Drawing.Size(765, 208);
            this.dataGridView_send.TabIndex = 7;
            // 
            // datagrid_ip1
            // 
            this.datagrid_ip1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.datagrid_ip1.HeaderText = "IP1";
            this.datagrid_ip1.Name = "datagrid_ip1";
            this.datagrid_ip1.ReadOnly = true;
            // 
            // datagrid_ip2
            // 
            this.datagrid_ip2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.datagrid_ip2.HeaderText = "IP2";
            this.datagrid_ip2.Name = "datagrid_ip2";
            this.datagrid_ip2.ReadOnly = true;
            // 
            // datagrid_message
            // 
            this.datagrid_message.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.datagrid_message.HeaderText = "Message";
            this.datagrid_message.Name = "datagrid_message";
            this.datagrid_message.ReadOnly = true;
            // 
            // datagrid_date
            // 
            this.datagrid_date.HeaderText = "Date";
            this.datagrid_date.Name = "datagrid_date";
            this.datagrid_date.ReadOnly = true;
            // 
            // dategrid_number
            // 
            this.dategrid_number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dategrid_number.HeaderText = "Number";
            this.dategrid_number.Name = "dategrid_number";
            this.dategrid_number.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView_send);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_dekod);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.message);
            this.Controls.Add(this.ip2);
            this.Controls.Add(this.ip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_send)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ip1;
        private System.Windows.Forms.TextBox ip2;
        private System.Windows.Forms.TextBox message;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Button btn_dekod;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.DataGridView dataGridView_send;
        private System.Windows.Forms.DataGridViewTextBoxColumn datagrid_ip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn datagrid_ip2;
        private System.Windows.Forms.DataGridViewTextBoxColumn datagrid_message;
        private System.Windows.Forms.DataGridViewTextBoxColumn datagrid_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn dategrid_number;
    }
}

