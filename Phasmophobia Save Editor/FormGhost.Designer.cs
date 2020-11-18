using System.ComponentModel;

namespace Phasmophobia_Save_Editor
{
    partial class FormGhost
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxEMF = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxFreezing = new System.Windows.Forms.CheckBox();
            this.checkBoxWriting = new System.Windows.Forms.CheckBox();
            this.checkBoxOrb = new System.Windows.Forms.CheckBox();
            this.checkBoxFingies = new System.Windows.Forms.CheckBox();
            this.checkBoxSpiritBox = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelWraith = new System.Windows.Forms.Label();
            this.labelPoltergeist = new System.Windows.Forms.Label();
            this.labelOni = new System.Windows.Forms.Label();
            this.labelRevenant = new System.Windows.Forms.Label();
            this.labelBanshee = new System.Windows.Forms.Label();
            this.labelDemon = new System.Windows.Forms.Label();
            this.labelMare = new System.Windows.Forms.Label();
            this.labelYurei = new System.Windows.Forms.Label();
            this.labelJinn = new System.Windows.Forms.Label();
            this.labelPhantom = new System.Windows.Forms.Label();
            this.labelShade = new System.Windows.Forms.Label();
            this.labelSpirit = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonHint = new System.Windows.Forms.Button();
            this.buttonSolve = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Evidence";
            // 
            // checkBoxEMF
            // 
            this.checkBoxEMF.Location = new System.Drawing.Point(5, 3);
            this.checkBoxEMF.Name = "checkBoxEMF";
            this.checkBoxEMF.Size = new System.Drawing.Size(101, 23);
            this.checkBoxEMF.TabIndex = 1;
            this.checkBoxEMF.Text = "EMF Level 5";
            this.checkBoxEMF.UseVisualStyleBackColor = true;
            this.checkBoxEMF.CheckedChanged += new System.EventHandler(this.checkbox_Check);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBoxFreezing);
            this.panel1.Controls.Add(this.checkBoxWriting);
            this.panel1.Controls.Add(this.checkBoxOrb);
            this.panel1.Controls.Add(this.checkBoxFingies);
            this.panel1.Controls.Add(this.checkBoxSpiritBox);
            this.panel1.Controls.Add(this.checkBoxEMF);
            this.panel1.Location = new System.Drawing.Point(12, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(109, 178);
            this.panel1.TabIndex = 2;
            // 
            // checkBoxFreezing
            // 
            this.checkBoxFreezing.Location = new System.Drawing.Point(5, 148);
            this.checkBoxFreezing.Name = "checkBoxFreezing";
            this.checkBoxFreezing.Size = new System.Drawing.Size(101, 23);
            this.checkBoxFreezing.TabIndex = 6;
            this.checkBoxFreezing.Text = "Freezing Temps";
            this.checkBoxFreezing.UseVisualStyleBackColor = true;
            this.checkBoxFreezing.CheckedChanged += new System.EventHandler(this.checkbox_Check);
            // 
            // checkBoxWriting
            // 
            this.checkBoxWriting.Location = new System.Drawing.Point(5, 119);
            this.checkBoxWriting.Name = "checkBoxWriting";
            this.checkBoxWriting.Size = new System.Drawing.Size(101, 23);
            this.checkBoxWriting.TabIndex = 5;
            this.checkBoxWriting.Text = "Ghost Writing";
            this.checkBoxWriting.UseVisualStyleBackColor = true;
            this.checkBoxWriting.CheckedChanged += new System.EventHandler(this.checkbox_Check);
            // 
            // checkBoxOrb
            // 
            this.checkBoxOrb.Location = new System.Drawing.Point(5, 90);
            this.checkBoxOrb.Name = "checkBoxOrb";
            this.checkBoxOrb.Size = new System.Drawing.Size(101, 23);
            this.checkBoxOrb.TabIndex = 4;
            this.checkBoxOrb.Text = "Ghost Orb";
            this.checkBoxOrb.UseVisualStyleBackColor = true;
            this.checkBoxOrb.CheckedChanged += new System.EventHandler(this.checkbox_Check);
            // 
            // checkBoxFingies
            // 
            this.checkBoxFingies.Location = new System.Drawing.Point(5, 61);
            this.checkBoxFingies.Name = "checkBoxFingies";
            this.checkBoxFingies.Size = new System.Drawing.Size(101, 23);
            this.checkBoxFingies.TabIndex = 3;
            this.checkBoxFingies.Text = "Fingies";
            this.checkBoxFingies.UseVisualStyleBackColor = true;
            this.checkBoxFingies.CheckedChanged += new System.EventHandler(this.checkbox_Check);
            // 
            // checkBoxSpiritBox
            // 
            this.checkBoxSpiritBox.Location = new System.Drawing.Point(5, 32);
            this.checkBoxSpiritBox.Name = "checkBoxSpiritBox";
            this.checkBoxSpiritBox.Size = new System.Drawing.Size(101, 23);
            this.checkBoxSpiritBox.TabIndex = 2;
            this.checkBoxSpiritBox.Text = "Spirit Box";
            this.checkBoxSpiritBox.UseVisualStyleBackColor = true;
            this.checkBoxSpiritBox.CheckedChanged += new System.EventHandler(this.checkbox_Check);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelWraith);
            this.panel2.Controls.Add(this.labelPoltergeist);
            this.panel2.Controls.Add(this.labelOni);
            this.panel2.Controls.Add(this.labelRevenant);
            this.panel2.Controls.Add(this.labelBanshee);
            this.panel2.Controls.Add(this.labelDemon);
            this.panel2.Controls.Add(this.labelMare);
            this.panel2.Controls.Add(this.labelYurei);
            this.panel2.Controls.Add(this.labelJinn);
            this.panel2.Controls.Add(this.labelPhantom);
            this.panel2.Controls.Add(this.labelShade);
            this.panel2.Controls.Add(this.labelSpirit);
            this.panel2.Location = new System.Drawing.Point(127, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(449, 234);
            this.panel2.TabIndex = 3;
            // 
            // labelWraith
            // 
            this.labelWraith.Location = new System.Drawing.Point(3, 205);
            this.labelWraith.Name = "labelWraith";
            this.labelWraith.Size = new System.Drawing.Size(443, 18);
            this.labelWraith.TabIndex = 15;
            this.labelWraith.Text = "Wraith";
            // 
            // labelPoltergeist
            // 
            this.labelPoltergeist.Location = new System.Drawing.Point(3, 187);
            this.labelPoltergeist.Name = "labelPoltergeist";
            this.labelPoltergeist.Size = new System.Drawing.Size(443, 18);
            this.labelPoltergeist.TabIndex = 14;
            this.labelPoltergeist.Text = "Poltergeist";
            // 
            // labelOni
            // 
            this.labelOni.Location = new System.Drawing.Point(3, 169);
            this.labelOni.Name = "labelOni";
            this.labelOni.Size = new System.Drawing.Size(443, 18);
            this.labelOni.TabIndex = 6;
            this.labelOni.Text = "Oni";
            // 
            // labelRevenant
            // 
            this.labelRevenant.Location = new System.Drawing.Point(3, 151);
            this.labelRevenant.Name = "labelRevenant";
            this.labelRevenant.Size = new System.Drawing.Size(443, 18);
            this.labelRevenant.TabIndex = 13;
            this.labelRevenant.Text = "Revenant";
            // 
            // labelBanshee
            // 
            this.labelBanshee.Location = new System.Drawing.Point(3, 133);
            this.labelBanshee.Name = "labelBanshee";
            this.labelBanshee.Size = new System.Drawing.Size(443, 18);
            this.labelBanshee.TabIndex = 12;
            this.labelBanshee.Text = "Banshee";
            // 
            // labelDemon
            // 
            this.labelDemon.Location = new System.Drawing.Point(3, 115);
            this.labelDemon.Name = "labelDemon";
            this.labelDemon.Size = new System.Drawing.Size(443, 18);
            this.labelDemon.TabIndex = 11;
            this.labelDemon.Text = "Demon";
            // 
            // labelMare
            // 
            this.labelMare.Location = new System.Drawing.Point(3, 97);
            this.labelMare.Name = "labelMare";
            this.labelMare.Size = new System.Drawing.Size(443, 18);
            this.labelMare.TabIndex = 10;
            this.labelMare.Text = "Mare";
            // 
            // labelYurei
            // 
            this.labelYurei.Location = new System.Drawing.Point(3, 79);
            this.labelYurei.Name = "labelYurei";
            this.labelYurei.Size = new System.Drawing.Size(443, 18);
            this.labelYurei.TabIndex = 9;
            this.labelYurei.Text = "Yurei";
            // 
            // labelJinn
            // 
            this.labelJinn.Location = new System.Drawing.Point(3, 61);
            this.labelJinn.Name = "labelJinn";
            this.labelJinn.Size = new System.Drawing.Size(443, 18);
            this.labelJinn.TabIndex = 8;
            this.labelJinn.Text = "Jinn";
            // 
            // labelPhantom
            // 
            this.labelPhantom.Location = new System.Drawing.Point(3, 44);
            this.labelPhantom.Name = "labelPhantom";
            this.labelPhantom.Size = new System.Drawing.Size(443, 18);
            this.labelPhantom.TabIndex = 7;
            this.labelPhantom.Text = "Phantom";
            // 
            // labelShade
            // 
            this.labelShade.Location = new System.Drawing.Point(3, 26);
            this.labelShade.Name = "labelShade";
            this.labelShade.Size = new System.Drawing.Size(443, 18);
            this.labelShade.TabIndex = 6;
            this.labelShade.Text = "Shade";
            // 
            // labelSpirit
            // 
            this.labelSpirit.Location = new System.Drawing.Point(3, 8);
            this.labelSpirit.Name = "labelSpirit";
            this.labelSpirit.Size = new System.Drawing.Size(443, 18);
            this.labelSpirit.TabIndex = 5;
            this.labelSpirit.Text = "Spirit";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(127, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ghosts";
            // 
            // buttonHint
            // 
            this.buttonHint.Location = new System.Drawing.Point(341, 4);
            this.buttonHint.Name = "buttonHint";
            this.buttonHint.Size = new System.Drawing.Size(109, 23);
            this.buttonHint.TabIndex = 5;
            this.buttonHint.Text = "Hint";
            this.buttonHint.UseVisualStyleBackColor = true;
            this.buttonHint.Click += new System.EventHandler(this.buttonHint_Click);
            // 
            // buttonSolve
            // 
            this.buttonSolve.Location = new System.Drawing.Point(210, 4);
            this.buttonSolve.Name = "buttonSolve";
            this.buttonSolve.Size = new System.Drawing.Size(109, 23);
            this.buttonSolve.TabIndex = 6;
            this.buttonSolve.Text = "Solve";
            this.buttonSolve.UseVisualStyleBackColor = true;
            this.buttonSolve.Click += new System.EventHandler(this.buttonSolve_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(467, 4);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(109, 23);
            this.buttonReset.TabIndex = 7;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // FormGhost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 275);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonSolve);
            this.Controls.Add(this.buttonHint);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormGhost";
            this.Text = "Ghost Helper";
            this.Load += new System.EventHandler(this.FormGhost_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button buttonReset;

        private System.Windows.Forms.Button buttonHint;
        private System.Windows.Forms.Button buttonSolve;
        private System.Windows.Forms.Label labelBanshee;
        private System.Windows.Forms.Label labelDemon;
        private System.Windows.Forms.Label labelOni;
        private System.Windows.Forms.Label labelPoltergeist;
        private System.Windows.Forms.Label labelRevenant;
        private System.Windows.Forms.Label labelWraith;

        private System.Windows.Forms.Label labelJinn;
        private System.Windows.Forms.Label labelMare;
        private System.Windows.Forms.Label labelPhantom;
        private System.Windows.Forms.Label labelYurei;

        private System.Windows.Forms.Label labelShade;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelSpirit;
        private System.Windows.Forms.Panel panel2;

        private System.Windows.Forms.CheckBox checkBoxFreezing;

        private System.Windows.Forms.CheckBox checkBoxWriting;

        private System.Windows.Forms.CheckBox checkBoxOrb;

        private System.Windows.Forms.CheckBox checkBoxFingies;

        private System.Windows.Forms.CheckBox checkBoxSpiritBox;

        private System.Windows.Forms.CheckBox checkBoxEMF;
        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}