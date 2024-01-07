using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Db.mvcWeb.Entity
{
    public enum EnumOrderState
    {
        [Display(Name = "Onay bekleniyor.")]
        Waiting,
        [Display(Name = "Kargoya verildi.")]
        OnTheWay,
        [Display(Name = "Tamamlandı.")]
        Completed
    }
}