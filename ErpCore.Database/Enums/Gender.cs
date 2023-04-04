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
    public enum Gender
    {
        [Display(Name = "Nam")]
        Male,
        [Display(Name = "Nữ")]
        Female,
        [Display(Name = "Khác")]
        Other,
    }
}
