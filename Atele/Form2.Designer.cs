namespace Atele
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерТелефонаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.типУслугиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеУслугиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.снятыеМеркиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.материалИзделияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.колличествоМатериалаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.расходНаМатериалDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаВыдачиГотовогоЗаказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.итоговаяСтоимостьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.клиентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ateleDataSet = new Atele.ateleDataSet();
            this.клиентыTableAdapter = new Atele.ateleDataSetTableAdapters.КлиентыTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ateleDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.фИОDataGridViewTextBoxColumn,
            this.номерТелефонаDataGridViewTextBoxColumn,
            this.типУслугиDataGridViewTextBoxColumn,
            this.названиеУслугиDataGridViewTextBoxColumn,
            this.снятыеМеркиDataGridViewTextBoxColumn,
            this.материалИзделияDataGridViewTextBoxColumn,
            this.колличествоМатериалаDataGridViewTextBoxColumn,
            this.расходНаМатериалDataGridViewTextBoxColumn,
            this.датаВыдачиГотовогоЗаказаDataGridViewTextBoxColumn,
            this.итоговаяСтоимостьDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.клиентыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1145, 490);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // фИОDataGridViewTextBoxColumn
            // 
            this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
            // 
            // номерТелефонаDataGridViewTextBoxColumn
            // 
            this.номерТелефонаDataGridViewTextBoxColumn.DataPropertyName = "Номер телефона";
            this.номерТелефонаDataGridViewTextBoxColumn.HeaderText = "Номер телефона";
            this.номерТелефонаDataGridViewTextBoxColumn.Name = "номерТелефонаDataGridViewTextBoxColumn";
            // 
            // типУслугиDataGridViewTextBoxColumn
            // 
            this.типУслугиDataGridViewTextBoxColumn.DataPropertyName = "Тип услуги";
            this.типУслугиDataGridViewTextBoxColumn.HeaderText = "Тип услуги";
            this.типУслугиDataGridViewTextBoxColumn.Name = "типУслугиDataGridViewTextBoxColumn";
            // 
            // названиеУслугиDataGridViewTextBoxColumn
            // 
            this.названиеУслугиDataGridViewTextBoxColumn.DataPropertyName = "Название услуги";
            this.названиеУслугиDataGridViewTextBoxColumn.HeaderText = "Название услуги";
            this.названиеУслугиDataGridViewTextBoxColumn.Name = "названиеУслугиDataGridViewTextBoxColumn";
            // 
            // снятыеМеркиDataGridViewTextBoxColumn
            // 
            this.снятыеМеркиDataGridViewTextBoxColumn.DataPropertyName = "Снятые мерки";
            this.снятыеМеркиDataGridViewTextBoxColumn.HeaderText = "Снятые мерки";
            this.снятыеМеркиDataGridViewTextBoxColumn.Name = "снятыеМеркиDataGridViewTextBoxColumn";
            // 
            // материалИзделияDataGridViewTextBoxColumn
            // 
            this.материалИзделияDataGridViewTextBoxColumn.DataPropertyName = "Материал изделия";
            this.материалИзделияDataGridViewTextBoxColumn.HeaderText = "Материал изделия";
            this.материалИзделияDataGridViewTextBoxColumn.Name = "материалИзделияDataGridViewTextBoxColumn";
            // 
            // колличествоМатериалаDataGridViewTextBoxColumn
            // 
            this.колличествоМатериалаDataGridViewTextBoxColumn.DataPropertyName = "Колличество материала";
            this.колличествоМатериалаDataGridViewTextBoxColumn.HeaderText = "Колличество материала";
            this.колличествоМатериалаDataGridViewTextBoxColumn.Name = "колличествоМатериалаDataGridViewTextBoxColumn";
            // 
            // расходНаМатериалDataGridViewTextBoxColumn
            // 
            this.расходНаМатериалDataGridViewTextBoxColumn.DataPropertyName = "Расход на материал";
            this.расходНаМатериалDataGridViewTextBoxColumn.HeaderText = "Расход на материал";
            this.расходНаМатериалDataGridViewTextBoxColumn.Name = "расходНаМатериалDataGridViewTextBoxColumn";
            // 
            // датаВыдачиГотовогоЗаказаDataGridViewTextBoxColumn
            // 
            this.датаВыдачиГотовогоЗаказаDataGridViewTextBoxColumn.DataPropertyName = "Дата выдачи готового заказа";
            this.датаВыдачиГотовогоЗаказаDataGridViewTextBoxColumn.HeaderText = "Дата выдачи готового заказа";
            this.датаВыдачиГотовогоЗаказаDataGridViewTextBoxColumn.Name = "датаВыдачиГотовогоЗаказаDataGridViewTextBoxColumn";
            // 
            // итоговаяСтоимостьDataGridViewTextBoxColumn
            // 
            this.итоговаяСтоимостьDataGridViewTextBoxColumn.DataPropertyName = "Итоговая стоимость";
            this.итоговаяСтоимостьDataGridViewTextBoxColumn.HeaderText = "Итоговая стоимость";
            this.итоговаяСтоимостьDataGridViewTextBoxColumn.Name = "итоговаяСтоимостьDataGridViewTextBoxColumn";
            // 
            // клиентыBindingSource
            // 
            this.клиентыBindingSource.DataMember = "Клиенты";
            this.клиентыBindingSource.DataSource = this.ateleDataSet;
            // 
            // ateleDataSet
            // 
            this.ateleDataSet.DataSetName = "ateleDataSet";
            this.ateleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // клиентыTableAdapter
            // 
            this.клиентыTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(28, 508);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(967, 508);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 40);
            this.button2.TabIndex = 2;
            this.button2.Text = "В меню";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(222, 508);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 40);
            this.button3.TabIndex = 3;
            this.button3.Text = "Сохранить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 571);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Клиенты";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ateleDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        public ateleDataSet ateleDataSet;
        public System.Windows.Forms.BindingSource клиентыBindingSource;
        public ateleDataSetTableAdapters.КлиентыTableAdapter клиентыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерТелефонаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn типУслугиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеУслугиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn снятыеМеркиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn материалИзделияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn колличествоМатериалаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn расходНаМатериалDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаВыдачиГотовогоЗаказаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn итоговаяСтоимостьDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}