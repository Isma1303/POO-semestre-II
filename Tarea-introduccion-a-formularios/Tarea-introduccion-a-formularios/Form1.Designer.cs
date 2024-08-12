namespace Tarea_introduccion_a_formularios
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
            labelnombre = new Label();
            labelCorreo = new Label();
            labelMensaje = new Label();
            buttonEnviar = new Button();
            textBoxNombre = new TextBox();
            textBoxCorreo = new TextBox();
            textBoxMensaje = new TextBox();
            LabelEstado = new Label();
            SuspendLayout();
            // 
            // labelnombre
            // 
            labelnombre.AutoSize = true;
            labelnombre.Location = new Point(84, 66);
            labelnombre.Name = "labelnombre";
            labelnombre.Size = new Size(51, 15);
            labelnombre.TabIndex = 0;
            labelnombre.Text = "Nombre";
            // 
            // labelCorreo
            // 
            labelCorreo.AutoSize = true;
            labelCorreo.Location = new Point(84, 145);
            labelCorreo.Name = "labelCorreo";
            labelCorreo.Size = new Size(105, 15);
            labelCorreo.TabIndex = 1;
            labelCorreo.Text = "Correo Electrónico";
            labelCorreo.Click += label1_Click;
            // 
            // labelMensaje
            // 
            labelMensaje.AutoSize = true;
            labelMensaje.Location = new Point(81, 216);
            labelMensaje.Name = "labelMensaje";
            labelMensaje.Size = new Size(51, 15);
            labelMensaje.TabIndex = 2;
            labelMensaje.Text = "Mensaje";
            // 
            // buttonEnviar
            // 
            buttonEnviar.Location = new Point(310, 234);
            buttonEnviar.Name = "buttonEnviar";
            buttonEnviar.Size = new Size(75, 23);
            buttonEnviar.TabIndex = 3;
            buttonEnviar.Text = "Enviar";
            buttonEnviar.UseVisualStyleBackColor = true;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(87, 84);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(155, 23);
            textBoxNombre.TabIndex = 4;
            // 
            // textBoxCorreo
            // 
            textBoxCorreo.Location = new Point(88, 163);
            textBoxCorreo.Name = "textBoxCorreo";
            textBoxCorreo.Size = new Size(154, 23);
            textBoxCorreo.TabIndex = 5;
            // 
            // textBoxMensaje
            // 
            textBoxMensaje.Location = new Point(84, 234);
            textBoxMensaje.Multiline = true;
            textBoxMensaje.Name = "textBoxMensaje";
            textBoxMensaje.Size = new Size(154, 23);
            textBoxMensaje.TabIndex = 6;
            // 
            // LabelEstado
            // 
            LabelEstado.AutoSize = true;
            LabelEstado.Location = new Point(187, 325);
            LabelEstado.Name = "LabelEstado";
            LabelEstado.Size = new Size(0, 15);
            LabelEstado.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 450);
            Controls.Add(LabelEstado);
            Controls.Add(textBoxMensaje);
            Controls.Add(textBoxCorreo);
            Controls.Add(textBoxNombre);
            Controls.Add(buttonEnviar);
            Controls.Add(labelMensaje);
            Controls.Add(labelCorreo);
            Controls.Add(labelnombre);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelnombre;
        private Label labelCorreo;
        private Label labelMensaje;
        private Button buttonEnviar;
        private TextBox textBoxNombre;
        private TextBox textBoxCorreo;
        private TextBox textBoxMensaje;
        private Label LabelEstado;
    }
}
