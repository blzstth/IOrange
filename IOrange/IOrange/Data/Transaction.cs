using System;
using System.Collections.Generic;

namespace IOrange.Data;

public partial class Transaction
{
    public int Tid { get; set; }

    public int Bid { get; set; }

    public int Eid { get; set; }

    public float Total { get; set; }
   
    public DateTime Date { get; set; }
}
