namespace WindowsFormsApp1
{
    partial class MainMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Random = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.dgv_ticket = new System.Windows.Forms.DataGridView();
            this.num1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ticket)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(13, 105);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(383, 20);
            this.txt_Search.TabIndex = 0;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(402, 105);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(154, 23);
            this.btn_Search.TabIndex = 1;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Random
            // 
            this.btn_Random.Location = new System.Drawing.Point(13, 397);
            this.btn_Random.Name = "btn_Random";
            this.btn_Random.Size = new System.Drawing.Size(165, 23);
            this.btn_Random.TabIndex = 13;
            this.btn_Random.Text = "Random";
            this.btn_Random.UseVisualStyleBackColor = true;
            this.btn_Random.Click += new System.EventHandler(this.btn_Random_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(402, 397);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(154, 23);
            this.btn_OK.TabIndex = 14;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // dgv_ticket
            // 
            this.dgv_ticket.AllowUserToResizeColumns = false;
            this.dgv_ticket.AllowUserToResizeRows = false;
            this.dgv_ticket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ticket.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num1,
            this.num2,
            this.num3,
            this.num4,
            this.num5});
            this.dgv_ticket.Location = new System.Drawing.Point(13, 153);
            this.dgv_ticket.Name = "dgv_ticket";
            this.dgv_ticket.Size = new System.Drawing.Size(543, 227);
            this.dgv_ticket.TabIndex = 15;
            // 
            // num1
            // 
            this.num1.HeaderText = "1";
            this.num1.Name = "num1";
            // 
            // num2
            // 
            this.num2.HeaderText = "2";
            this.num2.Name = "num2";
            // 
            // num3
            // 
            this.num3.HeaderText = "3";
            this.num3.Name = "num3";
            // 
            // num4
            // 
            this.num4.HeaderText = "4";
            this.num4.Name = "num4";
            // 
            // num5
            // 
            this.num5.HeaderText = "5";
            this.num5.Name = "num5";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 483);
            this.Controls.Add(this.dgv_ticket);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.btn_Random);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txt_Search);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ticket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Random;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.DataGridViewTextBoxColumn num1;
        private System.Windows.Forms.DataGridViewTextBoxColumn num2;
        private System.Windows.Forms.DataGridViewTextBoxColumn num3;
        private System.Windows.Forms.DataGridViewTextBoxColumn num4;
        private System.Windows.Forms.DataGridViewTextBoxColumn num5;
        public System.Windows.Forms.DataGridView dgv_ticket;
    }
}