namespace encyclopedia_database
{
    partial class MainForm
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
            this.addButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chooseTable_comboBox = new System.Windows.Forms.ComboBox();
            this.modifyButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.searchB = new System.Windows.Forms.Button();
            this.tablesCB = new System.Windows.Forms.ComboBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.loggedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 521);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(121, 23);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add record";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(682, 320);
            this.dataGridView1.TabIndex = 1;
            // 
            // chooseTable_comboBox
            // 
            this.chooseTable_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chooseTable_comboBox.FormattingEnabled = true;
            this.chooseTable_comboBox.Location = new System.Drawing.Point(241, 454);
            this.chooseTable_comboBox.Name = "chooseTable_comboBox";
            this.chooseTable_comboBox.Size = new System.Drawing.Size(215, 24);
            this.chooseTable_comboBox.TabIndex = 2;
            this.chooseTable_comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // modifyButton
            // 
            this.modifyButton.Location = new System.Drawing.Point(283, 521);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(121, 23);
            this.modifyButton.TabIndex = 3;
            this.modifyButton.Text = "Search record";
            this.modifyButton.UseVisualStyleBackColor = true;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(573, 521);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(121, 23);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Delete record";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // searchTB
            // 
            this.searchTB.Location = new System.Drawing.Point(481, 12);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(100, 22);
            this.searchTB.TabIndex = 5;
            this.searchTB.Visible = false;
            // 
            // searchB
            // 
            this.searchB.Location = new System.Drawing.Point(597, 12);
            this.searchB.Name = "searchB";
            this.searchB.Size = new System.Drawing.Size(72, 22);
            this.searchB.TabIndex = 6;
            this.searchB.Text = "Search";
            this.searchB.UseVisualStyleBackColor = true;
            this.searchB.Visible = false;
            this.searchB.Click += new System.EventHandler(this.searchB_Click);
            // 
            // tablesCB
            // 
            this.tablesCB.FormattingEnabled = true;
            this.tablesCB.Location = new System.Drawing.Point(301, 10);
            this.tablesCB.Name = "tablesCB";
            this.tablesCB.Size = new System.Drawing.Size(121, 24);
            this.tablesCB.TabIndex = 7;
            this.tablesCB.Visible = false;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(450, 15);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(25, 17);
            this.idLabel.TabIndex = 8;
            this.idLabel.Text = "ID:";
            this.idLabel.Visible = false;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(316, 388);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // loggedLabel
            // 
            this.loggedLabel.AutoSize = true;
            this.loggedLabel.Location = new System.Drawing.Point(12, 15);
            this.loggedLabel.Name = "loggedLabel";
            this.loggedLabel.Size = new System.Drawing.Size(83, 17);
            this.loggedLabel.TabIndex = 10;
            this.loggedLabel.Text = "Logged as: ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 556);
            this.Controls.Add(this.loggedLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.tablesCB);
            this.Controls.Add(this.searchB);
            this.Controls.Add(this.searchTB);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.modifyButton);
            this.Controls.Add(this.chooseTable_comboBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.addButton);
            this.Name = "MainForm";
            this.Text = "The City Encyclopedia";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.ComboBox chooseTable_comboBox;
        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.Button searchB;
        private System.Windows.Forms.ComboBox tablesCB;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label loggedLabel;
    }
}

