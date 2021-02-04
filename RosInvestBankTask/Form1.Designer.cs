namespace RosInvestBankTask
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Import = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.socialNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testTaskDataSet = new RosInvestBankTask.TestTaskDataSet();
            this.clientsTableAdapter = new RosInvestBankTask.TestTaskDataSetTableAdapters.ClientsTableAdapter();
            this.INN = new System.Windows.Forms.TextBox();
            this.FindINN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Label();
            this.ResultTexBox = new System.Windows.Forms.TextBox();
            this.FindAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testTaskDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Import
            // 
            this.Import.Location = new System.Drawing.Point(12, 253);
            this.Import.Name = "Import";
            this.Import.Size = new System.Drawing.Size(232, 32);
            this.Import.TabIndex = 0;
            this.Import.Text = "Импортировать данные в эксель файл";
            this.Import.UseVisualStyleBackColor = true;
            this.Import.Click += new System.EventHandler(this.Import_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.birthDateDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.socialNumberDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clientsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(651, 160);
            this.dataGridView1.TabIndex = 1;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // birthDateDataGridViewTextBoxColumn
            // 
            this.birthDateDataGridViewTextBoxColumn.DataPropertyName = "BirthDate";
            this.birthDateDataGridViewTextBoxColumn.HeaderText = "BirthDate";
            this.birthDateDataGridViewTextBoxColumn.Name = "birthDateDataGridViewTextBoxColumn";
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // socialNumberDataGridViewTextBoxColumn
            // 
            this.socialNumberDataGridViewTextBoxColumn.DataPropertyName = "SocialNumber";
            this.socialNumberDataGridViewTextBoxColumn.HeaderText = "SocialNumber";
            this.socialNumberDataGridViewTextBoxColumn.Name = "socialNumberDataGridViewTextBoxColumn";
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.testTaskDataSet;
            // 
            // testTaskDataSet
            // 
            this.testTaskDataSet.DataSetName = "TestTaskDataSet";
            this.testTaskDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // INN
            // 
            this.INN.Location = new System.Drawing.Point(59, 198);
            this.INN.Name = "INN";
            this.INN.Size = new System.Drawing.Size(198, 20);
            this.INN.TabIndex = 2;
            // 
            // FindINN
            // 
            this.FindINN.Location = new System.Drawing.Point(282, 198);
            this.FindINN.Name = "FindINN";
            this.FindINN.Size = new System.Drawing.Size(117, 32);
            this.FindINN.TabIndex = 3;
            this.FindINN.Text = "Поиск ИНН";
            this.FindINN.UseVisualStyleBackColor = true;
            this.FindINN.Click += new System.EventHandler(this.FindINN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ИНН:";
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(19, 230);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(101, 13);
            this.Result.TabIndex = 5;
            this.Result.Text = "Результат поиска:";
            // 
            // ResultTexBox
            // 
            this.ResultTexBox.Location = new System.Drawing.Point(126, 227);
            this.ResultTexBox.Name = "ResultTexBox";
            this.ResultTexBox.Size = new System.Drawing.Size(131, 20);
            this.ResultTexBox.TabIndex = 6;
            // 
            // FindAll
            // 
            this.FindAll.Location = new System.Drawing.Point(418, 198);
            this.FindAll.Name = "FindAll";
            this.FindAll.Size = new System.Drawing.Size(178, 32);
            this.FindAll.TabIndex = 7;
            this.FindAll.Text = "Вывод всех клиентов";
            this.FindAll.UseVisualStyleBackColor = true;
            this.FindAll.Click += new System.EventHandler(this.FindAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(675, 293);
            this.Controls.Add(this.FindAll);
            this.Controls.Add(this.ResultTexBox);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FindINN);
            this.Controls.Add(this.INN);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Import);
            this.Name = "Form1";
            this.Text = "RosInBank";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testTaskDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Import;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TestTaskDataSet testTaskDataSet;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private TestTaskDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn socialNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox INN;
        private System.Windows.Forms.Button FindINN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.TextBox ResultTexBox;
        private System.Windows.Forms.Button FindAll;
    }
}

