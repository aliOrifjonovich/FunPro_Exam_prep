using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Childrens
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
                    MessageBox.Show("All data saved");
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
            if(tb_ChildBindingSource.Position == 0)
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
                btnNext.Enabled= true;
                btnLast.Enabled= true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(tb_ChildBindingSource.Count == 0)
            {
                MessageBox.Show("There is no information to delete");
            }
            else
            {
                var userResponse = MessageBox.Show("Sure!", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (userResponse == DialogResult.Yes)
                {
                    tb_ChildBindingSource.RemoveAt(0);
                    MessageBox.Show("Deleted"); 
                }
            }
        }

        private void tb_ChildBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            EnableDisableButton();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var selectedCategory = ((DataRowView) cbxCategory.SelectedItem).Row;

            childrenDataSet.tb_Child.Addtb_ChildRow(
                tbxChildName.Text,
                tbxChildAddress.Text,
                dtpBirth.Value,
                Convert.ToInt32(numWeight.Value),
                (childrenDataSet.tb_ChildCategoryRow)selectedCategory);


        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Validate())
            {
                this.tb_ChildBindingSource.EndEdit();

                if (childrenDataSet.HasChanges())
                {
                    if (MessageBox.Show("do you save all information", "save", MessageBoxButtons.YesNo)== DialogResult.Yes)
                    {
                        SaveData();
                    }
                }
            } 
            else
            {
                e.Cancel = true;
            }

        }

        private void tbxFilter_TextChanged(object sender, EventArgs e)
        {
            tb_ChildBindingSource.Filter= $"ChildName LIKE'{ tbxFilter.Text}%'";
        }
    }
}
