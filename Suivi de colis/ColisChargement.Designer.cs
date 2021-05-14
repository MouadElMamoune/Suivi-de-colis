
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
            this.DestinationCCcomboBox = new System.Windows.Forms.ComboBox();
            this.DestinationPLlabel = new System.Windows.Forms.Label();
            this.CamionPLlabel = new System.Windows.Forms.Label();
            this.CamionCCcomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ColisCCDechargercheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.ColisCCChargercheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.SuivantCCbutton = new System.Windows.Forms.Button();
            this.PrécédentCCbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DestinationCCcomboBox
            // 
            this.DestinationCCcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DestinationCCcomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DestinationCCcomboBox.FormattingEnabled = true;
            this.DestinationCCcomboBox.Location = new System.Drawing.Point(587, 35);
            this.DestinationCCcomboBox.Name = "DestinationCCcomboBox";
            this.DestinationCCcomboBox.Size = new System.Drawing.Size(180, 33);
            this.DestinationCCcomboBox.TabIndex = 7;
            this.DestinationCCcomboBox.SelectedIndexChanged += new System.EventHandler(this.DestinationCCcomboBox_SelectedIndexChanged);
            // 
            // DestinationPLlabel
            // 
            this.DestinationPLlabel.AutoSize = true;
            this.DestinationPLlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DestinationPLlabel.Location = new System.Drawing.Point(449, 38);
            this.DestinationPLlabel.Name = "DestinationPLlabel";
            this.DestinationPLlabel.Size = new System.Drawing.Size(138, 25);
            this.DestinationPLlabel.TabIndex = 6;
            this.DestinationPLlabel.Text = "Destination 1";
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
            this.CamionCCcomboBox.Enabled = false;
            this.CamionCCcomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CamionCCcomboBox.FormattingEnabled = true;
            this.CamionCCcomboBox.Location = new System.Drawing.Point(134, 36);
            this.CamionCCcomboBox.Name = "CamionCCcomboBox";
            this.CamionCCcomboBox.Size = new System.Drawing.Size(180, 33);
            this.CamionCCcomboBox.TabIndex = 4;
            this.CamionCCcomboBox.SelectedIndexChanged += new System.EventHandler(this.CamionCCcomboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Colis à charger";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(475, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Colis à décharger";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ColisCCDechargercheckedListBox
            // 
            this.ColisCCDechargercheckedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColisCCDechargercheckedListBox.FormattingEnabled = true;
            this.ColisCCDechargercheckedListBox.Location = new System.Drawing.Point(432, 127);
            this.ColisCCDechargercheckedListBox.MultiColumn = true;
            this.ColisCCDechargercheckedListBox.Name = "ColisCCDechargercheckedListBox";
            this.ColisCCDechargercheckedListBox.Size = new System.Drawing.Size(258, 160);
            this.ColisCCDechargercheckedListBox.Sorted = true;
            this.ColisCCDechargercheckedListBox.TabIndex = 11;
            this.ColisCCDechargercheckedListBox.SelectedIndexChanged += new System.EventHandler(this.ColisCCDechargercheckedListBox_SelectedIndexChanged);
            // 
            // ColisCCChargercheckedListBox
            // 
            this.ColisCCChargercheckedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColisCCChargercheckedListBox.FormattingEnabled = true;
            this.ColisCCChargercheckedListBox.Location = new System.Drawing.Point(91, 127);
            this.ColisCCChargercheckedListBox.MultiColumn = true;
            this.ColisCCChargercheckedListBox.Name = "ColisCCChargercheckedListBox";
            this.ColisCCChargercheckedListBox.Size = new System.Drawing.Size(258, 160);
            this.ColisCCChargercheckedListBox.Sorted = true;
            this.ColisCCChargercheckedListBox.TabIndex = 13;
            this.ColisCCChargercheckedListBox.SelectedIndexChanged += new System.EventHandler(this.ColisCCChargercheckedListBox_SelectedIndexChanged);
            // 
            // SuivantCCbutton
            // 
            this.SuivantCCbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuivantCCbutton.Location = new System.Drawing.Point(476, 363);
            this.SuivantCCbutton.Name = "SuivantCCbutton";
            this.SuivantCCbutton.Size = new System.Drawing.Size(180, 36);
            this.SuivantCCbutton.TabIndex = 15;
            this.SuivantCCbutton.Text = "Suivant";
            this.SuivantCCbutton.UseVisualStyleBackColor = true;
            this.SuivantCCbutton.Click += new System.EventHandler(this.SuivantCCbutton_Click);
            // 
            // PrécédentCCbutton
            // 
            this.PrécédentCCbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrécédentCCbutton.Location = new System.Drawing.Point(125, 363);
            this.PrécédentCCbutton.Name = "PrécédentCCbutton";
            this.PrécédentCCbutton.Size = new System.Drawing.Size(180, 36);
            this.PrécédentCCbutton.TabIndex = 16;
            this.PrécédentCCbutton.Text = "Précédent";
            this.PrécédentCCbutton.UseVisualStyleBackColor = true;
            this.PrécédentCCbutton.Click += new System.EventHandler(this.PrécédentCCbutton_Click);
            // 
            // ColisChargement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PrécédentCCbutton);
            this.Controls.Add(this.SuivantCCbutton);
            this.Controls.Add(this.ColisCCChargercheckedListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ColisCCDechargercheckedListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DestinationCCcomboBox);
            this.Controls.Add(this.DestinationPLlabel);
            this.Controls.Add(this.CamionPLlabel);
            this.Controls.Add(this.CamionCCcomboBox);
            this.Name = "ColisChargement";
            this.Text = "ColisChargement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox DestinationCCcomboBox;
        private System.Windows.Forms.Label DestinationPLlabel;
        private System.Windows.Forms.Label CamionPLlabel;
        private System.Windows.Forms.ComboBox CamionCCcomboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox ColisCCDechargercheckedListBox;
        private System.Windows.Forms.CheckedListBox ColisCCChargercheckedListBox;
        private System.Windows.Forms.Button SuivantCCbutton;
        private System.Windows.Forms.Button PrécédentCCbutton;
    }
}