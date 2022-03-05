
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
            this.NameTableBox = new System.Windows.Forms.ComboBox();
            this.DataGridApp = new System.Windows.Forms.DataGridView();
            this.CreateTableButton = new System.Windows.Forms.Button();
            this.UpdateTableButton = new System.Windows.Forms.Button();
            this.DeleteTableButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridApp)).BeginInit();
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
            // NameTableBox
            // 
            this.NameTableBox.FormattingEnabled = true;
            this.NameTableBox.Location = new System.Drawing.Point(51, 88);
            this.NameTableBox.Name = "NameTableBox";
            this.NameTableBox.Size = new System.Drawing.Size(159, 24);
            this.NameTableBox.TabIndex = 1;
            // 
            // DataGridApp
            // 
            this.DataGridApp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridApp.Location = new System.Drawing.Point(292, 159);
            this.DataGridApp.Name = "DataGridApp";
            this.DataGridApp.RowHeadersWidth = 51;
            this.DataGridApp.RowTemplate.Height = 24;
            this.DataGridApp.Size = new System.Drawing.Size(488, 275);
            this.DataGridApp.TabIndex = 2;
            // 
            // CreateTableButton
            // 
            this.CreateTableButton.Location = new System.Drawing.Point(292, 74);
            this.CreateTableButton.Name = "CreateTableButton";
            this.CreateTableButton.Size = new System.Drawing.Size(157, 51);
            this.CreateTableButton.TabIndex = 3;
            this.CreateTableButton.Text = "Создать таблицу";
            this.CreateTableButton.UseVisualStyleBackColor = true;
            this.CreateTableButton.Click += new System.EventHandler(this.CreateTableButton_Click);
            // 
            // UpdateTableButton
            // 
            this.UpdateTableButton.Location = new System.Drawing.Point(455, 74);
            this.UpdateTableButton.Name = "UpdateTableButton";
            this.UpdateTableButton.Size = new System.Drawing.Size(157, 51);
            this.UpdateTableButton.TabIndex = 4;
            this.UpdateTableButton.Text = "Обновить выбранную таблицу";
            this.UpdateTableButton.UseVisualStyleBackColor = true;
            // 
            // DeleteTableButton
            // 
            this.DeleteTableButton.Location = new System.Drawing.Point(618, 74);
            this.DeleteTableButton.Name = "DeleteTableButton";
            this.DeleteTableButton.Size = new System.Drawing.Size(157, 51);
            this.DeleteTableButton.TabIndex = 5;
            this.DeleteTableButton.Text = "Удалить выбранную таблицу";
            this.DeleteTableButton.UseVisualStyleBackColor = true;
            this.DeleteTableButton.Click += new System.EventHandler(this.DeleteTableButton_Click);
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeleteTableButton);
            this.Controls.Add(this.UpdateTableButton);
            this.Controls.Add(this.CreateTableButton);
            this.Controls.Add(this.DataGridApp);
            this.Controls.Add(this.NameTableBox);
            this.Controls.Add(this.label1);
            this.Name = "AppForm";
            this.Text = "AppForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AppForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridApp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox NameTableBox;
        private System.Windows.Forms.DataGridView DataGridApp;
        private System.Windows.Forms.Button CreateTableButton;
        private System.Windows.Forms.Button UpdateTableButton;
        private System.Windows.Forms.Button DeleteTableButton;
    }
}