namespace grafika2
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
            this.checkboxKavekrem = new System.Windows.Forms.CheckBox();
            this.checkboxTejszin = new System.Windows.Forms.CheckBox();
            this.checkboxTejpor = new System.Windows.Forms.CheckBox();
            this.espresso = new System.Windows.Forms.RadioButton();
            this.duplaKave = new System.Windows.Forms.RadioButton();
            this.hosszuKave = new System.Windows.Forms.RadioButton();
            this.cukorSok = new System.Windows.Forms.RadioButton();
            this.cukorKeves = new System.Windows.Forms.RadioButton();
            this.cukorMentes = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelEredmeny = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkboxKavekrem
            // 
            this.checkboxKavekrem.AutoSize = true;
            this.checkboxKavekrem.Location = new System.Drawing.Point(184, 173);
            this.checkboxKavekrem.Name = "checkboxKavekrem";
            this.checkboxKavekrem.Size = new System.Drawing.Size(73, 17);
            this.checkboxKavekrem.TabIndex = 0;
            this.checkboxKavekrem.Text = "kávékrém";
            this.checkboxKavekrem.UseVisualStyleBackColor = true;
            // 
            // checkboxTejszin
            // 
            this.checkboxTejszin.AutoSize = true;
            this.checkboxTejszin.Location = new System.Drawing.Point(184, 196);
            this.checkboxTejszin.Name = "checkboxTejszin";
            this.checkboxTejszin.Size = new System.Drawing.Size(57, 17);
            this.checkboxTejszin.TabIndex = 1;
            this.checkboxTejszin.Text = "tejszín";
            this.checkboxTejszin.UseVisualStyleBackColor = true;
            // 
            // checkboxTejpor
            // 
            this.checkboxTejpor.AutoSize = true;
            this.checkboxTejpor.Location = new System.Drawing.Point(184, 219);
            this.checkboxTejpor.Name = "checkboxTejpor";
            this.checkboxTejpor.Size = new System.Drawing.Size(52, 17);
            this.checkboxTejpor.TabIndex = 2;
            this.checkboxTejpor.Text = "tejpor";
            this.checkboxTejpor.UseVisualStyleBackColor = true;
            // 
            // espresso
            // 
            this.espresso.AutoSize = true;
            this.espresso.Location = new System.Drawing.Point(14, 14);
            this.espresso.Name = "espresso";
            this.espresso.Size = new System.Drawing.Size(67, 17);
            this.espresso.TabIndex = 3;
            this.espresso.TabStop = true;
            this.espresso.Text = "espresso";
            this.espresso.UseVisualStyleBackColor = true;
            // 
            // duplaKave
            // 
            this.duplaKave.AutoSize = true;
            this.duplaKave.Location = new System.Drawing.Point(14, 38);
            this.duplaKave.Name = "duplaKave";
            this.duplaKave.Size = new System.Drawing.Size(78, 17);
            this.duplaKave.TabIndex = 4;
            this.duplaKave.TabStop = true;
            this.duplaKave.Text = "dupla kávé";
            this.duplaKave.UseVisualStyleBackColor = true;
            // 
            // hosszuKave
            // 
            this.hosszuKave.AutoSize = true;
            this.hosszuKave.Location = new System.Drawing.Point(14, 60);
            this.hosszuKave.Name = "hosszuKave";
            this.hosszuKave.Size = new System.Drawing.Size(85, 17);
            this.hosszuKave.TabIndex = 5;
            this.hosszuKave.TabStop = true;
            this.hosszuKave.Text = "hosszú kávé";
            this.hosszuKave.UseVisualStyleBackColor = true;
            // 
            // cukorSok
            // 
            this.cukorSok.AutoSize = true;
            this.cukorSok.Location = new System.Drawing.Point(24, 14);
            this.cukorSok.Name = "cukorSok";
            this.cukorSok.Size = new System.Drawing.Size(72, 17);
            this.cukorSok.TabIndex = 6;
            this.cukorSok.Text = "sok cukor";
            this.cukorSok.UseVisualStyleBackColor = true;
            this.cukorSok.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // cukorKeves
            // 
            this.cukorKeves.AutoSize = true;
            this.cukorKeves.Location = new System.Drawing.Point(24, 37);
            this.cukorKeves.Name = "cukorKeves";
            this.cukorKeves.Size = new System.Drawing.Size(84, 17);
            this.cukorKeves.TabIndex = 7;
            this.cukorKeves.Text = "kevés cukor";
            this.cukorKeves.UseVisualStyleBackColor = true;
            this.cukorKeves.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // cukorMentes
            // 
            this.cukorMentes.AutoSize = true;
            this.cukorMentes.Location = new System.Drawing.Point(24, 60);
            this.cukorMentes.Name = "cukorMentes";
            this.cukorMentes.Size = new System.Drawing.Size(83, 17);
            this.cukorMentes.TabIndex = 8;
            this.cukorMentes.Text = "cukor nélkül";
            this.cukorMentes.UseVisualStyleBackColor = true;
            this.cukorMentes.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hosszuKave);
            this.groupBox1.Controls.Add(this.duplaKave);
            this.groupBox1.Controls.Add(this.espresso);
            this.groupBox1.Location = new System.Drawing.Point(483, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(125, 93);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "kávéféleségek";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cukorMentes);
            this.groupBox2.Controls.Add(this.cukorKeves);
            this.groupBox2.Controls.Add(this.cukorSok);
            this.groupBox2.Location = new System.Drawing.Point(314, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(120, 93);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cukor";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(334, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "gemb";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // labelEredmeny
            // 
            this.labelEredmeny.AutoSize = true;
            this.labelEredmeny.Location = new System.Drawing.Point(270, 380);
            this.labelEredmeny.Name = "labelEredmeny";
            this.labelEredmeny.Size = new System.Drawing.Size(83, 13);
            this.labelEredmeny.TabIndex = 12;
            this.labelEredmeny.Text = "Nincs eredmény";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelEredmeny);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkboxTejpor);
            this.Controls.Add(this.checkboxTejszin);
            this.Controls.Add(this.checkboxKavekrem);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkboxKavekrem;
        private System.Windows.Forms.CheckBox checkboxTejszin;
        private System.Windows.Forms.CheckBox checkboxTejpor;
        private System.Windows.Forms.RadioButton espresso;
        private System.Windows.Forms.RadioButton duplaKave;
        private System.Windows.Forms.RadioButton hosszuKave;
        private System.Windows.Forms.RadioButton cukorSok;
        private System.Windows.Forms.RadioButton cukorKeves;
        private System.Windows.Forms.RadioButton cukorMentes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelEredmeny;
    }
}

