using System;
using System.Collections.Generic;

namespace RFSchedulingWizardPrototype
{
    // 用來暫存 4 個步驟的資料（Singleton）
    public class WizardContext
    {
        // ★ Singleton Instance ★
        private static WizardContext _instance;
        public static WizardContext Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new WizardContext();
                return _instance;
            }
        }

        // ★ Private constructor（不允許外部 new）
        private WizardContext() { }

        // Step1：Project 資訊
        public string ProjectName { get; set; }
        public string Customer { get; set; }
        public string Priority { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        // Step2：Regulation（先用簡單字串列表表示）
        public List<string> SelectedRegulations { get; set; } = new List<string>();

        // Step3：TestItem（我們先用簡單物件）
        public List<TestItemInfo> TestItems { get; set; } = new List<TestItemInfo>();

        // Step4：工程師分配
        public List<EngineerAssignmentInfo> EngineerAssignments { get; set; } = new List<EngineerAssignmentInfo>();
    }

    public class TestItemInfo
    {
        public string RegulationName { get; set; }
        public string TestItemName { get; set; }
        public string TestType { get; set; }
        public string TestLocation { get; set; }
        public decimal EstimatedHours { get; set; }
        public string ManagerNote { get; set; }
    }

    public class EngineerAssignmentInfo
    {
        public string RegulationName { get; set; }
        public string TestItemName { get; set; }
        public string EngineerName { get; set; }
        public string RoleType { get; set; } // Main/Sub
        public decimal AssignedHours { get; set; }
    }
}
