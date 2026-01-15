namespace miniCRMProje.UI
{
    partial class FrmRequest
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlActions = new System.Windows.Forms.Panel();
            this.cmbMemnuniyet = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textRequestNote = new System.Windows.Forms.TextBox();
            this.lblRequestNote = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cnbRequestType = new System.Windows.Forms.ComboBox();
            this.cmbService = new System.Windows.Forms.ComboBox();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblService = new System.Windows.Forms.Label();
            this.lblRequestType = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblAssignedStaff = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.pnlTop.SuspendLayout();
            this.pnlActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1434, 100);
            this.pnlTop.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(553, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "TALEP YÖNETİMİ";
            // 
            // pnlActions
            // 
            this.pnlActions.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlActions.Controls.Add(this.cmbMemnuniyet);
            this.pnlActions.Controls.Add(this.label8);
            this.pnlActions.Controls.Add(this.textRequestNote);
            this.pnlActions.Controls.Add(this.lblRequestNote);
            this.pnlActions.Controls.Add(this.comboBox1);
            this.pnlActions.Controls.Add(this.cnbRequestType);
            this.pnlActions.Controls.Add(this.cmbService);
            this.pnlActions.Controls.Add(this.cmbCustomer);
            this.pnlActions.Controls.Add(this.btnUpdate);
            this.pnlActions.Controls.Add(this.btnClear);
            this.pnlActions.Controls.Add(this.btnDelete);
            this.pnlActions.Controls.Add(this.btnAdd);
            this.pnlActions.Controls.Add(this.cmbStatus);
            this.pnlActions.Controls.Add(this.lblService);
            this.pnlActions.Controls.Add(this.lblRequestType);
            this.pnlActions.Controls.Add(this.lblStatus);
            this.pnlActions.Controls.Add(this.lblAssignedStaff);
            this.pnlActions.Controls.Add(this.lblCustomer);
            this.pnlActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlActions.Location = new System.Drawing.Point(0, 100);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Size = new System.Drawing.Size(1434, 330);
            this.pnlActions.TabIndex = 4;
            // 
            // cmbMemnuniyet
            // 
            this.cmbMemnuniyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMemnuniyet.FormattingEnabled = true;
            this.cmbMemnuniyet.Location = new System.Drawing.Point(824, 181);
            this.cmbMemnuniyet.Name = "cmbMemnuniyet";
            this.cmbMemnuniyet.Size = new System.Drawing.Size(239, 24);
            this.cmbMemnuniyet.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label8.Location = new System.Drawing.Point(586, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(195, 24);
            this.label8.TabIndex = 25;
            this.label8.Text = "MEMNUNİYET PUANI";
            // 
            // textRequestNote
            // 
            this.textRequestNote.Location = new System.Drawing.Point(824, 122);
            this.textRequestNote.Name = "textRequestNote";
            this.textRequestNote.Size = new System.Drawing.Size(239, 22);
            this.textRequestNote.TabIndex = 24;
            // 
            // lblRequestNote
            // 
            this.lblRequestNote.AutoSize = true;
            this.lblRequestNote.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblRequestNote.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequestNote.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblRequestNote.Location = new System.Drawing.Point(586, 122);
            this.lblRequestNote.Name = "lblRequestNote";
            this.lblRequestNote.Size = new System.Drawing.Size(104, 24);
            this.lblRequestNote.TabIndex = 23;
            this.lblRequestNote.Text = "AÇIKLAMA";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(294, 255);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(239, 24);
            this.comboBox1.TabIndex = 22;
            // 
            // cnbRequestType
            // 
            this.cnbRequestType.FormattingEnabled = true;
            this.cnbRequestType.Location = new System.Drawing.Point(294, 150);
            this.cnbRequestType.Name = "cnbRequestType";
            this.cnbRequestType.Size = new System.Drawing.Size(239, 24);
            this.cnbRequestType.TabIndex = 21;
            // 
            // cmbService
            // 
            this.cmbService.FormattingEnabled = true;
            this.cmbService.Location = new System.Drawing.Point(294, 90);
            this.cmbService.Name = "cmbService";
            this.cmbService.Size = new System.Drawing.Size(239, 24);
            this.cmbService.TabIndex = 20;
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(294, 30);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(239, 24);
            this.cmbCustomer.TabIndex = 19;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnUpdate.Location = new System.Drawing.Point(1103, 90);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(220, 49);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "GÜNCELLE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnClear.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnClear.Location = new System.Drawing.Point(1103, 241);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(220, 49);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "TEMİZLE";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnDelete.Location = new System.Drawing.Point(1103, 169);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(220, 49);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "SİL";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnAdd.Location = new System.Drawing.Point(1103, 18);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(220, 49);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "EKLE";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(294, 207);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(239, 24);
            this.cmbStatus.TabIndex = 14;
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblService.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblService.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblService.Location = new System.Drawing.Point(64, 90);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(144, 24);
            this.lblService.TabIndex = 9;
            this.lblService.Text = "HİZMET/PAKET";
            // 
            // lblRequestType
            // 
            this.lblRequestType.AutoSize = true;
            this.lblRequestType.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblRequestType.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequestType.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblRequestType.Location = new System.Drawing.Point(64, 150);
            this.lblRequestType.Name = "lblRequestType";
            this.lblRequestType.Size = new System.Drawing.Size(118, 24);
            this.lblRequestType.TabIndex = 8;
            this.lblRequestType.Text = "TALEP TÜRÜ";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblStatus.Location = new System.Drawing.Point(64, 207);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(78, 24);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "DURUM";
            // 
            // lblAssignedStaff
            // 
            this.lblAssignedStaff.AutoSize = true;
            this.lblAssignedStaff.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblAssignedStaff.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssignedStaff.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblAssignedStaff.Location = new System.Drawing.Point(64, 266);
            this.lblAssignedStaff.Name = "lblAssignedStaff";
            this.lblAssignedStaff.Size = new System.Drawing.Size(183, 24);
            this.lblAssignedStaff.TabIndex = 6;
            this.lblAssignedStaff.Text = "ATANAN PERSONEL";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblCustomer.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblCustomer.Location = new System.Drawing.Point(64, 30);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(89, 24);
            this.lblCustomer.TabIndex = 5;
            this.lblCustomer.Text = "MÜŞTERİ";
            // 
            // dgvList
            // 
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.Location = new System.Drawing.Point(0, 430);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowHeadersWidth = 51;
            this.dgvList.RowTemplate.Height = 24;
            this.dgvList.Size = new System.Drawing.Size(1434, 190);
            this.dgvList.TabIndex = 5;
            // 
            // FrmRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1434, 620);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.pnlActions);
            this.Controls.Add(this.pnlTop);
            this.Name = "FrmRequest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Talep Yönetimi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlActions.ResumeLayout(false);
            this.pnlActions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlActions;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.Label lblRequestType;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblAssignedStaff;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Label lblRequestNote;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox cnbRequestType;
        private System.Windows.Forms.ComboBox cmbService;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.ComboBox cmbMemnuniyet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textRequestNote;
    }
}