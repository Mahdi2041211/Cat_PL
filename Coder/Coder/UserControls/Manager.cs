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
        public static string[] GetVariablesByType(ValueBlock.CLc.Type type)
        {
            List<string> vars = new List<string>();
            foreach (string item in Variables.Keys)
            {
                if (Variables[item].Type == type)
                    vars.Add(item);
            }
            return vars.ToArray();
        }
    }
    public class Variable
    {
        public object Value { get; set; }
        public ValueBlock.CLc.Type Type { get; set; }
        public Variable() { }
        public Variable(object value, ValueBlock.CLc.Type type)
        {
            Value = value;
            Type = type;
        }
    }
}
