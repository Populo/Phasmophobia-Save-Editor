﻿namespace Phasmophobia_Save_Editor.Models
{
    public sealed class Ghost
    {
        public static readonly Ghost Spirit = new Ghost("Spirit", 
            "Basic ghost", 
            new []{Evidence.SpiritBox, Evidence.Fingies, Evidence.GhostWriting});
        public static readonly Ghost Wraith = new Ghost("Wraith", 
            "Can fly and can go through walls", 
            new []{Evidence.Fingies, Evidence.Freezing, Evidence.SpiritBox});
        public static readonly Ghost Phantom = new Ghost("Phantom", 
            "Photos will make it disappear for a short time, Ouija boards will anger it", 
            new [] {Evidence.EMF, Evidence.GhostOrb, Evidence.Freezing});
        public static readonly Ghost Poltergeist = new Ghost("Poltergeist", 
            "Likes to throw things", 
            new []{Evidence.SpiritBox, Evidence.Fingies, Evidence.GhostOrb});
        public static readonly Ghost Banshee = new Ghost("Banshee",
            "Will target one person at a time. Use a crucifix to calm it down.",
            new[] {Evidence.EMF, Evidence.Fingies, Evidence.Freezing});
        public static readonly Ghost Jinn = new Ghost("Jinn", 
            "Territorial, can move quickly when attacking. Turn off power to slow it down.", 
            new []{Evidence.SpiritBox, Evidence.GhostOrb, Evidence.EMF});
        public static readonly Ghost Mare = new Ghost("Mare",
            "Likes the dark. Turn on lights to reduce chances to attack.",
            new[] {Evidence.SpiritBox, Evidence.GhostOrb, Evidence.Freezing});
        public static readonly Ghost Revenant = new Ghost("Revenant",
            "This ghost is very fast and, along with Jinn, can outrun you during a hunt.",
            new[] {Evidence.EMF, Evidence.Fingies, Evidence.GhostWriting});
        public static readonly Ghost Shade = new Ghost("Shade", 
            "Very shy. Do things alone to gather evidence.",
            new [] {Evidence.EMF, Evidence.GhostOrb, Evidence.GhostWriting});
        public static readonly Ghost Demon = new Ghost("Demon", 
            "Increased chance of attack. Ouija boards will not lower your sanity.",
            new [] {Evidence.SpiritBox, Evidence.GhostWriting, Evidence.Freezing});
        public static readonly Ghost Yurei = new Ghost("Yurei",
            "This ghost will drain your sanity very quickly.",
            new [] {Evidence.GhostOrb, Evidence.GhostWriting, Evidence.Freezing});
        public static readonly Ghost Oni = new Ghost("Oni",
            "Acive when multiple people are nearby. Likes to throw things.",
            new [] {Evidence.EMF, Evidence.SpiritBox, Evidence.GhostWriting});


        public static readonly Ghost[] Ghosts = new[]
        {
            Spirit,
            Wraith,
            Phantom,
            Poltergeist,
            Banshee,
            Jinn,
            Mare,
            Revenant,
            Shade,
            Demon,
            Yurei,
            Oni
        };
        
        private Ghost(string type, string desc, Evidence[] evidences)
        {
            Type = type;
            Description = desc;
            Evidences = evidences;
        }
        
        public string Type { get; }
        public string Description { get; }
        public Evidence[] Evidences { get; }

        public override string ToString()
        {
            return $"{Type} - {Description}";
        }
    }
}