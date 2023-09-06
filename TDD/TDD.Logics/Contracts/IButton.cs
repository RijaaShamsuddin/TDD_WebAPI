using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.Logics.Contracts
{
    public enum TypeEnum
    {
        Submit = 0,
        Reset = 1,
        Button = 2,
    }
    public interface IButton
    {
        public TypeEnum Type { get; set; }
        public string Text { get; set; }
        public string Value { get; set; }

    }
}
