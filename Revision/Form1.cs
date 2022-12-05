using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Revision
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tb_ChildBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void SaveData()
        {
            if (this.Validate())
            {
                try
                {
                    this.tb_ChildBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.childrenDataSet);
                    MessageBox.Show("Saved");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                this.tb_ChildCategoryTableAdapter.Fill(this.childrenDataSet.tb_ChildCategory);
                this.tb_ChildTableAdapter.Fill(this.childrenDataSet.tb_Child);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            

        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            tb_ChildBindingSource.MoveFirst();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            tb_ChildBindingSource.MovePrevious();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tb_ChildBindingSource.MoveNext();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            tb_ChildBindingSource.MoveLast();
        }

        private void EnableDisableButton()
        {
            if (tb_ChildBindingSource.Position == 0)
            {
                btnFirst.Enabled= false;
                btnPrev.Enabled= false;
            }
            else
            {
                btnFirst.Enabled= true;
                btnPrev.Enabled= true;
            }
            if (tb_ChildBindingSource.Position == tb_ChildBindingSource.Count - 1)
            {
                btnNext.Enabled= false;
                btnLast.Enabled= false;
            }
            else
            {
                btnLast.Enabled= true;
                btnNext.Enabled= true;  
            }
        }

        private void tb_ChildBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            EnableDisableButton();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tb_ChildBindingSource.Count == 0)
            {
                MessageBox.Show("There is no information to delete");
            }
            else
            {
                var userResponse = MessageBox.Show("Dou you delete", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (userResponse == DialogResult.Yes)
                {
                    tb_ChildBindingSource.RemoveCurrent();
                    MessageBox.Show("Dleted");
                }
            }
        }

        private void tbxFilter_TextChanged(object sender, EventArgs e)
        {
            tb_ChildBindingSource.Filter = $"ChildName_1461 LIKE ('{tbxFilter.Text}%')";  
        }

        private void childName_1461TextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(childName_1461TextBox.Text))
            {
                MessageBox.Show("child name cannot be empty");
                e.Cancel = true;
            }
        }

        private void tbxChildName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbxChildName.Text))
            {
                MessageBox.Show("child name cannot be empty");
                e.Cancel = true;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Validate())
            {
                this.tb_ChildBindingSource.EndEdit();
                if (childrenDataSet.HasChanges())
                {
                    if (MessageBox.Show("do wanna save all", "save", MessageBoxButtons.YesNo)==DialogResult.Yes)
                    {
                        SaveData();
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedCataegory = ((DataRowView)cbxCategory.SelectedItem).Row;

                childrenDataSet.tb_Child.Addtb_ChildRow(
                    tbxChildName.Text,
                    tbxChildAddress.Text,
                    dtpBirthDate.Value,
                    Convert.ToInt32(numChildWeight.Value),
                    (ChildrenDataSet.tb_ChildCategoryRow)selectedCataegory);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
