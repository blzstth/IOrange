using System;
using System.Collections.Generic;

namespace IOrange.Data;

public partial class Employee
{
    public int Eid { get; set; }

    public string Name { get; set; } = null!;

    public float Totalincome { get; set; }

    public int Pid { get; set; }

    public int Bid { get; set; }
}
