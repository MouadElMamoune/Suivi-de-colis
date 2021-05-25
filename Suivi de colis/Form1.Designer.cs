
namespace Suivi_de_colis
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.PlanifierLivraisonbutton = new System.Windows.Forms.Button();
            this.SuiviActuelbutton = new System.Windows.Forms.Button();
            this.Gestionbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PlanifierLivraisonbutton
            // 
            this.PlanifierLivraisonbutton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.PlanifierLivraisonbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlanifierLivraisonbutton.Location = new System.Drawing.Point(274, 143);
            this.PlanifierLivraisonbutton.Name = "PlanifierLivraisonbutton";
            this.PlanifierLivraisonbutton.Size = new System.Drawing.Size(194, 42);
            this.PlanifierLivraisonbutton.TabIndex = 0;
            this.PlanifierLivraisonbutton.Text = "Planifier Livraison";
            this.PlanifierLivraisonbutton.UseVisualStyleBackColor = false;
            this.PlanifierLivraisonbutton.Click += new System.EventHandler(this.PlanifierLivraisonbutton_Click);
            // 
            // SuiviActuelbutton
            // 
            this.SuiviActuelbutton.BackColor = System.Drawing.Color.Plum;
            this.SuiviActuelbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuiviActuelbutton.Location = new System.Drawing.Point(530, 143);
            this.SuiviActuelbutton.Name = "SuiviActuelbutton";
            this.SuiviActuelbutton.Size = new System.Drawing.Size(194, 42);
            this.SuiviActuelbutton.TabIndex = 1;
            this.SuiviActuelbutton.Text = "Suivi actuel";
            this.SuiviActuelbutton.UseVisualStyleBackColor = false;
            this.SuiviActuelbutton.Click += new System.EventHandler(this.SuiviActuelbutton_Click);
            // 
            // Gestionbutton
            // 
            this.Gestionbutton.BackColor = System.Drawing.Color.SkyBlue;
            this.Gestionbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gestionbutton.Location = new System.Drawing.Point(27, 143);
            this.Gestionbutton.Name = "Gestionbutton";
            this.Gestionbutton.Size = new System.Drawing.Size(194, 42);
            this.Gestionbutton.TabIndex = 2;
            this.Gestionbutton.Text = "Gestion";
            this.Gestionbutton.UseVisualStyleBackColor = false;
            this.Gestionbutton.Click += new System.EventHandler(this.Gestionbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Gestionbutton);
            this.Controls.Add(this.SuiviActuelbutton);
            this.Controls.Add(this.PlanifierLivraisonbutton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PlanifierLivraisonbutton;
        private System.Windows.Forms.Button SuiviActuelbutton;
        private System.Windows.Forms.Button Gestionbutton;
    }
}

