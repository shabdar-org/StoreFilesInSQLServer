namespace StoreFilesInSQLServer
{
    partial class frmFilesStore
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtConnectionString = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdStoreNewFile = new System.Windows.Forms.Button();
            this.cmdConnect = new System.Windows.Forms.Button();
            this.btnSaveFromDBToDisk = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.cmdDeleteFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(587, 255);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // txtConnectionString
            // 
            this.txtConnectionString.Location = new System.Drawing.Point(105, 36);
            this.txtConnectionString.Multiline = true;
            this.txtConnectionString.Name = "txtConnectionString";
            this.txtConnectionString.Size = new System.Drawing.Size(520, 40);
            this.txtConnectionString.TabIndex = 1;
            this.txtConnectionString.Text = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\user2021\\source\\repo" +
    "s\\StoreFilesInSQLServer\\StoreFilesInSQLServer\\FileStore.mdf;Integrated Security=" +
    "True";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Connection String :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(431, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Restore database provided in source code zip file and change following connection" +
    " string.";
            // 
            // cmdStoreNewFile
            // 
            this.cmdStoreNewFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdStoreNewFile.Location = new System.Drawing.Point(260, 429);
            this.cmdStoreNewFile.Name = "cmdStoreNewFile";
            this.cmdStoreNewFile.Size = new System.Drawing.Size(168, 34);
            this.cmdStoreNewFile.TabIndex = 5;
            this.cmdStoreNewFile.Text = "Store New File";
            this.cmdStoreNewFile.UseVisualStyleBackColor = true;
            this.cmdStoreNewFile.Click += new System.EventHandler(this.cmdStoreNewFile_Click);
            // 
            // cmdConnect
            // 
            this.cmdConnect.Location = new System.Drawing.Point(105, 82);
            this.cmdConnect.Name = "cmdConnect";
            this.cmdConnect.Size = new System.Drawing.Size(91, 25);
            this.cmdConnect.TabIndex = 6;
            this.cmdConnect.Text = "Connect";
            this.cmdConnect.UseVisualStyleBackColor = true;
            this.cmdConnect.Click += new System.EventHandler(this.cmdConnect_Click);
            // 
            // btnSaveFromDBToDisk
            // 
            this.btnSaveFromDBToDisk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveFromDBToDisk.Location = new System.Drawing.Point(38, 374);
            this.btnSaveFromDBToDisk.Name = "btnSaveFromDBToDisk";
            this.btnSaveFromDBToDisk.Size = new System.Drawing.Size(220, 31);
            this.btnSaveFromDBToDisk.TabIndex = 7;
            this.btnSaveFromDBToDisk.Text = "Save selected file from DB to Disk";
            this.btnSaveFromDBToDisk.UseVisualStyleBackColor = true;
            this.btnSaveFromDBToDisk.Click += new System.EventHandler(this.btnSaveFromDBToDisk_Click);
            // 
            // cmdDeleteFile
            // 
            this.cmdDeleteFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDeleteFile.Location = new System.Drawing.Point(323, 375);
            this.cmdDeleteFile.Name = "cmdDeleteFile";
            this.cmdDeleteFile.Size = new System.Drawing.Size(264, 29);
            this.cmdDeleteFile.TabIndex = 8;
            this.cmdDeleteFile.Text = "Delete selected file";
            this.cmdDeleteFile.UseVisualStyleBackColor = true;
            this.cmdDeleteFile.Click += new System.EventHandler(this.cmdDeleteFile_Click);
            // 
            // frmFilesStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 475);
            this.Controls.Add(this.cmdDeleteFile);
            this.Controls.Add(this.btnSaveFromDBToDisk);
            this.Controls.Add(this.cmdConnect);
            this.Controls.Add(this.cmdStoreNewFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtConnectionString);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmFilesStore";
            this.Text = "Store Files in SQL Server Database";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtConnectionString;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdStoreNewFile;
        private System.Windows.Forms.Button cmdConnect;
        private System.Windows.Forms.Button btnSaveFromDBToDisk;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button cmdDeleteFile;
    }
}

