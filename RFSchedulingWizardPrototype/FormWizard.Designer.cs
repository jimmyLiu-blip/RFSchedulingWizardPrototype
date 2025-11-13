namespace RFSchedulingWizardPrototype
{
    partial class FormWizard
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
            wizardControl1 = new DevExpress.XtraWizard.WizardControl();
            wizardPageProject = new DevExpress.XtraWizard.WizardPage();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            dtEndDate = new DevExpress.XtraEditors.DateEdit();
            dtStartDate = new DevExpress.XtraEditors.DateEdit();
            txtCustomer = new DevExpress.XtraEditors.TextEdit();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            cmbPriority = new DevExpress.XtraEditors.ComboBoxEdit();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            txtProjectName = new DevExpress.XtraEditors.TextEdit();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            wizardPageRegulation = new DevExpress.XtraWizard.WizardPage();
            checkedListRegulations = new DevExpress.XtraEditors.CheckedListBoxControl();
            wizardPageTestItems = new DevExpress.XtraWizard.WizardPage();
            wizardPageEngineers = new DevExpress.XtraWizard.WizardPage();
            ((System.ComponentModel.ISupportInitialize)wizardControl1).BeginInit();
            wizardControl1.SuspendLayout();
            wizardPageProject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtEndDate.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtEndDate.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtStartDate.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtStartDate.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtCustomer.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbPriority.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtProjectName.Properties).BeginInit();
            wizardPageRegulation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)checkedListRegulations).BeginInit();
            SuspendLayout();
            // 
            // wizardControl1
            // 
            wizardControl1.Controls.Add(wizardPageProject);
            wizardControl1.Controls.Add(wizardPageRegulation);
            wizardControl1.Controls.Add(wizardPageTestItems);
            wizardControl1.Controls.Add(wizardPageEngineers);
            wizardControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            wizardControl1.Name = "wizardControl1";
            wizardControl1.Pages.AddRange(new DevExpress.XtraWizard.BaseWizardPage[] { wizardPageProject, wizardPageRegulation, wizardPageTestItems, wizardPageEngineers });
            wizardControl1.Size = new System.Drawing.Size(1619, 893);
            wizardControl1.NextClick += wizardControl1_NextClick;
            // 
            // wizardPageProject
            // 
            wizardPageProject.Controls.Add(labelControl5);
            wizardPageProject.Controls.Add(labelControl4);
            wizardPageProject.Controls.Add(dtEndDate);
            wizardPageProject.Controls.Add(dtStartDate);
            wizardPageProject.Controls.Add(txtCustomer);
            wizardPageProject.Controls.Add(labelControl3);
            wizardPageProject.Controls.Add(cmbPriority);
            wizardPageProject.Controls.Add(labelControl2);
            wizardPageProject.Controls.Add(txtProjectName);
            wizardPageProject.Controls.Add(labelControl1);
            wizardPageProject.Name = "wizardPageProject";
            wizardPageProject.Size = new System.Drawing.Size(1571, 680);
            wizardPageProject.Text = "Project Information";
            // 
            // labelControl5
            // 
            labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 18F);
            labelControl5.Appearance.Options.UseFont = true;
            labelControl5.Location = new System.Drawing.Point(523, 349);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new System.Drawing.Size(181, 43);
            labelControl5.TabIndex = 10;
            labelControl5.Text = "End Date：";
            // 
            // labelControl4
            // 
            labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 18F);
            labelControl4.Appearance.Options.UseFont = true;
            labelControl4.Location = new System.Drawing.Point(26, 349);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new System.Drawing.Size(197, 43);
            labelControl4.TabIndex = 9;
            labelControl4.Text = "Start Date：";
            // 
            // dtEndDate
            // 
            dtEndDate.EditValue = null;
            dtEndDate.Location = new System.Drawing.Point(710, 346);
            dtEndDate.Name = "dtEndDate";
            dtEndDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 18F);
            dtEndDate.Properties.Appearance.Options.UseFont = true;
            dtEndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dtEndDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dtEndDate.Size = new System.Drawing.Size(250, 50);
            dtEndDate.TabIndex = 8;
            // 
            // dtStartDate
            // 
            dtStartDate.EditValue = null;
            dtStartDate.Location = new System.Drawing.Point(229, 346);
            dtStartDate.Name = "dtStartDate";
            dtStartDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 18F);
            dtStartDate.Properties.Appearance.Options.UseFont = true;
            dtStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dtStartDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dtStartDate.Size = new System.Drawing.Size(250, 50);
            dtStartDate.TabIndex = 7;
            // 
            // txtCustomer
            // 
            txtCustomer.Location = new System.Drawing.Point(356, 182);
            txtCustomer.Name = "txtCustomer";
            txtCustomer.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 18F);
            txtCustomer.Properties.Appearance.Options.UseFont = true;
            txtCustomer.Size = new System.Drawing.Size(250, 50);
            txtCustomer.TabIndex = 6;
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 18F);
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Location = new System.Drawing.Point(162, 185);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new System.Drawing.Size(188, 43);
            labelControl3.TabIndex = 5;
            labelControl3.Text = "Customer：";
            // 
            // cmbPriority
            // 
            cmbPriority.Location = new System.Drawing.Point(356, 262);
            cmbPriority.Name = "cmbPriority";
            cmbPriority.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 18F);
            cmbPriority.Properties.Appearance.Options.UseFont = true;
            cmbPriority.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cmbPriority.Properties.Items.AddRange(new object[] { "High", "Medium", "Low" });
            cmbPriority.Size = new System.Drawing.Size(250, 50);
            cmbPriority.TabIndex = 4;
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new System.Drawing.Point(202, 265);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new System.Drawing.Size(148, 43);
            labelControl2.TabIndex = 3;
            labelControl2.Text = "Priority：";
            // 
            // txtProjectName
            // 
            txtProjectName.Location = new System.Drawing.Point(356, 103);
            txtProjectName.Name = "txtProjectName";
            txtProjectName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtProjectName.Properties.Appearance.Options.UseFont = true;
            txtProjectName.Size = new System.Drawing.Size(250, 50);
            txtProjectName.TabIndex = 2;
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new System.Drawing.Point(100, 106);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new System.Drawing.Size(250, 43);
            labelControl1.TabIndex = 1;
            labelControl1.Text = "Project Name：";
            // 
            // wizardPageRegulation
            // 
            wizardPageRegulation.Controls.Add(checkedListRegulations);
            wizardPageRegulation.Name = "wizardPageRegulation";
            wizardPageRegulation.Size = new System.Drawing.Size(1571, 680);
            wizardPageRegulation.Text = "Select Regulations";
            // 
            // checkedListRegulations
            // 
            checkedListRegulations.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] { new DevExpress.XtraEditors.Controls.CheckedListBoxItem("FCC"), new DevExpress.XtraEditors.Controls.CheckedListBoxItem("NCC"), new DevExpress.XtraEditors.Controls.CheckedListBoxItem("IC"), new DevExpress.XtraEditors.Controls.CheckedListBoxItem("CE"), new DevExpress.XtraEditors.Controls.CheckedListBoxItem("TELEC") });
            checkedListRegulations.Location = new System.Drawing.Point(121, 231);
            checkedListRegulations.Name = "checkedListRegulations";
            checkedListRegulations.Size = new System.Drawing.Size(114, 177);
            checkedListRegulations.TabIndex = 0;
            // 
            // wizardPageTestItems
            // 
            wizardPageTestItems.Name = "wizardPageTestItems";
            wizardPageTestItems.Size = new System.Drawing.Size(1571, 680);
            wizardPageTestItems.Text = "Test Items";
            // 
            // wizardPageEngineers
            // 
            wizardPageEngineers.Name = "wizardPageEngineers";
            wizardPageEngineers.Size = new System.Drawing.Size(1571, 680);
            wizardPageEngineers.Text = "Assign Engineers";
            // 
            // FormWizard
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1619, 893);
            Controls.Add(wizardControl1);
            Margin = new System.Windows.Forms.Padding(5);
            Name = "FormWizard";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)wizardControl1).EndInit();
            wizardControl1.ResumeLayout(false);
            wizardPageProject.ResumeLayout(false);
            wizardPageProject.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtEndDate.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtEndDate.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtStartDate.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtStartDate.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtCustomer.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbPriority.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtProjectName.Properties).EndInit();
            wizardPageRegulation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)checkedListRegulations).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraWizard.WizardControl wizardControl1;
        private DevExpress.XtraWizard.WelcomeWizardPage welcomeWizardPage1;
        private DevExpress.XtraWizard.WizardPage wizardPageProject;
        private DevExpress.XtraWizard.WizardPage wizardPageRegulation;
        private DevExpress.XtraWizard.WizardPage wizardPageTestItems;
        private DevExpress.XtraWizard.WizardPage wizardPageEngineers;
        private DevExpress.XtraEditors.TextEdit txtProjectName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ComboBoxEdit cmbPriority;
        private DevExpress.XtraEditors.TextEdit txtCustomer;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.DateEdit dtEndDate;
        private DevExpress.XtraEditors.DateEdit dtStartDate;
        private DevExpress.XtraWizard.CompletionWizardPage completionWizardPage1;
        private DevExpress.XtraEditors.CheckedListBoxControl checkedListRegulations;
    }
}

