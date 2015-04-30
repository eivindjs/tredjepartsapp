namespace thirdapp
{
    partial class SettingsForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbManualsource = new System.Windows.Forms.TextBox();
            this.tbAlerts = new System.Windows.Forms.TextBox();
            this.tbSwatch = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBrowseMS = new System.Windows.Forms.Button();
            this.btnAlert = new System.Windows.Forms.Button();
            this.btnSwatch = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(506, 705);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 554F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(506, 705);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::thirdapp.Properties.Resources.basefarmTransparent;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 145);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSwatch);
            this.panel2.Controls.Add(this.btnAlert);
            this.panel2.Controls.Add(this.btnBrowseMS);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.tbSwatch);
            this.panel2.Controls.Add(this.tbAlerts);
            this.panel2.Controls.Add(this.tbManualsource);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 154);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 548);
            this.panel2.TabIndex = 1;
            // 
            // tbManualsource
            // 
            this.tbManualsource.Location = new System.Drawing.Point(61, 47);
            this.tbManualsource.Name = "tbManualsource";
            this.tbManualsource.Size = new System.Drawing.Size(169, 20);
            this.tbManualsource.TabIndex = 0;
            // 
            // tbAlerts
            // 
            this.tbAlerts.Location = new System.Drawing.Point(61, 93);
            this.tbAlerts.Name = "tbAlerts";
            this.tbAlerts.Size = new System.Drawing.Size(169, 20);
            this.tbAlerts.TabIndex = 1;
            // 
            // tbSwatch
            // 
            this.tbSwatch.Location = new System.Drawing.Point(61, 140);
            this.tbSwatch.Name = "tbSwatch";
            this.tbSwatch.Size = new System.Drawing.Size(169, 20);
            this.tbSwatch.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(49)))), ((int)(((byte)(76)))));
            this.btnSave.Location = new System.Drawing.Point(61, 219);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 29);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBrowseMS
            // 
            this.btnBrowseMS.Location = new System.Drawing.Point(237, 47);
            this.btnBrowseMS.Name = "btnBrowseMS";
            this.btnBrowseMS.Size = new System.Drawing.Size(93, 23);
            this.btnBrowseMS.TabIndex = 4;
            this.btnBrowseMS.Text = "Browse MS";
            this.btnBrowseMS.UseVisualStyleBackColor = true;
            this.btnBrowseMS.Click += new System.EventHandler(this.btnBrowseMS_Click);
            // 
            // btnAlert
            // 
            this.btnAlert.Location = new System.Drawing.Point(237, 93);
            this.btnAlert.Name = "btnAlert";
            this.btnAlert.Size = new System.Drawing.Size(93, 23);
            this.btnAlert.TabIndex = 5;
            this.btnAlert.Text = "Browse Alert";
            this.btnAlert.UseVisualStyleBackColor = true;
            this.btnAlert.Click += new System.EventHandler(this.btnAlert_Click);
            // 
            // btnSwatch
            // 
            this.btnSwatch.Location = new System.Drawing.Point(237, 136);
            this.btnSwatch.Name = "btnSwatch";
            this.btnSwatch.Size = new System.Drawing.Size(93, 23);
            this.btnSwatch.TabIndex = 6;
            this.btnSwatch.Text = "Browse Swatch";
            this.btnSwatch.UseVisualStyleBackColor = true;
            this.btnSwatch.Click += new System.EventHandler(this.btnSwatch_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 705);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(522, 744);
            this.MinimumSize = new System.Drawing.Size(522, 744);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbSwatch;
        private System.Windows.Forms.TextBox tbAlerts;
        private System.Windows.Forms.TextBox tbManualsource;
        private System.Windows.Forms.Button btnSwatch;
        private System.Windows.Forms.Button btnAlert;
        private System.Windows.Forms.Button btnBrowseMS;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}