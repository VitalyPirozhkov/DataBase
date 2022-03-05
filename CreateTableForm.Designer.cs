
namespace DataBase
{
    partial class CreateTableForm
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
            this.CreateTableButton = new System.Windows.Forms.Button();
            this.ColumnDataGird = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TableNameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.PK = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ColumnDataGird)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateTableButton
            // 
            this.CreateTableButton.Location = new System.Drawing.Point(16, 396);
            this.CreateTableButton.Name = "CreateTableButton";
            this.CreateTableButton.Size = new System.Drawing.Size(614, 41);
            this.CreateTableButton.TabIndex = 0;
            this.CreateTableButton.Text = "Создать таблицу";
            this.CreateTableButton.UseVisualStyleBackColor = true;
            this.CreateTableButton.Click += new System.EventHandler(this.CreateTableButton_Click);
            // 
            // ColumnDataGird
            // 
            this.ColumnDataGird.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ColumnDataGird.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.DataType,
            this.PK});
            this.ColumnDataGird.Location = new System.Drawing.Point(15, 216);
            this.ColumnDataGird.Name = "ColumnDataGird";
            this.ColumnDataGird.RowHeadersWidth = 51;
            this.ColumnDataGird.RowTemplate.Height = 24;
            this.ColumnDataGird.Size = new System.Drawing.Size(613, 174);
            this.ColumnDataGird.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Создание таблицы";
            // 
            // TableNameBox
            // 
            this.TableNameBox.Location = new System.Drawing.Point(125, 74);
            this.TableNameBox.Name = "TableNameBox";
            this.TableNameBox.Size = new System.Drawing.Size(279, 22);
            this.TableNameBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Имя таблицы";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Добавление столбцов";
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Имя колонки";
            this.ColumnName.MinimumWidth = 6;
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.Width = 125;
            // 
            // DataType
            // 
            this.DataType.HeaderText = "Тип данных";
            this.DataType.Items.AddRange(new object[] {
            "Integer",
            "Decimal",
            "Text",
            "Date"});
            this.DataType.MinimumWidth = 6;
            this.DataType.Name = "DataType";
            this.DataType.Width = 125;
            // 
            // PK
            // 
            this.PK.HeaderText = "PK";
            this.PK.Items.AddRange(new object[] {
            "True",
            "False"});
            this.PK.MinimumWidth = 6;
            this.PK.Name = "PK";
            this.PK.Width = 125;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(377, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Примичание: Первичный ключ может быть только один";
            // 
            // CreateTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 531);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TableNameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ColumnDataGird);
            this.Controls.Add(this.CreateTableButton);
            this.Name = "CreateTableForm";
            this.Text = "CreateTableForm";
            ((System.ComponentModel.ISupportInitialize)(this.ColumnDataGird)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateTableButton;
        private System.Windows.Forms.DataGridView ColumnDataGird;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TableNameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewComboBoxColumn DataType;
        private System.Windows.Forms.DataGridViewComboBoxColumn PK;
        private System.Windows.Forms.Label label4;
    }
}