using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ErpCore.Database.Enums
{
    public enum Roles
    {
        [Display(Name = "Nhân viên")]
        Employee,
        [Display(Name = "Quản lý")]
        Manager,
        [Display(Name = "Giám đốc")]
        Director,
        [Display(Name = "Kế toán")]
        Accountant,
        [Display(Name = "Chuyên gia nhân sự")]
        HumanResources,
        [Display(Name = "Chuyên gia CNTT")]
        ITSpecialist
    }
}
