﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.exceptions
{
    internal class NotFoundException
    {
        public NotFoundException(string message = "polozka nebyla nalezena") : base(message)
        {
        }
    }
}
