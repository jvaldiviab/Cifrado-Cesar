
namespace Cifrado_Cesar
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.richTextBoxCifrado = new System.Windows.Forms.RichTextBox();
            this.btnCifrar = new System.Windows.Forms.Button();
            this.btnDescif = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(31, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "TEXTO DE ENTRADA:";
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(156, 22);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(572, 23);
            this.textBox.TabIndex = 2;
            this.textBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // richTextBoxCifrado
            // 
            this.richTextBoxCifrado.Location = new System.Drawing.Point(328, 67);
            this.richTextBoxCifrado.Name = "richTextBoxCifrado";
            this.richTextBoxCifrado.Size = new System.Drawing.Size(400, 223);
            this.richTextBoxCifrado.TabIndex = 0;
            this.richTextBoxCifrado.Text = "";
            // 
            // btnCifrar
            // 
            this.btnCifrar.Location = new System.Drawing.Point(223, 66);
            this.btnCifrar.Name = "btnCifrar";
            this.btnCifrar.Size = new System.Drawing.Size(75, 23);
            this.btnCifrar.TabIndex = 1;
            this.btnCifrar.Text = "CIFRAR";
            this.btnCifrar.UseVisualStyleBackColor = true;
            this.btnCifrar.Click += new System.EventHandler(this.btnCifrar_Click);
            // 
            // btnDescif
            // 
            this.btnDescif.Location = new System.Drawing.Point(223, 95);
            this.btnDescif.Name = "btnDescif";
            this.btnDescif.Size = new System.Drawing.Size(75, 23);
            this.btnDescif.TabIndex = 0;
            this.btnDescif.Text = "DSECIFRAR";
            this.btnDescif.UseVisualStyleBackColor = true;
            this.btnDescif.Click += new System.EventHandler(this.btnDescif_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.textBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnDescif);
            this.groupBox1.Controls.Add(this.richTextBoxCifrado);
            this.groupBox1.Controls.Add(this.btnCifrar);
            this.groupBox1.Location = new System.Drawing.Point(25, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(843, 330);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cifrado Cesar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "DESPLAZAMIENTO";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(156, 71);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(41, 23);
            this.numericUpDown1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(948, 465);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.RichTextBox richTextBoxCifrado;
        private System.Windows.Forms.Button btnCifrar;
        private System.Windows.Forms.Button btnDescif;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

