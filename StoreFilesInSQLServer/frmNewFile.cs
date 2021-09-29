using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
namespace StoreFilesInSQLServer
{
    public partial class frmNewFile : Form
    {
        public frmNewFile()
        {
            InitializeComponent();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            try
            {
                //Read File Bytes into a byte array
                byte[] FileData = ReadFile(txtFilePath.Text);
                
                //Initialize SQL Server Connection
                SqlConnection CN = new SqlConnection(txtConnectionString.Text);

                //Set insert query
                string qry = "insert into FileStore (OriginalPath,FileData) values(@OriginalPath, @FileData)";

                //Initialize SqlCommand object for insert.
                SqlCommand SqlCom = new SqlCommand(qry, CN);

                //We are passing Original File Path and File byte data as sql parameters.
                SqlCom.Parameters.Add(new SqlParameter("@OriginalPath", (object)txtFilePath.Text));
                SqlCom.Parameters.Add(new SqlParameter("@FileData", (object)FileData));

                //Open connection and execute insert query.
                CN.Open();
                SqlCom.ExecuteNonQuery();
                CN.Close();

                //Close form and return to list or Files.
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cmdBrowse_Click(object sender, EventArgs e)
        {
            //Ask user to select file.
            OpenFileDialog dlg = new OpenFileDialog();
            DialogResult dlgRes = dlg.ShowDialog();
            if (dlgRes != DialogResult.Cancel)
            {
                //Provide file path in txtFilePath text box.
                txtFilePath.Text = dlg.FileName;
            }
        }

        //Open file in to a filestream and read data in a byte array.
        byte[] ReadFile(string sPath)
        {
            //Initialize byte array with a null value initially.
            byte[] data = null;

            //Use FileInfo object to get file size.
            FileInfo fInfo = new FileInfo(sPath);
            long numBytes = fInfo.Length;

            //Open FileStream to read file
            FileStream fStream = new FileStream(sPath, FileMode.Open, FileAccess.Read);

            //Use BinaryReader to read file stream into byte array.
            BinaryReader br = new BinaryReader(fStream);

            //When you use BinaryReader, you need to supply number of bytes to read from file.
            //In this case we want to read entire file. So supplying total number of bytes.
            data = br.ReadBytes((int)numBytes);

            //Close BinaryReader
            br.Close();

            //Close FileStream
            fStream.Close();

            return data;
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            //Close this form if user clicks cancel.
            this.Close();
        }
    }
}