﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public interface IMyDependency
    {
        Task WriteMessage(string message);
    }
}
