namespace WindowsFormsApp1
{
    partial class Results
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
            this.dgv_search = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_search)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_search
            // 
            this.dgv_search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_search.Location = new System.Drawing.Point(13, 13);
            this.dgv_search.Name = "dgv_search";
            this.dgv_search.Size = new System.Drawing.Size(533, 254);
            this.dgv_search.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(447, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Create Ticket";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 362);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_search);
            this.Name = "Results";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_search)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_search;
        private System.Windows.Forms.Button button1;
    }
}