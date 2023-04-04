using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ErpCore.Database.Enums
{
    public enum Departments
    {
        [Display(Name = "Phòng Kế toán")]
        Accounting,
        [Display(Name = "Phòng Tài chính")]
        Finance,
        [Display(Name = "Phòng Nhân sự")]
        HumanResource,
        [Display(Name = "Phòng Đào tạo")]
        Training,
        [Display(Name = "Phòng Kinh doanh")]
        Sales,
        [Display(Name = "Phòng Chăm sóc Khách hàng")]
        CustomerService
    }
}
