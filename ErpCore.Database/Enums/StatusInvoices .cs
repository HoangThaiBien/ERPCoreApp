using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Database.Enums
{
    public enum StatusInvoices
    {
        [Description("Đã thanh toán")]
        PaidInvoices,
        [Description("Chưa thanh toán")]
        UnpaidInvoices,
        [Description("Đã hủy")]
        CancelledInvoices
    }
}
