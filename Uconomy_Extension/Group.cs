﻿using System;
using System.Xml.Serialization;

namespace Uconomy_Essentials
{
    [XmlRoot("UconomyEConfiguration")]
    public class Group
    {
        [XmlAttribute]
        public string DisplayName { get; set;}
        [XmlAttribute]
        public decimal Salary { get; set; }
    }
}
