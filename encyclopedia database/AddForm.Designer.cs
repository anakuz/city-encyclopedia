namespace encyclopedia_database
{
    partial class AddForm
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
            this.tablesTab = new System.Windows.Forms.TabControl();
            this.streetTab = new System.Windows.Forms.TabPage();
            this.commitStreetButton = new System.Windows.Forms.Button();
            this.idStrLabel = new System.Windows.Forms.Label();
            this.idStreetTextBox = new System.Windows.Forms.TextBox();
            this.stryearLabel = new System.Windows.Forms.Label();
            this.stronLabel = new System.Windows.Forms.Label();
            this.strnnLabel = new System.Windows.Forms.Label();
            this.strYearTextBox = new System.Windows.Forms.TextBox();
            this.strONTextBox = new System.Windows.Forms.TextBox();
            this.strNNTextBox = new System.Windows.Forms.TextBox();
            this.squareTab = new System.Windows.Forms.TabPage();
            this.commitSquareButton = new System.Windows.Forms.Button();
            this.sqryearLabel = new System.Windows.Forms.Label();
            this.sqronLabel = new System.Windows.Forms.Label();
            this.sqrnnLabel = new System.Windows.Forms.Label();
            this.sqrYearTextBox = new System.Windows.Forms.TextBox();
            this.sqrONameTextBox = new System.Windows.Forms.TextBox();
            this.sqrNNameTextBox = new System.Windows.Forms.TextBox();
            this.sightTab = new System.Windows.Forms.TabPage();
            this.strFKTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.choosePhotoButton = new System.Windows.Forms.Button();
            this.commitSightButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.sightYearLabel = new System.Windows.Forms.Label();
            this.sightPhotoLabel = new System.Windows.Forms.Label();
            this.sightNameLabel = new System.Windows.Forms.Label();
            this.sightYearTextBox = new System.Windows.Forms.TextBox();
            this.sightNameTextBox = new System.Windows.Forms.TextBox();
            this.bcgrTab = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.sightFKTextBox = new System.Windows.Forms.TextBox();
            this.backgroundCommitButton = new System.Windows.Forms.Button();
            this.bcgrYearLabel = new System.Windows.Forms.Label();
            this.bcgrContLabel = new System.Windows.Forms.Label();
            this.bcgrSrcLabel = new System.Windows.Forms.Label();
            this.bcgrYearTextBox = new System.Windows.Forms.TextBox();
            this.bcgrContTextBox = new System.Windows.Forms.TextBox();
            this.bcgrSourceTextBox = new System.Windows.Forms.TextBox();
            this.declineButton = new System.Windows.Forms.Button();
            this.tablesTab.SuspendLayout();
            this.streetTab.SuspendLayout();
            this.squareTab.SuspendLayout();
            this.sightTab.SuspendLayout();
            this.bcgrTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablesTab
            // 
            this.tablesTab.Controls.Add(this.streetTab);
            this.tablesTab.Controls.Add(this.squareTab);
            this.tablesTab.Controls.Add(this.sightTab);
            this.tablesTab.Controls.Add(this.bcgrTab);
            this.tablesTab.Location = new System.Drawing.Point(0, 2);
            this.tablesTab.Name = "tablesTab";
            this.tablesTab.SelectedIndex = 0;
            this.tablesTab.Size = new System.Drawing.Size(559, 308);
            this.tablesTab.TabIndex = 0;
            // 
            // streetTab
            // 
            this.streetTab.Controls.Add(this.commitStreetButton);
            this.streetTab.Controls.Add(this.idStrLabel);
            this.streetTab.Controls.Add(this.idStreetTextBox);
            this.streetTab.Controls.Add(this.stryearLabel);
            this.streetTab.Controls.Add(this.stronLabel);
            this.streetTab.Controls.Add(this.strnnLabel);
            this.streetTab.Controls.Add(this.strYearTextBox);
            this.streetTab.Controls.Add(this.strONTextBox);
            this.streetTab.Controls.Add(this.strNNTextBox);
            this.streetTab.Location = new System.Drawing.Point(4, 25);
            this.streetTab.Name = "streetTab";
            this.streetTab.Padding = new System.Windows.Forms.Padding(3);
            this.streetTab.Size = new System.Drawing.Size(551, 279);
            this.streetTab.TabIndex = 0;
            this.streetTab.Text = "Street";
            this.streetTab.UseVisualStyleBackColor = true;
            // 
            // commitStreetButton
            // 
            this.commitStreetButton.Location = new System.Drawing.Point(235, 201);
            this.commitStreetButton.Name = "commitStreetButton";
            this.commitStreetButton.Size = new System.Drawing.Size(75, 23);
            this.commitStreetButton.TabIndex = 8;
            this.commitStreetButton.Text = "Commit";
            this.commitStreetButton.UseVisualStyleBackColor = true;
            this.commitStreetButton.Click += new System.EventHandler(this.commitStreetButton_Click);
            // 
            // idStrLabel
            // 
            this.idStrLabel.AutoSize = true;
            this.idStrLabel.Location = new System.Drawing.Point(56, 40);
            this.idStrLabel.Name = "idStrLabel";
            this.idStrLabel.Size = new System.Drawing.Size(25, 17);
            this.idStrLabel.TabIndex = 3;
            this.idStrLabel.Text = "ID:";
            this.idStrLabel.Visible = false;
            this.idStrLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // idStreetTextBox
            // 
            this.idStreetTextBox.Location = new System.Drawing.Point(235, 37);
            this.idStreetTextBox.Name = "idStreetTextBox";
            this.idStreetTextBox.Size = new System.Drawing.Size(100, 22);
            this.idStreetTextBox.TabIndex = 3;
            this.idStreetTextBox.Visible = false;
            // 
            // stryearLabel
            // 
            this.stryearLabel.AutoSize = true;
            this.stryearLabel.Location = new System.Drawing.Point(56, 129);
            this.stryearLabel.Name = "stryearLabel";
            this.stryearLabel.Size = new System.Drawing.Size(42, 17);
            this.stryearLabel.TabIndex = 7;
            this.stryearLabel.Text = "Year:";
            // 
            // stronLabel
            // 
            this.stronLabel.AutoSize = true;
            this.stronLabel.Location = new System.Drawing.Point(56, 99);
            this.stronLabel.Name = "stronLabel";
            this.stronLabel.Size = new System.Drawing.Size(73, 17);
            this.stronLabel.TabIndex = 6;
            this.stronLabel.Text = "Old name:";
            // 
            // strnnLabel
            // 
            this.strnnLabel.AutoSize = true;
            this.strnnLabel.Location = new System.Drawing.Point(56, 68);
            this.strnnLabel.Name = "strnnLabel";
            this.strnnLabel.Size = new System.Drawing.Size(78, 17);
            this.strnnLabel.TabIndex = 5;
            this.strnnLabel.Text = "New name:";
            // 
            // strYearTextBox
            // 
            this.strYearTextBox.Location = new System.Drawing.Point(235, 126);
            this.strYearTextBox.Name = "strYearTextBox";
            this.strYearTextBox.Size = new System.Drawing.Size(97, 22);
            this.strYearTextBox.TabIndex = 3;
            // 
            // strONTextBox
            // 
            this.strONTextBox.Location = new System.Drawing.Point(235, 96);
            this.strONTextBox.Name = "strONTextBox";
            this.strONTextBox.Size = new System.Drawing.Size(284, 22);
            this.strONTextBox.TabIndex = 2;
            // 
            // strNNTextBox
            // 
            this.strNNTextBox.Location = new System.Drawing.Point(235, 65);
            this.strNNTextBox.Name = "strNNTextBox";
            this.strNNTextBox.Size = new System.Drawing.Size(284, 22);
            this.strNNTextBox.TabIndex = 1;
            // 
            // squareTab
            // 
            this.squareTab.Controls.Add(this.commitSquareButton);
            this.squareTab.Controls.Add(this.sqryearLabel);
            this.squareTab.Controls.Add(this.sqronLabel);
            this.squareTab.Controls.Add(this.sqrnnLabel);
            this.squareTab.Controls.Add(this.sqrYearTextBox);
            this.squareTab.Controls.Add(this.sqrONameTextBox);
            this.squareTab.Controls.Add(this.sqrNNameTextBox);
            this.squareTab.Location = new System.Drawing.Point(4, 25);
            this.squareTab.Name = "squareTab";
            this.squareTab.Padding = new System.Windows.Forms.Padding(3);
            this.squareTab.Size = new System.Drawing.Size(551, 279);
            this.squareTab.TabIndex = 1;
            this.squareTab.Text = "Square";
            this.squareTab.UseVisualStyleBackColor = true;
            // 
            // commitSquareButton
            // 
            this.commitSquareButton.Location = new System.Drawing.Point(235, 202);
            this.commitSquareButton.Name = "commitSquareButton";
            this.commitSquareButton.Size = new System.Drawing.Size(75, 23);
            this.commitSquareButton.TabIndex = 1;
            this.commitSquareButton.Text = "Commit";
            this.commitSquareButton.UseVisualStyleBackColor = true;
            this.commitSquareButton.Click += new System.EventHandler(this.commitButton_Click);
            // 
            // sqryearLabel
            // 
            this.sqryearLabel.AutoSize = true;
            this.sqryearLabel.Location = new System.Drawing.Point(44, 124);
            this.sqryearLabel.Name = "sqryearLabel";
            this.sqryearLabel.Size = new System.Drawing.Size(42, 17);
            this.sqryearLabel.TabIndex = 15;
            this.sqryearLabel.Text = "Year:";
            // 
            // sqronLabel
            // 
            this.sqronLabel.AutoSize = true;
            this.sqronLabel.Location = new System.Drawing.Point(44, 91);
            this.sqronLabel.Name = "sqronLabel";
            this.sqronLabel.Size = new System.Drawing.Size(73, 17);
            this.sqronLabel.TabIndex = 14;
            this.sqronLabel.Text = "Old name:";
            // 
            // sqrnnLabel
            // 
            this.sqrnnLabel.AutoSize = true;
            this.sqrnnLabel.Location = new System.Drawing.Point(44, 57);
            this.sqrnnLabel.Name = "sqrnnLabel";
            this.sqrnnLabel.Size = new System.Drawing.Size(78, 17);
            this.sqrnnLabel.TabIndex = 13;
            this.sqrnnLabel.Text = "New name:";
            // 
            // sqrYearTextBox
            // 
            this.sqrYearTextBox.Location = new System.Drawing.Point(223, 121);
            this.sqrYearTextBox.Name = "sqrYearTextBox";
            this.sqrYearTextBox.Size = new System.Drawing.Size(97, 22);
            this.sqrYearTextBox.TabIndex = 11;
            // 
            // sqrONameTextBox
            // 
            this.sqrONameTextBox.Location = new System.Drawing.Point(223, 88);
            this.sqrONameTextBox.Name = "sqrONameTextBox";
            this.sqrONameTextBox.Size = new System.Drawing.Size(284, 22);
            this.sqrONameTextBox.TabIndex = 10;
            // 
            // sqrNNameTextBox
            // 
            this.sqrNNameTextBox.Location = new System.Drawing.Point(223, 54);
            this.sqrNNameTextBox.Name = "sqrNNameTextBox";
            this.sqrNNameTextBox.Size = new System.Drawing.Size(284, 22);
            this.sqrNNameTextBox.TabIndex = 9;
            // 
            // sightTab
            // 
            this.sightTab.Controls.Add(this.strFKTextBox);
            this.sightTab.Controls.Add(this.label1);
            this.sightTab.Controls.Add(this.button1);
            this.sightTab.Controls.Add(this.choosePhotoButton);
            this.sightTab.Controls.Add(this.commitSightButton);
            this.sightTab.Controls.Add(this.label9);
            this.sightTab.Controls.Add(this.sightYearLabel);
            this.sightTab.Controls.Add(this.sightPhotoLabel);
            this.sightTab.Controls.Add(this.sightNameLabel);
            this.sightTab.Controls.Add(this.sightYearTextBox);
            this.sightTab.Controls.Add(this.sightNameTextBox);
            this.sightTab.Location = new System.Drawing.Point(4, 25);
            this.sightTab.Name = "sightTab";
            this.sightTab.Size = new System.Drawing.Size(551, 279);
            this.sightTab.TabIndex = 2;
            this.sightTab.Text = "Sight";
            this.sightTab.UseVisualStyleBackColor = true;
            // 
            // strFKTextBox
            // 
            this.strFKTextBox.Location = new System.Drawing.Point(223, 127);
            this.strFKTextBox.Name = "strFKTextBox";
            this.strFKTextBox.Size = new System.Drawing.Size(100, 22);
            this.strFKTextBox.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Street ID:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(392, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // choosePhotoButton
            // 
            this.choosePhotoButton.Location = new System.Drawing.Point(357, 23);
            this.choosePhotoButton.Name = "choosePhotoButton";
            this.choosePhotoButton.Size = new System.Drawing.Size(75, 23);
            this.choosePhotoButton.TabIndex = 25;
            this.choosePhotoButton.Text = "Choose";
            this.choosePhotoButton.UseVisualStyleBackColor = true;
            this.choosePhotoButton.Visible = false;
            // 
            // commitSightButton
            // 
            this.commitSightButton.Location = new System.Drawing.Point(235, 202);
            this.commitSightButton.Name = "commitSightButton";
            this.commitSightButton.Size = new System.Drawing.Size(75, 23);
            this.commitSightButton.TabIndex = 9;
            this.commitSightButton.Text = "Commit";
            this.commitSightButton.UseVisualStyleBackColor = true;
            this.commitSightButton.Click += new System.EventHandler(this.commitSightButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(220, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "not chosen";
            this.label9.Visible = false;
            // 
            // sightYearLabel
            // 
            this.sightYearLabel.AutoSize = true;
            this.sightYearLabel.Location = new System.Drawing.Point(44, 96);
            this.sightYearLabel.Name = "sightYearLabel";
            this.sightYearLabel.Size = new System.Drawing.Size(42, 17);
            this.sightYearLabel.TabIndex = 23;
            this.sightYearLabel.Text = "Year:";
            // 
            // sightPhotoLabel
            // 
            this.sightPhotoLabel.AutoSize = true;
            this.sightPhotoLabel.Location = new System.Drawing.Point(44, 23);
            this.sightPhotoLabel.Name = "sightPhotoLabel";
            this.sightPhotoLabel.Size = new System.Drawing.Size(49, 17);
            this.sightPhotoLabel.TabIndex = 22;
            this.sightPhotoLabel.Text = "Photo:";
            this.sightPhotoLabel.Visible = false;
            // 
            // sightNameLabel
            // 
            this.sightNameLabel.AutoSize = true;
            this.sightNameLabel.Location = new System.Drawing.Point(44, 62);
            this.sightNameLabel.Name = "sightNameLabel";
            this.sightNameLabel.Size = new System.Drawing.Size(49, 17);
            this.sightNameLabel.TabIndex = 21;
            this.sightNameLabel.Text = "Name:";
            // 
            // sightYearTextBox
            // 
            this.sightYearTextBox.Location = new System.Drawing.Point(223, 93);
            this.sightYearTextBox.Name = "sightYearTextBox";
            this.sightYearTextBox.Size = new System.Drawing.Size(97, 22);
            this.sightYearTextBox.TabIndex = 19;
            // 
            // sightNameTextBox
            // 
            this.sightNameTextBox.Location = new System.Drawing.Point(223, 59);
            this.sightNameTextBox.Name = "sightNameTextBox";
            this.sightNameTextBox.Size = new System.Drawing.Size(284, 22);
            this.sightNameTextBox.TabIndex = 17;
            // 
            // bcgrTab
            // 
            this.bcgrTab.Controls.Add(this.label2);
            this.bcgrTab.Controls.Add(this.button2);
            this.bcgrTab.Controls.Add(this.sightFKTextBox);
            this.bcgrTab.Controls.Add(this.backgroundCommitButton);
            this.bcgrTab.Controls.Add(this.bcgrYearLabel);
            this.bcgrTab.Controls.Add(this.bcgrContLabel);
            this.bcgrTab.Controls.Add(this.bcgrSrcLabel);
            this.bcgrTab.Controls.Add(this.bcgrYearTextBox);
            this.bcgrTab.Controls.Add(this.bcgrContTextBox);
            this.bcgrTab.Controls.Add(this.bcgrSourceTextBox);
            this.bcgrTab.Location = new System.Drawing.Point(4, 25);
            this.bcgrTab.Name = "bcgrTab";
            this.bcgrTab.Size = new System.Drawing.Size(551, 279);
            this.bcgrTab.TabIndex = 3;
            this.bcgrTab.Text = "Background";
            this.bcgrTab.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Sight ID:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(47, 194);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 25;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            // 
            // sightFKTextBox
            // 
            this.sightFKTextBox.Location = new System.Drawing.Point(223, 154);
            this.sightFKTextBox.Name = "sightFKTextBox";
            this.sightFKTextBox.Size = new System.Drawing.Size(100, 22);
            this.sightFKTextBox.TabIndex = 24;
            // 
            // backgroundCommitButton
            // 
            this.backgroundCommitButton.Location = new System.Drawing.Point(235, 205);
            this.backgroundCommitButton.Name = "backgroundCommitButton";
            this.backgroundCommitButton.Size = new System.Drawing.Size(75, 23);
            this.backgroundCommitButton.TabIndex = 16;
            this.backgroundCommitButton.Text = "Commit";
            this.backgroundCommitButton.UseVisualStyleBackColor = true;
            this.backgroundCommitButton.Click += new System.EventHandler(this.backgroundCommitButton_Click);
            // 
            // bcgrYearLabel
            // 
            this.bcgrYearLabel.AutoSize = true;
            this.bcgrYearLabel.Location = new System.Drawing.Point(44, 129);
            this.bcgrYearLabel.Name = "bcgrYearLabel";
            this.bcgrYearLabel.Size = new System.Drawing.Size(42, 17);
            this.bcgrYearLabel.TabIndex = 23;
            this.bcgrYearLabel.Text = "Year:";
            // 
            // bcgrContLabel
            // 
            this.bcgrContLabel.AutoSize = true;
            this.bcgrContLabel.Location = new System.Drawing.Point(44, 96);
            this.bcgrContLabel.Name = "bcgrContLabel";
            this.bcgrContLabel.Size = new System.Drawing.Size(68, 17);
            this.bcgrContLabel.TabIndex = 22;
            this.bcgrContLabel.Text = "Contents:";
            // 
            // bcgrSrcLabel
            // 
            this.bcgrSrcLabel.AutoSize = true;
            this.bcgrSrcLabel.Location = new System.Drawing.Point(43, 62);
            this.bcgrSrcLabel.Name = "bcgrSrcLabel";
            this.bcgrSrcLabel.Size = new System.Drawing.Size(57, 17);
            this.bcgrSrcLabel.TabIndex = 21;
            this.bcgrSrcLabel.Text = "Source:";
            // 
            // bcgrYearTextBox
            // 
            this.bcgrYearTextBox.Location = new System.Drawing.Point(223, 126);
            this.bcgrYearTextBox.Name = "bcgrYearTextBox";
            this.bcgrYearTextBox.Size = new System.Drawing.Size(97, 22);
            this.bcgrYearTextBox.TabIndex = 19;
            // 
            // bcgrContTextBox
            // 
            this.bcgrContTextBox.Location = new System.Drawing.Point(223, 93);
            this.bcgrContTextBox.Name = "bcgrContTextBox";
            this.bcgrContTextBox.Size = new System.Drawing.Size(284, 22);
            this.bcgrContTextBox.TabIndex = 18;
            // 
            // bcgrSourceTextBox
            // 
            this.bcgrSourceTextBox.Location = new System.Drawing.Point(223, 59);
            this.bcgrSourceTextBox.Name = "bcgrSourceTextBox";
            this.bcgrSourceTextBox.Size = new System.Drawing.Size(284, 22);
            this.bcgrSourceTextBox.TabIndex = 17;
            // 
            // declineButton
            // 
            this.declineButton.Location = new System.Drawing.Point(239, 316);
            this.declineButton.Name = "declineButton";
            this.declineButton.Size = new System.Drawing.Size(75, 23);
            this.declineButton.TabIndex = 2;
            this.declineButton.Text = "Decline";
            this.declineButton.UseVisualStyleBackColor = true;
            this.declineButton.Click += new System.EventHandler(this.declineButton_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 362);
            this.Controls.Add(this.declineButton);
            this.Controls.Add(this.tablesTab);
            this.Name = "AddForm";
            this.Text = "Add record";
            this.tablesTab.ResumeLayout(false);
            this.streetTab.ResumeLayout(false);
            this.streetTab.PerformLayout();
            this.squareTab.ResumeLayout(false);
            this.squareTab.PerformLayout();
            this.sightTab.ResumeLayout(false);
            this.sightTab.PerformLayout();
            this.bcgrTab.ResumeLayout(false);
            this.bcgrTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tablesTab;
        private System.Windows.Forms.TabPage streetTab;
        private System.Windows.Forms.Label stryearLabel;
        private System.Windows.Forms.Label stronLabel;
        private System.Windows.Forms.Label strnnLabel;
        private System.Windows.Forms.TextBox strYearTextBox;
        private System.Windows.Forms.TextBox strONTextBox;
        private System.Windows.Forms.TextBox strNNTextBox;
        private System.Windows.Forms.TabPage squareTab;
        private System.Windows.Forms.Label sqryearLabel;
        private System.Windows.Forms.Label sqronLabel;
        private System.Windows.Forms.Label sqrnnLabel;
        private System.Windows.Forms.TextBox sqrYearTextBox;
        private System.Windows.Forms.TextBox sqrONameTextBox;
        private System.Windows.Forms.TextBox sqrNNameTextBox;
        private System.Windows.Forms.TabPage sightTab;
        private System.Windows.Forms.TabPage bcgrTab;
        private System.Windows.Forms.Button backgroundCommitButton;
        private System.Windows.Forms.Button commitSquareButton;
        private System.Windows.Forms.Button declineButton;
        private System.Windows.Forms.Button choosePhotoButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label sightYearLabel;
        private System.Windows.Forms.Label sightPhotoLabel;
        private System.Windows.Forms.Label sightNameLabel;
        private System.Windows.Forms.TextBox sightYearTextBox;
        private System.Windows.Forms.TextBox sightNameTextBox;
        private System.Windows.Forms.Label bcgrYearLabel;
        private System.Windows.Forms.Label bcgrContLabel;
        private System.Windows.Forms.Label bcgrSrcLabel;
        private System.Windows.Forms.TextBox bcgrYearTextBox;
        private System.Windows.Forms.TextBox bcgrContTextBox;
        private System.Windows.Forms.TextBox bcgrSourceTextBox;
        private System.Windows.Forms.TextBox idStreetTextBox;
        private System.Windows.Forms.Label idStrLabel;
        private System.Windows.Forms.Button commitSightButton;
        private System.Windows.Forms.Button commitStreetButton;
        private System.Windows.Forms.TextBox strFKTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox sightFKTextBox;
    }
}