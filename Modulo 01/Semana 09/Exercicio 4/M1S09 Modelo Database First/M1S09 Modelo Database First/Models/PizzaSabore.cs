using System;
using System.Collections.Generic;

namespace M1S09_Modelo_Database_First.Models;

public partial class PizzaSabore
{
    public int Id { get; set; }

    public string? IdPizza { get; set; }

    public string? IdSabores { get; set; }
}
