﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEF.Core.Entities;

public class Setting
{
    public int Id { get; set; }
    public string? Key { get; set; }
    public string? Value { get; set; }
}
