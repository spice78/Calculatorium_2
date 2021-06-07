
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
            this.la_pulsante_uno_plus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // decime
            // 
            this.decime.BackColor = System.Drawing.Color.Gainsboro;
            this.decime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.decime.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.decime.ForeColor = System.Drawing.Color.DodgerBlue;
            this.decime.Location = new System.Drawing.Point(40, 213);
            this.decime.Name = "decime";
            this.decime.Size = new System.Drawing.Size(402, 35);
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
            this.hexito.Location = new System.Drawing.Point(40, 276);
            this.hexito.Name = "hexito";
            this.hexito.Size = new System.Drawing.Size(402, 35);
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
            this.la_binare.Size = new System.Drawing.Size(881, 35);
            this.la_binare.TabIndex = 2;
            this.la_binare.Text = "0";
            this.la_binare.TextChanged += new System.EventHandler(this.la_binare_TextChanged);
            this.la_binare.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.la_binare_KeyPress);
            // 
            // la_pulsante_uno_plus
            // 
            this.la_pulsante_uno_plus.Location = new System.Drawing.Point(513, 213);
            this.la_pulsante_uno_plus.Name = "la_pulsante_uno_plus";
            this.la_pulsante_uno_plus.Size = new System.Drawing.Size(404, 98);
            this.la_pulsante_uno_plus.TabIndex = 3;
            this.la_pulsante_uno_plus.Text = "+1 La Pulsante";
            this.la_pulsante_uno_plus.UseVisualStyleBackColor = true;
            this.la_pulsante_uno_plus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.la_pulsante_uno_plus_MouseClick);
            // 
            // Calcutator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Calculatorium_2.Properties.Resources.bkg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(929, 410);
            this.Controls.Add(this.la_pulsante_uno_plus);
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
        private System.Windows.Forms.Button la_pulsante_uno_plus;
    }
}

