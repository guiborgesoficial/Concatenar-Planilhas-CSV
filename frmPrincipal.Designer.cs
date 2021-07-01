
namespace ConcatenarPlanilhasCSV
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtBoxCaminho = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPreset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtBoxCaminho
            // 
            this.txtBoxCaminho.Location = new System.Drawing.Point(26, 27);
            this.txtBoxCaminho.Name = "txtBoxCaminho";
            this.txtBoxCaminho.Size = new System.Drawing.Size(161, 20);
            this.txtBoxCaminho.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(193, 25);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPreset
            // 
            this.btnPreset.Location = new System.Drawing.Point(336, 27);
            this.btnPreset.Name = "btnPreset";
            this.btnPreset.Size = new System.Drawing.Size(75, 23);
            this.btnPreset.TabIndex = 2;
            this.btnPreset.Text = "PRESET";
            this.btnPreset.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 324);
            this.Controls.Add(this.btnPreset);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtBoxCaminho);
            this.Name = "frmPrincipal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtBoxCaminho;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPreset;
    }
}

