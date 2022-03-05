
namespace DataBase
{
    partial class AppForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.nameTableBox = new System.Windows.Forms.ComboBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.createTableButton = new System.Windows.Forms.Button();
            this.updateTableButton = new System.Windows.Forms.Button();
            this.deleteTableButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Список таблиц";
            // 
            // nameTableBox
            // 
            this.nameTableBox.FormattingEnabled = true;
            this.nameTableBox.Location = new System.Drawing.Point(51, 88);
            this.nameTableBox.Name = "nameTableBox";
            this.nameTableBox.Size = new System.Drawing.Size(159, 24);
            this.nameTableBox.TabIndex = 1;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(292, 159);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(488, 275);
            this.dataGridView.TabIndex = 2;
            // 
            // createTableButton
            // 
            this.createTableButton.Location = new System.Drawing.Point(292, 74);
            this.createTableButton.Name = "createTableButton";
            this.createTableButton.Size = new System.Drawing.Size(157, 51);
            this.createTableButton.TabIndex = 3;
            this.createTableButton.Text = "Создать таблицу";
            this.createTableButton.UseVisualStyleBackColor = true;
            // 
            // updateTableButton
            // 
            this.updateTableButton.Location = new System.Drawing.Point(455, 74);
            this.updateTableButton.Name = "updateTableButton";
            this.updateTableButton.Size = new System.Drawing.Size(157, 51);
            this.updateTableButton.TabIndex = 4;
            this.updateTableButton.Text = "Обновить выбранную таблицу";
            this.updateTableButton.UseVisualStyleBackColor = true;
            // 
            // deleteTableButton
            // 
            this.deleteTableButton.Location = new System.Drawing.Point(623, 74);
            this.deleteTableButton.Name = "deleteTableButton";
            this.deleteTableButton.Size = new System.Drawing.Size(157, 51);
            this.deleteTableButton.TabIndex = 5;
            this.deleteTableButton.Text = "Удалить выбранную таблицу";
            this.deleteTableButton.UseVisualStyleBackColor = true;
            this.deleteTableButton.Click += new System.EventHandler(this.deleteTableButton_Click);
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteTableButton);
            this.Controls.Add(this.updateTableButton);
            this.Controls.Add(this.createTableButton);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.nameTableBox);
            this.Controls.Add(this.label1);
            this.Name = "AppForm";
            this.Text = "AppForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AppForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox nameTableBox;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button createTableButton;
        private System.Windows.Forms.Button updateTableButton;
        private System.Windows.Forms.Button deleteTableButton;
    }
}