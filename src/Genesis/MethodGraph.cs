﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Genesis
{
    public enum MethodVisibilities
    {
        Public,
        Private,
        Internal,
        Protected
    }

    public class MethodGraph : Graph
    {
        public override GraphTypes GraphType => GraphTypes.Method;
        public Type ReturnDataType { get; set; }
        public MethodVisibilities MethodVisibility { get; set; } = MethodVisibilities.Public;
        public List<ParameterGraph> Parameters { get; } = new List<ParameterGraph>();
        public string Name { get; set; }
        public bool HasGenericParams { get; set; }
        public bool IsGeneric { get; set; }
        public string ReturnTypeFormattedName { get; set; }
    }
}
