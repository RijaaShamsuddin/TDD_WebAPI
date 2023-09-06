using TDD.Logics.Contracts;

namespace TDD.Logics.DataModels
{

    internal class ButtonDataModel : IButton
    {
        public TypeEnum Type { get; set; }
        public string Text { get; set; }
        public string Value { get; set; }
    }
}
