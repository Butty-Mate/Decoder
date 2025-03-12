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
            this.IP1_label = new System.Windows.Forms.Label();
            this.IP2_label = new System.Windows.Forms.Label();
            this.M_label = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_send)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ip1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.ip1, 2);
            this.ip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ip1.Location = new System.Drawing.Point(129, 52);
            this.ip1.Name = "ip1";
            this.ip1.Size = new System.Drawing.Size(137, 20);
            this.ip1.TabIndex = 0;
            // 
            // ip2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.ip2, 2);
            this.ip2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ip2.Location = new System.Drawing.Point(129, 82);
            this.ip2.Name = "ip2";
            this.ip2.Size = new System.Drawing.Size(137, 20);
            this.ip2.TabIndex = 2;
            // 
            // message
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.message, 2);
            this.message.Dock = System.Windows.Forms.DockStyle.Fill;
            this.message.Location = new System.Drawing.Point(129, 112);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(137, 20);
            this.message.TabIndex = 3;
            // 
            // btn_send
            // 
            this.btn_send.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_send.Location = new System.Drawing.Point(272, 52);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 24);
            this.btn_send.TabIndex = 4;
            this.btn_send.Text = "Küldés";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // btn_dekod
            // 
            this.btn_dekod.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_dekod.Location = new System.Drawing.Point(272, 82);
            this.btn_dekod.Name = "btn_dekod";
            this.btn_dekod.Size = new System.Drawing.Size(75, 24);
            this.btn_dekod.TabIndex = 5;
            this.btn_dekod.Text = "Dekódolás";
            this.btn_dekod.UseVisualStyleBackColor = true;
            this.btn_dekod.Click += new System.EventHandler(this.btn_dekod_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_exit.Location = new System.Drawing.Point(272, 112);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 24);
            this.btn_exit.TabIndex = 6;
            this.btn_exit.Text = "Kilépés";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // dataGridView_send
            // 
            this.dataGridView_send.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridView_send, 6);
            this.dataGridView_send.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_send.Location = new System.Drawing.Point(43, 186);
            this.dataGridView_send.Name = "dataGridView_send";
            this.dataGridView_send.Size = new System.Drawing.Size(565, 218);
            this.dataGridView_send.TabIndex = 7;
            // 
            // IP1_label
            // 
            this.IP1_label.AutoSize = true;
            this.IP1_label.Dock = System.Windows.Forms.DockStyle.Right;
            this.IP1_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.IP1_label.Location = new System.Drawing.Point(97, 49);
            this.IP1_label.Name = "IP1_label";
            this.IP1_label.Size = new System.Drawing.Size(26, 30);
            this.IP1_label.TabIndex = 8;
            this.IP1_label.Text = "IP1:";
            this.IP1_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.IP1_label.Click += new System.EventHandler(this.IP1_label_Click);
            // 
            // IP2_label
            // 
            this.IP2_label.AutoSize = true;
            this.IP2_label.Dock = System.Windows.Forms.DockStyle.Right;
            this.IP2_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.IP2_label.Location = new System.Drawing.Point(97, 79);
            this.IP2_label.Name = "IP2_label";
            this.IP2_label.Size = new System.Drawing.Size(26, 30);
            this.IP2_label.TabIndex = 9;
            this.IP2_label.Text = "IP2:";
            this.IP2_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.IP2_label.Click += new System.EventHandler(this.IP2_label_Click);
            // 
            // M_label
            // 
            this.M_label.AutoSize = true;
            this.M_label.Dock = System.Windows.Forms.DockStyle.Right;
            this.M_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.M_label.Location = new System.Drawing.Point(79, 109);
            this.M_label.Name = "M_label";
            this.M_label.Size = new System.Drawing.Size(44, 30);
            this.M_label.TabIndex = 10;
            this.M_label.Text = "Üzenet:";
            this.M_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Controls.Add(this.btn_exit, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_dekod, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_send, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView_send, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.IP1_label, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.IP2_label, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.M_label, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.ip1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.ip2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.message, 2, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(400, 300);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.10258F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.748571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.748571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.748571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.925707F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.96162F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.764377F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(654, 450);
            this.tableLayoutPanel1.TabIndex = 11;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_send)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox ip1;
        private System.Windows.Forms.TextBox ip2;
        private System.Windows.Forms.TextBox message;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Button btn_dekod;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.DataGridView dataGridView_send;
        private System.Windows.Forms.Label IP1_label;
        private System.Windows.Forms.Label IP2_label;
        private System.Windows.Forms.Label M_label;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

