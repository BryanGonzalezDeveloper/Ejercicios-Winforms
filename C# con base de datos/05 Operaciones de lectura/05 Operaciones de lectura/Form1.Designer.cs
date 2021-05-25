
namespace _05_Operaciones_de_lectura
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnMostrarInformacion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblConexion = new System.Windows.Forms.Label();
            this.btnIniciarConexion = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumeroTelefonico = new System.Windows.Forms.TextBox();
            this.txtSP = new System.Windows.Forms.TextBox();
            this.btnSP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(40, 39);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(341, 129);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // btnMostrarInformacion
            // 
            this.btnMostrarInformacion.Location = new System.Drawing.Point(136, 174);
            this.btnMostrarInformacion.Name = "btnMostrarInformacion";
            this.btnMostrarInformacion.Size = new System.Drawing.Size(121, 23);
            this.btnMostrarInformacion.TabIndex = 1;
            this.btnMostrarInformacion.Text = "Mostrar informacion";
            this.btnMostrarInformacion.UseVisualStyleBackColor = true;
            this.btnMostrarInformacion.Click += new System.EventHandler(this.btnMostrarInformacion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(286, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Estado de la conexion:";
            // 
            // lblConexion
            // 
            this.lblConexion.AutoSize = true;
            this.lblConexion.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConexion.ForeColor = System.Drawing.Color.Navy;
            this.lblConexion.Location = new System.Drawing.Point(368, 312);
            this.lblConexion.Name = "lblConexion";
            this.lblConexion.Size = new System.Drawing.Size(0, 22);
            this.lblConexion.TabIndex = 3;
            // 
            // btnIniciarConexion
            // 
            this.btnIniciarConexion.Location = new System.Drawing.Point(559, 278);
            this.btnIniciarConexion.Name = "btnIniciarConexion";
            this.btnIniciarConexion.Size = new System.Drawing.Size(121, 23);
            this.btnIniciarConexion.TabIndex = 4;
            this.btnIniciarConexion.Text = "Abrir Conexion";
            this.btnIniciarConexion.UseVisualStyleBackColor = true;
            this.btnIniciarConexion.Click += new System.EventHandler(this.btnIniciarConexion_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(423, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Buscar por numero de telefono:";
            // 
            // txtNumeroTelefonico
            // 
            this.txtNumeroTelefonico.Location = new System.Drawing.Point(427, 50);
            this.txtNumeroTelefonico.Name = "txtNumeroTelefonico";
            this.txtNumeroTelefonico.Size = new System.Drawing.Size(306, 20);
            this.txtNumeroTelefonico.TabIndex = 6;
            this.txtNumeroTelefonico.TextChanged += new System.EventHandler(this.txtNumeroTelefonico_TextChanged);
            this.txtNumeroTelefonico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroTelefonico_KeyPress);
            // 
            // txtSP
            // 
            this.txtSP.Location = new System.Drawing.Point(427, 106);
            this.txtSP.Name = "txtSP";
            this.txtSP.Size = new System.Drawing.Size(306, 20);
            this.txtSP.TabIndex = 7;
            // 
            // btnSP
            // 
            this.btnSP.Location = new System.Drawing.Point(477, 132);
            this.btnSP.Name = "btnSP";
            this.btnSP.Size = new System.Drawing.Size(223, 23);
            this.btnSP.TabIndex = 8;
            this.btnSP.Text = "buscar con procedimiento almacendado";
            this.btnSP.UseVisualStyleBackColor = true;
            this.btnSP.Click += new System.EventHandler(this.btnSP_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSP);
            this.Controls.Add(this.txtSP);
            this.Controls.Add(this.txtNumeroTelefonico);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnIniciarConexion);
            this.Controls.Add(this.lblConexion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMostrarInformacion);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnMostrarInformacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblConexion;
        private System.Windows.Forms.Button btnIniciarConexion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumeroTelefonico;
        private System.Windows.Forms.TextBox txtSP;
        private System.Windows.Forms.Button btnSP;
    }
}

