namespace GoldRT
{
    partial class frmQueryCust
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQueryCust));
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.imageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.grdDanhSach = new DevExpress.XtraGrid.GridControl();
            this.grvDanhSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CustID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GoldCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TrnDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CustName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TrnCodeDesc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GoldCcyDesc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Qty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TotalAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.dtpDenNgay = new DevExpress.XtraEditors.DateEdit();
            this.dtpTuNgay = new DevExpress.XtraEditors.DateEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDenNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTuNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnPrint);
            this.layoutControl1.Controls.Add(this.grdDanhSach);
            this.layoutControl1.Controls.Add(this.btnClose);
            this.layoutControl1.Controls.Add(this.btnSearch);
            this.layoutControl1.Controls.Add(this.dtpDenNgay);
            this.layoutControl1.Controls.Add(this.dtpTuNgay);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(742, 548);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnPrint
            // 
            this.btnPrint.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Appearance.Options.UseFont = true;
            this.btnPrint.ImageIndex = 16;
            this.btnPrint.ImageList = this.imageCollection;
            this.btnPrint.Location = new System.Drawing.Point(547, 518);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(108, 27);
            this.btnPrint.StyleController = this.layoutControl1;
            this.btnPrint.TabIndex = 50;
            this.btnPrint.Text = "Xuất Excel";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // imageCollection
            // 
            this.imageCollection.ImageSize = new System.Drawing.Size(18, 18);
            this.imageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection.ImageStream")));
            // 
            // grdDanhSach
            // 
            this.grdDanhSach.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.grdDanhSach.EmbeddedNavigator.Name = "";
            this.grdDanhSach.Location = new System.Drawing.Point(7, 62);
            this.grdDanhSach.MainView = this.grvDanhSach;
            this.grdDanhSach.Name = "grdDanhSach";
            this.grdDanhSach.Size = new System.Drawing.Size(729, 448);
            this.grdDanhSach.TabIndex = 8;
            this.grdDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvDanhSach});
            // 
            // grvDanhSach
            // 
            this.grvDanhSach.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grvDanhSach.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.grvDanhSach.Appearance.ColumnFilterButtonActive.Font = new System.Drawing.Font("Arial", 12F);
            this.grvDanhSach.Appearance.ColumnFilterButtonActive.Options.UseFont = true;
            this.grvDanhSach.Appearance.DetailTip.Font = new System.Drawing.Font("Arial", 12F);
            this.grvDanhSach.Appearance.DetailTip.Options.UseFont = true;
            this.grvDanhSach.Appearance.Empty.Font = new System.Drawing.Font("Arial", 12F);
            this.grvDanhSach.Appearance.Empty.Options.UseFont = true;
            this.grvDanhSach.Appearance.EvenRow.Font = new System.Drawing.Font("Arial", 12F);
            this.grvDanhSach.Appearance.EvenRow.Options.UseFont = true;
            this.grvDanhSach.Appearance.FilterCloseButton.Font = new System.Drawing.Font("Arial", 12F);
            this.grvDanhSach.Appearance.FilterCloseButton.Options.UseFont = true;
            this.grvDanhSach.Appearance.FilterPanel.Font = new System.Drawing.Font("Arial", 12F);
            this.grvDanhSach.Appearance.FilterPanel.Options.UseFont = true;
            this.grvDanhSach.Appearance.FixedLine.Font = new System.Drawing.Font("Arial", 12F);
            this.grvDanhSach.Appearance.FixedLine.Options.UseFont = true;
            this.grvDanhSach.Appearance.FocusedCell.Font = new System.Drawing.Font("Arial", 12F);
            this.grvDanhSach.Appearance.FocusedCell.Options.UseFont = true;
            this.grvDanhSach.Appearance.FocusedRow.Font = new System.Drawing.Font("Arial", 12F);
            this.grvDanhSach.Appearance.FocusedRow.Options.UseFont = true;
            this.grvDanhSach.Appearance.FooterPanel.Font = new System.Drawing.Font("Arial", 12F);
            this.grvDanhSach.Appearance.FooterPanel.Options.UseFont = true;
            this.grvDanhSach.Appearance.GroupButton.Font = new System.Drawing.Font("Arial", 12F);
            this.grvDanhSach.Appearance.GroupButton.Options.UseFont = true;
            this.grvDanhSach.Appearance.GroupFooter.Font = new System.Drawing.Font("Arial", 12F);
            this.grvDanhSach.Appearance.GroupFooter.Options.UseFont = true;
            this.grvDanhSach.Appearance.GroupPanel.Font = new System.Drawing.Font("Arial", 12F);
            this.grvDanhSach.Appearance.GroupPanel.Options.UseFont = true;
            this.grvDanhSach.Appearance.GroupRow.Font = new System.Drawing.Font("Arial", 12F);
            this.grvDanhSach.Appearance.GroupRow.Options.UseFont = true;
            this.grvDanhSach.Appearance.HeaderPanel.Font = new System.Drawing.Font("Arial", 12F);
            this.grvDanhSach.Appearance.HeaderPanel.Options.UseFont = true;
            this.grvDanhSach.Appearance.HideSelectionRow.Font = new System.Drawing.Font("Arial", 12F);
            this.grvDanhSach.Appearance.HideSelectionRow.Options.UseFont = true;
            this.grvDanhSach.Appearance.HorzLine.Font = new System.Drawing.Font("Arial", 12F);
            this.grvDanhSach.Appearance.HorzLine.Options.UseFont = true;
            this.grvDanhSach.Appearance.OddRow.Font = new System.Drawing.Font("Arial", 12F);
            this.grvDanhSach.Appearance.OddRow.Options.UseFont = true;
            this.grvDanhSach.Appearance.Preview.Font = new System.Drawing.Font("Arial", 12F);
            this.grvDanhSach.Appearance.Preview.Options.UseFont = true;
            this.grvDanhSach.Appearance.Row.Font = new System.Drawing.Font("Arial", 12F);
            this.grvDanhSach.Appearance.Row.Options.UseFont = true;
            this.grvDanhSach.Appearance.RowSeparator.Font = new System.Drawing.Font("Arial", 12F);
            this.grvDanhSach.Appearance.RowSeparator.Options.UseFont = true;
            this.grvDanhSach.Appearance.SelectedRow.Font = new System.Drawing.Font("Arial", 12F);
            this.grvDanhSach.Appearance.SelectedRow.Options.UseFont = true;
            this.grvDanhSach.Appearance.TopNewRow.Font = new System.Drawing.Font("Arial", 12F);
            this.grvDanhSach.Appearance.TopNewRow.Options.UseFont = true;
            this.grvDanhSach.Appearance.VertLine.Font = new System.Drawing.Font("Arial", 12F);
            this.grvDanhSach.Appearance.VertLine.Options.UseFont = true;
            this.grvDanhSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.CustID,
            this.GoldCode,
            this.TrnDate,
            this.CustName,
            this.TrnCodeDesc,
            this.GoldCcyDesc,
            this.Qty,
            this.TotalAmount});
            this.grvDanhSach.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            styleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            styleFormatCondition1.Appearance.Options.UseBackColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition1.Value1 = "C";
            this.grvDanhSach.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.grvDanhSach.GridControl = this.grdDanhSach;
            this.grvDanhSach.Name = "grvDanhSach";
            this.grvDanhSach.OptionsBehavior.Editable = false;
            this.grvDanhSach.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.grvDanhSach.OptionsView.ShowFooter = true;
            this.grvDanhSach.OptionsView.ShowGroupPanel = false;
            this.grvDanhSach.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.TrnDate, DevExpress.Data.ColumnSortOrder.Descending)});
            // 
            // CustID
            // 
            this.CustID.Caption = "CustID";
            this.CustID.FieldName = "CustID";
            this.CustID.Name = "CustID";
            // 
            // GoldCode
            // 
            this.GoldCode.Caption = "GoldCode";
            this.GoldCode.FieldName = "GoldCode";
            this.GoldCode.Name = "GoldCode";
            this.GoldCode.Width = 87;
            // 
            // TrnDate
            // 
            this.TrnDate.Caption = "Ngày";
            this.TrnDate.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.TrnDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.TrnDate.FieldName = "TrnDate";
            this.TrnDate.Name = "TrnDate";
            this.TrnDate.Visible = true;
            this.TrnDate.VisibleIndex = 0;
            this.TrnDate.Width = 83;
            // 
            // CustName
            // 
            this.CustName.Caption = "Khách hàng";
            this.CustName.FieldName = "CustName";
            this.CustName.Name = "CustName";
            this.CustName.SummaryItem.DisplayFormat = "Số dòng = {0}";
            this.CustName.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count;
            this.CustName.Visible = true;
            this.CustName.VisibleIndex = 1;
            this.CustName.Width = 120;
            // 
            // TrnCodeDesc
            // 
            this.TrnCodeDesc.Caption = "Giao dịch";
            this.TrnCodeDesc.FieldName = "TrnCodeDesc";
            this.TrnCodeDesc.Name = "TrnCodeDesc";
            this.TrnCodeDesc.Visible = true;
            this.TrnCodeDesc.VisibleIndex = 2;
            // 
            // GoldCcyDesc
            // 
            this.GoldCcyDesc.Caption = "Mặt hàng";
            this.GoldCcyDesc.FieldName = "GoldCcyDesc";
            this.GoldCcyDesc.Name = "GoldCcyDesc";
            this.GoldCcyDesc.Visible = true;
            this.GoldCcyDesc.VisibleIndex = 3;
            this.GoldCcyDesc.Width = 125;
            // 
            // Qty
            // 
            this.Qty.Caption = "Số lượng";
            this.Qty.DisplayFormat.FormatString = "{0:#,##0}";
            this.Qty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Qty.FieldName = "Qty";
            this.Qty.Name = "Qty";
            this.Qty.SummaryItem.DisplayFormat = "{0:#,##0}";
            this.Qty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.Qty.Visible = true;
            this.Qty.VisibleIndex = 4;
            // 
            // TotalAmount
            // 
            this.TotalAmount.Caption = "Thành tiền";
            this.TotalAmount.DisplayFormat.FormatString = "{0:#,##0}";
            this.TotalAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TotalAmount.FieldName = "TotalAmount";
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.SummaryItem.DisplayFormat = "{0:#,##0}";
            this.TotalAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.TotalAmount.Visible = true;
            this.TotalAmount.VisibleIndex = 5;
            // 
            // btnClose
            // 
            this.btnClose.Appearance.Font = new System.Drawing.Font("Arial", 12F);
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.ImageIndex = 5;
            this.btnClose.ImageList = this.imageCollection;
            this.btnClose.Location = new System.Drawing.Point(660, 518);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(79, 27);
            this.btnClose.StyleController = this.layoutControl1;
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Thoát";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Appearance.Font = new System.Drawing.Font("Arial", 12F);
            this.btnSearch.Appearance.Options.UseFont = true;
            this.btnSearch.ImageIndex = 15;
            this.btnSearch.ImageList = this.imageCollection;
            this.btnSearch.Location = new System.Drawing.Point(460, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(97, 27);
            this.btnSearch.StyleController = this.layoutControl1;
            this.btnSearch.TabIndex = 23;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.EditValue = null;
            this.dtpDenNgay.Location = new System.Drawing.Point(315, 4);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Properties.Appearance.Font = new System.Drawing.Font("Arial", 12F);
            this.dtpDenNgay.Properties.Appearance.Options.UseFont = true;
            this.dtpDenNgay.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Arial", 12F);
            this.dtpDenNgay.Properties.AppearanceDisabled.Options.UseFont = true;
            this.dtpDenNgay.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Arial", 12F);
            this.dtpDenNgay.Properties.AppearanceDropDown.Options.UseFont = true;
            this.dtpDenNgay.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("Arial", 12F);
            this.dtpDenNgay.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.dtpDenNgay.Properties.AppearanceDropDownHeaderHighlight.Font = new System.Drawing.Font("Arial", 12F);
            this.dtpDenNgay.Properties.AppearanceDropDownHeaderHighlight.Options.UseFont = true;
            this.dtpDenNgay.Properties.AppearanceDropDownHighlight.Font = new System.Drawing.Font("Arial", 12F);
            this.dtpDenNgay.Properties.AppearanceDropDownHighlight.Options.UseFont = true;
            this.dtpDenNgay.Properties.AppearanceFocused.Font = new System.Drawing.Font("Arial", 12F);
            this.dtpDenNgay.Properties.AppearanceFocused.Options.UseFont = true;
            this.dtpDenNgay.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Arial", 12F);
            this.dtpDenNgay.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.dtpDenNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpDenNgay.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dtpDenNgay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpDenNgay.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dtpDenNgay.Size = new System.Drawing.Size(118, 25);
            this.dtpDenNgay.StyleController = this.layoutControl1;
            this.dtpDenNgay.TabIndex = 22;
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.EditValue = null;
            this.dtpTuNgay.Location = new System.Drawing.Point(75, 4);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Properties.Appearance.Font = new System.Drawing.Font("Arial", 12F);
            this.dtpTuNgay.Properties.Appearance.Options.UseFont = true;
            this.dtpTuNgay.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Arial", 12F);
            this.dtpTuNgay.Properties.AppearanceDisabled.Options.UseFont = true;
            this.dtpTuNgay.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Arial", 12F);
            this.dtpTuNgay.Properties.AppearanceDropDown.Options.UseFont = true;
            this.dtpTuNgay.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("Arial", 12F);
            this.dtpTuNgay.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.dtpTuNgay.Properties.AppearanceDropDownHeaderHighlight.Font = new System.Drawing.Font("Arial", 12F);
            this.dtpTuNgay.Properties.AppearanceDropDownHeaderHighlight.Options.UseFont = true;
            this.dtpTuNgay.Properties.AppearanceDropDownHighlight.Font = new System.Drawing.Font("Arial", 12F);
            this.dtpTuNgay.Properties.AppearanceDropDownHighlight.Options.UseFont = true;
            this.dtpTuNgay.Properties.AppearanceFocused.Font = new System.Drawing.Font("Arial", 12F);
            this.dtpTuNgay.Properties.AppearanceFocused.Options.UseFont = true;
            this.dtpTuNgay.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Arial", 12F);
            this.dtpTuNgay.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.dtpTuNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpTuNgay.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dtpTuNgay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpTuNgay.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dtpTuNgay.Size = new System.Drawing.Size(114, 25);
            this.dtpTuNgay.StyleController = this.layoutControl1;
            this.dtpTuNgay.TabIndex = 21;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.emptySpaceItem2,
            this.layoutControlItem3,
            this.emptySpaceItem3,
            this.layoutControlGroup2,
            this.layoutControlItem5,
            this.emptySpaceItem1,
            this.emptySpaceItem4,
            this.layoutControlItem6});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(742, 548);
            this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AllowHotTrack = false;
            this.layoutControlItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem1.Control = this.dtpTuNgay;
            this.layoutControlItem1.CustomizationFormText = "Từ ngày";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(190, 32);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(190, 32);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlItem1.Size = new System.Drawing.Size(190, 32);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlItem1.Text = "Từ ngày";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(66, 20);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AllowHotTrack = false;
            this.layoutControlItem2.AppearanceItemCaption.Font = new System.Drawing.Font("Arial", 12F);
            this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem2.Control = this.dtpDenNgay;
            this.layoutControlItem2.CustomizationFormText = "Đến ngày";
            this.layoutControlItem2.Location = new System.Drawing.Point(240, 0);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(194, 32);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(194, 32);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlItem2.Size = new System.Drawing.Size(194, 32);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlItem2.Text = "Đến ngày";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(66, 20);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
            this.emptySpaceItem2.Location = new System.Drawing.Point(190, 0);
            this.emptySpaceItem2.MinSize = new System.Drawing.Size(50, 24);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.emptySpaceItem2.Size = new System.Drawing.Size(50, 32);
            this.emptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem2.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.emptySpaceItem2.Text = "emptySpaceItem2";
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AllowHotTrack = false;
            this.layoutControlItem3.Control = this.btnSearch;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(456, 0);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(102, 32);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(102, 32);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlItem3.Size = new System.Drawing.Size(102, 32);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlItem3.Text = "layoutControlItem3";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextToControlDistance = 0;
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.CustomizationFormText = "emptySpaceItem3";
            this.emptySpaceItem3.Location = new System.Drawing.Point(558, 0);
            this.emptySpaceItem3.MinSize = new System.Drawing.Size(104, 24);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.emptySpaceItem3.Size = new System.Drawing.Size(182, 32);
            this.emptySpaceItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem3.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.emptySpaceItem3.Text = "emptySpaceItem3";
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AppearanceGroup.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlGroup2.AppearanceGroup.Options.UseFont = true;
            this.layoutControlGroup2.CustomizationFormText = "Danh sách khách hàng";
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 32);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup2.Size = new System.Drawing.Size(740, 482);
            this.layoutControlGroup2.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlGroup2.Text = "Danh sách khách hàng";
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AllowHotTrack = false;
            this.layoutControlItem4.Control = this.grdDanhSach;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlItem4.Size = new System.Drawing.Size(734, 453);
            this.layoutControlItem4.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlItem4.Text = "layoutControlItem4";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextToControlDistance = 0;
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.AllowHotTrack = false;
            this.layoutControlItem5.Control = this.btnClose;
            this.layoutControlItem5.CustomizationFormText = "layoutControlItem5";
            this.layoutControlItem5.Location = new System.Drawing.Point(656, 514);
            this.layoutControlItem5.MaxSize = new System.Drawing.Size(84, 32);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(84, 32);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlItem5.Size = new System.Drawing.Size(84, 32);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlItem5.Text = "layoutControlItem5";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextToControlDistance = 0;
            this.layoutControlItem5.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 514);
            this.emptySpaceItem1.MinSize = new System.Drawing.Size(104, 24);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.emptySpaceItem1.Size = new System.Drawing.Size(543, 32);
            this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.CustomizationFormText = "emptySpaceItem4";
            this.emptySpaceItem4.Location = new System.Drawing.Point(434, 0);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.emptySpaceItem4.Size = new System.Drawing.Size(22, 32);
            this.emptySpaceItem4.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.emptySpaceItem4.Text = "emptySpaceItem4";
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.AllowHotTrack = false;
            this.layoutControlItem6.Control = this.btnPrint;
            this.layoutControlItem6.CustomizationFormText = "layoutControlItem6";
            this.layoutControlItem6.Location = new System.Drawing.Point(543, 514);
            this.layoutControlItem6.MaxSize = new System.Drawing.Size(113, 32);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(113, 32);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlItem6.Size = new System.Drawing.Size(113, 32);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlItem6.Text = "layoutControlItem6";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextToControlDistance = 0;
            this.layoutControlItem6.TextVisible = false;
            // 
            // frmQueryCust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 548);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmQueryCust";
            this.Text = "Tra cứu doanh số giao dịch của KH";
            this.Load += new System.EventHandler(this.frmQueryCust_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDenNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTuNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.DateEdit dtpTuNgay;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.DateEdit dtpDenNgay;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraGrid.GridControl grdDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView grvDanhSach;
        private DevExpress.XtraGrid.Columns.GridColumn CustID;
        private DevExpress.XtraGrid.Columns.GridColumn GoldCode;
        private DevExpress.XtraGrid.Columns.GridColumn TrnDate;
        private DevExpress.XtraGrid.Columns.GridColumn CustName;
        private DevExpress.XtraGrid.Columns.GridColumn TrnCodeDesc;
        private DevExpress.XtraGrid.Columns.GridColumn GoldCcyDesc;
        private DevExpress.XtraGrid.Columns.GridColumn Qty;
        private DevExpress.XtraGrid.Columns.GridColumn TotalAmount;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.Utils.ImageCollection imageCollection;
    }
}