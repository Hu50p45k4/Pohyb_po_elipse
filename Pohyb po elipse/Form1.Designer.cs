namespace Pohyb_po_elipse
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.poleSirka = new System.Windows.Forms.TextBox();
            this.poleVyska = new System.Windows.Forms.TextBox();
            this.tlacitkoPrepocitej = new System.Windows.Forms.Button();
            this.poleRychlost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.labelRychlost = new System.Windows.Forms.Label();
            this.labelUhel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Šířka:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Výška:";
            // 
            // poleSirka
            // 
            this.poleSirka.Location = new System.Drawing.Point(246, 168);
            this.poleSirka.Name = "poleSirka";
            this.poleSirka.Size = new System.Drawing.Size(100, 20);
            this.poleSirka.TabIndex = 4;
            // 
            // poleVyska
            // 
            this.poleVyska.Location = new System.Drawing.Point(246, 205);
            this.poleVyska.Name = "poleVyska";
            this.poleVyska.Size = new System.Drawing.Size(100, 20);
            this.poleVyska.TabIndex = 5;
            // 
            // tlacitkoPrepocitej
            // 
            this.tlacitkoPrepocitej.Location = new System.Drawing.Point(246, 240);
            this.tlacitkoPrepocitej.Name = "tlacitkoPrepocitej";
            this.tlacitkoPrepocitej.Size = new System.Drawing.Size(75, 23);
            this.tlacitkoPrepocitej.TabIndex = 6;
            this.tlacitkoPrepocitej.Text = "Přepočítej";
            this.tlacitkoPrepocitej.UseVisualStyleBackColor = true;
            this.tlacitkoPrepocitej.Click += new System.EventHandler(this.tlacitkoPrepocitej_Click);
            // 
            // poleRychlost
            // 
            this.poleRychlost.Location = new System.Drawing.Point(446, 192);
            this.poleRychlost.Name = "poleRychlost";
            this.poleRychlost.Size = new System.Drawing.Size(100, 20);
            this.poleRychlost.TabIndex = 8;
            this.poleRychlost.TextChanged += new System.EventHandler(this.poleRychlost_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(389, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Rychlost:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(418, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 26);
            this.button1.TabIndex = 10;
            this.button1.Text = "Zastav";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(289, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Rychlost:";
            // 
            // labelRychlost
            // 
            this.labelRychlost.AutoSize = true;
            this.labelRychlost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRychlost.Location = new System.Drawing.Point(363, 311);
            this.labelRychlost.Name = "labelRychlost";
            this.labelRychlost.Size = new System.Drawing.Size(18, 20);
            this.labelRychlost.TabIndex = 12;
            this.labelRychlost.Text = "5";
            // 
            // labelUhel
            // 
            this.labelUhel.AutoSize = true;
            this.labelUhel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelUhel.Location = new System.Drawing.Point(363, 331);
            this.labelUhel.Name = "labelUhel";
            this.labelUhel.Size = new System.Drawing.Size(18, 20);
            this.labelUhel.TabIndex = 14;
            this.labelUhel.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(317, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Úhel:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 523);
            this.Controls.Add(this.labelUhel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelRychlost);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.poleRychlost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tlacitkoPrepocitej);
            this.Controls.Add(this.poleVyska);
            this.Controls.Add(this.poleSirka);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Pohyb po elipse";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox poleSirka;
        private System.Windows.Forms.TextBox poleVyska;
        private System.Windows.Forms.Button tlacitkoPrepocitej;
        private System.Windows.Forms.TextBox poleRychlost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelRychlost;
        private System.Windows.Forms.Label labelUhel;
        private System.Windows.Forms.Label label6;
    }
}

