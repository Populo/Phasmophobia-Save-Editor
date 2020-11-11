using System.Windows.Forms;

namespace Phasmophobia_Save_Editor
{
    internal class SaveValue
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public string Category { get; set; }
        public NumericUpDown NumberBox { get; set; }

        public void SetValue(int multiple = 1)
        {
            Value = (NumberBox.Value * multiple).ToString();
        }

        public void GetValue(int divide = 1)
        {
            NumberBox.Text = (int.Parse(Value) / divide).ToString();
        }
    }
}