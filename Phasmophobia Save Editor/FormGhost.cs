using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;
using System.Windows.Forms;
using Phasmophobia_Save_Editor.Models;

namespace Phasmophobia_Save_Editor
{
    public partial class FormGhost : Form
    {
        private Ghost _ghost;
        private Dictionary<Evidence, CheckBox> Evidences;
        private Dictionary<Ghost, Label> Ghosts;

        public FormGhost(string ghostName)
        {
            InitializeComponent();
            _ghost = Ghost.Ghosts.First(g => g.Type == ghostName);
            Evidences = new Dictionary<Evidence, CheckBox>()
            {
                {Evidence.EMF, checkBoxEMF},
                {Evidence.FINGIES, checkBoxFingies},
                {Evidence.GHOST_ORB, checkBoxOrb},
                {Evidence.SPIRIT_BOX, checkBoxSpiritBox},
                {Evidence.GHOST_WRITING, checkBoxWriting},
                {Evidence.FREEZING_TEMPS, checkBoxFreezing}
            };
            Ghosts = new Dictionary<Ghost, Label>()
            {
                {Ghost.Spirit, labelSpirit},
                {Ghost.Shade, labelShade},
                {Ghost.Phantom, labelPhantom},
                {Ghost.Jinn, labelJinn},
                {Ghost.Yurei, labelYurei},
                {Ghost.Mare, labelMare},
                {Ghost.Demon, labelDemon},
                {Ghost.Banshee, labelBanshee},
                {Ghost.Revenant, labelRevenant},
                {Ghost.Oni, labelOni},
                {Ghost.Poltergeist, labelPoltergeist},
                {Ghost.Wraith, labelWraith}
            };
        }
        
        public FormGhost()
        {
            InitializeComponent();
        }

        private void buttonHint_Click(object sender, EventArgs e)
        {
            if (_ghost == null) return;
            
            var r = new Random();
            var nocheck = Evidences.Values.Where(x => !x.Checked && x.Enabled);
            var checkBoxes = nocheck.ToList();
            if (!checkBoxes.Any()) return;
            
            var box = checkBoxes.ElementAt(r.Next(0, checkBoxes.Count()));
            var evidence = Evidences.First(x => x.Value == box).Key;

            if (_ghost.Evidences.Contains(evidence)) box.Checked = true;
            else box.Enabled = false;
            
        }

        private void buttonSolve_Click(object sender, EventArgs e)
        {
            if (_ghost == null) return;

            var boxes = Evidences.Where(x => _ghost.Evidences.Any(y => x.Key == y)).ToDictionary(k => k.Key, v => v.Value);
            boxes.Values.All(b => b.Checked = true);
        }

        private void checkbox_Check(object sender, EventArgs e)
        {
            var check = Evidences.Where(c => c.Value.Checked).ToDictionary(c => c.Key, c => c.Value);
            var notPossibleGhosts = Ghosts.Where(g => check.Keys.Any(c => !g.Key.Evidences.Contains(c))).ToDictionary(d => d.Key, v => v.Value);
            var possible = Ghosts.Except(notPossibleGhosts).ToDictionary(k => k.Key, v => v.Value);

            foreach (var l in notPossibleGhosts.Values)
            {
                l.Enabled = false;
            }

            foreach (var l in possible.Values)
            {
                l.Enabled = true;
            }
        }

        private void FormGhost_Load(object sender, EventArgs e)
        {
            foreach (var g in Ghosts.Keys)
            {
                Ghosts[g].Text = g.ToString();
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            foreach (var c in Evidences.Values)
            {
                c.Checked = false;
                c.Enabled = true;
            }
        }
    }
}