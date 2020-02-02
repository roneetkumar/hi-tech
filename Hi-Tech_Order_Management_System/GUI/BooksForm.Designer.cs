namespace Hi_Tech_Order_Management_System.GUI
{
    partial class BooksForm
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listView4 = new System.Windows.Forms.ListView();
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListUser = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.LabelMessage = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxQOH = new System.Windows.Forms.TextBox();
            this.deleleBtn = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.textBoxtitle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TextboxISBN = new System.Windows.Forms.TextBox();
            this.textBoxunit = new System.Windows.Forms.TextBox();
            this.textBoxyear = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.listView4);
            this.groupBox4.Controls.Add(this.ListUser);
            this.groupBox4.Location = new System.Drawing.Point(79, 338);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox4.Size = new System.Drawing.Size(709, 262);
            this.groupBox4.TabIndex = 48;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "List of Books";
            // 
            // listView4
            // 
            this.listView4.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader19,
            this.columnHeader20,
            this.columnHeader1});
            this.listView4.GridLines = true;
            this.listView4.HideSelection = false;
            this.listView4.Location = new System.Drawing.Point(20, 71);
            this.listView4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.listView4.Name = "listView4";
            this.listView4.Size = new System.Drawing.Size(670, 183);
            this.listView4.TabIndex = 34;
            this.listView4.UseCompatibleStateImageBehavior = false;
            this.listView4.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "ISBN";
            this.columnHeader17.Width = 118;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Title";
            this.columnHeader18.Width = 163;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "Unit Price";
            this.columnHeader19.Width = 144;
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "Year Published";
            this.columnHeader20.Width = 132;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "QOH";
            this.columnHeader1.Width = 109;
            // 
            // ListUser
            // 
            this.ListUser.Location = new System.Drawing.Point(115, 17);
            this.ListUser.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ListUser.Name = "ListUser";
            this.ListUser.Size = new System.Drawing.Size(150, 24);
            this.ListUser.TabIndex = 32;
            this.ListUser.Text = "Display All Books";
            this.ListUser.UseVisualStyleBackColor = true;
            this.ListUser.Click += new System.EventHandler(this.ListUser_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.LabelMessage);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.comboBox1);
            this.groupBox5.Controls.Add(this.textBoxSearch);
            this.groupBox5.Controls.Add(this.searchButton);
            this.groupBox5.Location = new System.Drawing.Point(534, 31);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox5.Size = new System.Drawing.Size(293, 222);
            this.groupBox5.TabIndex = 47;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Search";
            // 
            // LabelMessage
            // 
            this.LabelMessage.AutoSize = true;
            this.LabelMessage.Location = new System.Drawing.Point(129, 62);
            this.LabelMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelMessage.Name = "LabelMessage";
            this.LabelMessage.Size = new System.Drawing.Size(0, 13);
            this.LabelMessage.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 42);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Select one option:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(86, 71);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 34;
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "User Id",
            "First Name",
            "Last Name",
            "Job Title"});
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Select an option",
            "ISBN",
            "Title"});
            this.comboBox1.Location = new System.Drawing.Point(128, 39);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 21);
            this.comboBox1.TabIndex = 31;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(128, 99);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(140, 20);
            this.textBoxSearch.TabIndex = 25;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(160, 156);
            this.searchButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 41);
            this.searchButton.TabIndex = 29;
            this.searchButton.Text = "&Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Transparent;
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.textBoxQOH);
            this.groupBox6.Controls.Add(this.deleleBtn);
            this.groupBox6.Controls.Add(this.addButton);
            this.groupBox6.Controls.Add(this.textBoxtitle);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.TextboxISBN);
            this.groupBox6.Controls.Add(this.textBoxunit);
            this.groupBox6.Controls.Add(this.textBoxyear);
            this.groupBox6.Controls.Add(this.updateButton);
            this.groupBox6.Location = new System.Drawing.Point(79, 23);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox6.Size = new System.Drawing.Size(422, 283);
            this.groupBox6.TabIndex = 46;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Book Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 248);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Quantity on Hand(QOH):";
            // 
            // textBoxQOH
            // 
            this.textBoxQOH.Location = new System.Drawing.Point(153, 245);
            this.textBoxQOH.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxQOH.Name = "textBoxQOH";
            this.textBoxQOH.Size = new System.Drawing.Size(140, 20);
            this.textBoxQOH.TabIndex = 34;
            // 
            // deleleBtn
            // 
            this.deleleBtn.Location = new System.Drawing.Point(326, 199);
            this.deleleBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.deleleBtn.Name = "deleleBtn";
            this.deleleBtn.Size = new System.Drawing.Size(75, 41);
            this.deleleBtn.TabIndex = 32;
            this.deleleBtn.Text = "&Delete";
            this.deleleBtn.UseVisualStyleBackColor = true;
            this.deleleBtn.Click += new System.EventHandler(this.deleleBtn_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(326, 69);
            this.addButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 41);
            this.addButton.TabIndex = 30;
            this.addButton.Text = "&Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // textBoxtitle
            // 
            this.textBoxtitle.Location = new System.Drawing.Point(153, 93);
            this.textBoxtitle.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxtitle.Name = "textBoxtitle";
            this.textBoxtitle.Size = new System.Drawing.Size(140, 20);
            this.textBoxtitle.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 37);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "ISBN:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 95);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Title:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 148);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Unit Price:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 198);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Year Published:";
            // 
            // TextboxISBN
            // 
            this.TextboxISBN.Location = new System.Drawing.Point(153, 36);
            this.TextboxISBN.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TextboxISBN.Name = "TextboxISBN";
            this.TextboxISBN.Size = new System.Drawing.Size(140, 20);
            this.TextboxISBN.TabIndex = 21;
            // 
            // textBoxunit
            // 
            this.textBoxunit.Location = new System.Drawing.Point(153, 147);
            this.textBoxunit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxunit.Name = "textBoxunit";
            this.textBoxunit.Size = new System.Drawing.Size(140, 20);
            this.textBoxunit.TabIndex = 23;
            // 
            // textBoxyear
            // 
            this.textBoxyear.Location = new System.Drawing.Point(153, 199);
            this.textBoxyear.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxyear.Name = "textBoxyear";
            this.textBoxyear.Size = new System.Drawing.Size(140, 20);
            this.textBoxyear.TabIndex = 24;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(326, 131);
            this.updateButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 41);
            this.updateButton.TabIndex = 27;
            this.updateButton.Text = "&Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(840, 551);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 41);
            this.buttonExit.TabIndex = 49;
            this.buttonExit.Text = "Logout";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // BooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(926, 628);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox6);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "BooksForm";
            this.Text = "BooksForm";
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button ListUser;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxQOH;
        private System.Windows.Forms.Button deleleBtn;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox textBoxtitle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TextboxISBN;
        private System.Windows.Forms.TextBox textBoxunit;
        private System.Windows.Forms.TextBox textBoxyear;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label LabelMessage;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ListView listView4;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}