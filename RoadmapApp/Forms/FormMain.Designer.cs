namespace RoadmapApp.Forms
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageInput = new System.Windows.Forms.TabPage();
            this.lblPurpose = new System.Windows.Forms.Label();
            this.cmbPurpose = new System.Windows.Forms.ComboBox();
            this.lblEntry = new System.Windows.Forms.Label();
            this.dtpEntryDate = new System.Windows.Forms.DateTimePicker();
            this.lblPatent = new System.Windows.Forms.Label();
            this.dtpPatentDate = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnGenerateRoadMap = new System.Windows.Forms.Button();
            this.tabPageRoadMap = new System.Windows.Forms.TabPage();
            this.txtRoadMap = new System.Windows.Forms.TextBox();
            this.tabControlMain.SuspendLayout();
            this.tabPageInput.SuspendLayout();
            this.tabPageRoadMap.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageInput);
            this.tabControlMain.Controls.Add(this.tabPageRoadMap);
            this.tabControlMain.Location = new System.Drawing.Point(12, 12);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(345, 325);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageInput
            // 
            this.tabPageInput.Controls.Add(this.lblPurpose);
            this.tabPageInput.Controls.Add(this.cmbPurpose);
            this.tabPageInput.Controls.Add(this.lblEntry);
            this.tabPageInput.Controls.Add(this.dtpEntryDate);
            this.tabPageInput.Controls.Add(this.lblPatent);
            this.tabPageInput.Controls.Add(this.dtpPatentDate);
            this.tabPageInput.Controls.Add(this.btnSave);
            this.tabPageInput.Controls.Add(this.btnGenerateRoadMap);
            this.tabPageInput.Location = new System.Drawing.Point(4, 29);
            this.tabPageInput.Name = "tabPageInput";
            this.tabPageInput.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInput.Size = new System.Drawing.Size(337, 292);
            this.tabPageInput.TabIndex = 0;
            this.tabPageInput.Text = "Ввод данных";
            this.tabPageInput.UseVisualStyleBackColor = true;
            // 
            // lblPurpose
            // 
            this.lblPurpose.AutoSize = true;
            this.lblPurpose.Location = new System.Drawing.Point(6, 30);
            this.lblPurpose.Name = "lblPurpose";
            this.lblPurpose.Size = new System.Drawing.Size(110, 20);
            this.lblPurpose.TabIndex = 0;
            this.lblPurpose.Text = "Цель въезда";
            // 
            // cmbPurpose
            // 
            this.cmbPurpose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPurpose.FormattingEnabled = true;
            this.cmbPurpose.Location = new System.Drawing.Point(122, 22);
            this.cmbPurpose.Name = "cmbPurpose";
            this.cmbPurpose.Size = new System.Drawing.Size(207, 28);
            this.cmbPurpose.TabIndex = 1;
            this.cmbPurpose.SelectedIndexChanged += new System.EventHandler(this.cmbPurpose_SelectedIndexChanged);
            // 
            // lblEntry
            // 
            this.lblEntry.AutoSize = true;
            this.lblEntry.Location = new System.Drawing.Point(6, 58);
            this.lblEntry.Name = "lblEntry";
            this.lblEntry.Size = new System.Drawing.Size(151, 20);
            this.lblEntry.TabIndex = 2;
            this.lblEntry.Text = "Дата въезда в РФ";
            // 
            // dtpEntryDate
            // 
            this.dtpEntryDate.Location = new System.Drawing.Point(122, 53);
            this.dtpEntryDate.Name = "dtpEntryDate";
            this.dtpEntryDate.Size = new System.Drawing.Size(207, 26);
            this.dtpEntryDate.TabIndex = 3;
            this.dtpEntryDate.ValueChanged += new System.EventHandler(this.dtpEntryDate_ValueChanged);
            // 
            // lblPatent
            // 
            this.lblPatent.AutoSize = true;
            this.lblPatent.Location = new System.Drawing.Point(6, 96);
            this.lblPatent.Name = "lblPatent";
            this.lblPatent.Size = new System.Drawing.Size(115, 20);
            this.lblPatent.TabIndex = 4;
            this.lblPatent.Text = "Дата патента";
            // 
            // dtpPatentDate
            // 
            this.dtpPatentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPatentDate.Location = new System.Drawing.Point(122, 90);
            this.dtpPatentDate.Name = "dtpPatentDate";
            this.dtpPatentDate.ShowCheckBox = true;
            this.dtpPatentDate.Size = new System.Drawing.Size(207, 26);
            this.dtpPatentDate.TabIndex = 5;
            this.dtpPatentDate.ValueChanged += new System.EventHandler(this.dtpPatentDate_ValueChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(122, 122);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(207, 36);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Сохранить данные";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnGenerateRoadMap
            // 
            this.btnGenerateRoadMap.Location = new System.Drawing.Point(122, 164);
            this.btnGenerateRoadMap.Name = "btnGenerateRoadMap";
            this.btnGenerateRoadMap.Size = new System.Drawing.Size(207, 31);
            this.btnGenerateRoadMap.TabIndex = 7;
            this.btnGenerateRoadMap.Text = "Сформировать дорожную карту";
            this.btnGenerateRoadMap.UseVisualStyleBackColor = true;
            this.btnGenerateRoadMap.Click += new System.EventHandler(this.btnGenerateRoadMap_Click);
            // 
            // tabPageRoadMap
            // 
            this.tabPageRoadMap.Controls.Add(this.txtRoadMap);
            this.tabPageRoadMap.Location = new System.Drawing.Point(4, 29);
            this.tabPageRoadMap.Name = "tabPageRoadMap";
            this.tabPageRoadMap.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRoadMap.Size = new System.Drawing.Size(337, 292);
            this.tabPageRoadMap.TabIndex = 1;
            this.tabPageRoadMap.Text = "Дорожная карта";
            this.tabPageRoadMap.UseVisualStyleBackColor = true;
            // 
            // txtRoadMap
            // 
            this.txtRoadMap.Location = new System.Drawing.Point(6, 6);
            this.txtRoadMap.Multiline = true;
            this.txtRoadMap.Name = "txtRoadMap";
            this.txtRoadMap.ReadOnly = true;
            this.txtRoadMap.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRoadMap.Size = new System.Drawing.Size(325, 286);
            this.txtRoadMap.TabIndex = 0;
            // 
            // FormMain
            // 
            this.ClientSize = new System.Drawing.Size(359, 339);
            this.Controls.Add(this.tabControlMain);
            this.Name = "FormMain";
            this.Text = "Основная форма";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageInput.ResumeLayout(false);
            this.tabPageInput.PerformLayout();
            this.tabPageRoadMap.ResumeLayout(false);
            this.tabPageRoadMap.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageInput;
        private System.Windows.Forms.Label lblPurpose;
        private System.Windows.Forms.ComboBox cmbPurpose;
        private System.Windows.Forms.Label lblEntry;
        private System.Windows.Forms.DateTimePicker dtpEntryDate;
        private System.Windows.Forms.Label lblPatent;
        private System.Windows.Forms.DateTimePicker dtpPatentDate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnGenerateRoadMap;
        private System.Windows.Forms.TabPage tabPageRoadMap;
        private System.Windows.Forms.TextBox txtRoadMap;
    }
}
