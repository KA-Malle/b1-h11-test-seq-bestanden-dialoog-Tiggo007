namespace test_H11_seq_bestanden_dialoog_LEEG
{
    partial class Form1
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
            this.btnSluiten = new System.Windows.Forms.Button();
            this.btnVerwerken = new System.Windows.Forms.Button();
            this.txtResultaat = new System.Windows.Forms.TextBox();
            this.btnGenereer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSluiten
            // 
            this.btnSluiten.Location = new System.Drawing.Point(501, 439);
            this.btnSluiten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSluiten.Name = "btnSluiten";
            this.btnSluiten.Size = new System.Drawing.Size(96, 35);
            this.btnSluiten.TabIndex = 6;
            this.btnSluiten.Text = "&Sluiten";
            this.btnSluiten.UseVisualStyleBackColor = true;
            this.btnSluiten.Click += new System.EventHandler(this.btnSluiten_Click);
            // 
            // btnVerwerken
            // 
            this.btnVerwerken.Location = new System.Drawing.Point(374, 439);
            this.btnVerwerken.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVerwerken.Name = "btnVerwerken";
            this.btnVerwerken.Size = new System.Drawing.Size(122, 35);
            this.btnVerwerken.TabIndex = 5;
            this.btnVerwerken.Text = "&Verwerken";
            this.btnVerwerken.UseVisualStyleBackColor = true;
            this.btnVerwerken.Click += new System.EventHandler(this.btnVerwerken_Click);
            // 
            // txtResultaat
            // 
            this.txtResultaat.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultaat.Location = new System.Drawing.Point(14, 14);
            this.txtResultaat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtResultaat.Multiline = true;
            this.txtResultaat.Name = "txtResultaat";
            this.txtResultaat.Size = new System.Drawing.Size(581, 402);
            this.txtResultaat.TabIndex = 4;
            // 
            // btnGenereer
            // 
            this.btnGenereer.Location = new System.Drawing.Point(14, 439);
            this.btnGenereer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGenereer.Name = "btnGenereer";
            this.btnGenereer.Size = new System.Drawing.Size(112, 35);
            this.btnGenereer.TabIndex = 7;
            this.btnGenereer.Text = "Genereer";
            this.btnGenereer.UseVisualStyleBackColor = true;
            this.btnGenereer.Click += new System.EventHandler(this.btnGenereer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 490);
            this.Controls.Add(this.btnSluiten);
            this.Controls.Add(this.btnVerwerken);
            this.Controls.Add(this.txtResultaat);
            this.Controls.Add(this.btnGenereer);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnSluiten;
        internal System.Windows.Forms.Button btnVerwerken;
        internal System.Windows.Forms.TextBox txtResultaat;
        internal System.Windows.Forms.Button btnGenereer;
    }
}

