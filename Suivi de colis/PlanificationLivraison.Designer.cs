
namespace Suivi_de_colis
{
    partial class PlanificationLivraison
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CamionPLcomboBox = new System.Windows.Forms.ComboBox();
            this.CamionPLlabel = new System.Windows.Forms.Label();
            this.TrajetPLlabel = new System.Windows.Forms.Label();
            this.TrajetPLbutton = new System.Windows.Forms.Button();
            this.ValiderPLbutton = new System.Windows.Forms.Button();
            this.NbDestinationPLnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.DestinationsPLlabel = new System.Windows.Forms.Label();
            this.TrajetPLdataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NbDestinationPLlabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NbDestinationPLnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrajetPLdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CamionPLcomboBox
            // 
            this.CamionPLcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CamionPLcomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CamionPLcomboBox.FormattingEnabled = true;
            this.CamionPLcomboBox.Location = new System.Drawing.Point(322, 37);
            this.CamionPLcomboBox.Name = "CamionPLcomboBox";
            this.CamionPLcomboBox.Size = new System.Drawing.Size(180, 33);
            this.CamionPLcomboBox.TabIndex = 0;
            this.CamionPLcomboBox.SelectedIndexChanged += new System.EventHandler(this.CamionPLcomboBox_SelectedIndexChanged);
            // 
            // CamionPLlabel
            // 
            this.CamionPLlabel.AutoSize = true;
            this.CamionPLlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CamionPLlabel.Location = new System.Drawing.Point(50, 40);
            this.CamionPLlabel.Name = "CamionPLlabel";
            this.CamionPLlabel.Size = new System.Drawing.Size(85, 25);
            this.CamionPLlabel.TabIndex = 1;
            this.CamionPLlabel.Text = "Camion";
            // 
            // TrajetPLlabel
            // 
            this.TrajetPLlabel.AutoSize = true;
            this.TrajetPLlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrajetPLlabel.Location = new System.Drawing.Point(50, 235);
            this.TrajetPLlabel.Name = "TrajetPLlabel";
            this.TrajetPLlabel.Size = new System.Drawing.Size(67, 25);
            this.TrajetPLlabel.TabIndex = 4;
            this.TrajetPLlabel.Text = "Trajet";
            // 
            // TrajetPLbutton
            // 
            this.TrajetPLbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrajetPLbutton.Location = new System.Drawing.Point(322, 229);
            this.TrajetPLbutton.Name = "TrajetPLbutton";
            this.TrajetPLbutton.Size = new System.Drawing.Size(180, 36);
            this.TrajetPLbutton.TabIndex = 7;
            this.TrajetPLbutton.Text = "Définir";
            this.TrajetPLbutton.UseVisualStyleBackColor = true;
            this.TrajetPLbutton.Click += new System.EventHandler(this.TrajetPLbutton_Click);
            // 
            // ValiderPLbutton
            // 
            this.ValiderPLbutton.BackColor = System.Drawing.SystemColors.Desktop;
            this.ValiderPLbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValiderPLbutton.Location = new System.Drawing.Point(154, 325);
            this.ValiderPLbutton.Name = "ValiderPLbutton";
            this.ValiderPLbutton.Size = new System.Drawing.Size(180, 36);
            this.ValiderPLbutton.TabIndex = 10;
            this.ValiderPLbutton.Text = "Valider";
            this.ValiderPLbutton.UseVisualStyleBackColor = false;
            this.ValiderPLbutton.Click += new System.EventHandler(this.ValiderPLbutton_Click);
            // 
            // NbDestinationPLnumericUpDown
            // 
            this.NbDestinationPLnumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NbDestinationPLnumericUpDown.Location = new System.Drawing.Point(322, 138);
            this.NbDestinationPLnumericUpDown.Name = "NbDestinationPLnumericUpDown";
            this.NbDestinationPLnumericUpDown.Size = new System.Drawing.Size(180, 31);
            this.NbDestinationPLnumericUpDown.TabIndex = 13;
            this.NbDestinationPLnumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NbDestinationPLnumericUpDown.ValueChanged += new System.EventHandler(this.NbDestinationPLnumericUpDown_ValueChanged);
            // 
            // DestinationsPLlabel
            // 
            this.DestinationsPLlabel.AutoSize = true;
            this.DestinationsPLlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DestinationsPLlabel.Location = new System.Drawing.Point(588, 37);
            this.DestinationsPLlabel.Name = "DestinationsPLlabel";
            this.DestinationsPLlabel.Size = new System.Drawing.Size(131, 25);
            this.DestinationsPLlabel.TabIndex = 15;
            this.DestinationsPLlabel.Text = "Destinations";
            // 
            // TrajetPLdataGridView
            // 
            this.TrajetPLdataGridView.AllowUserToAddRows = false;
            this.TrajetPLdataGridView.AllowUserToDeleteRows = false;
            this.TrajetPLdataGridView.AllowUserToResizeColumns = false;
            this.TrajetPLdataGridView.AllowUserToResizeRows = false;
            this.TrajetPLdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TrajetPLdataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.TrajetPLdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TrajetPLdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TrajetPLdataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.TrajetPLdataGridView.Location = new System.Drawing.Point(538, 84);
            this.TrajetPLdataGridView.MultiSelect = false;
            this.TrajetPLdataGridView.Name = "TrajetPLdataGridView";
            this.TrajetPLdataGridView.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TrajetPLdataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.TrajetPLdataGridView.RowHeadersVisible = false;
            this.TrajetPLdataGridView.Size = new System.Drawing.Size(240, 323);
            this.TrajetPLdataGridView.TabIndex = 14;
            this.TrajetPLdataGridView.TabStop = false;
            this.TrajetPLdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TrajetPLdataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // NbDestinationPLlabel
            // 
            this.NbDestinationPLlabel.AutoSize = true;
            this.NbDestinationPLlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NbDestinationPLlabel.Location = new System.Drawing.Point(50, 140);
            this.NbDestinationPLlabel.Name = "NbDestinationPLlabel";
            this.NbDestinationPLlabel.Size = new System.Drawing.Size(239, 25);
            this.NbDestinationPLlabel.TabIndex = 5;
            this.NbDestinationPLlabel.Text = "Nombre de destinations";
            // 
            // PlanificationLivraison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DestinationsPLlabel);
            this.Controls.Add(this.TrajetPLdataGridView);
            this.Controls.Add(this.NbDestinationPLnumericUpDown);
            this.Controls.Add(this.ValiderPLbutton);
            this.Controls.Add(this.TrajetPLbutton);
            this.Controls.Add(this.NbDestinationPLlabel);
            this.Controls.Add(this.TrajetPLlabel);
            this.Controls.Add(this.CamionPLlabel);
            this.Controls.Add(this.CamionPLcomboBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PlanificationLivraison";
            this.Text = "Planification de livraison";
            ((System.ComponentModel.ISupportInitialize)(this.NbDestinationPLnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrajetPLdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CamionPLcomboBox;
        private System.Windows.Forms.Label CamionPLlabel;
        private System.Windows.Forms.Label TrajetPLlabel;
        private System.Windows.Forms.Button TrajetPLbutton;
        private System.Windows.Forms.Button ValiderPLbutton;
        private System.Windows.Forms.NumericUpDown NbDestinationPLnumericUpDown;
        private System.Windows.Forms.Label DestinationsPLlabel;
        private System.Windows.Forms.DataGridView TrajetPLdataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label NbDestinationPLlabel;
    }
}