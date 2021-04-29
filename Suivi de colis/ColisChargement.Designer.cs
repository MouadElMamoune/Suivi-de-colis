
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
            this.lieuChargementCCcomboBox = new System.Windows.Forms.ComboBox();
            this.lieuChargementPLlabel = new System.Windows.Forms.Label();
            this.camionPLlabel = new System.Windows.Forms.Label();
            this.camionCCcomboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lieuChargementCCcomboBox
            // 
            this.lieuChargementCCcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lieuChargementCCcomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lieuChargementCCcomboBox.FormattingEnabled = true;
            this.lieuChargementCCcomboBox.Location = new System.Drawing.Point(304, 75);
            this.lieuChargementCCcomboBox.Name = "lieuChargementCCcomboBox";
            this.lieuChargementCCcomboBox.Size = new System.Drawing.Size(180, 33);
            this.lieuChargementCCcomboBox.TabIndex = 7;
            // 
            // lieuChargementPLlabel
            // 
            this.lieuChargementPLlabel.AutoSize = true;
            this.lieuChargementPLlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lieuChargementPLlabel.Location = new System.Drawing.Point(32, 78);
            this.lieuChargementPLlabel.Name = "lieuChargementPLlabel";
            this.lieuChargementPLlabel.Size = new System.Drawing.Size(202, 25);
            this.lieuChargementPLlabel.TabIndex = 6;
            this.lieuChargementPLlabel.Text = "Lieu de chargement";
            // 
            // camionPLlabel
            // 
            this.camionPLlabel.AutoSize = true;
            this.camionPLlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.camionPLlabel.Location = new System.Drawing.Point(32, 38);
            this.camionPLlabel.Name = "camionPLlabel";
            this.camionPLlabel.Size = new System.Drawing.Size(85, 25);
            this.camionPLlabel.TabIndex = 5;
            this.camionPLlabel.Text = "Camion";
            // 
            // camionCCcomboBox
            // 
            this.camionCCcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.camionCCcomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.camionCCcomboBox.FormattingEnabled = true;
            this.camionCCcomboBox.Location = new System.Drawing.Point(304, 35);
            this.camionCCcomboBox.Name = "camionCCcomboBox";
            this.camionCCcomboBox.Size = new System.Drawing.Size(180, 33);
            this.camionCCcomboBox.TabIndex = 4;
            // 
            // ColisChargement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lieuChargementCCcomboBox);
            this.Controls.Add(this.lieuChargementPLlabel);
            this.Controls.Add(this.camionPLlabel);
            this.Controls.Add(this.camionCCcomboBox);
            this.Name = "ColisChargement";
            this.Text = "ColisChargement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox lieuChargementCCcomboBox;
        private System.Windows.Forms.Label lieuChargementPLlabel;
        private System.Windows.Forms.Label camionPLlabel;
        private System.Windows.Forms.ComboBox camionCCcomboBox;
    }
}