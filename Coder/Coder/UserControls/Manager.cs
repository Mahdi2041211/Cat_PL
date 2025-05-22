using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coder.UserControls.Block;

namespace Coder.UserControls
{
    public static class Manager
    {
        public static Dictionary<string, Variable> Variables = new Dictionary<string, Variable>();

    }
    public class Variable
    {
        public object Value { get; set; }
        public Type Type { get; set; }
        public Variable() { }
        public Variable(object value, Type type)
        {
            Value = value;
            Type = type;
        }
    }
    public enum Type { Number = 0, String = 1, Bool = 2 }
}
