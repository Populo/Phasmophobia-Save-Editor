namespace Phasmophobia_Save_Editor.Models
{
    public sealed class Evidence
    {
        public static readonly Evidence EMF = new Evidence("EMF Level 5");
        public static readonly Evidence SpiritBox = new Evidence("Spirit Box");
        public static readonly Evidence Fingies = new Evidence("Fingies");
        public static readonly Evidence GhostOrb = new Evidence("Ghost Orb");
        public static readonly Evidence GhostWriting = new Evidence("Ghost Writing");
        public static readonly Evidence Freezing = new Evidence("Freezing Temperatures");
        
        public string Name { get; }
        public Evidence(string name)
        {
            Name = name;
        }

        public override string ToString() => Name;
    }
}