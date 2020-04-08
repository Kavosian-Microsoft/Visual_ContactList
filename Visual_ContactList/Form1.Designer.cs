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
            this.tbl_ContactTableAdapter = new Visual_ContactList.ContactListDataDataSetTableAdapters.tbl_ContactTableAdapter();
            this.btnNewContact = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grbContactList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblContactBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactListDataDataSet)).BeginInit();
            this.grbEditData.SuspendLayout();
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
            this.grbEditData.Location = new System.Drawing.Point(12, 231);
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
            this.btnCancel.TabIndex = 16;
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
            this.btnSave.TabIndex = 16;
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
            this.txtAddress.TabIndex = 15;
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
            this.txtMobile.TabIndex = 13;
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
            this.txtPhoneWork.TabIndex = 11;
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
            this.txtPhoneHome.TabIndex = 9;
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
            this.txtEmail.TabIndex = 7;
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
            this.txtLastname.TabIndex = 5;
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
            // tbl_ContactTableAdapter
            // 
            this.tbl_ContactTableAdapter.ClearBeforeFill = true;
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
            this.btnNewContact.TabIndex = 17;
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
            this.btnEdit.TabIndex = 18;
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
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmContactList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 484);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNewContact);
            this.Controls.Add(this.grbEditData);
            this.Controls.Add(this.grbContactList);
            this.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "frmContactList";
            this.Load += new System.EventHandler(this.frmContactList_Load);
            this.grbContactList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblContactBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactListDataDataSet)).EndInit();
            this.grbEditData.ResumeLayout(false);
            this.grbEditData.PerformLayout();
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
    }
}

