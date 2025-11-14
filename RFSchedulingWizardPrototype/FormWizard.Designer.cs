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
            groupControl2 = new DevExpress.XtraEditors.GroupControl();
            tableProject = new System.Windows.Forms.TableLayoutPanel();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            txtCustomer = new DevExpress.XtraEditors.TextEdit();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            cmbPriority = new DevExpress.XtraEditors.ComboBoxEdit();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            dtEndDate = new DevExpress.XtraEditors.DateEdit();
            txtProjectName = new DevExpress.XtraEditors.TextEdit();
            dtStartDate = new DevExpress.XtraEditors.DateEdit();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            wizardPageRegulation = new DevExpress.XtraWizard.WizardPage();
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            checkedListRegulations = new DevExpress.XtraEditors.CheckedListBoxControl();
            wizardPageTestItems = new DevExpress.XtraWizard.WizardPage();
            wizardPageEngineers = new DevExpress.XtraWizard.WizardPage();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)wizardControl1).BeginInit();
            wizardControl1.SuspendLayout();
            wizardPageProject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)groupControl2).BeginInit();
            groupControl2.SuspendLayout();
            tableProject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtCustomer.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbPriority.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtEndDate.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtEndDate.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtProjectName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtStartDate.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtStartDate.Properties.CalendarTimeProperties).BeginInit();
            wizardPageRegulation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)checkedListRegulations).BeginInit();
            wizardPageTestItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
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
            wizardControl1.Size = new System.Drawing.Size(744, 593);
            wizardControl1.NextClick += wizardControl1_NextClick;
            // 
            // wizardPageProject
            // 
            wizardPageProject.Controls.Add(groupControl2);
            wizardPageProject.Name = "wizardPageProject";
            wizardPageProject.Size = new System.Drawing.Size(696, 380);
            wizardPageProject.Text = "Project Information";
            // 
            // groupControl2
            // 
            groupControl2.Controls.Add(tableProject);
            groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            groupControl2.Location = new System.Drawing.Point(0, 0);
            groupControl2.Name = "groupControl2";
            groupControl2.Padding = new System.Windows.Forms.Padding(15);
            groupControl2.Size = new System.Drawing.Size(696, 380);
            groupControl2.TabIndex = 11;
            groupControl2.Text = "Project Information";
            groupControl2.Paint += groupControl2_Paint;
            // 
            // tableProject
            // 
            tableProject.ColumnCount = 2;
            tableProject.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 281F));
            tableProject.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableProject.Controls.Add(labelControl1, 0, 0);
            tableProject.Controls.Add(labelControl3, 0, 1);
            tableProject.Controls.Add(txtCustomer, 1, 1);
            tableProject.Controls.Add(labelControl2, 0, 2);
            tableProject.Controls.Add(cmbPriority, 1, 2);
            tableProject.Controls.Add(labelControl4, 0, 3);
            tableProject.Controls.Add(dtEndDate, 1, 4);
            tableProject.Controls.Add(txtProjectName, 1, 0);
            tableProject.Controls.Add(dtStartDate, 1, 3);
            tableProject.Controls.Add(labelControl5, 0, 4);
            tableProject.Dock = System.Windows.Forms.DockStyle.Fill;
            tableProject.Location = new System.Drawing.Point(17, 49);
            tableProject.Name = "tableProject";
            tableProject.Padding = new System.Windows.Forms.Padding(10);
            tableProject.RowCount = 5;
            tableProject.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableProject.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableProject.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableProject.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableProject.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableProject.Size = new System.Drawing.Size(662, 314);
            tableProject.TabIndex = 11;
            tableProject.Paint += tableProject_Paint;
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Appearance.Options.UseTextOptions = true;
            labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            labelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            labelControl1.Location = new System.Drawing.Point(13, 16);
            labelControl1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new System.Drawing.Size(275, 44);
            labelControl1.TabIndex = 1;
            labelControl1.Text = "Project Name：";
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 18F);
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Appearance.Options.UseTextOptions = true;
            labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            labelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            labelControl3.Location = new System.Drawing.Point(13, 72);
            labelControl3.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new System.Drawing.Size(275, 44);
            labelControl3.TabIndex = 5;
            labelControl3.Text = "Customer：";
            // 
            // txtCustomer
            // 
            txtCustomer.Dock = System.Windows.Forms.DockStyle.Left;
            txtCustomer.Location = new System.Drawing.Point(294, 69);
            txtCustomer.Name = "txtCustomer";
            txtCustomer.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 18F);
            txtCustomer.Properties.Appearance.Options.UseFont = true;
            txtCustomer.Size = new System.Drawing.Size(344, 50);
            txtCustomer.TabIndex = 6;
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Appearance.Options.UseTextOptions = true;
            labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            labelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            labelControl2.Location = new System.Drawing.Point(13, 128);
            labelControl2.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new System.Drawing.Size(275, 44);
            labelControl2.TabIndex = 3;
            labelControl2.Text = "Priority：";
            // 
            // cmbPriority
            // 
            cmbPriority.Dock = System.Windows.Forms.DockStyle.Left;
            cmbPriority.Location = new System.Drawing.Point(294, 125);
            cmbPriority.Name = "cmbPriority";
            cmbPriority.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 18F);
            cmbPriority.Properties.Appearance.Options.UseFont = true;
            cmbPriority.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cmbPriority.Properties.Items.AddRange(new object[] { "High", "Medium", "Low" });
            cmbPriority.Size = new System.Drawing.Size(344, 50);
            cmbPriority.TabIndex = 4;
            // 
            // labelControl4
            // 
            labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 18F);
            labelControl4.Appearance.Options.UseFont = true;
            labelControl4.Appearance.Options.UseTextOptions = true;
            labelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            labelControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            labelControl4.Location = new System.Drawing.Point(13, 181);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new System.Drawing.Size(275, 50);
            labelControl4.TabIndex = 9;
            labelControl4.Text = "Start Date：";
            // 
            // dtEndDate
            // 
            dtEndDate.Dock = System.Windows.Forms.DockStyle.Left;
            dtEndDate.EditValue = null;
            dtEndDate.Location = new System.Drawing.Point(294, 237);
            dtEndDate.Name = "dtEndDate";
            dtEndDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 18F);
            dtEndDate.Properties.Appearance.Options.UseFont = true;
            dtEndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dtEndDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dtEndDate.Size = new System.Drawing.Size(344, 50);
            dtEndDate.TabIndex = 8;
            // 
            // txtProjectName
            // 
            txtProjectName.Dock = System.Windows.Forms.DockStyle.Left;
            txtProjectName.Location = new System.Drawing.Point(294, 13);
            txtProjectName.Name = "txtProjectName";
            txtProjectName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtProjectName.Properties.Appearance.Options.UseFont = true;
            txtProjectName.Size = new System.Drawing.Size(344, 50);
            txtProjectName.TabIndex = 2;
            txtProjectName.EditValueChanged += txtProjectName_EditValueChanged;
            // 
            // dtStartDate
            // 
            dtStartDate.Dock = System.Windows.Forms.DockStyle.Left;
            dtStartDate.EditValue = null;
            dtStartDate.Location = new System.Drawing.Point(294, 181);
            dtStartDate.Name = "dtStartDate";
            dtStartDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 18F);
            dtStartDate.Properties.Appearance.Options.UseFont = true;
            dtStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dtStartDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dtStartDate.Size = new System.Drawing.Size(344, 50);
            dtStartDate.TabIndex = 7;
            // 
            // labelControl5
            // 
            labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 18F);
            labelControl5.Appearance.Options.UseFont = true;
            labelControl5.Appearance.Options.UseTextOptions = true;
            labelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            labelControl5.Dock = System.Windows.Forms.DockStyle.Right;
            labelControl5.Location = new System.Drawing.Point(107, 237);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new System.Drawing.Size(181, 43);
            labelControl5.TabIndex = 10;
            labelControl5.Text = "End Date：";
            // 
            // wizardPageRegulation
            // 
            wizardPageRegulation.Controls.Add(groupControl1);
            wizardPageRegulation.Name = "wizardPageRegulation";
            wizardPageRegulation.Size = new System.Drawing.Size(696, 380);
            wizardPageRegulation.Text = "Select Regulations";
            // 
            // groupControl1
            // 
            groupControl1.Controls.Add(checkedListRegulations);
            groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            groupControl1.Location = new System.Drawing.Point(0, 0);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new System.Drawing.Size(696, 262);
            groupControl1.TabIndex = 1;
            groupControl1.Text = "Select Regulations";
            // 
            // checkedListRegulations
            // 
            checkedListRegulations.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            checkedListRegulations.Appearance.Options.UseFont = true;
            checkedListRegulations.Dock = System.Windows.Forms.DockStyle.Fill;
            checkedListRegulations.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] { new DevExpress.XtraEditors.Controls.CheckedListBoxItem("FCC"), new DevExpress.XtraEditors.Controls.CheckedListBoxItem("NCC"), new DevExpress.XtraEditors.Controls.CheckedListBoxItem("IC"), new DevExpress.XtraEditors.Controls.CheckedListBoxItem("CE"), new DevExpress.XtraEditors.Controls.CheckedListBoxItem("TELEC") });
            checkedListRegulations.Location = new System.Drawing.Point(2, 34);
            checkedListRegulations.Name = "checkedListRegulations";
            checkedListRegulations.Size = new System.Drawing.Size(692, 226);
            checkedListRegulations.TabIndex = 0;
            checkedListRegulations.SelectedIndexChanged += checkedListRegulations_SelectedIndexChanged;
            // 
            // wizardPageTestItems
            // 
            wizardPageTestItems.Controls.Add(gridControl1);
            wizardPageTestItems.Name = "wizardPageTestItems";
            wizardPageTestItems.Size = new System.Drawing.Size(696, 380);
            wizardPageTestItems.Text = "Test Items";
            // 
            // wizardPageEngineers
            // 
            wizardPageEngineers.Name = "wizardPageEngineers";
            wizardPageEngineers.Size = new System.Drawing.Size(696, 380);
            wizardPageEngineers.Text = "Assign Engineers";
            // 
            // gridControl1
            // 
            gridControl1.Location = new System.Drawing.Point(3, 3);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new System.Drawing.Size(690, 374);
            gridControl1.TabIndex = 0;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            // 
            // FormWizard
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(744, 593);
            Controls.Add(wizardControl1);
            Margin = new System.Windows.Forms.Padding(5);
            Name = "FormWizard";
            Text = "Form1";
            Load += FormWizard_Load;
            ((System.ComponentModel.ISupportInitialize)wizardControl1).EndInit();
            wizardControl1.ResumeLayout(false);
            wizardPageProject.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)groupControl2).EndInit();
            groupControl2.ResumeLayout(false);
            tableProject.ResumeLayout(false);
            tableProject.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtCustomer.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbPriority.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtEndDate.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtEndDate.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtProjectName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtStartDate.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtStartDate.Properties).EndInit();
            wizardPageRegulation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)checkedListRegulations).EndInit();
            wizardPageTestItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
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
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.TableLayoutPanel tableProject;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}

