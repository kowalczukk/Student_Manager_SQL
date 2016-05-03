namespace StudentManager2
{
    partial class StudentDetails
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
            this.deleteMarkButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numberBox = new System.Windows.Forms.TextBox();
            this.typeBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addMarkButton = new System.Windows.Forms.Button();
            this.markGridView = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.subjectComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.idBox = new System.Windows.Forms.TextBox();
            this.dataSet1 = new System.Data.DataSet();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.markGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteMarkButton
            // 
            this.deleteMarkButton.Location = new System.Drawing.Point(15, 296);
            this.deleteMarkButton.Name = "deleteMarkButton";
            this.deleteMarkButton.Size = new System.Drawing.Size(124, 34);
            this.deleteMarkButton.TabIndex = 37;
            this.deleteMarkButton.Text = "USUŃ OCENĘ";
            this.deleteMarkButton.UseVisualStyleBackColor = true;
            this.deleteMarkButton.Click += new System.EventHandler(this.deleteMarkButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.deleteMarkButton);
            this.groupBox1.Controls.Add(this.markGridView);
            this.groupBox1.Controls.Add(this.numberBox);
            this.groupBox1.Controls.Add(this.typeBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.addMarkButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 336);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodaj ocenę";
            // 
            // numberBox
            // 
            this.numberBox.Location = new System.Drawing.Point(203, 39);
            this.numberBox.Name = "numberBox";
            this.numberBox.Size = new System.Drawing.Size(124, 20);
            this.numberBox.TabIndex = 24;
            this.numberBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numberBox_KeyDown);
            // 
            // typeBox
            // 
            this.typeBox.Location = new System.Drawing.Point(15, 39);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(152, 20);
            this.typeBox.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(11, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Za co:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(199, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Ocena:";
            // 
            // addMarkButton
            // 
            this.addMarkButton.Location = new System.Drawing.Point(15, 65);
            this.addMarkButton.Name = "addMarkButton";
            this.addMarkButton.Size = new System.Drawing.Size(124, 34);
            this.addMarkButton.TabIndex = 20;
            this.addMarkButton.Text = "DODAJ OCENĘ";
            this.addMarkButton.UseVisualStyleBackColor = true;
            this.addMarkButton.Click += new System.EventHandler(this.addMarkButton_Click);
            // 
            // markGridView
            // 
            this.markGridView.AllowUserToAddRows = false;
            this.markGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.markGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.markGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1,
            this.Column3});
            this.markGridView.Location = new System.Drawing.Point(15, 105);
            this.markGridView.Name = "markGridView";
            this.markGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.markGridView.Size = new System.Drawing.Size(325, 185);
            this.markGridView.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(8, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "Przedmiot:";
            // 
            // subjectComboBox
            // 
            this.subjectComboBox.FormattingEnabled = true;
            this.subjectComboBox.Location = new System.Drawing.Point(145, 109);
            this.subjectComboBox.Name = "subjectComboBox";
            this.subjectComboBox.Size = new System.Drawing.Size(213, 21);
            this.subjectComboBox.TabIndex = 33;
            this.subjectComboBox.SelectedIndexChanged += new System.EventHandler(this.subjectComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(8, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Nazwisko ucznia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(8, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Imię ucznia:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "ID ucznia:";
            // 
            // firstNameBox
            // 
            this.firstNameBox.Enabled = false;
            this.firstNameBox.Location = new System.Drawing.Point(145, 60);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(213, 20);
            this.firstNameBox.TabIndex = 29;
            // 
            // lastNameBox
            // 
            this.lastNameBox.Enabled = false;
            this.lastNameBox.Location = new System.Drawing.Point(145, 34);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(213, 20);
            this.lastNameBox.TabIndex = 28;
            // 
            // idBox
            // 
            this.idBox.Enabled = false;
            this.idBox.Location = new System.Drawing.Point(145, 9);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(143, 20);
            this.idBox.TabIndex = 27;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ocena";
            this.Column2.Name = "Column2";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Za co";
            this.Column1.Name = "Column1";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "ID oceny";
            this.Column3.Name = "Column3";
            // 
            // StudentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(370, 485);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.subjectComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.firstNameBox);
            this.Controls.Add(this.lastNameBox);
            this.Controls.Add(this.idBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "StudentDetails";
            this.Text = "StudentDetails";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StudentDetails_FormClosing);
            this.Load += new System.EventHandler(this.StudentDetails_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.markGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button deleteMarkButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox numberBox;
        private System.Windows.Forms.TextBox typeBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addMarkButton;
        private System.Windows.Forms.DataGridView markGridView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox subjectComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox firstNameBox;
        public System.Windows.Forms.TextBox lastNameBox;
        public System.Windows.Forms.TextBox idBox;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}