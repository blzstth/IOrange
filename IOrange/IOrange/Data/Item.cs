using System;
using System.Collections.Generic;

namespace IOrange.Data;

public partial class Item
{
    public int Iid { get; set; }

    public string Name { get; set; } = null!;

    public float Price { get; set; }

    public int Sold { get; set; }
    public float Amount { get; set; }

   

}
