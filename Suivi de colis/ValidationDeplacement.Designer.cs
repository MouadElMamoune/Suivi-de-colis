
namespace Suivi_de_colis
{
    partial class ValidationDeplacement
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
            this.ValiderVDbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ValiderVDbutton
            // 
            this.ValiderVDbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValiderVDbutton.Location = new System.Drawing.Point(252, 359);
            this.ValiderVDbutton.Name = "ValiderVDbutton";
            this.ValiderVDbutton.Size = new System.Drawing.Size(180, 36);
            this.ValiderVDbutton.TabIndex = 8;
            this.ValiderVDbutton.Text = "Valider";
            this.ValiderVDbutton.UseVisualStyleBackColor = true;
            this.ValiderVDbutton.Click += new System.EventHandler(this.ValiderVDbutton_Click);
            // 
            // ValidationDeplacement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ValiderVDbutton);
            this.Name = "ValidationDeplacement";
            this.Text = "ValidationDeplacement";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ValiderVDbutton;
    }
}