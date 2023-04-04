using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Database.Enums
{
   public enum Levels
    {
        [Description("Xuất sắc")]
        Excellent,
        [Description("Giỏi")]
        VeryGood,
        [Description("Khá")]
        Good,
        [Description("Trung bình")]
        AverageGood,
        [Description("Trung bình yếu")]
        Ordinary     
    }
}
