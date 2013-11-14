using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FISCA;
using FISCA.Permission;

namespace Example_ExportExcessCreditsBaseData_
{
    public class Program
    {
        [MainMethod()]
        public static void Main()
        {

            K12.Presentation.NLDPanels.Student.RibbonBarItems["資料統計"]["報表"]["學籍相關報表"]["外掛_學生會考報名檔(新)"].Enable = UserAcl.Current["ischoolJHWishBase.ExportExcessCreditsBaseDataSOldAss"].Executable;
            K12.Presentation.NLDPanels.Student.RibbonBarItems["資料統計"]["報表"]["學籍相關報表"]["外掛_學生會考報名檔(新)"].Click += delegate
            {
                ExportExcessCreditsBaseData eecbd = new ExportExcessCreditsBaseData(true);
                eecbd.ShowDialog();
            };

            // 學生會考報名檔
            Catalog catalog05 = RoleAclSource.Instance["學生"]["報表"];
            catalog05.Add(new RibbonFeature("ischoolJHWishBase.ExportExcessCreditsBaseDataSb", "外掛_學生會考報名檔(新)"));
        }
    }
}
