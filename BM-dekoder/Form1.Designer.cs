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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_send)).BeginInit();
            this.SuspendLayout();
            // 
            // ip1
            // 
            this.ip1.Location = new System.Drawing.Point(77, 31);
            this.ip1.Name = "ip1";
            this.ip1.Size = new System.Drawing.Size(100, 20);
            this.ip1.TabIndex = 0;
            // 
            // ip2
            // 
            this.ip2.Location = new System.Drawing.Point(77, 66);
            this.ip2.Name = "ip2";
            this.ip2.Size = new System.Drawing.Size(100, 20);
            this.ip2.TabIndex = 2;
            // 
            // message
            // 
            this.message.Location = new System.Drawing.Point(78, 100);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(100, 20);
            this.message.TabIndex = 3;
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(200, 27);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 23);
            this.btn_send.TabIndex = 4;
            this.btn_send.Text = "Küldés";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // btn_dekod
            // 
            this.btn_dekod.Location = new System.Drawing.Point(200, 63);
            this.btn_dekod.Name = "btn_dekod";
            this.btn_dekod.Size = new System.Drawing.Size(75, 23);
            this.btn_dekod.TabIndex = 5;
            this.btn_dekod.Text = "Dekódolás";
            this.btn_dekod.UseVisualStyleBackColor = true;
            this.btn_dekod.Click += new System.EventHandler(this.btn_dekod_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(200, 97);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 6;
            this.btn_exit.Text = "Kilépés";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // dataGridView_send
            // 
            this.dataGridView_send.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_send.Location = new System.Drawing.Point(12, 160);
            this.dataGridView_send.Name = "dataGridView_send";
            this.dataGridView_send.Size = new System.Drawing.Size(765, 208);
            this.dataGridView_send.TabIndex = 7;
            // 
            // IP1_label
            // 
            this.IP1_label.AutoSize = true;
            this.IP1_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.IP1_label.Location = new System.Drawing.Point(27, 38);
            this.IP1_label.Name = "IP1_label";
            this.IP1_label.Size = new System.Drawing.Size(23, 13);
            this.IP1_label.TabIndex = 8;
            this.IP1_label.Text = "IP1";
            // 
            // IP2_label
            // 
            this.IP2_label.AutoSize = true;
            this.IP2_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.IP2_label.Location = new System.Drawing.Point(27, 74);
            this.IP2_label.Name = "IP2_label";
            this.IP2_label.Size = new System.Drawing.Size(23, 13);
            this.IP2_label.TabIndex = 9;
            this.IP2_label.Text = "IP2";
            // 
            // M_label
            // 
            this.M_label.AutoSize = true;
            this.M_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.M_label.Location = new System.Drawing.Point(27, 108);
            this.M_label.Name = "M_label";
            this.M_label.Size = new System.Drawing.Size(50, 13);
            this.M_label.TabIndex = 10;
            this.M_label.Text = "Message";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.M_label);
            this.Controls.Add(this.IP2_label);
            this.Controls.Add(this.IP1_label);
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
        private System.Windows.Forms.Label IP1_label;
        private System.Windows.Forms.Label IP2_label;
        private System.Windows.Forms.Label M_label;
    }
}

