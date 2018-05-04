namespace CopyPasta
{
    partial class Form_Parameter
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
            this.groupBox_Parameter = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // groupBox_Parameter
            // 
            this.groupBox_Parameter.Location = new System.Drawing.Point(12, 12);
            this.groupBox_Parameter.Name = "groupBox_Parameter";
            this.groupBox_Parameter.Size = new System.Drawing.Size(351, 275);
            this.groupBox_Parameter.TabIndex = 0;
            this.groupBox_Parameter.TabStop = false;
            this.groupBox_Parameter.Text = "Parameters";
            // 
            // Form_Parameter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 299);
            this.Controls.Add(this.groupBox_Parameter);
            this.Name = "Form_Parameter";
            this.Text = "CopyPasta";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Parameter;
    }
}

