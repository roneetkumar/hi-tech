namespace Hi_Tech_Order_Management_System.GUI
{
    partial class OrderForm
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
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listViewDisplay = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListUser = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.comboBoxsearch = new System.Windows.Forms.ComboBox();
            this.LabelMessage = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedTextBoxArrivalDate = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedTextBoxPlacedDate = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxPublisher = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxCustomer = new System.Windows.Forms.ComboBox();
            this.deleleBtn = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TextboxOrderId = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Transparent;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonExit.Location = new System.Drawing.Point(850, 544);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 41);
            this.buttonExit.TabIndex = 53;
            this.buttonExit.Text = "Logout";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.listViewDisplay);
            this.groupBox4.Controls.Add(this.ListUser);
            this.groupBox4.Location = new System.Drawing.Point(41, 323);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox4.Size = new System.Drawing.Size(766, 262);
            this.groupBox4.TabIndex = 52;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "List of Orders";
            // 
            // listViewDisplay
            // 
            this.listViewDisplay.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewDisplay.GridLines = true;
            this.listViewDisplay.HideSelection = false;
            this.listViewDisplay.Location = new System.Drawing.Point(18, 69);
            this.listViewDisplay.Name = "listViewDisplay";
            this.listViewDisplay.Size = new System.Drawing.Size(730, 137);
            this.listViewDisplay.TabIndex = 33;
            this.listViewDisplay.UseCompatibleStateImageBehavior = false;
            this.listViewDisplay.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Order ID";
            this.columnHeader1.Width = 116;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Placed Date";
            this.columnHeader2.Width = 146;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Estimated Delivery Date";
            this.columnHeader3.Width = 127;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Employee Id";
            this.columnHeader4.Width = 183;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Customer ID";
            this.columnHeader5.Width = 489;
            // 
            // ListUser
            // 
            this.ListUser.Location = new System.Drawing.Point(115, 17);
            this.ListUser.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ListUser.Name = "ListUser";
            this.ListUser.Size = new System.Drawing.Size(150, 24);
            this.ListUser.TabIndex = 32;
            this.ListUser.Text = "Display All Order";
            this.ListUser.UseVisualStyleBackColor = true;
            this.ListUser.Click += new System.EventHandler(this.ListUser_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.comboBoxsearch);
            this.groupBox5.Controls.Add(this.LabelMessage);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.searchButton);
            this.groupBox5.Location = new System.Drawing.Point(496, 16);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox5.Size = new System.Drawing.Size(293, 222);
            this.groupBox5.TabIndex = 51;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Search";
            // 
            // comboBoxsearch
            // 
            this.comboBoxsearch.Enabled = false;
            this.comboBoxsearch.FormattingEnabled = true;
            this.comboBoxsearch.Location = new System.Drawing.Point(128, 55);
            this.comboBoxsearch.Margin = new System.Windows.Forms.Padding(1);
            this.comboBoxsearch.Name = "comboBoxsearch";
            this.comboBoxsearch.Size = new System.Drawing.Size(140, 21);
            this.comboBoxsearch.TabIndex = 43;
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
            this.label5.Location = new System.Drawing.Point(27, 58);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Select OrderId:";
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
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.maskedTextBoxArrivalDate);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.maskedTextBoxPlacedDate);
            this.groupBox6.Controls.Add(this.comboBoxPublisher);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.comboBoxCustomer);
            this.groupBox6.Controls.Add(this.deleleBtn);
            this.groupBox6.Controls.Add(this.addButton);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.TextboxOrderId);
            this.groupBox6.Controls.Add(this.updateButton);
            this.groupBox6.Location = new System.Drawing.Point(41, 9);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox6.Size = new System.Drawing.Size(422, 283);
            this.groupBox6.TabIndex = 50;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Order Information";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "(mm/dd/yyyy)";
            // 
            // maskedTextBoxArrivalDate
            // 
            this.maskedTextBoxArrivalDate.Location = new System.Drawing.Point(153, 118);
            this.maskedTextBoxArrivalDate.Mask = "00/00/0000";
            this.maskedTextBoxArrivalDate.Name = "maskedTextBoxArrivalDate";
            this.maskedTextBoxArrivalDate.Size = new System.Drawing.Size(140, 20);
            this.maskedTextBoxArrivalDate.TabIndex = 41;
            this.maskedTextBoxArrivalDate.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "(mm/dd/yyyy)";
            // 
            // maskedTextBoxPlacedDate
            // 
            this.maskedTextBoxPlacedDate.Location = new System.Drawing.Point(153, 76);
            this.maskedTextBoxPlacedDate.Mask = "00/00/0000";
            this.maskedTextBoxPlacedDate.Name = "maskedTextBoxPlacedDate";
            this.maskedTextBoxPlacedDate.Size = new System.Drawing.Size(140, 20);
            this.maskedTextBoxPlacedDate.TabIndex = 39;
            this.maskedTextBoxPlacedDate.ValidatingType = typeof(System.DateTime);
            this.maskedTextBoxPlacedDate.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxPlacedDate_MaskInputRejected);
            // 
            // comboBoxPublisher
            // 
            this.comboBoxPublisher.FormattingEnabled = true;
            this.comboBoxPublisher.Location = new System.Drawing.Point(153, 167);
            this.comboBoxPublisher.Margin = new System.Windows.Forms.Padding(1);
            this.comboBoxPublisher.Name = "comboBoxPublisher";
            this.comboBoxPublisher.Size = new System.Drawing.Size(140, 21);
            this.comboBoxPublisher.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 164);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Employee ID";
            // 
            // comboBoxCustomer
            // 
            this.comboBoxCustomer.FormattingEnabled = true;
            this.comboBoxCustomer.Location = new System.Drawing.Point(153, 196);
            this.comboBoxCustomer.Margin = new System.Windows.Forms.Padding(1);
            this.comboBoxCustomer.Name = "comboBoxCustomer";
            this.comboBoxCustomer.Size = new System.Drawing.Size(140, 21);
            this.comboBoxCustomer.TabIndex = 35;
            this.comboBoxCustomer.SelectedIndexChanged += new System.EventHandler(this.comboBoxCustomer_SelectedIndexChanged);
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 37);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Order ID:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 78);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Place Date:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 119);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Estimate Delivary Date:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 198);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Customer ID:";
            // 
            // TextboxOrderId
            // 
            this.TextboxOrderId.Location = new System.Drawing.Point(153, 36);
            this.TextboxOrderId.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TextboxOrderId.Name = "TextboxOrderId";
            this.TextboxOrderId.Size = new System.Drawing.Size(140, 20);
            this.TextboxOrderId.TabIndex = 21;
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
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 648);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox6);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button ListUser;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label LabelMessage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button deleleBtn;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TextboxOrderId;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.ComboBox comboBoxCustomer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxArrivalDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPlacedDate;
        private System.Windows.Forms.ComboBox comboBoxPublisher;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listViewDisplay;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ComboBox comboBoxsearch;
    }
}