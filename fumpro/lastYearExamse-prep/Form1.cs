using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lastYearExamse_prep
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tb_ModuleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
         
           SaveDate();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                this.tb_ModuleTypeTableAdapter.Fill(this.universityDataSet.tb_ModuleType);
                this.tb_ModuleTableAdapter.Fill(this.universityDataSet.tb_Module);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void SaveDate()
        {
            if(this.Validate())
            {
                try
                {
                    this.tb_ModuleBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.universityDataSet);
                    MessageBox.Show("Sure!");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void moduleNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            tb_ModuleBindingSource.MovePrevious();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            tb_ModuleBindingSource.MoveFirst();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tb_ModuleBindingSource.MoveNext();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            tb_ModuleBindingSource.MoveLast();
        }

        private void EnableDisableButton(object sender, EventArgs e)
        {
            if (tb_ModuleBindingSource.Position == 0)
            {
                btnFirst.Enabled = false;
                btnPrev.Enabled = false;
            }
            else
            {
                btnFirst.Enabled = true;
                btnPrev.Enabled = true; 
            }
            if(tb_ModuleBindingSource.Position == tb_ModuleBindingSource.Count - 1)
            {
                btnNext.Enabled = false;
                btnLast.Enabled = false;
            }
            else
            {
                btnNext.Enabled = true; 
                btnLast.Enabled = true; 
            }
        }

        private void tb_ModuleBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            EnableDisableButton(sender, e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveDate();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(tb_ModuleBindingSource.Count == 0)
            {
                MessageBox.Show("There is no more information to delete");
            }
            else
            {
                var userResponse = MessageBox.Show("Sure?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (userResponse == DialogResult.Yes)
                {
                    tb_ModuleBindingSource.RemoveAt(0);
                    MessageBox.Show("Deleted");
                }
            }
        }

       private void Form1_FormClosing(object sender, FormClosingEventArgs e)
       {
            if (Validate())
            {
                this.tb_ModuleBindingSource.EndEdit();
                if (universityDataSet.HasChanges())
                {
                    if (MessageBox.Show("do you save all information", "save", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        SaveDate();
                    }
                }
            }
            else
            {
                e.Cancel = true;
            }
       }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var selectedType = ((DataRowView) cbxModelType.SelectedItem).Row;
            universityDataSet.tb_Module.Addtb_ModuleRow(tbxModelCode.Text,
                                                        tbxModelName.Text,
                                                        tbxModelYear.Text,
                                                        (universityDataSet.)selectedType);
            
        }

        private void tbxFilter_TextChanged(object sender, EventArgs e)
        {
            tb_ModuleBindingSource.Filter = $"ModaleName LIKE '{tbxFilter.Text}%'";
        }
    }
}
