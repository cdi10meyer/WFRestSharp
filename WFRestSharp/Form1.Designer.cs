namespace WFRestSharp
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewNoms = new System.Windows.Forms.DataGridView();
            this.bindingSourceNoms = new System.Windows.Forms.BindingSource(this.components);
            this.tbNomPays = new System.Windows.Forms.TextBox();
            this.tbCapitale = new System.Windows.Forms.TextBox();
            this.tbNrHabitants = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNoms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceNoms)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbNrHabitants);
            this.panel1.Controls.Add(this.tbCapitale);
            this.panel1.Controls.Add(this.tbNomPays);
            this.panel1.Controls.Add(this.dataGridViewNoms);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // dataGridViewNoms
            // 
            this.dataGridViewNoms.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewNoms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewNoms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNoms.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewNoms.Location = new System.Drawing.Point(12, 72);
            this.dataGridViewNoms.Name = "dataGridViewNoms";
            this.dataGridViewNoms.Size = new System.Drawing.Size(412, 150);
            this.dataGridViewNoms.TabIndex = 0;
            // 
            // bindingSourceNoms
            // 
            this.bindingSourceNoms.CurrentChanged += new System.EventHandler(this.bindingSourceNoms_CurrentChanged);
            // 
            // tbNomPays
            // 
            this.tbNomPays.Location = new System.Drawing.Point(645, 84);
            this.tbNomPays.Name = "tbNomPays";
            this.tbNomPays.Size = new System.Drawing.Size(100, 20);
            this.tbNomPays.TabIndex = 1;
            // 
            // tbCapitale
            // 
            this.tbCapitale.Location = new System.Drawing.Point(645, 110);
            this.tbCapitale.Name = "tbCapitale";
            this.tbCapitale.Size = new System.Drawing.Size(100, 20);
            this.tbCapitale.TabIndex = 2;
            // 
            // tbNrHabitants
            // 
            this.tbNrHabitants.Location = new System.Drawing.Point(645, 136);
            this.tbNrHabitants.Name = "tbNrHabitants";
            this.tbNrHabitants.Size = new System.Drawing.Size(100, 20);
            this.tbNrHabitants.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(513, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(513, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Capitale";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(513, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nbre d\'habitants (millions)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNoms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceNoms)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewNoms;
        private System.Windows.Forms.BindingSource bindingSourceNoms;
        private System.Windows.Forms.TextBox tbNrHabitants;
        private System.Windows.Forms.TextBox tbCapitale;
        private System.Windows.Forms.TextBox tbNomPays;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

