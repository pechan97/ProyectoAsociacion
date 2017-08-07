namespace Asociacion.GUI
{
    partial class EditarRecibo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarRecibo));
            this.lblMensaje = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.Fecha = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRecibDe = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMensaje
            // 
            this.lblMensaje.BackColor = System.Drawing.Color.Transparent;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblMensaje.Location = new System.Drawing.Point(37, 356);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(428, 31);
            this.lblMensaje.TabIndex = 32;
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(37, 168);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(97, 23);
            this.label4.TabIndex = 31;
            this.label4.Text = "La suma de:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.FlatAppearance.BorderSize = 3;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Transparent;
            this.btnGuardar.Location = new System.Drawing.Point(207, 305);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(90, 34);
            this.btnGuardar.TabIndex = 29;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Fecha
            // 
            this.Fecha.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha.Location = new System.Drawing.Point(153, 67);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(209, 20);
            this.Fecha.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(27, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 23);
            this.label3.TabIndex = 27;
            this.label3.Text = "Fecha:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(153, 167);
            this.txtMonto.Multiline = true;
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(144, 24);
            this.txtMonto.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(140, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 23);
            this.label2.TabIndex = 25;
            this.label2.Text = "₡";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(153, 231);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(281, 46);
            this.txtDescripcion.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(27, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 23);
            this.label1.TabIndex = 23;
            this.label1.Text = "Descripción:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtRecibDe
            // 
            this.txtRecibDe.Location = new System.Drawing.Point(153, 118);
            this.txtRecibDe.Multiline = true;
            this.txtRecibDe.Name = "txtRecibDe";
            this.txtRecibDe.Size = new System.Drawing.Size(281, 24);
            this.txtRecibDe.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(27, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 23);
            this.label10.TabIndex = 21;
            this.label10.Text = "Recibimos de:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label21.Location = new System.Drawing.Point(138, 9);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(259, 35);
            this.label21.TabIndex = 20;
            this.label21.Text = "Actualizar Recibo";
            // 
            // EditarRecibo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(492, 399);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRecibDe);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label21);
            this.Name = "EditarRecibo";
            this.Text = "EditarRecibo";
            this.Load += new System.EventHandler(this.EditarRecibo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DateTimePicker Fecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRecibDe;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label21;
    }
}