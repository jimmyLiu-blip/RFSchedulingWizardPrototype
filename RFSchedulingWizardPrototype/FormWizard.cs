using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RFSchedulingWizardPrototype
{
    public partial class FormWizard : DevExpress.XtraEditors.XtraForm
    {
        public FormWizard()
        {
            InitializeComponent();

        }

        private void wizardControl1_NextClick(object sender, DevExpress.XtraWizard.WizardCommandButtonClickEventArgs e)
        {
            if (wizardControl1.SelectedPage == wizardPageProject)
            {
                if (string.IsNullOrWhiteSpace(txtProjectName.Text))
                {
                    MessageBox.Show("Project Name is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Handled = true; // 阻止切換頁面
                    return;
                }

                // Priority 必填
                if (cmbPriority.SelectedIndex == -1)
                {
                    MessageBox.Show("Priority must be selected.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Handled = true;
                    return;
                }

                // Start/End Date 檢查（如果都有填）
                if (dtStartDate.EditValue != null && dtEndDate.EditValue != null)
                {
                    DateTime start = (DateTime)dtStartDate.EditValue;
                    DateTime end = (DateTime)dtEndDate.EditValue;

                    if (start > end)
                    {
                        MessageBox.Show("Start Date cannot be later than End Date.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        e.Handled = true;
                        return;
                    }
                }

                // 儲存到 WizardContext
                WizardContext.Instance.ProjectName = txtProjectName.Text;
                WizardContext.Instance.Customer = txtCustomer.Text;
                WizardContext.Instance.Priority = cmbPriority.Text;
                WizardContext.Instance.StartDate = dtStartDate.EditValue as DateTime?;
                WizardContext.Instance.EndDate = dtEndDate.EditValue as DateTime?;
            }
        }
    }
}
