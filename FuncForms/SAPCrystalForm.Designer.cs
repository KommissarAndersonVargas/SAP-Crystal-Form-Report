namespace SAPCrystalReports.FuncForms
{
    partial class SAPCrystalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SAPCrystalForm));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofbirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imp_InfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataStaff = new SAPCrystalReports.DataSet.DataStaff();
            this.imp_InfoTableAdapter = new SAPCrystalReports.DataSet.DataStaffTableAdapters.Imp_InfoTableAdapter();
            this.tableAdapterManager = new SAPCrystalReports.DataSet.DataStaffTableAdapters.TableAdapterManager();
            this.SAPCrystalFromgroupBox = new System.Windows.Forms.GroupBox();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.FirstRep1 = new SAPCrystalReports.FuncForms.FirstRep();
            this.groupBoxDataGrid = new System.Windows.Forms.GroupBox();
            this.RightChatPanel = new System.Windows.Forms.Panel();
            this.webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.MainTab = new System.Windows.Forms.TabPage();
            this.FullScrenTab = new System.Windows.Forms.TabPage();
            this.crystalReportViewerFullScr = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.MaximizeFormButton = new System.Windows.Forms.Button();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.LoadData = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.LoadFast = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.AddNewData = new System.Windows.Forms.ToolStripButton();
            this.CloseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imp_InfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataStaff)).BeginInit();
            this.SAPCrystalFromgroupBox.SuspendLayout();
            this.groupBoxDataGrid.SuspendLayout();
            this.RightChatPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView)).BeginInit();
            this.tabControl.SuspendLayout();
            this.MainTab.SuspendLayout();
            this.FullScrenTab.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.dateofbirthDataGridViewTextBoxColumn,
            this.incomeDataGridViewTextBoxColumn,
            this.cellNumberDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.imp_InfoBindingSource;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(3, 16);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(629, 141);
            this.dataGridView.TabIndex = 3;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "First_Name";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First_Name";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "Last_Name";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last_Name";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // dateofbirthDataGridViewTextBoxColumn
            // 
            this.dateofbirthDataGridViewTextBoxColumn.DataPropertyName = "Date_of_birth";
            this.dateofbirthDataGridViewTextBoxColumn.HeaderText = "Date_of_birth";
            this.dateofbirthDataGridViewTextBoxColumn.Name = "dateofbirthDataGridViewTextBoxColumn";
            // 
            // incomeDataGridViewTextBoxColumn
            // 
            this.incomeDataGridViewTextBoxColumn.DataPropertyName = "income";
            this.incomeDataGridViewTextBoxColumn.HeaderText = "income";
            this.incomeDataGridViewTextBoxColumn.Name = "incomeDataGridViewTextBoxColumn";
            // 
            // cellNumberDataGridViewTextBoxColumn
            // 
            this.cellNumberDataGridViewTextBoxColumn.DataPropertyName = "Cell_Number";
            this.cellNumberDataGridViewTextBoxColumn.HeaderText = "Cell_Number";
            this.cellNumberDataGridViewTextBoxColumn.Name = "cellNumberDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // imp_InfoBindingSource
            // 
            this.imp_InfoBindingSource.DataMember = "Imp_Info";
            this.imp_InfoBindingSource.DataSource = this.dataStaff;
            // 
            // dataStaff
            // 
            this.dataStaff.DataSetName = "DataStaff";
            this.dataStaff.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // imp_InfoTableAdapter
            // 
            this.imp_InfoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Imp_InfoTableAdapter = this.imp_InfoTableAdapter;
            this.tableAdapterManager.UpdateOrder = SAPCrystalReports.DataSet.DataStaffTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // SAPCrystalFromgroupBox
            // 
            this.SAPCrystalFromgroupBox.Controls.Add(this.crystalReportViewer1);
            this.SAPCrystalFromgroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SAPCrystalFromgroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SAPCrystalFromgroupBox.Location = new System.Drawing.Point(3, 163);
            this.SAPCrystalFromgroupBox.Name = "SAPCrystalFromgroupBox";
            this.SAPCrystalFromgroupBox.Size = new System.Drawing.Size(635, 273);
            this.SAPCrystalFromgroupBox.TabIndex = 6;
            this.SAPCrystalFromgroupBox.TabStop = false;
            this.SAPCrystalFromgroupBox.Text = "SAP Crystal Report ";
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(3, 16);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.FirstRep1;
            this.crystalReportViewer1.ShowCloseButton = false;
            this.crystalReportViewer1.Size = new System.Drawing.Size(629, 254);
            this.crystalReportViewer1.TabIndex = 1;
            // 
            // groupBoxDataGrid
            // 
            this.groupBoxDataGrid.Controls.Add(this.dataGridView);
            this.groupBoxDataGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxDataGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDataGrid.Location = new System.Drawing.Point(3, 3);
            this.groupBoxDataGrid.Name = "groupBoxDataGrid";
            this.groupBoxDataGrid.Size = new System.Drawing.Size(635, 160);
            this.groupBoxDataGrid.TabIndex = 7;
            this.groupBoxDataGrid.TabStop = false;
            this.groupBoxDataGrid.Text = "DataBase Information";
            // 
            // RightChatPanel
            // 
            this.RightChatPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.RightChatPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RightChatPanel.Controls.Add(this.webView);
            this.RightChatPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightChatPanel.Location = new System.Drawing.Point(649, 73);
            this.RightChatPanel.Name = "RightChatPanel";
            this.RightChatPanel.Size = new System.Drawing.Size(253, 465);
            this.RightChatPanel.TabIndex = 9;
            // 
            // webView
            // 
            this.webView.AllowExternalDrop = true;
            this.webView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.webView.CreationProperties = null;
            this.webView.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView.Dock = System.Windows.Forms.DockStyle.Right;
            this.webView.Location = new System.Drawing.Point(0, 0);
            this.webView.Name = "webView";
            this.webView.Size = new System.Drawing.Size(249, 461);
            this.webView.TabIndex = 0;
            this.webView.ZoomFactor = 1D;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.MainTab);
            this.tabControl.Controls.Add(this.FullScrenTab);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(0, 73);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(649, 465);
            this.tabControl.TabIndex = 10;
            // 
            // MainTab
            // 
            this.MainTab.Controls.Add(this.SAPCrystalFromgroupBox);
            this.MainTab.Controls.Add(this.groupBoxDataGrid);
            this.MainTab.Location = new System.Drawing.Point(4, 22);
            this.MainTab.Name = "MainTab";
            this.MainTab.Padding = new System.Windows.Forms.Padding(3);
            this.MainTab.Size = new System.Drawing.Size(641, 439);
            this.MainTab.TabIndex = 0;
            this.MainTab.Text = "Work Space";
            this.MainTab.UseVisualStyleBackColor = true;
            // 
            // FullScrenTab
            // 
            this.FullScrenTab.Controls.Add(this.crystalReportViewerFullScr);
            this.FullScrenTab.Location = new System.Drawing.Point(4, 22);
            this.FullScrenTab.Name = "FullScrenTab";
            this.FullScrenTab.Padding = new System.Windows.Forms.Padding(3);
            this.FullScrenTab.Size = new System.Drawing.Size(641, 439);
            this.FullScrenTab.TabIndex = 1;
            this.FullScrenTab.Text = "Full Screen Report";
            this.FullScrenTab.UseVisualStyleBackColor = true;
            // 
            // crystalReportViewerFullScr
            // 
            this.crystalReportViewerFullScr.ActiveViewIndex = 0;
            this.crystalReportViewerFullScr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerFullScr.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerFullScr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerFullScr.Location = new System.Drawing.Point(3, 3);
            this.crystalReportViewerFullScr.Name = "crystalReportViewerFullScr";
            this.crystalReportViewerFullScr.ReportSource = this.FirstRep1;
            this.crystalReportViewerFullScr.Size = new System.Drawing.Size(635, 433);
            this.crystalReportViewerFullScr.TabIndex = 0;
            // 
            // MaximizeFormButton
            // 
            this.MaximizeFormButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaximizeFormButton.BackColor = System.Drawing.Color.Gainsboro;
            this.MaximizeFormButton.FlatAppearance.BorderSize = 0;
            this.MaximizeFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaximizeFormButton.Image = global::SAPCrystalReports.Properties.Resources._9042777_multi_mac_os_window_icon;
            this.MaximizeFormButton.Location = new System.Drawing.Point(794, 6);
            this.MaximizeFormButton.Name = "MaximizeFormButton";
            this.MaximizeFormButton.Size = new System.Drawing.Size(55, 53);
            this.MaximizeFormButton.TabIndex = 1;
            this.MaximizeFormButton.UseVisualStyleBackColor = false;
            this.MaximizeFormButton.Click += new System.EventHandler(this.MaximizeFormButton_Click);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeButton.BackColor = System.Drawing.Color.Gainsboro;
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Image = global::SAPCrystalReports.Properties.Resources._1303882_delete_minimize_minus_remove_sign_icon;
            this.MinimizeButton.Location = new System.Drawing.Point(734, 18);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(54, 35);
            this.MinimizeButton.TabIndex = 2;
            this.MinimizeButton.UseVisualStyleBackColor = false;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.Gainsboro;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoadData,
            this.toolStripSeparator1,
            this.LoadFast,
            this.toolStripSeparator2,
            this.AddNewData});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(902, 73);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStripMenu";
            // 
            // LoadData
            // 
            this.LoadData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LoadData.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadData.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LoadData.Image = global::SAPCrystalReports.Properties.Resources._8684054_folder_file_document_download_load_icon;
            this.LoadData.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.LoadData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LoadData.Name = "LoadData";
            this.LoadData.Size = new System.Drawing.Size(75, 70);
            this.LoadData.Text = "Load Data";
            this.LoadData.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LoadData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.LoadData.ToolTipText = "Load Data";
            this.LoadData.Click += new System.EventHandler(this.LoadData_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 73);
            // 
            // LoadFast
            // 
            this.LoadFast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LoadFast.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadFast.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LoadFast.Image = global::SAPCrystalReports.Properties.Resources._9990964_update_data_load_system_upload_icon;
            this.LoadFast.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.LoadFast.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LoadFast.Name = "LoadFast";
            this.LoadFast.Size = new System.Drawing.Size(104, 70);
            this.LoadFast.Text = "Load Fast Data";
            this.LoadFast.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LoadFast.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.LoadFast.ToolTipText = "Load Fast Data";
            this.LoadFast.Click += new System.EventHandler(this.LoadFast_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 73);
            // 
            // AddNewData
            // 
            this.AddNewData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddNewData.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewData.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddNewData.Image = global::SAPCrystalReports.Properties.Resources._9004713_add_file_document_paper_icon;
            this.AddNewData.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AddNewData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddNewData.Name = "AddNewData";
            this.AddNewData.Size = new System.Drawing.Size(70, 70);
            this.AddNewData.Text = "Add Data";
            this.AddNewData.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AddNewData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.AddNewData.ToolTipText = "Add Data";
            this.AddNewData.Click += new System.EventHandler(this.AddNewData_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.BackColor = System.Drawing.Color.Gainsboro;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Image = global::SAPCrystalReports.Properties.Resources._211651_close_round_icon;
            this.CloseButton.Location = new System.Drawing.Point(855, 12);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(45, 41);
            this.CloseButton.TabIndex = 12;
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click_1);
            // 
            // SAPCrystalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(902, 538);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.MaximizeFormButton);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.MinimizeButton);
            this.Controls.Add(this.RightChatPanel);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SAPCrystalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SAP Crystal Reports";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SAPCrystalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imp_InfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataStaff)).EndInit();
            this.SAPCrystalFromgroupBox.ResumeLayout(false);
            this.groupBoxDataGrid.ResumeLayout(false);
            this.RightChatPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webView)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.MainTab.ResumeLayout(false);
            this.FullScrenTab.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.DataGridView dataGridView;
        private DataSet.DataStaff dataStaff;
        private System.Windows.Forms.BindingSource imp_InfoBindingSource;
        private DataSet.DataStaffTableAdapters.Imp_InfoTableAdapter imp_InfoTableAdapter;
        private DataSet.DataStaffTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofbirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn incomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private FirstRep FirstRep1;
        private System.Windows.Forms.GroupBox SAPCrystalFromgroupBox;
        private System.Windows.Forms.GroupBox groupBoxDataGrid;
        private System.Windows.Forms.Panel RightChatPanel;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage MainTab;
        private System.Windows.Forms.TabPage FullScrenTab;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerFullScr;
        private System.Windows.Forms.Button MaximizeFormButton;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton AddNewData;
        private System.Windows.Forms.ToolStripButton LoadData;
        private System.Windows.Forms.ToolStripButton LoadFast;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}