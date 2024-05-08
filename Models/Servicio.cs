using System;
using System.Collections.Generic;

namespace mercy_developers.Models;

public partial class Servicio
{
    public int Idservicio { get; set; }

    public string? Nombre { get; set; }

    public string? Diagnostico { get; set; }

    public string? Mantenimiento { get; set; }

    public string? RepararReemplazar { get; set; }

    public string? ReinstalarInstalarSowfware { get; set; }

    public DateTime? FechaInicio { get; set; }

    public DateTime? FechaTermino { get; set; }

    public string? Valor { get; set; }

    public int? Idcliente { get; set; }
}
