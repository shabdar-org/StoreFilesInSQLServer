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
    public partial class frmFilesStore : Form
    {
        DataSet DS;
        public frmFilesStore()
        {
            InitializeComponent();
        }

        //Get table rows from sql server to be displayed in Datagrid.
        void GetFilesFromDatabase()
        {
            try
            {
                //Initialize SQL Server connection.
                SqlConnection CN = new SqlConnection(txtConnectionString.Text);

                //Initialize SQL adapter.
                SqlDataAdapter ADAP = new SqlDataAdapter("Select FileId,OriginalPath,FileData from FileStore", CN);

                //Initialize Dataset.
                DS = new DataSet();

                //Fill dataset with FileStore table.
                ADAP.Fill(DS, "FileStore");

                //Fill Grid with dataset.
                dataGridView1.DataSource = DS.Tables["FileStore"];
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cmdConnect_Click(object sender, EventArgs e)
        {
            //Fill datagrid with table rows.
            GetFilesFromDatabase();
        }

        //Open form to get new File.
        private void cmdStoreNewFile_Click(object sender, EventArgs e)
        {
            frmNewFile fNew = new frmNewFile();
            //Supply connection string from this form to frmNewFile form.
            fNew.txtConnectionString.Text = txtConnectionString.Text;
            fNew.ShowDialog();

            //Refresh File
            cmdConnect_Click(null, null);
        }

        //When user changes row selection, display File of selected row in picture box.
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSaveFromDBToDisk_Click(object sender, EventArgs e)
        {
             try
             {
                 //Check if a file is selected in Grid
                 if (dataGridView1.CurrentCell ==null)
                 {
                     MessageBox.Show("Select a file in Grid first.");
                     return;
                 }

                 int SelectedRow = dataGridView1.CurrentCell.RowIndex;
                 string OriginalPath = DS.Tables[0].Rows[SelectedRow]["OriginalPath"].ToString();

                 saveFileDialog1.FileName = OriginalPath;

                 DialogResult DR = saveFileDialog1.ShowDialog();
                 if (DR == DialogResult.OK)
                 {
                     string FileName = saveFileDialog1.FileName;
                     //Get File data from dataset row.
                     byte[] FileData = (byte[])DS.Tables["FileStore"].Rows[SelectedRow]["FileData"];
                     //Write file data to selected file.
                     using (FileStream fs = new FileStream(FileName, FileMode.Create))
                     {
                         fs.Write(FileData, 0, FileData.Length);
                         fs.Close();
                     }

                     MessageBox.Show("File saved successfully to ");
                 }
             }
             catch(Exception ex)
             {
                 MessageBox.Show(ex.ToString());
             }
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //This event is to ignore an error related to grid.
        }

        private void cmdDeleteFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Select a row first in Grid");
                    return;
                }
                object selectedFileId = dataGridView1.SelectedRows[0].Cells[0].Value;
                if (MessageBox.Show("Are you sure to delete this record?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //Initialize SQL Server Connection
                    SqlConnection CN = new SqlConnection(txtConnectionString.Text);

                    //Set insert query
                    string qry = "delete from FileStore where FileId=@FileId";

                    //Initialize SqlCommand object for insert.
                    SqlCommand SqlCom = new SqlCommand(qry, CN);

                    //We are passing Original Image Path and Image byte data as sql parameters.
                    SqlCom.Parameters.Add(new SqlParameter("@FileId", selectedFileId));

                    //Open connection and execute insert query.
                    CN.Open();
                    SqlCom.ExecuteNonQuery();
                    CN.Close();

                    //Refresh Grid after deleting record
                    cmdConnect_Click(null, null);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}