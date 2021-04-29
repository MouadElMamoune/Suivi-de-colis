
namespace Suivi_de_colis
{
    partial class DestinationDesignation
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
            this.CamionDDlabel = new System.Windows.Forms.Label();
            this.CamionDDcomboBox = new System.Windows.Forms.ComboBox();
            this.DestinationDDlabel = new System.Windows.Forms.Label();
            this.DestinationDDcomboBox = new System.Windows.Forms.ComboBox();
            this.ContinuerDDbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CamionDDlabel
            // 
            this.CamionDDlabel.AutoSize = true;
            this.CamionDDlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CamionDDlabel.Location = new System.Drawing.Point(26, 59);
            this.CamionDDlabel.Name = "CamionDDlabel";
            this.CamionDDlabel.Size = new System.Drawing.Size(85, 25);
            this.CamionDDlabel.TabIndex = 3;
            this.CamionDDlabel.Text = "Camion";
            // 
            // CamionDDcomboBox
            // 
            this.CamionDDcomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CamionDDcomboBox.FormattingEnabled = true;
            this.CamionDDcomboBox.Location = new System.Drawing.Point(298, 56);
            this.CamionDDcomboBox.Name = "CamionDDcomboBox";
            this.CamionDDcomboBox.Size = new System.Drawing.Size(180, 33);
            this.CamionDDcomboBox.TabIndex = 2;
            this.CamionDDcomboBox.SelectedIndexChanged += new System.EventHandler(this.CamionDDcomboBox_SelectedIndexChanged);
            // 
            // DestinationDDlabel
            // 
            this.DestinationDDlabel.AutoSize = true;
            this.DestinationDDlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DestinationDDlabel.Location = new System.Drawing.Point(26, 123);
            this.DestinationDDlabel.Name = "DestinationDDlabel";
            this.DestinationDDlabel.Size = new System.Drawing.Size(120, 25);
            this.DestinationDDlabel.TabIndex = 5;
            this.DestinationDDlabel.Text = "Destination";
            // 
            // DestinationDDcomboBox
            // 
            this.DestinationDDcomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DestinationDDcomboBox.FormattingEnabled = true;
            this.DestinationDDcomboBox.Location = new System.Drawing.Point(298, 120);
            this.DestinationDDcomboBox.Name = "DestinationDDcomboBox";
            this.DestinationDDcomboBox.Size = new System.Drawing.Size(180, 33);
            this.DestinationDDcomboBox.TabIndex = 4;
            this.DestinationDDcomboBox.SelectedIndexChanged += new System.EventHandler(this.DestinationDDcomboBox_SelectedIndexChanged);
            // 
            // ContinuerDDbutton
            // 
            this.ContinuerDDbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContinuerDDbutton.Location = new System.Drawing.Point(144, 191);
            this.ContinuerDDbutton.Name = "ContinuerDDbutton";
            this.ContinuerDDbutton.Size = new System.Drawing.Size(180, 36);
            this.ContinuerDDbutton.TabIndex = 8;
            this.ContinuerDDbutton.Text = "Continuer";
            this.ContinuerDDbutton.UseVisualStyleBackColor = true;
            this.ContinuerDDbutton.Click += new System.EventHandler(this.ContinuerDDbutton_Click);
            // 
            // DestinationDesignation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ContinuerDDbutton);
            this.Controls.Add(this.DestinationDDlabel);
            this.Controls.Add(this.DestinationDDcomboBox);
            this.Controls.Add(this.CamionDDlabel);
            this.Controls.Add(this.CamionDDcomboBox);
            this.Name = "DestinationDesignation";
            this.Text = "DestinationDesignation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CamionDDlabel;
        private System.Windows.Forms.ComboBox CamionDDcomboBox;
        private System.Windows.Forms.Label DestinationDDlabel;
        private System.Windows.Forms.ComboBox DestinationDDcomboBox;
        private System.Windows.Forms.Button ContinuerDDbutton;
    }
}