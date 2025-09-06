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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.FirstRep1 = new SAPCrystalReports.FuncForms.FirstRep();
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
            this.LoadReport = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LoadByCode = new System.Windows.Forms.Button();
            this.SAPCrystalFromgroupBox = new System.Windows.Forms.GroupBox();
            this.groupBoxDataGrid = new System.Windows.Forms.GroupBox();
            this.panelTopMenu = new System.Windows.Forms.Panel();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.MaximizeFormButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imp_InfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataStaff)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SAPCrystalFromgroupBox.SuspendLayout();
            this.groupBoxDataGrid.SuspendLayout();
            this.panelTopMenu.SuspendLayout();
            this.SuspendLayout();
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
            this.crystalReportViewer1.Size = new System.Drawing.Size(728, 271);
            this.crystalReportViewer1.TabIndex = 1;
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
            this.dataGridView.Size = new System.Drawing.Size(725, 150);
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
            // LoadReport
            // 
            this.LoadReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.LoadReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.LoadReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.LoadReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadReport.ForeColor = System.Drawing.SystemColors.Control;
            this.LoadReport.Location = new System.Drawing.Point(3, 3);
            this.LoadReport.Name = "LoadReport";
            this.LoadReport.Size = new System.Drawing.Size(156, 64);
            this.LoadReport.TabIndex = 4;
            this.LoadReport.Text = "Load Report";
            this.LoadReport.UseVisualStyleBackColor = true;
            this.LoadReport.Click += new System.EventHandler(this.LoadReport_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelMenu.Controls.Add(this.tableLayoutPanel1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(162, 538);
            this.panelMenu.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.LoadByCode, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LoadReport, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(162, 538);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // LoadByCode
            // 
            this.LoadByCode.Dock = System.Windows.Forms.DockStyle.Top;
            this.LoadByCode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.LoadByCode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.LoadByCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadByCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadByCode.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LoadByCode.Location = new System.Drawing.Point(3, 272);
            this.LoadByCode.Name = "LoadByCode";
            this.LoadByCode.Size = new System.Drawing.Size(156, 64);
            this.LoadByCode.TabIndex = 5;
            this.LoadByCode.Text = "Load By DataBase";
            this.LoadByCode.UseVisualStyleBackColor = true;
            this.LoadByCode.Click += new System.EventHandler(this.LoadByCode_Click);
            // 
            // SAPCrystalFromgroupBox
            // 
            this.SAPCrystalFromgroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SAPCrystalFromgroupBox.Controls.Add(this.crystalReportViewer1);
            this.SAPCrystalFromgroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SAPCrystalFromgroupBox.Location = new System.Drawing.Point(168, 248);
            this.SAPCrystalFromgroupBox.Name = "SAPCrystalFromgroupBox";
            this.SAPCrystalFromgroupBox.Size = new System.Drawing.Size(734, 290);
            this.SAPCrystalFromgroupBox.TabIndex = 6;
            this.SAPCrystalFromgroupBox.TabStop = false;
            this.SAPCrystalFromgroupBox.Text = "SAP Crystal ";
            // 
            // groupBoxDataGrid
            // 
            this.groupBoxDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDataGrid.Controls.Add(this.dataGridView);
            this.groupBoxDataGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDataGrid.Location = new System.Drawing.Point(168, 73);
            this.groupBoxDataGrid.Name = "groupBoxDataGrid";
            this.groupBoxDataGrid.Size = new System.Drawing.Size(731, 169);
            this.groupBoxDataGrid.TabIndex = 7;
            this.groupBoxDataGrid.TabStop = false;
            this.groupBoxDataGrid.Text = "DataBase Information";
            // 
            // panelTopMenu
            // 
            this.panelTopMenu.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelTopMenu.Controls.Add(this.MinimizeButton);
            this.panelTopMenu.Controls.Add(this.MaximizeFormButton);
            this.panelTopMenu.Controls.Add(this.CloseButton);
            this.panelTopMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopMenu.Location = new System.Drawing.Point(162, 0);
            this.panelTopMenu.Name = "panelTopMenu";
            this.panelTopMenu.Size = new System.Drawing.Size(740, 67);
            this.panelTopMenu.TabIndex = 8;
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Image = global::SAPCrystalReports.Properties.Resources._1303882_delete_minimize_minus_remove_sign_icon;
            this.MinimizeButton.Location = new System.Drawing.Point(562, 15);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(54, 35);
            this.MinimizeButton.TabIndex = 2;
            this.MinimizeButton.UseVisualStyleBackColor = true;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // MaximizeFormButton
            // 
            this.MaximizeFormButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaximizeFormButton.FlatAppearance.BorderSize = 0;
            this.MaximizeFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaximizeFormButton.Image = global::SAPCrystalReports.Properties.Resources._9042777_multi_mac_os_window_icon;
            this.MaximizeFormButton.Location = new System.Drawing.Point(622, 3);
            this.MaximizeFormButton.Name = "MaximizeFormButton";
            this.MaximizeFormButton.Size = new System.Drawing.Size(55, 53);
            this.MaximizeFormButton.TabIndex = 1;
            this.MaximizeFormButton.UseVisualStyleBackColor = true;
            this.MaximizeFormButton.Click += new System.EventHandler(this.MaximizeFormButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Image = global::SAPCrystalReports.Properties.Resources._211651_close_round_icon;
            this.CloseButton.Location = new System.Drawing.Point(683, 12);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(45, 41);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // SAPCrystalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(902, 538);
            this.Controls.Add(this.panelTopMenu);
            this.Controls.Add(this.groupBoxDataGrid);
            this.Controls.Add(this.SAPCrystalFromgroupBox);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SAPCrystalForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SAP Crystal Reports";
            this.Load += new System.EventHandler(this.SAPCrystalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imp_InfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataStaff)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.SAPCrystalFromgroupBox.ResumeLayout(false);
            this.groupBoxDataGrid.ResumeLayout(false);
            this.panelTopMenu.ResumeLayout(false);
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
        private System.Windows.Forms.Button LoadReport;
        private FirstRep FirstRep1;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.GroupBox SAPCrystalFromgroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button LoadByCode;
        private System.Windows.Forms.GroupBox groupBoxDataGrid;
        private System.Windows.Forms.Panel panelTopMenu;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button MaximizeFormButton;
        private System.Windows.Forms.Button MinimizeButton;
    }
}