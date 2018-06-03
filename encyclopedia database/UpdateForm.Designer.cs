namespace encyclopedia_database
{
    partial class UpdateForm
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
            this.tablesComboBox = new System.Windows.Forms.ComboBox();
            this.searchDGV = new System.Windows.Forms.DataGridView();
            this.commitUpdButton = new System.Windows.Forms.Button();
            this.declineUpdButton = new System.Windows.Forms.Button();
            this.tablesTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.searchStrFDTB = new System.Windows.Forms.TextBox();
            this.searchStrONTB = new System.Windows.Forms.TextBox();
            this.searchStrNNTB = new System.Windows.Forms.TextBox();
            this.searchStrButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.searchStrIDTB = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.searchSqrButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.searchSqrFDTB = new System.Windows.Forms.TextBox();
            this.searchSqrONTB = new System.Windows.Forms.TextBox();
            this.searchSqrNNTB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.searchSqrIDTB = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.searchSightButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.searchSightStrIDTB = new System.Windows.Forms.TextBox();
            this.searchSightFDTB = new System.Windows.Forms.TextBox();
            this.searchSightNTB = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.searchSightIDTB = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.searchBcgrButton = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.searchBcgrSightIDTB = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.searchBcgrYearTB = new System.Windows.Forms.TextBox();
            this.searchBcgrContTB = new System.Windows.Forms.TextBox();
            this.searchBcgrSourceTB = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.searchBcgrIDTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.searchDGV)).BeginInit();
            this.tablesTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter info about record you would like to search:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tablesComboBox
            // 
            this.tablesComboBox.FormattingEnabled = true;
            this.tablesComboBox.Location = new System.Drawing.Point(430, 12);
            this.tablesComboBox.Name = "tablesComboBox";
            this.tablesComboBox.Size = new System.Drawing.Size(121, 24);
            this.tablesComboBox.TabIndex = 3;
            this.tablesComboBox.Visible = false;
            // 
            // searchDGV
            // 
            this.searchDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchDGV.Location = new System.Drawing.Point(26, 287);
            this.searchDGV.Name = "searchDGV";
            this.searchDGV.RowTemplate.Height = 24;
            this.searchDGV.Size = new System.Drawing.Size(481, 150);
            this.searchDGV.TabIndex = 4;
            this.searchDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // commitUpdButton
            // 
            this.commitUpdButton.Location = new System.Drawing.Point(101, 461);
            this.commitUpdButton.Name = "commitUpdButton";
            this.commitUpdButton.Size = new System.Drawing.Size(75, 23);
            this.commitUpdButton.TabIndex = 5;
            this.commitUpdButton.Text = "Commit";
            this.commitUpdButton.UseVisualStyleBackColor = true;
            this.commitUpdButton.Click += new System.EventHandler(this.commitUpdButton_Click);
            // 
            // declineUpdButton
            // 
            this.declineUpdButton.Location = new System.Drawing.Point(361, 461);
            this.declineUpdButton.Name = "declineUpdButton";
            this.declineUpdButton.Size = new System.Drawing.Size(75, 23);
            this.declineUpdButton.TabIndex = 6;
            this.declineUpdButton.Text = "Decline";
            this.declineUpdButton.UseVisualStyleBackColor = true;
            this.declineUpdButton.Click += new System.EventHandler(this.declineUpdButton_Click);
            // 
            // tablesTab
            // 
            this.tablesTab.Controls.Add(this.tabPage1);
            this.tablesTab.Controls.Add(this.tabPage2);
            this.tablesTab.Controls.Add(this.tabPage3);
            this.tablesTab.Controls.Add(this.tabPage4);
            this.tablesTab.Location = new System.Drawing.Point(12, 29);
            this.tablesTab.Name = "tablesTab";
            this.tablesTab.SelectedIndex = 0;
            this.tablesTab.Size = new System.Drawing.Size(507, 238);
            this.tablesTab.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.searchStrFDTB);
            this.tabPage1.Controls.Add(this.searchStrONTB);
            this.tabPage1.Controls.Add(this.searchStrNNTB);
            this.tabPage1.Controls.Add(this.searchStrButton);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.searchStrIDTB);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(499, 209);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Street";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(144, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "New name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Old name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Date:";
            // 
            // searchStrFDTB
            // 
            this.searchStrFDTB.Location = new System.Drawing.Point(225, 123);
            this.searchStrFDTB.Name = "searchStrFDTB";
            this.searchStrFDTB.Size = new System.Drawing.Size(100, 22);
            this.searchStrFDTB.TabIndex = 19;
            // 
            // searchStrONTB
            // 
            this.searchStrONTB.Location = new System.Drawing.Point(225, 95);
            this.searchStrONTB.Name = "searchStrONTB";
            this.searchStrONTB.Size = new System.Drawing.Size(100, 22);
            this.searchStrONTB.TabIndex = 18;
            // 
            // searchStrNNTB
            // 
            this.searchStrNNTB.Location = new System.Drawing.Point(225, 67);
            this.searchStrNNTB.Name = "searchStrNNTB";
            this.searchStrNNTB.Size = new System.Drawing.Size(100, 22);
            this.searchStrNNTB.TabIndex = 17;
            // 
            // searchStrButton
            // 
            this.searchStrButton.Location = new System.Drawing.Point(206, 167);
            this.searchStrButton.Name = "searchStrButton";
            this.searchStrButton.Size = new System.Drawing.Size(75, 23);
            this.searchStrButton.TabIndex = 15;
            this.searchStrButton.Text = "Search";
            this.searchStrButton.UseVisualStyleBackColor = true;
            this.searchStrButton.Click += new System.EventHandler(this.searchButton_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "ID:";
            // 
            // searchStrIDTB
            // 
            this.searchStrIDTB.Location = new System.Drawing.Point(225, 39);
            this.searchStrIDTB.Name = "searchStrIDTB";
            this.searchStrIDTB.Size = new System.Drawing.Size(100, 22);
            this.searchStrIDTB.TabIndex = 14;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.searchSqrButton);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.searchSqrFDTB);
            this.tabPage2.Controls.Add(this.searchSqrONTB);
            this.tabPage2.Controls.Add(this.searchSqrNNTB);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.searchSqrIDTB);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(499, 209);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Square";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // searchSqrButton
            // 
            this.searchSqrButton.Location = new System.Drawing.Point(209, 158);
            this.searchSqrButton.Name = "searchSqrButton";
            this.searchSqrButton.Size = new System.Drawing.Size(75, 23);
            this.searchSqrButton.TabIndex = 31;
            this.searchSqrButton.Text = "Search";
            this.searchSqrButton.UseVisualStyleBackColor = true;
            this.searchSqrButton.Click += new System.EventHandler(this.searchSqrButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(138, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.TabIndex = 30;
            this.label6.Text = "New name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(138, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 29;
            this.label7.Text = "Old name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(138, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 17);
            this.label8.TabIndex = 28;
            this.label8.Text = "Date:";
            // 
            // searchSqrFDTB
            // 
            this.searchSqrFDTB.Location = new System.Drawing.Point(219, 117);
            this.searchSqrFDTB.Name = "searchSqrFDTB";
            this.searchSqrFDTB.Size = new System.Drawing.Size(100, 22);
            this.searchSqrFDTB.TabIndex = 27;
            // 
            // searchSqrONTB
            // 
            this.searchSqrONTB.Location = new System.Drawing.Point(219, 89);
            this.searchSqrONTB.Name = "searchSqrONTB";
            this.searchSqrONTB.Size = new System.Drawing.Size(100, 22);
            this.searchSqrONTB.TabIndex = 26;
            // 
            // searchSqrNNTB
            // 
            this.searchSqrNNTB.Location = new System.Drawing.Point(219, 61);
            this.searchSqrNNTB.Name = "searchSqrNNTB";
            this.searchSqrNNTB.Size = new System.Drawing.Size(100, 22);
            this.searchSqrNNTB.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(138, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "ID:";
            // 
            // searchSqrIDTB
            // 
            this.searchSqrIDTB.Location = new System.Drawing.Point(219, 33);
            this.searchSqrIDTB.Name = "searchSqrIDTB";
            this.searchSqrIDTB.Size = new System.Drawing.Size(100, 22);
            this.searchSqrIDTB.TabIndex = 23;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.searchSightButton);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.searchSightStrIDTB);
            this.tabPage3.Controls.Add(this.searchSightFDTB);
            this.tabPage3.Controls.Add(this.searchSightNTB);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.searchSightIDTB);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(499, 209);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Sight";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // searchSightButton
            // 
            this.searchSightButton.Location = new System.Drawing.Point(213, 160);
            this.searchSightButton.Name = "searchSightButton";
            this.searchSightButton.Size = new System.Drawing.Size(75, 23);
            this.searchSightButton.TabIndex = 31;
            this.searchSightButton.Text = "Search";
            this.searchSightButton.UseVisualStyleBackColor = true;
            this.searchSightButton.Click += new System.EventHandler(this.searchSightButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(142, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 17);
            this.label10.TabIndex = 30;
            this.label10.Text = "Name:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(142, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 17);
            this.label11.TabIndex = 29;
            this.label11.Text = "Year:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(142, 122);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 17);
            this.label12.TabIndex = 28;
            this.label12.Text = "Street ID:";
            // 
            // searchSightStrIDTB
            // 
            this.searchSightStrIDTB.Location = new System.Drawing.Point(223, 119);
            this.searchSightStrIDTB.Name = "searchSightStrIDTB";
            this.searchSightStrIDTB.Size = new System.Drawing.Size(100, 22);
            this.searchSightStrIDTB.TabIndex = 27;
            // 
            // searchSightFDTB
            // 
            this.searchSightFDTB.Location = new System.Drawing.Point(223, 91);
            this.searchSightFDTB.Name = "searchSightFDTB";
            this.searchSightFDTB.Size = new System.Drawing.Size(100, 22);
            this.searchSightFDTB.TabIndex = 26;
            // 
            // searchSightNTB
            // 
            this.searchSightNTB.Location = new System.Drawing.Point(223, 63);
            this.searchSightNTB.Name = "searchSightNTB";
            this.searchSightNTB.Size = new System.Drawing.Size(100, 22);
            this.searchSightNTB.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(142, 38);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(25, 17);
            this.label13.TabIndex = 24;
            this.label13.Text = "ID:";
            // 
            // searchSightIDTB
            // 
            this.searchSightIDTB.Location = new System.Drawing.Point(223, 35);
            this.searchSightIDTB.Name = "searchSightIDTB";
            this.searchSightIDTB.Size = new System.Drawing.Size(100, 22);
            this.searchSightIDTB.TabIndex = 23;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.searchBcgrButton);
            this.tabPage4.Controls.Add(this.label18);
            this.tabPage4.Controls.Add(this.searchBcgrSightIDTB);
            this.tabPage4.Controls.Add(this.label14);
            this.tabPage4.Controls.Add(this.label15);
            this.tabPage4.Controls.Add(this.label16);
            this.tabPage4.Controls.Add(this.searchBcgrYearTB);
            this.tabPage4.Controls.Add(this.searchBcgrContTB);
            this.tabPage4.Controls.Add(this.searchBcgrSourceTB);
            this.tabPage4.Controls.Add(this.label17);
            this.tabPage4.Controls.Add(this.searchBcgrIDTB);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(499, 209);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Background";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // searchBcgrButton
            // 
            this.searchBcgrButton.Location = new System.Drawing.Point(218, 166);
            this.searchBcgrButton.Name = "searchBcgrButton";
            this.searchBcgrButton.Size = new System.Drawing.Size(75, 23);
            this.searchBcgrButton.TabIndex = 33;
            this.searchBcgrButton.Text = "Search";
            this.searchBcgrButton.UseVisualStyleBackColor = true;
            this.searchBcgrButton.Click += new System.EventHandler(this.searchBcgrButton_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(137, 141);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(61, 17);
            this.label18.TabIndex = 32;
            this.label18.Text = "Sight ID:";
            // 
            // searchBcgrSightIDTB
            // 
            this.searchBcgrSightIDTB.Location = new System.Drawing.Point(218, 138);
            this.searchBcgrSightIDTB.Name = "searchBcgrSightIDTB";
            this.searchBcgrSightIDTB.Size = new System.Drawing.Size(100, 22);
            this.searchBcgrSightIDTB.TabIndex = 31;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(137, 85);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 17);
            this.label14.TabIndex = 30;
            this.label14.Text = "Contents:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(137, 113);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 17);
            this.label15.TabIndex = 29;
            this.label15.Text = "Year:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(137, 57);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 17);
            this.label16.TabIndex = 28;
            this.label16.Text = "Source:";
            // 
            // searchBcgrYearTB
            // 
            this.searchBcgrYearTB.Location = new System.Drawing.Point(218, 110);
            this.searchBcgrYearTB.Name = "searchBcgrYearTB";
            this.searchBcgrYearTB.Size = new System.Drawing.Size(100, 22);
            this.searchBcgrYearTB.TabIndex = 27;
            // 
            // searchBcgrContTB
            // 
            this.searchBcgrContTB.Location = new System.Drawing.Point(218, 82);
            this.searchBcgrContTB.Name = "searchBcgrContTB";
            this.searchBcgrContTB.Size = new System.Drawing.Size(100, 22);
            this.searchBcgrContTB.TabIndex = 26;
            // 
            // searchBcgrSourceTB
            // 
            this.searchBcgrSourceTB.Location = new System.Drawing.Point(218, 54);
            this.searchBcgrSourceTB.Name = "searchBcgrSourceTB";
            this.searchBcgrSourceTB.Size = new System.Drawing.Size(100, 22);
            this.searchBcgrSourceTB.TabIndex = 25;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(137, 29);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(25, 17);
            this.label17.TabIndex = 24;
            this.label17.Text = "ID:";
            // 
            // searchBcgrIDTB
            // 
            this.searchBcgrIDTB.Location = new System.Drawing.Point(218, 26);
            this.searchBcgrIDTB.Name = "searchBcgrIDTB";
            this.searchBcgrIDTB.Size = new System.Drawing.Size(100, 22);
            this.searchBcgrIDTB.TabIndex = 23;
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 496);
            this.Controls.Add(this.tablesTab);
            this.Controls.Add(this.declineUpdButton);
            this.Controls.Add(this.commitUpdButton);
            this.Controls.Add(this.searchDGV);
            this.Controls.Add(this.tablesComboBox);
            this.Controls.Add(this.label1);
            this.Name = "UpdateForm";
            this.Text = "Update record";
            ((System.ComponentModel.ISupportInitialize)(this.searchDGV)).EndInit();
            this.tablesTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox tablesComboBox;
        private System.Windows.Forms.DataGridView searchDGV;
        private System.Windows.Forms.Button commitUpdButton;
        private System.Windows.Forms.Button declineUpdButton;
        private System.Windows.Forms.TabControl tablesTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox searchStrFDTB;
        private System.Windows.Forms.TextBox searchStrONTB;
        private System.Windows.Forms.TextBox searchStrNNTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button searchStrButton;
        private System.Windows.Forms.TextBox searchStrIDTB;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox searchSqrFDTB;
        private System.Windows.Forms.TextBox searchSqrONTB;
        private System.Windows.Forms.TextBox searchSqrNNTB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox searchSqrIDTB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox searchSightStrIDTB;
        private System.Windows.Forms.TextBox searchSightFDTB;
        private System.Windows.Forms.TextBox searchSightNTB;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox searchSightIDTB;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox searchBcgrYearTB;
        private System.Windows.Forms.TextBox searchBcgrContTB;
        private System.Windows.Forms.TextBox searchBcgrSourceTB;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox searchBcgrIDTB;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox searchBcgrSightIDTB;
        private System.Windows.Forms.Button searchSqrButton;
        private System.Windows.Forms.Button searchSightButton;
        private System.Windows.Forms.Button searchBcgrButton;
    }
}