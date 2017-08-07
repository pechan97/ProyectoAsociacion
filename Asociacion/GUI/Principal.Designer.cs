namespace Asociacion.GUI
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAlquiler = new System.Windows.Forms.Button();
            this.btnRecibo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(149, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(389, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Asociacion de desarrollo El Invu Peñas Blancas";
            // 
            // btnAlquiler
            // 
            this.btnAlquiler.BackColor = System.Drawing.Color.Transparent;
            this.btnAlquiler.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAlquiler.FlatAppearance.BorderSize = 3;
            this.btnAlquiler.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnAlquiler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnAlquiler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlquiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlquiler.ForeColor = System.Drawing.Color.White;
            this.btnAlquiler.Location = new System.Drawing.Point(96, 90);
            this.btnAlquiler.Name = "btnAlquiler";
            this.btnAlquiler.Size = new System.Drawing.Size(93, 31);
            this.btnAlquiler.TabIndex = 2;
            this.btnAlquiler.Text = "Alquileres";
            this.btnAlquiler.UseVisualStyleBackColor = false;
            this.btnAlquiler.Click += new System.EventHandler(this.btnAlquiler_Click);
            // 
            // btnRecibo
            // 
            this.btnRecibo.BackColor = System.Drawing.Color.Transparent;
            this.btnRecibo.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnRecibo.FlatAppearance.BorderSize = 3;
            this.btnRecibo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnRecibo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnRecibo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecibo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecibo.ForeColor = System.Drawing.Color.White;
            this.btnRecibo.Location = new System.Drawing.Point(217, 90);
            this.btnRecibo.Name = "btnRecibo";
            this.btnRecibo.Size = new System.Drawing.Size(93, 31);
            this.btnRecibo.TabIndex = 5;
            this.btnRecibo.Text = "Recibos";
            this.btnRecibo.UseVisualStyleBackColor = false;
            this.btnRecibo.Click += new System.EventHandler(this.button4_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(407, 218);
            this.Controls.Add(this.btnRecibo);
            this.Controls.Add(this.btnAlquiler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Principal";
            this.Text = "Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAlquiler;
        private System.Windows.Forms.Button btnRecibo;
    }
}