using System;
using System.Data;
using System.Windows.Forms;

namespace GoldRT
{
    public partial class frmRTBuySell_Lst : DevExpress.XtraEditors.XtraForm
    {
        frmRTBuySell frm;

        public frmRTBuySell_Lst()
        {
            InitializeComponent();
        }

        public frmRTBuySell_Lst(frmRTBuySell _frm)
        {
            InitializeComponent();
            this.frm = _frm;
        }

        private void fn_LoadDefault()
        {
            dtpDenNgay.DateTime = DateTime.Now;
            //dtpTuNgay.DateTime = DateTime.Now.AddDays(-15);
            dtpTuNgay.DateTime = DateTime.Now;            
        }

        private void fn_LoadDataToCombo()
        {
            //DataSet ds = new DataSet();

            //ds = clsCommon.LoadComboSP("I_GOLD", "G");
            //Functions.BindDropDownList(cboLoaiVang, ds, "GoldDesc", "GoldCode", "", true);
            //ds.Clear();

            //ds.Dispose();

            //cboTinhTrang.Properties.Items.Add(new ItemList("", ""));
            //cboTinhTrang.Properties.Items.Add(new ItemList("P", "P"));
            //cboTinhTrang.Properties.Items.Add(new ItemList("W", "W"));
            //cboTinhTrang.Properties.Items.Add(new ItemList("C", "C"));
        }

        private void fn_LoadDataToGrid()
        {
            DataSet ds = new DataSet();

            try
            {
                ds = clsCommon.ExecuteDatasetSP("TRN_RT_BUYSELL_Lst", "", txtBillCode.Text.Trim(), dtpTuNgay.DateTime.ToString("dd/MM/yyyy"), dtpDenNgay.DateTime.ToString("dd/MM/yyyy"),
                "", txtTenKhachHang.Text.Trim(), "", "", clsSystem.UserID);

                gridControl.DataSource = ds.Tables[0];
                
            }
            catch { }
            finally { ds.Dispose(); }

        }

        private void frmRTBuySell_Lst_Load(object sender, EventArgs e)
        {
            fn_LoadDataToCombo();
            fn_LoadDefault();
            fn_LoadDataToGrid();
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            if (grdDanhSach.FocusedRowHandle > -1)
            {
                string strID = grdDanhSach.GetFocusedRowCellValue("TrnID").ToString();

                frm.fn_LoadDataToForm(strID);
                this.Close();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            fn_LoadDataToGrid();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grdDanhSach_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Clicks == 2)
            {
                if (e.Button == MouseButtons.Left)
                {
                    btnXemChiTiet_Click(null, null);
                }
            }
        }

        private void grdDanhSach_DoubleClick(object sender, EventArgs e)
        {
            btnXemChiTiet_Click(sender, e);
        }
    }
}