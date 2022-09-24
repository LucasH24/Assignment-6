using System;
using System.Collections.Generic;

namespace Assignment6;

    public abstract class Media
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public abstract String Display();
    }
