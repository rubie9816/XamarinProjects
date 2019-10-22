namespace _170444_RubiVargas_EditorDeTexto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rtbEditor = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNegrita = new System.Windows.Forms.Button();
            this.btnSubrayado = new System.Windows.Forms.Button();
            this.btnAlineaIzq = new System.Windows.Forms.Button();
            this.btnAlinearCentro = new System.Windows.Forms.Button();
            this.btnAlinearDere = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbEditor
            // 
            this.rtbEditor.Location = new System.Drawing.Point(12, 72);
            this.rtbEditor.Name = "rtbEditor";
            this.rtbEditor.Size = new System.Drawing.Size(454, 182);
            this.rtbEditor.TabIndex = 0;
            this.rtbEditor.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Editor de texto";
            // 
            // btnNegrita
            // 
            this.btnNegrita.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNegrita.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNegrita.Location = new System.Drawing.Point(481, 72);
            this.btnNegrita.Name = "btnNegrita";
            this.btnNegrita.Size = new System.Drawing.Size(88, 42);
            this.btnNegrita.TabIndex = 4;
            this.btnNegrita.Text = "N";
            this.btnNegrita.UseVisualStyleBackColor = false;
            this.btnNegrita.Click += new System.EventHandler(this.btnNegrita_Click);
            // 
            // btnSubrayado
            // 
            this.btnSubrayado.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubrayado.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubrayado.Location = new System.Drawing.Point(481, 120);
            this.btnSubrayado.Name = "btnSubrayado";
            this.btnSubrayado.Size = new System.Drawing.Size(88, 42);
            this.btnSubrayado.TabIndex = 5;
            this.btnSubrayado.Text = "S";
            this.btnSubrayado.UseVisualStyleBackColor = false;
            this.btnSubrayado.Click += new System.EventHandler(this.btnSubrayado_Click);
            // 
            // btnAlineaIzq
            // 
            this.btnAlineaIzq.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAlineaIzq.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlineaIzq.Image = ((System.Drawing.Image)(resources.GetObject("btnAlineaIzq.Image")));
            this.btnAlineaIzq.Location = new System.Drawing.Point(481, 168);
            this.btnAlineaIzq.Name = "btnAlineaIzq";
            this.btnAlineaIzq.Size = new System.Drawing.Size(41, 40);
            this.btnAlineaIzq.TabIndex = 6;
            this.btnAlineaIzq.UseVisualStyleBackColor = false;
            this.btnAlineaIzq.Click += new System.EventHandler(this.btnAlineaIzq_Click);
            // 
            // btnAlinearCentro
            // 
            this.btnAlinearCentro.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAlinearCentro.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlinearCentro.Image = ((System.Drawing.Image)(resources.GetObject("btnAlinearCentro.Image")));
            this.btnAlinearCentro.Location = new System.Drawing.Point(528, 168);
            this.btnAlinearCentro.Name = "btnAlinearCentro";
            this.btnAlinearCentro.Size = new System.Drawing.Size(41, 40);
            this.btnAlinearCentro.TabIndex = 7;
            this.btnAlinearCentro.UseVisualStyleBackColor = false;
            this.btnAlinearCentro.Click += new System.EventHandler(this.btnAlinearCentro_Click);
            // 
            // btnAlinearDere
            // 
            this.btnAlinearDere.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAlinearDere.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlinearDere.Image = ((System.Drawing.Image)(resources.GetObject("btnAlinearDere.Image")));
            this.btnAlinearDere.Location = new System.Drawing.Point(481, 214);
            this.btnAlinearDere.Name = "btnAlinearDere";
            this.btnAlinearDere.Size = new System.Drawing.Size(41, 40);
            this.btnAlinearDere.TabIndex = 8;
            this.btnAlinearDere.UseVisualStyleBackColor = false;
            this.btnAlinearDere.Click += new System.EventHandler(this.btnAlinearDere_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 270);
            this.Controls.Add(this.btnAlinearDere);
            this.Controls.Add(this.btnAlinearCentro);
            this.Controls.Add(this.btnAlineaIzq);
            this.Controls.Add(this.btnSubrayado);
            this.Controls.Add(this.btnNegrita);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbEditor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbEditor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNegrita;
        private System.Windows.Forms.Button btnSubrayado;
        private System.Windows.Forms.Button btnAlineaIzq;
        private System.Windows.Forms.Button btnAlinearCentro;
        private System.Windows.Forms.Button btnAlinearDere;
    }
}

