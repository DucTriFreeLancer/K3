using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using Messages;

namespace GoldRT.Query.ucQueryRTTran
{
    [DefaultEvent("DataSetExport")]
    [ToolboxBitmap(typeof(GoldRT.Query.ucQueryRTTran.ImportDataToExcel), "ImportDataToExcel")]
    
    public partial class ImportDataToExcel : UserControl
    {        
        private string FileName;
        private DataTable CurrentTable;
        private string CurrentSheet;
        private string TitleText;

        //required delegates
        public delegate void FileLoadEventHandler(object sender, FileLoadEventArgs e);
        public delegate void SheetChangeEventHandler(object sender, SheetChangeEventArgs e);
        public delegate void DataSetExportEventHandler(object sender, DataSetExportEventArgs e);

        //required events
        public event FileLoadEventHandler FileLoad;
        public event SheetChangeEventHandler SheetChange;

        ///<summary>
        ///Subscribe to this event to recieve the dataset thats exported by the control
        ///</summary>	
        public event DataSetExportEventHandler DataSetExport;

        public ImportDataToExcel()
        {
            InitializeComponent();
            //initialise members
            this.Clear();
            TitleText = "";


            // Initialise the event handlers.
            FileLoad += new FileLoadEventHandler(this.FileLoadController);
            SheetChange += new SheetChangeEventHandler(this.SheetChangeController);
            //Load data to combo
            fn_LoadDataToCombo();
            cmdChonFile.Focus();
        }
       
        #region Load all sheet name
        private void FileLoadController(object sender, FileLoadEventArgs e)
        {
            this.Clear();
            this.FileName = e.FileName;
            cboSheet.DataSource = LoadSchemaFromFile(this.FileName);
        }
        #endregion

        #region Select change Sheet name to reload data

        private void SheetChangeController(object sender, SheetChangeEventArgs e)
        {
            //clear previous sheet sytate
            ClearControlValue();
            //set the current sheet
            this.CurrentSheet = e.SheetName;
            //set the current datatable (SheetName)
            this.CurrentTable = this.LoadSpecifiedSheet(this.FileName, this.CurrentSheet);
            //set the datagrid view
            this.grdControl.DataSource = this.CurrentTable;
            txtRows.Text = Convert.ToString(this.grdDanhsach.RowCount - 1);
            //set  the current state
        }

        #endregion

        #region Clear Controls value
        private void ClearControlValue()
        {
            //TODO: add code to clear control after sheet change
            grdControl.DataBindings.Clear();
            this.CurrentSheet = "";
            this.CurrentTable = null;
        }
        #endregion

        #region Define events
        /// <summary>
        /// Return File Name
        /// </summary>
        public class FileLoadEventArgs : System.EventArgs
        {
            public string FileName;
            public FileLoadEventArgs(string fileName)
            {
                FileName = fileName;
            }
        }      
       
        public class SheetChangeEventArgs : System.EventArgs
        {
            public string SheetName;
            public SheetChangeEventArgs(string sheetName)
            {
                SheetName = sheetName;
            }
        }
        ///<summary>
        ///This eventargs used by DataSetExport event. Conatins the Dataset  that has been created from the xls file.
        ///</summary>	
        public class DataSetExportEventArgs
        {
            public DataSet ExportedDataSet;
            public DataSetExportEventArgs(DataSet exportedDataSet)
            {
                ExportedDataSet = exportedDataSet;
            }
        }
        #endregion

        #region Private Method Reset
        private void Clear()
        {
            //reset the controls			
            grdControl.DataBindings.Clear();
            cboSheet.DataBindings.Clear();
            //reset the member vars
            FileName = "";
            CurrentTable = null;
            CurrentSheet = "";
        }
        #endregion

        #region

        private string[] LoadSchemaFromFile(string fileName)
        {
            string[] SheetNames = null;
            OleDbConnection conn = this.ReturnConnection(fileName);
            try
            {
                conn.Open();

                DataTable SchemaTable = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null });
                if (SchemaTable.Rows.Count > 0)
                {
                    SheetNames = new string[SchemaTable.Rows.Count];
                    int i = 0;
                    foreach (DataRow TmpRow in SchemaTable.Rows)
                    {
                        SheetNames[i] = TmpRow["TABLE_NAME"].ToString();
                        i++;
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, TitleText);
                Trace.WriteLine(Ex.StackTrace);
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                    conn.Dispose();
                }
            }
            return SheetNames;

        }

        #endregion

        #region Get Sheet Name
        private DataTable LoadSpecifiedSheet(string fileName, string sheetName)
        {
            OleDbConnection conn = this.ReturnConnection(fileName);
            DataTable SheetData = null;
            try
            {
                conn.Open();
                //retrieve datareader with data for that sheet			
                OleDbDataAdapter SheetAdapter = new OleDbDataAdapter("select * from [" + sheetName + "]", conn);
                SheetData = new DataTable();
                SheetAdapter.Fill(SheetData);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, TitleText);
                Trace.WriteLine(Ex.StackTrace);
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                    conn.Dispose();
                }
            }
            return SheetData;
        }
        #endregion

        #region
        private OleDbConnection ReturnConnection(string fileName)
        {
            //return new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;" +
            //    "Data Source=" + fileName + "; Jet OLEDB:Engine Type=5;" +
            //    "Extended Properties=\"Excel 8.0;HDR=NO\"");
            return new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" +
                "Data Source=" + fileName + "; Extended Properties=\"Excel 12.0 Xml;HDR=NO;IMEX=1\"");
        }
        #endregion

        #region
        private bool TestFile(string fileName)
        {
            try
            {
                OleDbConnection conn = this.ReturnConnection(fileName);
                //test the connection
                conn.Open();
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.Message);
                return false;
            }
        }
        #endregion

        private void cmdChonFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            //ofd.Filter = "Excel files (*.xls)|*.xls;";
            ofd.Filter = "Excel 97-2003 (*.xls)|*.xls|Excel 2007 (*.xlsx)|*.xlsx";            
            DialogResult tmpDiag = ofd.ShowDialog();
            if (tmpDiag != DialogResult.Cancel)
            {
                FileName = ofd.FileName;
                txtFileName.Text = FileName;
                if (TestFile(FileName))
                {
                    //raise the fileload event
                    FileLoad(null, new FileLoadEventArgs(FileName));
                }
                else
                {
                    MessageBox.Show("Invalid input file. To diagnose, please enable tracing!", TitleText);
                }
            }
        }

        private void cboSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSheet.SelectedItem.ToString() != "")
            {
                SheetChange(null, new SheetChangeEventArgs(cboSheet.SelectedItem.ToString()));
            }
        }

        private void fn_LoadDataToCombo()
        {
            DataSet ds = new DataSet();
            try
            {
                ds = clsCommon.LoadComboSP("T_SECTION", "");
                Functions.BindDropDownList(cboSection, ds, "SectionName", "SectionID", "", true);
                ds.Clear();

                ds = clsCommon.LoadComboSP("I_PRODUCT_GROUP", "");
                Functions.BindDropDownList(cboProductGroup, ds, "GroupName", "GroupID", "", true);
                ds.Clear();
            }
            catch
            {
            }
            finally
            {
                ds.Dispose();
            }
        }
       
        private void cmdImport_Click(object sender, EventArgs e)
        {
            if (grdDanhsach.Columns.Count <= 0)
            {
                ThongBao.Show("Thông báo", "Không tồn tại dữ liệu để Import. Vui lòng chọn dữ liệu trước khi import.", "OK", ICon.Error);
                cmdChonFile.Focus();
                return;
            }
            if (!Check_Validate())            
                return;
            
            if (ThongBao.Show("Thông báo", "Bạn có chắc chắn muốn import dữ liệu không?", "Có", "Không", ICon.QuestionMark) == DialogResult.Cancel)
            {
                return;
            }

            ImPortData();          
        }

        private bool Check_Validate()
        {           
            if (cboSection.SelectedIndex <= 0 )
            {
                ThongBao.Show("Thông báo", "Vui lòng chọn Quầy hàng", "OK", ICon.Error);
                cboSection.Focus();
                return false;
            }
            if (cboGoldCode.SelectedIndex <= 0 )
            {
                ThongBao.Show("Thông báo", "Vui lòng chọn loại vàng", "OK", ICon.Error);
                cboGoldCode.Focus();
                return false;
            }            
           
            return true;             
        }

        private void ImPortData()
        {
            DataSet ds = new DataSet();
            int j = 1;

            this.Cursor = Cursors.WaitCursor;
            string strProductDesc = "";
            string strSL = "";
            string strTotalWeis = "";
            string strRoundings = "";
            string strDiamondWei = "";
            string strTaskPrices = "", strRingSize = "", strTotalPrice = "";
           
            /*    
             * CAU TRUC FILE IMPORT:
               F1: Tenhang/ F2: TLT/ F3: TL hot/ F4: Ni/ F5: GiaCong/ F6: SoLuong/ F7: GiaVon
            */
            Runagain:
            strProductDesc = "";
            strSL = "";
            strTotalWeis = "";
            strDiamondWei = "";
            strTaskPrices = "";
            strRingSize = "";
            strTotalPrice = "";
            for (int i = j; i < grdDanhsach.RowCount; i++)
            {               
                if (strProductDesc.Length > 6000 || strTaskPrices.Length > 6000 || strTotalWeis.Length > 6000)
                {
                    break;
                }
                j++;
                DataRow dr = grdDanhsach.GetDataRow(i);
                strProductDesc += dr["F1"].ToString().Trim() + "@";
                strTotalWeis += (dr["F2"].ToString().Trim() == "" ? "0" : dr["F2"].ToString().Trim()) + "@";
                strDiamondWei += (dr["F3"].ToString().Trim() == "" ? "0" : dr["F3"].ToString().Trim()) + "@";
                strRingSize += (dr["F4"].ToString().Trim() == "" ? "0" : dr["F4"].ToString().Trim()) + "@";
                strTaskPrices += (dr["F5"].ToString().Trim() == "" ? "0" : dr["F5"].ToString().Trim()) + "@";
                strSL += (dr["F6"].ToString().Trim() == "" ? "0" : dr["F6"].ToString().Trim()) + "@";
                strTotalPrice += (dr["F7"].ToString().Trim() == "" ? "0" : dr["F7"].ToString().Trim()) + "@";
            }
            strProductDesc = strProductDesc.Substring(0, strProductDesc.Length - 1);
            strTaskPrices = strTaskPrices.Substring(0, strTaskPrices.Length - 1);
            strTotalWeis = strTotalWeis.Substring(0, strTotalWeis.Length - 1);
            strDiamondWei = strDiamondWei.Substring(0, strDiamondWei.Length - 1);
            strRingSize = strRingSize.Substring(0, strRingSize.Length - 1);
            strSL = strSL.Substring(0, strSL.Length - 1);
            strTotalPrice = strTotalPrice.Substring(0, strTotalPrice.Length - 1);
            try
            {
                ds = clsCommon.ExecuteDatasetSP("[TRN_PRODUCT_IN_import]",
                                                DateTime.Now.ToString("dd/MM/yyyy"),
                                                DateTime.Now.ToString("hh:mm:ss"),
                                                ((ItemList) cboSection.SelectedItem).ID,
                                                ((ItemList) cboGoldCode.SelectedItem).ID,
                                                strProductDesc,
                                                ((ItemList) cboProductGroup.SelectedItem).ID,
                                                strSL,
                                                strTotalWeis,
                                                strDiamondWei,
                                                strTaskPrices,                                                
                                                strRingSize,
                                                strTotalPrice,
                                                clsSystem.UserID, "", "W");
            }

            catch (Exception ex)
            {
                ds.Dispose();
                this.Cursor = Cursors.Default;
                ThongBao.Show("Lỗi", ex.Source + " - " + ex.Message, "OK", ICon.Error);
                return;
            }
            finally
            {
                ds.Dispose();
                this.Cursor = Cursors.Default;
            }
            if(j < grdDanhsach.RowCount)
                goto Runagain;

            this.Cursor = Cursors.Default;
            ThongBao.Show("Thông báo", "Dữ liệu đã Import thành công", "OK", ICon.Information);
        }       

        private void cboSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSection.SelectedIndex >0)
            {         
                DataSet ds = new DataSet();
                try
                {
                    ds = clsCommon.ExecuteDatasetSP("[T_SECTION_Get]", ((ItemList)cboSection.SelectedItem).ID);
                    ds = clsCommon.LoadComboSP("I_SECTION_GROUP", ((ItemList)cboSection.SelectedItem).ID);
                    Functions.BindDropDownList(cboGoldCode, ds, "GoldDesc", "GoldCode", "", true);
                    cboGoldCode.SelectedIndex = Functions.GetSelectedIndexCombo(ds.Tables[0].Rows[0]["GoldCode"].ToString(), cboGoldCode, 0);
                }
                catch { }
                finally
                {
                    ds.Clear();
                    ds = null;
                }
            }
        }
                
    }
}
