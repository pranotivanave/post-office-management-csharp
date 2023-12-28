namespace PostOfficeManagementSystem2
{
    partial class ViewMoneySavings
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.moneysavingsDataSet1 = new PostOfficeManagementSystem2.moneysavingsDataSet1();
            this.moneysavingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.moneysavingsTableAdapter = new PostOfficeManagementSystem2.moneysavingsDataSet1TableAdapters.moneysavingsTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doornoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interestrateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthlyamtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalinterestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalamtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moneysavingsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.moneysavingsDataSet2 = new PostOfficeManagementSystem2.moneysavingsDataSet2();
            this.moneysavingsTableAdapter1 = new PostOfficeManagementSystem2.moneysavingsDataSet2TableAdapters.moneysavingsTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.moneysavingsDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneysavingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneysavingsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneysavingsDataSet2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // moneysavingsDataSet1
            // 
            this.moneysavingsDataSet1.DataSetName = "moneysavingsDataSet1";
            this.moneysavingsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // moneysavingsBindingSource
            // 
            this.moneysavingsBindingSource.DataMember = "moneysavings";
            this.moneysavingsBindingSource.DataSource = this.moneysavingsDataSet1;
            // 
            // moneysavingsTableAdapter
            // 
            this.moneysavingsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.doornoDataGridViewTextBoxColumn,
            this.streetDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn,
            this.stateDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.accountnoDataGridViewTextBoxColumn,
            this.yearsDataGridViewTextBoxColumn,
            this.interestrateDataGridViewTextBoxColumn,
            this.startdateDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.monthlyamtDataGridViewTextBoxColumn,
            this.totalinterestDataGridViewTextBoxColumn,
            this.lastdateDataGridViewTextBoxColumn,
            this.totalamtDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.moneysavingsBindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 188);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1059, 250);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // doornoDataGridViewTextBoxColumn
            // 
            this.doornoDataGridViewTextBoxColumn.DataPropertyName = "door_no";
            this.doornoDataGridViewTextBoxColumn.HeaderText = "door_no";
            this.doornoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.doornoDataGridViewTextBoxColumn.Name = "doornoDataGridViewTextBoxColumn";
            this.doornoDataGridViewTextBoxColumn.ReadOnly = true;
            this.doornoDataGridViewTextBoxColumn.Width = 125;
            // 
            // streetDataGridViewTextBoxColumn
            // 
            this.streetDataGridViewTextBoxColumn.DataPropertyName = "street";
            this.streetDataGridViewTextBoxColumn.HeaderText = "street";
            this.streetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.streetDataGridViewTextBoxColumn.Name = "streetDataGridViewTextBoxColumn";
            this.streetDataGridViewTextBoxColumn.ReadOnly = true;
            this.streetDataGridViewTextBoxColumn.Width = 125;
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "country";
            this.countryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            this.countryDataGridViewTextBoxColumn.ReadOnly = true;
            this.countryDataGridViewTextBoxColumn.Width = 125;
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "state";
            this.stateDataGridViewTextBoxColumn.HeaderText = "state";
            this.stateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            this.stateDataGridViewTextBoxColumn.ReadOnly = true;
            this.stateDataGridViewTextBoxColumn.Width = 125;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "city";
            this.cityDataGridViewTextBoxColumn.HeaderText = "city";
            this.cityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.ReadOnly = true;
            this.cityDataGridViewTextBoxColumn.Width = 125;
            // 
            // accountnoDataGridViewTextBoxColumn
            // 
            this.accountnoDataGridViewTextBoxColumn.DataPropertyName = "account_no";
            this.accountnoDataGridViewTextBoxColumn.HeaderText = "account_no";
            this.accountnoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.accountnoDataGridViewTextBoxColumn.Name = "accountnoDataGridViewTextBoxColumn";
            this.accountnoDataGridViewTextBoxColumn.ReadOnly = true;
            this.accountnoDataGridViewTextBoxColumn.Width = 125;
            // 
            // yearsDataGridViewTextBoxColumn
            // 
            this.yearsDataGridViewTextBoxColumn.DataPropertyName = "years";
            this.yearsDataGridViewTextBoxColumn.HeaderText = "years";
            this.yearsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yearsDataGridViewTextBoxColumn.Name = "yearsDataGridViewTextBoxColumn";
            this.yearsDataGridViewTextBoxColumn.ReadOnly = true;
            this.yearsDataGridViewTextBoxColumn.Width = 125;
            // 
            // interestrateDataGridViewTextBoxColumn
            // 
            this.interestrateDataGridViewTextBoxColumn.DataPropertyName = "interest_rate";
            this.interestrateDataGridViewTextBoxColumn.HeaderText = "interest_rate";
            this.interestrateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.interestrateDataGridViewTextBoxColumn.Name = "interestrateDataGridViewTextBoxColumn";
            this.interestrateDataGridViewTextBoxColumn.ReadOnly = true;
            this.interestrateDataGridViewTextBoxColumn.Width = 125;
            // 
            // startdateDataGridViewTextBoxColumn
            // 
            this.startdateDataGridViewTextBoxColumn.DataPropertyName = "start_date";
            this.startdateDataGridViewTextBoxColumn.HeaderText = "start_date";
            this.startdateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.startdateDataGridViewTextBoxColumn.Name = "startdateDataGridViewTextBoxColumn";
            this.startdateDataGridViewTextBoxColumn.ReadOnly = true;
            this.startdateDataGridViewTextBoxColumn.Width = 125;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "amount";
            this.amountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            this.amountDataGridViewTextBoxColumn.Width = 125;
            // 
            // monthlyamtDataGridViewTextBoxColumn
            // 
            this.monthlyamtDataGridViewTextBoxColumn.DataPropertyName = "monthly_amt";
            this.monthlyamtDataGridViewTextBoxColumn.HeaderText = "monthly_amt";
            this.monthlyamtDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.monthlyamtDataGridViewTextBoxColumn.Name = "monthlyamtDataGridViewTextBoxColumn";
            this.monthlyamtDataGridViewTextBoxColumn.ReadOnly = true;
            this.monthlyamtDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalinterestDataGridViewTextBoxColumn
            // 
            this.totalinterestDataGridViewTextBoxColumn.DataPropertyName = "total_interest";
            this.totalinterestDataGridViewTextBoxColumn.HeaderText = "total_interest";
            this.totalinterestDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalinterestDataGridViewTextBoxColumn.Name = "totalinterestDataGridViewTextBoxColumn";
            this.totalinterestDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalinterestDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastdateDataGridViewTextBoxColumn
            // 
            this.lastdateDataGridViewTextBoxColumn.DataPropertyName = "last_date";
            this.lastdateDataGridViewTextBoxColumn.HeaderText = "last_date";
            this.lastdateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastdateDataGridViewTextBoxColumn.Name = "lastdateDataGridViewTextBoxColumn";
            this.lastdateDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastdateDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalamtDataGridViewTextBoxColumn
            // 
            this.totalamtDataGridViewTextBoxColumn.DataPropertyName = "total_amt";
            this.totalamtDataGridViewTextBoxColumn.HeaderText = "total_amt";
            this.totalamtDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalamtDataGridViewTextBoxColumn.Name = "totalamtDataGridViewTextBoxColumn";
            this.totalamtDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalamtDataGridViewTextBoxColumn.Width = 125;
            // 
            // moneysavingsBindingSource1
            // 
            this.moneysavingsBindingSource1.DataMember = "moneysavings";
            this.moneysavingsBindingSource1.DataSource = this.moneysavingsDataSet2;
            // 
            // moneysavingsDataSet2
            // 
            this.moneysavingsDataSet2.DataSetName = "moneysavingsDataSet2";
            this.moneysavingsDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // moneysavingsTableAdapter1
            // 
            this.moneysavingsTableAdapter1.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1072, 130);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(364, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "View Money Savings";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(503, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ViewMoneySavings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ViewMoneySavings";
            this.Text = "ViewMoneySavings";
            this.Load += new System.EventHandler(this.ViewMoneySavings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.moneysavingsDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneysavingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneysavingsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneysavingsDataSet2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private moneysavingsDataSet1 moneysavingsDataSet1;
        private System.Windows.Forms.BindingSource moneysavingsBindingSource;
        private moneysavingsDataSet1TableAdapters.moneysavingsTableAdapter moneysavingsTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private moneysavingsDataSet2 moneysavingsDataSet2;
        private System.Windows.Forms.BindingSource moneysavingsBindingSource1;
        private moneysavingsDataSet2TableAdapters.moneysavingsTableAdapter moneysavingsTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doornoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn interestrateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthlyamtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalinterestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalamtDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}