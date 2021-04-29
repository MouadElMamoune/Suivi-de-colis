
namespace Suivi_de_colis
{
    partial class ColisChargement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.LieuChargementCCcomboBox = new System.Windows.Forms.ComboBox();
            this.LieuChargementPLlabel = new System.Windows.Forms.Label();
            this.CamionPLlabel = new System.Windows.Forms.Label();
            this.CamionCCcomboBox = new System.Windows.Forms.ComboBox();
            this.ColisCCcheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ChargerCCbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LieuChargementCCcomboBox
            // 
            this.LieuChargementCCcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LieuChargementCCcomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LieuChargementCCcomboBox.FormattingEnabled = true;
            this.LieuChargementCCcomboBox.Location = new System.Drawing.Point(304, 75);
            this.LieuChargementCCcomboBox.Name = "LieuChargementCCcomboBox";
            this.LieuChargementCCcomboBox.Size = new System.Drawing.Size(180, 33);
            this.LieuChargementCCcomboBox.TabIndex = 7;
            // 
            // LieuChargementPLlabel
            // 
            this.LieuChargementPLlabel.AutoSize = true;
            this.LieuChargementPLlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LieuChargementPLlabel.Location = new System.Drawing.Point(32, 78);
            this.LieuChargementPLlabel.Name = "LieuChargementPLlabel";
            this.LieuChargementPLlabel.Size = new System.Drawing.Size(202, 25);
            this.LieuChargementPLlabel.TabIndex = 6;
            this.LieuChargementPLlabel.Text = "Lieu de chargement";
            // 
            // CamionPLlabel
            // 
            this.CamionPLlabel.AutoSize = true;
            this.CamionPLlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CamionPLlabel.Location = new System.Drawing.Point(32, 38);
            this.CamionPLlabel.Name = "CamionPLlabel";
            this.CamionPLlabel.Size = new System.Drawing.Size(85, 25);
            this.CamionPLlabel.TabIndex = 5;
            this.CamionPLlabel.Text = "Camion";
            // 
            // CamionCCcomboBox
            // 
            this.CamionCCcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CamionCCcomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CamionCCcomboBox.FormattingEnabled = true;
            this.CamionCCcomboBox.Location = new System.Drawing.Point(304, 35);
            this.CamionCCcomboBox.Name = "CamionCCcomboBox";
            this.CamionCCcomboBox.Size = new System.Drawing.Size(180, 33);
            this.CamionCCcomboBox.TabIndex = 4;
            this.CamionCCcomboBox.SelectedIndexChanged += new System.EventHandler(this.CamionCCcomboBox_SelectedIndexChanged);
            // 
            // ColisCCcheckedListBox
            // 
            this.ColisCCcheckedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColisCCcheckedListBox.FormattingEnabled = true;
            this.ColisCCcheckedListBox.Location = new System.Drawing.Point(134, 166);
            this.ColisCCcheckedListBox.MultiColumn = true;
            this.ColisCCcheckedListBox.Name = "ColisCCcheckedListBox";
            this.ColisCCcheckedListBox.Size = new System.Drawing.Size(490, 160);
            this.ColisCCcheckedListBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(282, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Colis à charger";
            // 
            // ChargerCCbutton
            // 
            this.ChargerCCbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChargerCCbutton.Location = new System.Drawing.Point(287, 362);
            this.ChargerCCbutton.Name = "ChargerCCbutton";
            this.ChargerCCbutton.Size = new System.Drawing.Size(180, 36);
            this.ChargerCCbutton.TabIndex = 10;
            this.ChargerCCbutton.Text = "Charger";
            this.ChargerCCbutton.UseVisualStyleBackColor = true;
            this.ChargerCCbutton.Click += new System.EventHandler(this.ChargerCCbutton_Click);
            // 
            // ColisChargement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ChargerCCbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ColisCCcheckedListBox);
            this.Controls.Add(this.LieuChargementCCcomboBox);
            this.Controls.Add(this.LieuChargementPLlabel);
            this.Controls.Add(this.CamionPLlabel);
            this.Controls.Add(this.CamionCCcomboBox);
            this.Name = "ColisChargement";
            this.Text = "ColisChargement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox LieuChargementCCcomboBox;
        private System.Windows.Forms.Label LieuChargementPLlabel;
        private System.Windows.Forms.Label CamionPLlabel;
        private System.Windows.Forms.ComboBox CamionCCcomboBox;
        private System.Windows.Forms.CheckedListBox ColisCCcheckedListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ChargerCCbutton;
    }
}