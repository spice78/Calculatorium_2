
namespace Calculatorium_2
{
    partial class Calcutator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.decime = new System.Windows.Forms.TextBox();
            this.hexito = new System.Windows.Forms.TextBox();
            this.la_binare = new System.Windows.Forms.TextBox();
            this.dec_il_pulsante = new System.Windows.Forms.Button();
            this.heximito = new System.Windows.Forms.Button();
            this.binarito = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // decime
            // 
            this.decime.BackColor = System.Drawing.Color.Gainsboro;
            this.decime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.decime.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.decime.ForeColor = System.Drawing.Color.DodgerBlue;
            this.decime.Location = new System.Drawing.Point(40, 73);
            this.decime.Name = "decime";
            this.decime.Size = new System.Drawing.Size(435, 35);
            this.decime.TabIndex = 0;
            this.decime.Text = "0";
            this.decime.TextChanged += new System.EventHandler(this.decime_TextChanged);
            this.decime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.decime_KeyPress);
            // 
            // hexito
            // 
            this.hexito.BackColor = System.Drawing.Color.Gainsboro;
            this.hexito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hexito.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hexito.ForeColor = System.Drawing.Color.DodgerBlue;
            this.hexito.Location = new System.Drawing.Point(40, 196);
            this.hexito.Name = "hexito";
            this.hexito.Size = new System.Drawing.Size(435, 35);
            this.hexito.TabIndex = 1;
            this.hexito.Text = "0";
            this.hexito.TextChanged += new System.EventHandler(this.hexito_TextChanged);
            this.hexito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hexito_KeyPress);
            // 
            // la_binare
            // 
            this.la_binare.BackColor = System.Drawing.Color.Gainsboro;
            this.la_binare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.la_binare.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.la_binare.ForeColor = System.Drawing.Color.DodgerBlue;
            this.la_binare.Location = new System.Drawing.Point(40, 335);
            this.la_binare.Name = "la_binare";
            this.la_binare.Size = new System.Drawing.Size(435, 35);
            this.la_binare.TabIndex = 2;
            this.la_binare.Text = "0";
            this.la_binare.TextChanged += new System.EventHandler(this.la_binare_TextChanged);
            this.la_binare.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.la_binare_KeyPress);
            // 
            // dec_il_pulsante
            // 
            this.dec_il_pulsante.BackColor = System.Drawing.Color.Transparent;
            this.dec_il_pulsante.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dec_il_pulsante.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.dec_il_pulsante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dec_il_pulsante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dec_il_pulsante.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.dec_il_pulsante.Location = new System.Drawing.Point(514, 73);
            this.dec_il_pulsante.Name = "dec_il_pulsante";
            this.dec_il_pulsante.Size = new System.Drawing.Size(110, 35);
            this.dec_il_pulsante.TabIndex = 3;
            this.dec_il_pulsante.Text = "Decimale";
            this.dec_il_pulsante.UseVisualStyleBackColor = false;
            this.dec_il_pulsante.Click += new System.EventHandler(this.dec_il_pulsante_Click);
            // 
            // heximito
            // 
            this.heximito.BackColor = System.Drawing.Color.Transparent;
            this.heximito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.heximito.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.heximito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.heximito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.heximito.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.heximito.Location = new System.Drawing.Point(514, 196);
            this.heximito.Name = "heximito";
            this.heximito.Size = new System.Drawing.Size(110, 35);
            this.heximito.TabIndex = 4;
            this.heximito.Text = "Heximale";
            this.heximito.UseVisualStyleBackColor = false;
            this.heximito.Click += new System.EventHandler(this.heximito_Click);
            // 
            // binarito
            // 
            this.binarito.BackColor = System.Drawing.Color.Transparent;
            this.binarito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.binarito.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.binarito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.binarito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.binarito.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.binarito.Location = new System.Drawing.Point(514, 335);
            this.binarito.Name = "binarito";
            this.binarito.Size = new System.Drawing.Size(110, 35);
            this.binarito.TabIndex = 5;
            this.binarito.Text = "Binamale";
            this.binarito.UseVisualStyleBackColor = false;
            this.binarito.Click += new System.EventHandler(this.binarito_Click);
            // 
            // Calcutator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Calculatorium_2.Properties.Resources.bkg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(633, 410);
            this.Controls.Add(this.binarito);
            this.Controls.Add(this.heximito);
            this.Controls.Add(this.dec_il_pulsante);
            this.Controls.Add(this.la_binare);
            this.Controls.Add(this.hexito);
            this.Controls.Add(this.decime);
            this.ForeColor = System.Drawing.Color.Maroon;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Calcutator";
            this.Text = "Calculatorium";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox decime;
        private System.Windows.Forms.TextBox hexito;
        private System.Windows.Forms.TextBox la_binare;
        private System.Windows.Forms.Button dec_il_pulsante;
        private System.Windows.Forms.Button heximito;
        private System.Windows.Forms.Button binarito;
    }
}

