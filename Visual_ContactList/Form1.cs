using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual_ContactList
{
    public partial class frmContactList : Form
    {
        //-----------------------------------------------------------------------------------------
        public enum DataBaseOperation
        {
            Create = 0,
            Read = 1,
            Update = 2,
            Delete = 3
        };
        //---------------------------------- Global Variables ------------------------------------
        DataBaseOperation _currentOperation;
        //-----------------------------------------------------------------------------------------

        public frmContactList()
        {
            InitializeComponent();
        }//frmContactList
        //-----------------------------------------------------------------------------------------
        private void frmContactList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'contactListDataDataSet.tbl_Contact' table. You can move, or remove it, as needed.
            this.tbl_ContactTableAdapter.Fill(this.contactListDataDataSet.tbl_Contact);
            _currentOperation = DataBaseOperation.Read;
            this.Text = Properties.Resources.EnglishProgramTitle;
        }//frmContactList_Load
        //-----------------------------------------------------------------------------------------
        private void clear_entry()
        {
            TextBox t = new TextBox();
            foreach (var item in grbEditData.Controls)
            {
                if (item.GetType() == t.GetType())
                {
                    t = (TextBox)item;
                    t.Clear();
                }//if it is a text box
            }//foreach
            foreach (var item in grbSearch.Controls)
            {
                if (item.GetType() == t.GetType())
                {
                    t = (TextBox)item;
                    t.Clear();
                }//if it is a text box
            }//foreach
        }//clear_entry
        //-----------------------------------------------------------------------------------------
        private bool check_data_entry()
        {
            bool result = false;
            if ((txtFirstName.Text.Length > 0) && (txtLastname.Text.Length > 0))
            {
                result = true;
            }//if
            return result;
        }//check_data_entry
        //-----------------------------------------------------------------------------------------
        private void dgvContacts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvContacts.CurrentRow.Cells[1].Value.ToString() != "")
            {
                txtContactID.Text = dgvContacts.CurrentRow.Cells[0].Value.ToString();
                txtFirstName.Text = dgvContacts.CurrentRow.Cells[1].Value.ToString();
                txtLastname.Text = dgvContacts.CurrentRow.Cells[2].Value.ToString();
                txtEmail.Text = dgvContacts.CurrentRow.Cells[3].Value.ToString();
                txtPhoneHome.Text = dgvContacts.CurrentRow.Cells[4].Value.ToString();
                txtPhoneWork.Text = dgvContacts.CurrentRow.Cells[5].Value.ToString();
                txtMobile.Text = dgvContacts.CurrentRow.Cells[6].Value.ToString();
                txtAddress.Text = dgvContacts.CurrentRow.Cells[7].Value.ToString();
            }//if


        }//dgvContacts_CellClick
        //-----------------------------------------------------------------------------------------
        private void btnCancel_Click(object sender, EventArgs e)
        {
            clear_entry();
            grbEditData.Enabled = false;
            _currentOperation = DataBaseOperation.Read;
            btnNewContact.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            clear_entry();
            tbl_ContactTableAdapter.Fill(contactListDataDataSet.tbl_Contact);
        }//btnCancel_Click
        //-----------------------------------------------------------------------------------------
        private void btnNewContact_Click(object sender, EventArgs e)
        {
            clear_entry();
            grbEditData.Enabled = true;
            _currentOperation = DataBaseOperation.Create;
            btnNewContact.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }//btnNewContact_Click
        //-----------------------------------------------------------------------------------------
        private void btnEdit_Click(object sender, EventArgs e)
        {
            string strTitle = Properties.Resources.EnglishProgramTitle;
            string strMessage = "";
            if (txtFirstName.Text.Length == 0)
            {
                strMessage = "Please select a contact first";
                MessageBox.Show(strMessage, strTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }//if nothing is selected
            else
            {
                _currentOperation = DataBaseOperation.Update;
                grbEditData.Enabled = true;
                btnNewContact.Enabled = false;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
            }//else if record is loaded
        }//btnEdit_Click
        //-----------------------------------------------------------------------------------------
        private void btnSave_Click(object sender, EventArgs e)
        {
            string strTitle = Properties.Resources.EnglishProgramTitle;
            string strMessage = "";
            if (check_data_entry())
            {
                if (_currentOperation == DataBaseOperation.Create)
                {
                    if (check_contact_existance())
                    {
                        strMessage = "The Contact Already exists";
                        MessageBox.Show(strMessage, strTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }//if contact already exists
                    else
                    {
                        tbl_ContactTableAdapter.InsertNewContact(txtFirstName.Text.Trim(), txtLastname.Text.Trim(), txtEmail.Text.Trim(), txtPhoneHome.Text, txtPhoneWork.Text.Trim(), txtMobile.Text.Trim(), txtAddress.Text.Trim());
                        tbl_ContactTableAdapter.Fill(contactListDataDataSet.tbl_Contact);
                        clear_entry();
                        grbEditData.Enabled = false;
                        btnNewContact.Enabled = true;
                        btnEdit.Enabled = true;
                        btnDelete.Enabled = true;
                        strMessage = "One Record is added";
                        MessageBox.Show(strMessage, strTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }//else if contact is unique
                }//if saving new contact
                else if (_currentOperation == DataBaseOperation.Update)
                {
                    if (check_contact_existance(int.Parse(txtContactID.Text), txtFirstName.Text, txtLastname.Text))
                    {
                        strMessage = "The Contact Already exists";
                        MessageBox.Show(strMessage, strTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }//if contact is duplicated 
                    else
                    {
                        tbl_ContactTableAdapter.UpdateContact(txtFirstName.Text.Trim(), txtLastname.Text.Trim(), txtEmail.Text.Trim(), txtPhoneHome.Text, txtPhoneWork.Text.Trim(), txtMobile.Text.Trim(), txtAddress.Text.Trim(), int.Parse(txtContactID.Text));
                        tbl_ContactTableAdapter.Fill(contactListDataDataSet.tbl_Contact);
                        clear_entry();
                        grbEditData.Enabled = false;
                        btnNewContact.Enabled = true;
                        btnEdit.Enabled = true;
                        btnDelete.Enabled = true;
                        strMessage = "One Record is updated";
                        MessageBox.Show(strMessage, strTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }//else if contact is unique
                }//else if updatuing 
            }//if data entry is acceeptable
            else
            {
                strMessage = "Please at least enter First and last name";
                MessageBox.Show(strMessage, strTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }//else if data missing
        }//btnSave_Click
        //-----------------------------------------------------------------------------------------
        private void btnDelete_Click(object sender, EventArgs e)
        {
            _currentOperation = DataBaseOperation.Delete;
            string strTitle = Properties.Resources.EnglishProgramTitle;
            string strMessage = "";
            if (txtFirstName.Text.Length == 0)
            {
                strMessage = "Please select a contact first";
                MessageBox.Show(strMessage, strTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }//if nothing is selected
            else
            {
                strMessage = "Are you sure that you want to remove the following record?";
                strMessage += "\n" + txtFirstName.Text + " " + txtLastname.Text;
                DialogResult res = MessageBox.Show(strMessage, strTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    int r = tbl_ContactTableAdapter.DeleteContact(int.Parse(txtContactID.Text));
                    if (r > 0)
                    {
                        tbl_ContactTableAdapter.Fill(contactListDataDataSet.tbl_Contact);
                        clear_entry();
                        strMessage = "One record is removed";
                        MessageBox.Show(strMessage, strTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }//if removed
                    else
                    {
                        strMessage = "It was not possible to remove record, please try again";
                        MessageBox.Show(strMessage, strTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }//else if delete was uncompleted 
                }//if Yes is clicked
            }//else if record is loaded
        }//btnDelete_Click
        //-----------------------------------------------------------------------------------------
        private bool check_contact_existance()
        {
            bool result = false;
            tbl_ContactTableAdapter.FillByFirstNameAndLastName(contactListDataDataSet.tbl_Contact, txtFirstName.Text.Trim(), txtLastname.Text.Trim());
            if (contactListDataDataSet.tbl_Contact.Rows.Count > 0)
            {
                result = true;
            }//if record already exists
            tbl_ContactTableAdapter.Fill(contactListDataDataSet.tbl_Contact);
            return result;
        }//check_contact_existance
        //-----------------------------------------------------------------------------------------
        private bool check_contact_existance(int contactID, string firstname, string lastname)
        {
            bool result = false;
            tbl_ContactTableAdapter.FillByFirstnameLastNameContactID(contactListDataDataSet.tbl_Contact, contactID, firstname, lastname);
            if (contactListDataDataSet.tbl_Contact.Rows.Count > 0)
            {
                result = true;
            }//if record already exists
            tbl_ContactTableAdapter.Fill(contactListDataDataSet.tbl_Contact);
            return result;
        }//check_contact_existance
        //-----------------------------------------------------------------------------------------
        private void btnFirstRecord_Click(object sender, EventArgs e)
        {
            tblContactBindingSource.MoveFirst();
        }//btnFirstRecord_Click
        //-----------------------------------------------------------------------------------------
        private void btnNext_Click(object sender, EventArgs e)
        {
            tblContactBindingSource.MoveNext();
        }//btnNext_Click
        //-----------------------------------------------------------------------------------------
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            tblContactBindingSource.MovePrevious();
        }//btnPrevious_Click
        //-----------------------------------------------------------------------------------------
        private void btnLast_Click(object sender, EventArgs e)
        {
            tblContactBindingSource.MoveLast();
        }//btnLast_Click
        //-----------------------------------------------------------------------------------------
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string strTitle = Properties.Resources.EnglishProgramTitle;
            string strMessage = "";


            if ((txtFirstNameSearch.Text.Length == 0) && (txtLastNameSearch.Text.Length == 0))
            {
                strMessage = "Search is possible on First and Last name of the contact";
                MessageBox.Show(strMessage, strTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }//if searchbox is empty
            else {
                if ((txtFirstNameSearch.Text.Length > 0) && (txtLastNameSearch.Text.Length == 0)){
                    tbl_ContactTableAdapter.Fill_SearchByFirstname(contactListDataDataSet.tbl_Contact,txtFirstNameSearch.Text); 
                }//if search is based on firstname
                else if ((txtFirstNameSearch.Text.Length == 0) && (txtLastNameSearch.Text.Length > 0))
                {
                    tbl_ContactTableAdapter.FillBy_SearchByLastName(contactListDataDataSet.tbl_Contact, txtLastNameSearch.Text);
                }//else if search is based on Lastname
                else if ((txtFirstNameSearch.Text.Length > 0) && (txtLastNameSearch.Text.Length > 0))
                {
                    tbl_ContactTableAdapter.FillBy_SearchByFirstnameAndLastName(contactListDataDataSet.tbl_Contact,txtFirstNameSearch.Text, txtLastNameSearch.Text);
                }//else if search is based on firstname and 


            }//else if data is entered
        }//btnSearch_Click
        //-----------------------------------------------------------------------------------------
        private void btnListAll_Click(object sender, EventArgs e)
        {
            clear_entry();
            grbEditData.Enabled = false;
            _currentOperation = DataBaseOperation.Read;
            btnNewContact.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            clear_entry();            
            tbl_ContactTableAdapter.Fill(contactListDataDataSet.tbl_Contact);
        }//btnListAll_Click
        //-----------------------------------------------------------------------------------------
    }//Form
}//Visual_ContactList
