using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Db.mvcWeb.Entity;

namespace Db.mvcWeb.Models
{
    public class AdminOrderModel
    {
        public int Id { get; set; }
        public string OrderNumber { get; set; }
        public double Total { get; set; }
        public EnumOrderState OrderState { get; set; }
        public DateTime OrderDate { get; set; }
        public int Count { get; set; }
    }
}