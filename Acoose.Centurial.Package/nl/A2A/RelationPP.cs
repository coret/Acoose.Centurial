﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Acoose.Centurial.Package.nl.A2A
{
    public class RelationPP
    {
        [XmlElement("PersonKeyRef")]
        public string[] PersonKeyRef
        {
            get;
            set;
        }
        [XmlElement]
        public string RelationType
        {
            get;
            set;
        }
    }
}