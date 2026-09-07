namespace Formulario_de_Contacto
{
    partial class Form1
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
            label1 = new Label();
            TxtNombre = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            chkRespuesta = new CheckBox();
            RbSugerencia = new RadioButton();
            RbQueja = new RadioButton();
            RbConsulta = new RadioButton();
            BtbEnviar = new Button();
            textBox2 = new TextBox();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 31);
            label1.Name = "label1";
            label1.Size = new Size(154, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre de usuario :";
            // 
            // TxtNombre
            // 
            TxtNombre.Location = new Point(171, 31);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(220, 23);
            TxtNombre.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 91);
            label2.Name = "label2";
            label2.Size = new Size(127, 17);
            label2.TabIndex = 2;
            label2.Text = "Motivo de contacto";
            // 
            // panel1
            // 
            panel1.Controls.Add(chkRespuesta);
            panel1.Controls.Add(RbSugerencia);
            panel1.Controls.Add(RbQueja);
            panel1.Controls.Add(RbConsulta);
            panel1.Location = new Point(12, 109);
            panel1.Name = "panel1";
            panel1.Size = new Size(251, 153);
            panel1.TabIndex = 3;
            // 
            // chkRespuesta
            // 
            chkRespuesta.AutoSize = true;
            chkRespuesta.Location = new Point(19, 98);
            chkRespuesta.Name = "chkRespuesta";
            chkRespuesta.Size = new Size(147, 19);
            chkRespuesta.TabIndex = 3;
            chkRespuesta.Text = "Deseo recibir respuesta";
            chkRespuesta.UseVisualStyleBackColor = true;
            // 
            // RbSugerencia
            // 
            RbSugerencia.AutoSize = true;
            RbSugerencia.Location = new Point(19, 73);
            RbSugerencia.Name = "RbSugerencia";
            RbSugerencia.Size = new Size(83, 19);
            RbSugerencia.TabIndex = 2;
            RbSugerencia.TabStop = true;
            RbSugerencia.Text = "Sugerencia";
            RbSugerencia.UseVisualStyleBackColor = true;
            // 
            // RbQueja
            // 
            RbQueja.AutoSize = true;
            RbQueja.Location = new Point(19, 48);
            RbQueja.Name = "RbQueja";
            RbQueja.Size = new Size(56, 19);
            RbQueja.TabIndex = 1;
            RbQueja.TabStop = true;
            RbQueja.Text = "Queja";
            RbQueja.UseVisualStyleBackColor = true;
            // 
            // RbConsulta
            // 
            RbConsulta.AutoSize = true;
            RbConsulta.Location = new Point(19, 23);
            RbConsulta.Name = "RbConsulta";
            RbConsulta.Size = new Size(72, 19);
            RbConsulta.TabIndex = 0;
            RbConsulta.TabStop = true;
            RbConsulta.Text = "Consulta";
            RbConsulta.UseVisualStyleBackColor = true;
            // 
            // BtbEnviar
            // 
            BtbEnviar.Location = new Point(12, 283);
            BtbEnviar.Name = "BtbEnviar";
            BtbEnviar.Size = new Size(107, 23);
            BtbEnviar.TabIndex = 4;
            BtbEnviar.Text = "Enviar";
            BtbEnviar.UseVisualStyleBackColor = true;
            BtbEnviar.Click += BtbEnviar_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 358);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(453, 176);
            textBox2.TabIndex = 5;
            textBox2.UseWaitCursor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 340);
            label3.Name = "label3";
            label3.Size = new Size(75, 17);
            label3.TabIndex = 6;
            label3.Text = "Confirmar :";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(171, 588);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(139, 15);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Ver politica de privacidad";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(477, 630);
            Controls.Add(linkLabel1);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(BtbEnviar);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(TxtNombre);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Formulario de Contacto";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TxtNombre;
        private Label label2;
        private Panel panel1;
        private RadioButton RbSugerencia;
        private RadioButton RbQueja;
        private RadioButton RbConsulta;
        private CheckBox chkRespuesta;
        private Button BtbEnviar;
        private TextBox textBox2;
        private Label label3;
        private LinkLabel linkLabel1;
    }
}
