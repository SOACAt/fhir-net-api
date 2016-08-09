﻿/*
* Copyright (c) 2016, Furore (info@furore.com) and contributors
* See the file CONTRIBUTORS for details.
*
* This file is licensed under the BSD 3-Clause license
*/

using Hl7.Fhir.Specification.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Fhir.Validation
{
    public class Outcome
    {
        public Group Type;
        public Vector Vector;
        public string Message;
        public int Nesting;
        public Status Kind;

        public Outcome(Group group, Status kind, Vector vector, string message, int nesting = 0)
        {
            this.Type = group;
            this.Kind = kind;
            this.Vector = vector;
            this.Message = message;
            this.Nesting = nesting;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}: {2}", this.Type, Kind.ToString().ToLower(), this.Message);
        }
    }
}