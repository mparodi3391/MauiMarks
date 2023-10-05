using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiMarks.Models;

public class Mark
{
    public int? EmpID { get; set; }
    public int MarkType { get; set; }
    public int? PassCode { get; set; }
    public DateTime MarkDate { get; set; }

}
