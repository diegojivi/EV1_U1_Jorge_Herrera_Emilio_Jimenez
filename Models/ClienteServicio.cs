using System;
using System.Collections.Generic;

namespace mercy_developers.Models;

public partial class ClienteServicio
{
    public int IdclienteServicio { get; set; }

    public int? Idservicio { get; set; }

    public int? ClienteServiciocol { get; set; }

    public DateTime? FechaServicio { get; set; }
}
