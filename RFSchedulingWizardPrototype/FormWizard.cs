using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace RFSchedulingWizardPrototype
{
    public partial class FormWizard : DevExpress.XtraEditors.XtraForm
    {
        public FormWizard()
        {
            InitializeComponent();
            wizardPageTestItems.PageInit += wizardPageTestItems_PageInit;
            wizardPageEngineers.PageInit += wizardPageEngineers_PageInit;
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
            else if (wizardControl1.SelectedPage == wizardPageRegulation)
            {
                WizardContext.Instance.SelectedRegulations.Clear();

                foreach (var item in checkedListRegulations.CheckedItems)
                {
                    WizardContext.Instance.SelectedRegulations.Add(item.ToString());
                }

                if (WizardContext.Instance.SelectedRegulations.Count == 0)
                {
                    MessageBox.Show("You must select at least one regulation.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    e.Handled = true;
                    return;
                }
            }
            else if (wizardControl1.SelectedPage == wizardPageTestItems)
            {
                // ★ 確保 Grid 把目前正在編輯的值寫回資料來源
                gridViewTestItems.PostEditor();
                gridViewTestItems.UpdateCurrentRow();

                // 取得目前所有列
                var list = new List<TestItemInfo>();
                for (int i = 0; i < gridViewTestItems.RowCount; i++)
                {
                    var row = gridViewTestItems.GetRow(i) as TestItemInfo;
                    if (row != null)
                        list.Add(row);
                }

                // 基本驗證：至少要有一筆測項、工時 > 0
                if (list.Count == 0)
                {
                    MessageBox.Show("You must define at least one Test Item.", "Validation",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Handled = true;
                    return;
                }

                if (list.Any(t => string.IsNullOrWhiteSpace(t.TestItemName) || t.EstimatedHours <= 0))
                {
                    MessageBox.Show("Each Test Item must have name and hours > 0.", "Validation",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Handled = true;
                    return;
                }

                // 驗證通過 → 存回 Context
                WizardContext.Instance.TestItems.Clear();
                foreach (var t in list)
                {
                    WizardContext.Instance.TestItems.Add(t);
                }
            }
            else if (wizardControl1.SelectedPage == wizardPageEngineers)
            {
                gridViewEngineer.PostEditor();
                gridViewEngineer.UpdateCurrentRow();

                var list = new List<EngineerAssignmentInfo>();

                for (int i = 0; i < gridViewEngineer.RowCount; i++)
                {
                    var row = gridViewEngineer.GetRow(i) as EngineerAssignmentInfo;
                    if (row != null)
                        list.Add(row);
                }

                // 驗證主工程師
                if (list.Any(x => string.IsNullOrWhiteSpace(x.EngineerName)))
                {
                    MessageBox.Show("Each Test Item must be assigned to an engineer.",
                        "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Handled = true;
                    return;
                }

                // 儲存
                WizardContext.Instance.EngineerAssignments = list;
            }
        }


        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableProject_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtProjectName_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void FormWizard_Load(object sender, EventArgs e)
        {

        }

        private void checkedListRegulations_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gridControlTestItems_Click(object sender, EventArgs e)
        {

        }

        private void wizardPageTestItems_PageInit(object sender, EventArgs e)
        {
            var regs = WizardContext.Instance.SelectedRegulations;
            var defaultItems = GenerateDefaultItems(regs);

            WizardContext.Instance.TestItems.Clear();
            foreach (var item in defaultItems)
            {
                WizardContext.Instance.TestItems.Add(item);
            }

            gridControlTestItems.DataSource = WizardContext.Instance.TestItems;

            gridViewTestItems.PopulateColumns();
            gridViewTestItems.BestFitColumns();

            SetupTestItemGrid();
        }

        private List<TestItemInfo> GenerateDefaultItems(List<string> regs)
        {
            var list = new List<TestItemInfo>();

            foreach (var r in regs)
            {
                if (r == "FCC")
                {
                    list.Add(new TestItemInfo
                    {
                        RegulationName = "FCC",
                        TestItemName = "Conducted",
                        TestType = "Normal",
                        TestLocation = "Lab A",
                        EstimatedHours = 3.5m,
                        ManagerNote = ""
                    });

                    list.Add(new TestItemInfo
                    {
                        RegulationName = "FCC",
                        TestItemName = "Radiated",
                        TestType = "Chamber",
                        TestLocation = "Chamber 1",
                        EstimatedHours = 8m,
                        ManagerNote = ""
                    });
                }
                else if (r == "NCC")
                {
                    list.Add(new TestItemInfo
                    {
                        RegulationName = "NCC",
                        TestItemName = "PLMN ALL",
                        TestType = "Normal",
                        TestLocation = "Lab A",
                        EstimatedHours = 5m,
                        ManagerNote = ""
                    });
                }
                else if (r == "IC")
                {
                    list.Add(new TestItemInfo
                    {
                        RegulationName = "IC",
                        TestItemName = "Conducted",
                        TestType = "Normal",
                        TestLocation = "Lab A",
                        EstimatedHours = 3m,
                        ManagerNote = ""
                    });
                }
                else if (r == "CE")
                {
                    list.Add(new TestItemInfo
                    {
                        RegulationName = "CE",
                        TestItemName = "EN301908",
                        TestType = "Normal",
                        TestLocation = "Lab B",
                        EstimatedHours = 4m,
                        ManagerNote = ""
                    });
                }
                else if (r == "TELEC")
                {
                    list.Add(new TestItemInfo
                    {
                        RegulationName = "TELEC",
                        TestItemName = "Normal",
                        TestType = "Normal",
                        TestLocation = "Lab A",
                        EstimatedHours = 4m,
                        ManagerNote = ""
                    });
                }
            }

            return list;
        }

        private void SetupTestItemGrid()
        {
            _repoTestItem = new RepositoryItemComboBox();
            _repoTestItem.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor; // 禁止手打，可選
            gridControlTestItems.RepositoryItems.Add(_repoTestItem);

            // 1. 先確保欄位已經產生
            gridViewTestItems.PopulateColumns();

            // 2. ★ 允許新增 / 刪除列
            gridViewTestItems.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            gridViewTestItems.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;

            // 3. ★ 新增列顯示在最底下（* 那一列）
            gridViewTestItems.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;

            GridColumn colReg = gridViewTestItems.Columns[nameof(TestItemInfo.RegulationName)];
            GridColumn colItem = gridViewTestItems.Columns[nameof(TestItemInfo.TestItemName)];
            GridColumn colType = gridViewTestItems.Columns[nameof(TestItemInfo.TestType)];
            GridColumn colLoc = gridViewTestItems.Columns[nameof(TestItemInfo.TestLocation)];
            GridColumn colHour = gridViewTestItems.Columns[nameof(TestItemInfo.EstimatedHours)];
            GridColumn colNote = gridViewTestItems.Columns[nameof(TestItemInfo.ManagerNote)];

            // 2. Caption（顯示文字）
            colReg.Caption = "Regulation";
            colItem.Caption = "Test Item";
            colType.Caption = "Type";
            colLoc.Caption = "Location";
            colHour.Caption = "Hours";
            colNote.Caption = "Manager Note";

            // 4. 建立下拉選單 Editor

            // ★ Regulation 下拉（依 Step2 勾選）
            var repoReg = new RepositoryItemComboBox();
            repoReg.Items.AddRange(WizardContext.Instance.SelectedRegulations);
            gridControlTestItems.RepositoryItems.Add(repoReg);
            colReg.ColumnEdit = repoReg;

            colItem.ColumnEdit = _repoTestItem;

            // Test Type 下拉
            var repoType = new RepositoryItemComboBox();
            repoType.Items.AddRange(new[] { "Normal", "Chamber", "Special" });
            gridControlTestItems.RepositoryItems.Add(repoType);
            colType.ColumnEdit = repoType;

            // Location 下拉
            var repoLoc = new RepositoryItemComboBox();
            repoLoc.Items.AddRange(new[] { "Lab A", "Lab B", "Chamber 1", "Chamber 2" });
            gridControlTestItems.RepositoryItems.Add(repoLoc);
            colLoc.ColumnEdit = repoLoc;

            // Hours 數字輸入
            var repoHours = new RepositoryItemSpinEdit();
            repoHours.MinValue = 0;
            repoHours.MaxValue = 24;
            repoHours.Increment = 0.5m;
            gridControlTestItems.RepositoryItems.Add(repoHours);
            colHour.ColumnEdit = repoHours;

            // 備註用一般文字就好，可允許多行（如果你想再進階可以改 MemoEdit）
            gridViewTestItems.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom; // 允許新增新測項（可選）
            gridViewTestItems.BestFitColumns();

            gridViewTestItems.ShownEditor += (s, ev) =>
            {
                var view = (GridView)s;

                // 正確：確認目前編輯的是 TestItemName 欄
                if (view.FocusedColumn.FieldName == nameof(TestItemInfo.TestItemName))
                {
                    var regValue = view.GetFocusedRowCellValue(nameof(TestItemInfo.RegulationName))?.ToString();

                    if (view.ActiveEditor is DevExpress.XtraEditors.ComboBoxEdit editor)
                    {
                        editor.Properties.Items.Clear();

                        if (!string.IsNullOrEmpty(regValue) && TestItemDictionary.ContainsKey(regValue))
                        {
                            editor.Properties.Items.AddRange(TestItemDictionary[regValue]);
                        }
                    }
                }
            };


            // ★ 當 Regulation 改變時，把 Test Item 清空，避免選錯
            gridViewTestItems.CellValueChanged += (s, ev) =>
            {
                if (ev.Column.FieldName == nameof(TestItemInfo.RegulationName))
                {
                    gridViewTestItems.SetRowCellValue(ev.RowHandle,
                        nameof(TestItemInfo.TestItemName), null);
                }
            };

            gridViewTestItems.InitNewRow += (s, ev) =>
            {
                var view = (GridView)s;

                // 只在「真正新增」的瞬間設定一次，不會刷新覆蓋
                view.SetRowCellValue(ev.RowHandle, nameof(TestItemInfo.TestType), "Normal");
                view.SetRowCellValue(ev.RowHandle, nameof(TestItemInfo.TestLocation), "Lab A");
            };
        }

        private void groupControl3_Paint(object sender, PaintEventArgs e)
        {

        }

        private readonly List<string> EngineerList = new List<string>
        {
         "Jimmy",
         "Ivy",
         "Kevin",
         "May"
        };

        private List<EngineerAssignmentInfo> GenerateAssignments(IEnumerable<TestItemInfo> testItems)
        {
            var list = new List<EngineerAssignmentInfo>();

            foreach (var item in testItems)
            {
                list.Add(new EngineerAssignmentInfo
                {
                    RegulationName = item.RegulationName,
                    TestItemName = item.TestItemName,
                    EngineerName = "",      // 主工程師（主管選）
                    RoleType = "Main",      // 固定 Main
                    AssignedHours = item.EstimatedHours
                });
            }

            return list;
        }

        private void wizardPageEngineers_PageInit(object sender, EventArgs e)
        {
            // 1. 取得 TestItems → 自動產生工程師配表
            var items = WizardContext.Instance.TestItems;
            var assignList = GenerateAssignments(items);
            WizardContext.Instance.EngineerAssignments = assignList;

            // 2. 綁定 Grid
            gridControlEngineer.DataSource = assignList;

            // 3. 建立欄位 Editor
            SetupEngineerGrid();
        }

        private void SetupEngineerGrid()
        {
            gridViewEngineer.PopulateColumns();

            GridColumn colReg = gridViewEngineer.Columns[nameof(EngineerAssignmentInfo.RegulationName)];
            GridColumn colItem = gridViewEngineer.Columns[nameof(EngineerAssignmentInfo.TestItemName)];
            GridColumn colEng = gridViewEngineer.Columns[nameof(EngineerAssignmentInfo.EngineerName)];
            GridColumn colRole = gridViewEngineer.Columns[nameof(EngineerAssignmentInfo.RoleType)];
            GridColumn colHour = gridViewEngineer.Columns[nameof(EngineerAssignmentInfo.AssignedHours)];

            colReg.Caption = "Regulation";
            colItem.Caption = "Test Item";
            colEng.Caption = "Engineer";
            colRole.Caption = "Role";
            colHour.Caption = "Hours";

            // 1. Regulation / Test Item / Role 不可修改
            colReg.OptionsColumn.AllowEdit = false;
            colItem.OptionsColumn.AllowEdit = false;
            colRole.OptionsColumn.AllowEdit = false;

            // 2. Engineer（主工程師）下拉選單
            var repoEngineer = new RepositoryItemComboBox();
            repoEngineer.Items.AddRange(EngineerList);
            gridControlEngineer.RepositoryItems.Add(repoEngineer);
            colEng.ColumnEdit = repoEngineer;

            // 3. Hours 編輯器（可調整）
            var repoHour = new RepositoryItemSpinEdit();
            repoHour.MinValue = 0;
            repoHour.MaxValue = 40;
            repoHour.Increment = 0.5m;
            gridControlEngineer.RepositoryItems.Add(repoHour);
            colHour.ColumnEdit = repoHour;

            gridViewEngineer.BestFitColumns();
        }

        private readonly Dictionary<string, List<string>> TestItemDictionary = new Dictionary<string, List<string>>
        {
             { "FCC", new List<string> { "Conducted", "Radiated", "Receiver Blocking", "Power Class" } },
             { "NCC", new List<string> { "PLMN ALL", "UL Power", "DL Power" } },
             { "IC",  new List<string> { "Conducted", "Radiated" } },
             { "CE",  new List<string> { "EN301908", "EN301489" } },
             { "TELEC", new List<string> { "Normal", "RedCap" } }
        };

        private RepositoryItemComboBox _repoTestItem;
    }
}
