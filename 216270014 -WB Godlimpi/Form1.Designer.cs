namespace _216270014__WB_Godlimpi
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tRANSECTIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDDNewStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retriveInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tRANSECTIONToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(946, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tRANSECTIONToolStripMenuItem
            // 
            this.tRANSECTIONToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDDNewStudentToolStripMenuItem,
            this.updateDetailsToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.retriveInfoToolStripMenuItem});
            this.tRANSECTIONToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tRANSECTIONToolStripMenuItem.Name = "tRANSECTIONToolStripMenuItem";
            this.tRANSECTIONToolStripMenuItem.Size = new System.Drawing.Size(97, 21);
            this.tRANSECTIONToolStripMenuItem.Text = "Transactions";
            // 
            // aDDNewStudentToolStripMenuItem
            // 
            this.aDDNewStudentToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aDDNewStudentToolStripMenuItem.Name = "aDDNewStudentToolStripMenuItem";
            this.aDDNewStudentToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.aDDNewStudentToolStripMenuItem.Text = "ADD New Student";
            this.aDDNewStudentToolStripMenuItem.Click += new System.EventHandler(this.aDDNewStudentToolStripMenuItem_Click);
            // 
            // updateDetailsToolStripMenuItem
            // 
            this.updateDetailsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateDetailsToolStripMenuItem.Name = "updateDetailsToolStripMenuItem";
            this.updateDetailsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.updateDetailsToolStripMenuItem.Text = "Update Details";
            this.updateDetailsToolStripMenuItem.Click += new System.EventHandler(this.updateDetailsToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // retriveInfoToolStripMenuItem
            // 
            this.retriveInfoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retriveInfoToolStripMenuItem.Name = "retriveInfoToolStripMenuItem";
            this.retriveInfoToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.retriveInfoToolStripMenuItem.Text = "Retrive Info";
            this.retriveInfoToolStripMenuItem.Click += new System.EventHandler(this.retriveInfoToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 527);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "TRANSECTION MENU";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tRANSECTIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDDNewStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retriveInfoToolStripMenuItem;
    }
}

