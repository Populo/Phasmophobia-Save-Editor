using System.Windows.Forms;

namespace Phasmophobia_Save_Editor.Models
{
    public class GhostTableRow
    {
        public Label GhostType { get; }
        public Label Evidence1 { get; }
        public Label Evidence2 { get; }
        public Label Evidence3 { get; }

        public GhostTableRow(Label ghostType, Label evidence1, Label evidence2, Label evidence3)
        {
            GhostType = ghostType;
            Evidence1 = evidence1;
            Evidence2 = evidence2;
            Evidence3 = evidence3;
        }
    }
}