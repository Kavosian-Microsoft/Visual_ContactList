namespace Visual_ContactList
{
    partial class frmContactList
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
            this.grbContactList = new System.Windows.Forms.GroupBox();
            this.dgvContacts = new System.Windows.Forms.DataGridView();
            this.grbEditData = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPhoneWork = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPhoneHome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContactID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNewContact = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnFirstRecord = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.contactIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneHomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneWorkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblContactBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactListDataDataSet = new Visual_ContactList.ContactListDataDataSet();
            this.tbl_ContactTableAdapter = new Visual_ContactList.ContactListDataDataSetTableAdapters.tbl_ContactTableAdapter();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFirstNameSearch = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtLastNameSearch = new System.Windows.Forms.TextBox();
            this.grbSearch = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnListAll = new System.Windows.Forms.Button();
            this.grbContactList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).BeginInit();
            this.grbEditData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblContactBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactListDataDataSet)).BeginInit();
            this.grbSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbContactList
            // 
            this.grbContactList.Controls.Add(this.dgvContacts);
            this.grbContactList.Location = new System.Drawing.Point(13, 13);
            this.grbContactList.Name = "grbContactList";
            this.grbContactList.Size = new System.Drawing.Size(755, 205);
            this.grbContactList.TabIndex = 0;
            this.grbContactList.TabStop = false;
            this.grbContactList.Text = "List of contacts";
            // 
            // dgvContacts
            // 
            this.dgvContacts.AutoGenerateColumns = false;
            this.dgvContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContacts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.contactIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.telephoneHomeDataGridViewTextBoxColumn,
            this.telephoneWorkDataGridViewTextBoxColumn,
            this.mobileDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.dgvContacts.DataSource = this.tblContactBindingSource;
            this.dgvContacts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvContacts.Location = new System.Drawing.Point(3, 33);
            this.dgvContacts.Name = "dgvContacts";
            this.dgvContacts.Size = new System.Drawing.Size(749, 169);
            this.dgvContacts.TabIndex = 0;
            this.dgvContacts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContacts_CellClick);
            // 
            // grbEditData
            // 
            this.grbEditData.Controls.Add(this.btnCancel);
            this.grbEditData.Controls.Add(this.btnSave);
            this.grbEditData.Controls.Add(this.txtAddress);
            this.grbEditData.Controls.Add(this.label8);
            this.grbEditData.Controls.Add(this.txtMobile);
            this.grbEditData.Controls.Add(this.label7);
            this.grbEditData.Controls.Add(this.txtPhoneWork);
            this.grbEditData.Controls.Add(this.label6);
            this.grbEditData.Controls.Add(this.txtPhoneHome);
            this.grbEditData.Controls.Add(this.label5);
            this.grbEditData.Controls.Add(this.txtEmail);
            this.grbEditData.Controls.Add(this.label4);
            this.grbEditData.Controls.Add(this.txtLastname);
            this.grbEditData.Controls.Add(this.label3);
            this.grbEditData.Controls.Add(this.txtFirstName);
            this.grbEditData.Controls.Add(this.label2);
            this.grbEditData.Controls.Add(this.txtContactID);
            this.grbEditData.Controls.Add(this.label1);
            this.grbEditData.Enabled = false;
            this.grbEditData.Location = new System.Drawing.Point(13, 316);
            this.grbEditData.Name = "grbEditData";
            this.grbEditData.Size = new System.Drawing.Size(755, 251);
            this.grbEditData.TabIndex = 1;
            this.grbEditData.TabStop = false;
            this.grbEditData.Text = "Contact Info";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.GreenYellow;
            this.btnCancel.Location = new System.Drawing.Point(152, 206);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(126, 39);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Lime;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.Maroon;
            this.btnSave.Location = new System.Drawing.Point(20, 206);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(126, 39);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(472, 143);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(277, 66);
            this.txtAddress.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(333, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 29);
            this.label8.TabIndex = 14;
            this.label8.Text = "Address:";
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(472, 103);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(189, 37);
            this.txtMobile.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(333, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 29);
            this.label7.TabIndex = 12;
            this.label7.Text = "Mobile:";
            // 
            // txtPhoneWork
            // 
            this.txtPhoneWork.Location = new System.Drawing.Point(472, 63);
            this.txtPhoneWork.Name = "txtPhoneWork";
            this.txtPhoneWork.Size = new System.Drawing.Size(189, 37);
            this.txtPhoneWork.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(333, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 29);
            this.label6.TabIndex = 10;
            this.label6.Text = "Phone Work:";
            // 
            // txtPhoneHome
            // 
            this.txtPhoneHome.Location = new System.Drawing.Point(472, 25);
            this.txtPhoneHome.Name = "txtPhoneHome";
            this.txtPhoneHome.Size = new System.Drawing.Size(189, 37);
            this.txtPhoneHome.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(330, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "Phone Home:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(149, 143);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(178, 37);
            this.txtEmail.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email:";
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(149, 104);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(178, 37);
            this.txtLastname.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(149, 65);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(178, 37);
            this.txtFirstName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "First name:";
            // 
            // txtContactID
            // 
            this.txtContactID.BackColor = System.Drawing.Color.OrangeRed;
            this.txtContactID.Location = new System.Drawing.Point(149, 25);
            this.txtContactID.Name = "txtContactID";
            this.txtContactID.ReadOnly = true;
            this.txtContactID.Size = new System.Drawing.Size(107, 37);
            this.txtContactID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contact ID:";
            // 
            // btnNewContact
            // 
            this.btnNewContact.BackColor = System.Drawing.Color.Chartreuse;
            this.btnNewContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewContact.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewContact.ForeColor = System.Drawing.Color.Maroon;
            this.btnNewContact.Location = new System.Drawing.Point(774, 46);
            this.btnNewContact.Name = "btnNewContact";
            this.btnNewContact.Size = new System.Drawing.Size(126, 39);
            this.btnNewContact.TabIndex = 0;
            this.btnNewContact.Text = "&New Cintact";
            this.btnNewContact.UseVisualStyleBackColor = false;
            this.btnNewContact.Click += new System.EventHandler(this.btnNewContact_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Gold;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Maroon;
            this.btnEdit.Location = new System.Drawing.Point(774, 91);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(126, 39);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "&Edit Contact";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.GreenYellow;
            this.btnDelete.Location = new System.Drawing.Point(774, 136);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(126, 39);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnFirstRecord
            // 
            this.btnFirstRecord.BackColor = System.Drawing.Color.DarkGreen;
            this.btnFirstRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirstRecord.ForeColor = System.Drawing.Color.GreenYellow;
            this.btnFirstRecord.Location = new System.Drawing.Point(774, 181);
            this.btnFirstRecord.Name = "btnFirstRecord";
            this.btnFirstRecord.Size = new System.Drawing.Size(126, 39);
            this.btnFirstRecord.TabIndex = 3;
            this.btnFirstRecord.Text = "&First";
            this.btnFirstRecord.UseVisualStyleBackColor = false;
            this.btnFirstRecord.Click += new System.EventHandler(this.btnFirstRecord_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.OrangeRed;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.ForeColor = System.Drawing.Color.GreenYellow;
            this.btnNext.Location = new System.Drawing.Point(774, 226);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(126, 39);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "Ne&xt";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.DarkOrange;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.ForeColor = System.Drawing.Color.GreenYellow;
            this.btnPrevious.Location = new System.Drawing.Point(774, 271);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(126, 39);
            this.btnPrevious.TabIndex = 5;
            this.btnPrevious.Text = "&Previous";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.Color.DarkGreen;
            this.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast.ForeColor = System.Drawing.Color.GreenYellow;
            this.btnLast.Location = new System.Drawing.Point(774, 316);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(126, 39);
            this.btnLast.TabIndex = 6;
            this.btnLast.Text = "&Last";
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // contactIDDataGridViewTextBoxColumn
            // 
            this.contactIDDataGridViewTextBoxColumn.DataPropertyName = "ContactID";
            this.contactIDDataGridViewTextBoxColumn.HeaderText = "ContactID";
            this.contactIDDataGridViewTextBoxColumn.Name = "contactIDDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // telephoneHomeDataGridViewTextBoxColumn
            // 
            this.telephoneHomeDataGridViewTextBoxColumn.DataPropertyName = "Telephone_Home";
            this.telephoneHomeDataGridViewTextBoxColumn.HeaderText = "Telephone_Home";
            this.telephoneHomeDataGridViewTextBoxColumn.Name = "telephoneHomeDataGridViewTextBoxColumn";
            // 
            // telephoneWorkDataGridViewTextBoxColumn
            // 
            this.telephoneWorkDataGridViewTextBoxColumn.DataPropertyName = "Telephone_Work";
            this.telephoneWorkDataGridViewTextBoxColumn.HeaderText = "Telephone_Work";
            this.telephoneWorkDataGridViewTextBoxColumn.Name = "telephoneWorkDataGridViewTextBoxColumn";
            // 
            // mobileDataGridViewTextBoxColumn
            // 
            this.mobileDataGridViewTextBoxColumn.DataPropertyName = "Mobile";
            this.mobileDataGridViewTextBoxColumn.HeaderText = "Mobile";
            this.mobileDataGridViewTextBoxColumn.Name = "mobileDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // tblContactBindingSource
            // 
            this.tblContactBindingSource.DataMember = "tbl_Contact";
            this.tblContactBindingSource.DataSource = this.contactListDataDataSet;
            // 
            // contactListDataDataSet
            // 
            this.contactListDataDataSet.DataSetName = "ContactListDataDataSet";
            this.contactListDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_ContactTableAdapter
            // 
            this.tbl_ContactTableAdapter.ClearBeforeFill = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 29);
            this.label9.TabIndex = 7;
            this.label9.Text = "Name:";
            // 
            // txtFirstNameSearch
            // 
            this.txtFirstNameSearch.Location = new System.Drawing.Point(93, 36);
            this.txtFirstNameSearch.Name = "txtFirstNameSearch";
            this.txtFirstNameSearch.Size = new System.Drawing.Size(144, 37);
            this.txtFirstNameSearch.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(243, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 29);
            this.label10.TabIndex = 9;
            this.label10.Text = "Last Name:";
            // 
            // txtLastNameSearch
            // 
            this.txtLastNameSearch.Location = new System.Drawing.Point(371, 36);
            this.txtLastNameSearch.Name = "txtLastNameSearch";
            this.txtLastNameSearch.Size = new System.Drawing.Size(249, 37);
            this.txtLastNameSearch.TabIndex = 10;
            // 
            // grbSearch
            // 
            this.grbSearch.Controls.Add(this.btnSearch);
            this.grbSearch.Controls.Add(this.txtLastNameSearch);
            this.grbSearch.Controls.Add(this.txtFirstNameSearch);
            this.grbSearch.Controls.Add(this.label9);
            this.grbSearch.Controls.Add(this.label10);
            this.grbSearch.Location = new System.Drawing.Point(13, 226);
            this.grbSearch.Name = "grbSearch";
            this.grbSearch.Size = new System.Drawing.Size(752, 84);
            this.grbSearch.TabIndex = 11;
            this.grbSearch.TabStop = false;
            this.grbSearch.Text = "Search";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.SpringGreen;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.Chocolate;
            this.btnSearch.Location = new System.Drawing.Point(626, 38);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(120, 34);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnListAll
            // 
            this.btnListAll.BackColor = System.Drawing.Color.SpringGreen;
            this.btnListAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListAll.ForeColor = System.Drawing.Color.Chocolate;
            this.btnListAll.Location = new System.Drawing.Point(774, 361);
            this.btnListAll.Name = "btnListAll";
            this.btnListAll.Size = new System.Drawing.Size(126, 48);
            this.btnListAll.TabIndex = 12;
            this.btnListAll.Text = "List &All";
            this.btnListAll.UseVisualStyleBackColor = false;
            this.btnListAll.Click += new System.EventHandler(this.btnListAll_Click);
            // 
            // frmContactList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 574);
            this.Controls.Add(this.btnListAll);
            this.Controls.Add(this.grbSearch);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnFirstRecord);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNewContact);
            this.Controls.Add(this.grbEditData);
            this.Controls.Add(this.grbContactList);
            this.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.Name = "frmContactList";
            this.Load += new System.EventHandler(this.frmContactList_Load);
            this.grbContactList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).EndInit();
            this.grbEditData.ResumeLayout(false);
            this.grbEditData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblContactBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactListDataDataSet)).EndInit();
            this.grbSearch.ResumeLayout(false);
            this.grbSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbContactList;
        private System.Windows.Forms.GroupBox grbEditData;
        private System.Windows.Forms.DataGridView dgvContacts;
        private ContactListDataDataSet contactListDataDataSet;
        private System.Windows.Forms.BindingSource tblContactBindingSource;
        private ContactListDataDataSetTableAdapters.tbl_ContactTableAdapter tbl_ContactTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneHomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneWorkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPhoneHome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtContactID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPhoneWork;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnNewContact;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnFirstRecord;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFirstNameSearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtLastNameSearch;
        private System.Windows.Forms.GroupBox grbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnListAll;
    }
}

