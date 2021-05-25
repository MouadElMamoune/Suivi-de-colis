
namespace Suivi_de_colis
{
    partial class Gestion
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
            this.GestionDesCamionsbutton = new System.Windows.Forms.Button();
            this.GestionDesColisbutton = new System.Windows.Forms.Button();
            this.GestionDesChauffeursbutton = new System.Windows.Forms.Button();
            this.GestionDesDestinationsbutton = new System.Windows.Forms.Button();
            this.GestionDesClientsbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GestionDesCamionsbutton
            // 
            this.GestionDesCamionsbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GestionDesCamionsbutton.Location = new System.Drawing.Point(237, 153);
            this.GestionDesCamionsbutton.Name = "GestionDesCamionsbutton";
            this.GestionDesCamionsbutton.Size = new System.Drawing.Size(271, 36);
            this.GestionDesCamionsbutton.TabIndex = 8;
            this.GestionDesCamionsbutton.Text = "Gestion des camions";
            this.GestionDesCamionsbutton.UseVisualStyleBackColor = true;
            this.GestionDesCamionsbutton.Click += new System.EventHandler(this.GestionDesCamionsbutton_Click);
            // 
            // GestionDesColisbutton
            // 
            this.GestionDesColisbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GestionDesColisbutton.Location = new System.Drawing.Point(237, 263);
            this.GestionDesColisbutton.Name = "GestionDesColisbutton";
            this.GestionDesColisbutton.Size = new System.Drawing.Size(271, 36);
            this.GestionDesColisbutton.TabIndex = 9;
            this.GestionDesColisbutton.Text = "Gestion des colis";
            this.GestionDesColisbutton.UseVisualStyleBackColor = true;
            // 
            // GestionDesChauffeursbutton
            // 
            this.GestionDesChauffeursbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GestionDesChauffeursbutton.Location = new System.Drawing.Point(237, 98);
            this.GestionDesChauffeursbutton.Name = "GestionDesChauffeursbutton";
            this.GestionDesChauffeursbutton.Size = new System.Drawing.Size(271, 36);
            this.GestionDesChauffeursbutton.TabIndex = 10;
            this.GestionDesChauffeursbutton.Text = "Gestion des chauffeurs";
            this.GestionDesChauffeursbutton.UseVisualStyleBackColor = true;
            this.GestionDesChauffeursbutton.Click += new System.EventHandler(this.GestionDesChauffeursbutton_Click);
            // 
            // GestionDesDestinationsbutton
            // 
            this.GestionDesDestinationsbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GestionDesDestinationsbutton.Location = new System.Drawing.Point(237, 208);
            this.GestionDesDestinationsbutton.Name = "GestionDesDestinationsbutton";
            this.GestionDesDestinationsbutton.Size = new System.Drawing.Size(271, 36);
            this.GestionDesDestinationsbutton.TabIndex = 11;
            this.GestionDesDestinationsbutton.Text = "Gestion des destinations";
            this.GestionDesDestinationsbutton.UseVisualStyleBackColor = true;
            // 
            // GestionDesClientsbutton
            // 
            this.GestionDesClientsbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GestionDesClientsbutton.Location = new System.Drawing.Point(237, 323);
            this.GestionDesClientsbutton.Name = "GestionDesClientsbutton";
            this.GestionDesClientsbutton.Size = new System.Drawing.Size(271, 36);
            this.GestionDesClientsbutton.TabIndex = 12;
            this.GestionDesClientsbutton.Text = "Gestion des clients";
            this.GestionDesClientsbutton.UseVisualStyleBackColor = true;
            // 
            // Gestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GestionDesClientsbutton);
            this.Controls.Add(this.GestionDesDestinationsbutton);
            this.Controls.Add(this.GestionDesChauffeursbutton);
            this.Controls.Add(this.GestionDesColisbutton);
            this.Controls.Add(this.GestionDesCamionsbutton);
            this.Name = "Gestion";
            this.Text = "Gestion";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GestionDesCamionsbutton;
        private System.Windows.Forms.Button GestionDesColisbutton;
        private System.Windows.Forms.Button GestionDesChauffeursbutton;
        private System.Windows.Forms.Button GestionDesDestinationsbutton;
        private System.Windows.Forms.Button GestionDesClientsbutton;
    }
}