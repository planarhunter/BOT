﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CypherBot.Models
{
    public class DescriptorAbility
    {
        public int DescriptorAbilityId { get; set; }
        public int DescriptorId { get; set; }
        public int Tier { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Descriptor Descriptor { get; set; }
    }
}