﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkau_Html_Intro.DAL.Entities
{
    public class DrugGroup
    {
        public int Id { set; get; }

        public string Name { set; get; }

        public List<Drug> Drugs { set; get; }
    }
}
