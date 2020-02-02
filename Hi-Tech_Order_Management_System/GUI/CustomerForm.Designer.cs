namespace Hi_Tech_Order_Management_System.GUI
{
    partial class CustomerForm
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
            this.hitechDBDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hitechDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label18 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.labelMessage = new System.Windows.Forms.Label();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.postal = new System.Windows.Forms.TextBox();
            this.phoneno = new System.Windows.Forms.TextBox();
            this.fax = new System.Windows.Forms.TextBox();
            this.credit = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label_street = new System.Windows.Forms.Label();
            this.label_credit = new System.Windows.Forms.Label();
            this.label_fax = new System.Windows.Forms.Label();
            this.label_phone = new System.Windows.Forms.Label();
            this.label_postal = new System.Windows.Forms.Label();
            this.label_city = new System.Windows.Forms.Label();
            this.label_customer = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.street = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.hitechDBDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hitechDBDataSetBindingSource)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(80, 50);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(0, 13);
            this.label18.TabIndex = 17;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(76, 79);
            this.textBox12.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(140, 20);
            this.textBox12.TabIndex = 8;
            this.textBox12.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Select the search Option",
            "Customer ID",
            "Name"});
            this.comboBox2.Location = new System.Drawing.Point(76, 43);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(140, 21);
            this.comboBox2.TabIndex = 14;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.Color.Transparent;
            this.groupBox8.Controls.Add(this.labelMessage);
            this.groupBox8.Controls.Add(this.comboBox2);
            this.groupBox8.Controls.Add(this.textBox12);
            this.groupBox8.Controls.Add(this.label18);
            this.groupBox8.Location = new System.Drawing.Point(479, 244);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox8.Size = new System.Drawing.Size(290, 178);
            this.groupBox8.TabIndex = 28;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Search Customer";
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.ForeColor = System.Drawing.Color.Red;
            this.labelMessage.Location = new System.Drawing.Point(74, 23);
            this.labelMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(0, 13);
            this.labelMessage.TabIndex = 41;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(332, 138);
            this.UpdateBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(75, 41);
            this.UpdateBtn.TabIndex = 15;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(26, 47);
            this.button11.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(150, 24);
            this.button11.TabIndex = 15;
            this.button11.Text = "List Of Customers";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.BackColor = System.Drawing.Color.Transparent;
            this.groupBox9.Controls.Add(this.dataGridView);
            this.groupBox9.Controls.Add(this.button11);
            this.groupBox9.Location = new System.Drawing.Point(11, 244);
            this.groupBox9.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox9.Size = new System.Drawing.Size(441, 294);
            this.groupBox9.TabIndex = 30;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "List Of Customers";
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(26, 93);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(1);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 40;
            this.dataGridView.Size = new System.Drawing.Size(389, 149);
            this.dataGridView.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(617, 76);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Street";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(448, 21);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(24, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "City";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(638, 21);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Postal Code";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(17, 82);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "Phone Number";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(221, 76);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 13);
            this.label16.TabIndex = 5;
            this.label16.Text = "Fax Number";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(432, 76);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 13);
            this.label17.TabIndex = 6;
            this.label17.Text = "Credit Limit";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(4, 37);
            this.name.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(117, 20);
            this.name.TabIndex = 7;
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(160, 37);
            this.id.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(179, 20);
            this.id.TabIndex = 8;
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(379, 37);
            this.city.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(158, 20);
            this.city.TabIndex = 9;
            // 
            // postal
            // 
            this.postal.Location = new System.Drawing.Point(578, 37);
            this.postal.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.postal.Name = "postal";
            this.postal.Size = new System.Drawing.Size(180, 20);
            this.postal.TabIndex = 10;
            // 
            // phoneno
            // 
            this.phoneno.Location = new System.Drawing.Point(4, 98);
            this.phoneno.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.phoneno.Name = "phoneno";
            this.phoneno.Size = new System.Drawing.Size(117, 20);
            this.phoneno.TabIndex = 11;
            // 
            // fax
            // 
            this.fax.Location = new System.Drawing.Point(160, 98);
            this.fax.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.fax.Name = "fax";
            this.fax.Size = new System.Drawing.Size(189, 20);
            this.fax.TabIndex = 12;
            // 
            // credit
            // 
            this.credit.Location = new System.Drawing.Point(379, 98);
            this.credit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.credit.Name = "credit";
            this.credit.Size = new System.Drawing.Size(140, 20);
            this.credit.TabIndex = 13;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(138, 138);
            this.button8.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 41);
            this.button8.TabIndex = 14;
            this.button8.Text = "Add";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click_1);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(549, 138);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 41);
            this.DeleteBtn.TabIndex = 16;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.Transparent;
            this.groupBox7.Controls.Add(this.label_street);
            this.groupBox7.Controls.Add(this.label_credit);
            this.groupBox7.Controls.Add(this.label_fax);
            this.groupBox7.Controls.Add(this.UpdateBtn);
            this.groupBox7.Controls.Add(this.label_phone);
            this.groupBox7.Controls.Add(this.label_postal);
            this.groupBox7.Controls.Add(this.label_city);
            this.groupBox7.Controls.Add(this.label_customer);
            this.groupBox7.Controls.Add(this.label_name);
            this.groupBox7.Controls.Add(this.labelPhone);
            this.groupBox7.Controls.Add(this.label1);
            this.groupBox7.Controls.Add(this.street);
            this.groupBox7.Controls.Add(this.DeleteBtn);
            this.groupBox7.Controls.Add(this.button8);
            this.groupBox7.Controls.Add(this.credit);
            this.groupBox7.Controls.Add(this.fax);
            this.groupBox7.Controls.Add(this.phoneno);
            this.groupBox7.Controls.Add(this.postal);
            this.groupBox7.Controls.Add(this.city);
            this.groupBox7.Controls.Add(this.id);
            this.groupBox7.Controls.Add(this.name);
            this.groupBox7.Controls.Add(this.label17);
            this.groupBox7.Controls.Add(this.label16);
            this.groupBox7.Controls.Add(this.label15);
            this.groupBox7.Controls.Add(this.label14);
            this.groupBox7.Controls.Add(this.label13);
            this.groupBox7.Controls.Add(this.label12);
            this.groupBox7.Controls.Add(this.label11);
            this.groupBox7.Location = new System.Drawing.Point(11, 12);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox7.Size = new System.Drawing.Size(791, 203);
            this.groupBox7.TabIndex = 31;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Customer Information";
            // 
            // label_street
            // 
            this.label_street.AutoSize = true;
            this.label_street.ForeColor = System.Drawing.Color.Red;
            this.label_street.Location = new System.Drawing.Point(581, 117);
            this.label_street.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_street.Name = "label_street";
            this.label_street.Size = new System.Drawing.Size(0, 13);
            this.label_street.TabIndex = 40;
            // 
            // label_credit
            // 
            this.label_credit.AutoSize = true;
            this.label_credit.ForeColor = System.Drawing.Color.Red;
            this.label_credit.Location = new System.Drawing.Point(381, 117);
            this.label_credit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_credit.Name = "label_credit";
            this.label_credit.Size = new System.Drawing.Size(0, 13);
            this.label_credit.TabIndex = 39;
            // 
            // label_fax
            // 
            this.label_fax.AutoSize = true;
            this.label_fax.ForeColor = System.Drawing.Color.Red;
            this.label_fax.Location = new System.Drawing.Point(170, 117);
            this.label_fax.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_fax.Name = "label_fax";
            this.label_fax.Size = new System.Drawing.Size(0, 13);
            this.label_fax.TabIndex = 38;
            // 
            // label_phone
            // 
            this.label_phone.AutoSize = true;
            this.label_phone.ForeColor = System.Drawing.Color.Red;
            this.label_phone.Location = new System.Drawing.Point(9, 122);
            this.label_phone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_phone.Name = "label_phone";
            this.label_phone.Size = new System.Drawing.Size(0, 13);
            this.label_phone.TabIndex = 37;
            // 
            // label_postal
            // 
            this.label_postal.AutoSize = true;
            this.label_postal.ForeColor = System.Drawing.Color.Red;
            this.label_postal.Location = new System.Drawing.Point(588, 56);
            this.label_postal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_postal.Name = "label_postal";
            this.label_postal.Size = new System.Drawing.Size(0, 13);
            this.label_postal.TabIndex = 36;
            // 
            // label_city
            // 
            this.label_city.AutoSize = true;
            this.label_city.ForeColor = System.Drawing.Color.Red;
            this.label_city.Location = new System.Drawing.Point(390, 62);
            this.label_city.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_city.Name = "label_city";
            this.label_city.Size = new System.Drawing.Size(0, 13);
            this.label_city.TabIndex = 35;
            // 
            // label_customer
            // 
            this.label_customer.AutoSize = true;
            this.label_customer.ForeColor = System.Drawing.Color.Red;
            this.label_customer.Location = new System.Drawing.Point(170, 62);
            this.label_customer.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label_customer.Name = "label_customer";
            this.label_customer.Size = new System.Drawing.Size(0, 13);
            this.label_customer.TabIndex = 34;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.ForeColor = System.Drawing.Color.Red;
            this.label_name.Location = new System.Drawing.Point(17, 62);
            this.label_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(0, 13);
            this.label_name.TabIndex = 33;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.ForeColor = System.Drawing.Color.Red;
            this.labelPhone.Location = new System.Drawing.Point(9, 122);
            this.labelPhone.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(0, 13);
            this.labelPhone.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "CustomerId";
            // 
            // street
            // 
            this.street.Location = new System.Drawing.Point(571, 98);
            this.street.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.street.Name = "street";
            this.street.Size = new System.Drawing.Size(140, 20);
            this.street.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 21);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Name";
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Transparent;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(479, 497);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 41);
            this.buttonExit.TabIndex = 18;
            this.buttonExit.Text = "Logout";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(917, 572);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox8);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hitechDBDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hitechDBDataSetBindingSource)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource hitechDBDataSetBindingSource;
        private System.Windows.Forms.BindingSource hitechDBDataSetBindingSource1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.TextBox postal;
        private System.Windows.Forms.TextBox phoneno;
        private System.Windows.Forms.TextBox fax;
        private System.Windows.Forms.TextBox credit;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox street;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label_customer;
        private System.Windows.Forms.Label label_city;
        private System.Windows.Forms.Label label_postal;
        private System.Windows.Forms.Label label_phone;
        private System.Windows.Forms.Label label_fax;
        private System.Windows.Forms.Label label_credit;
        private System.Windows.Forms.Label label_street;
        private System.Windows.Forms.Label labelMessage;
    }
}