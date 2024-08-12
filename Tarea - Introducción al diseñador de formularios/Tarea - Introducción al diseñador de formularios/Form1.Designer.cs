namespace Tarea___Introducción_al_diseñador_de_formularios
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
            labelNombre = new Label();
            labelTelefono = new Label();
            labelCorreo = new Label();
            textBoxNombre = new TextBox();
            textBoxTelefono = new TextBox();
            textBoxCorreo = new TextBox();
            buttonEnviar = new Button();
            buttonLimpiar = new Button();
            listBox1 = new ListBox();
            LabelEstado = new Label();
            SuspendLayout();
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(36, 48);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(51, 15);
            labelNombre.TabIndex = 0;
            labelNombre.Text = "Nombre";
            // 
            // labelTelefono
            // 
            labelTelefono.AutoSize = true;
            labelTelefono.Location = new Point(36, 108);
            labelTelefono.Name = "labelTelefono";
            labelTelefono.Size = new Size(52, 15);
            labelTelefono.TabIndex = 1;
            labelTelefono.Text = "Teléfono";
            // 
            // labelCorreo
            // 
            labelCorreo.AutoSize = true;
            labelCorreo.Location = new Point(36, 177);
            labelCorreo.Name = "labelCorreo";
            labelCorreo.Size = new Size(105, 15);
            labelCorreo.TabIndex = 2;
            labelCorreo.Text = "Correo Electrónico";
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(36, 66);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(271, 23);
            textBoxNombre.TabIndex = 3;
            // 
            // textBoxTelefono
            // 
            textBoxTelefono.Location = new Point(36, 126);
            textBoxTelefono.Name = "textBoxTelefono";
            textBoxTelefono.Size = new Size(100, 23);
            textBoxTelefono.TabIndex = 4;
            // 
            // textBoxCorreo
            // 
            textBoxCorreo.Location = new Point(36, 195);
            textBoxCorreo.Name = "textBoxCorreo";
            textBoxCorreo.Size = new Size(271, 23);
            textBoxCorreo.TabIndex = 5;
            // 
            // buttonEnviar
            // 
            buttonEnviar.Location = new Point(36, 260);
            buttonEnviar.Name = "buttonEnviar";
            buttonEnviar.Size = new Size(75, 23);
            buttonEnviar.TabIndex = 6;
            buttonEnviar.Text = "Enviar";
            buttonEnviar.UseVisualStyleBackColor = true;
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.Location = new Point(232, 260);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(75, 23);
            buttonLimpiar.TabIndex = 7;
            buttonLimpiar.Text = "Limpiar";
            buttonLimpiar.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(389, 66);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(385, 199);
            listBox1.TabIndex = 8;
            // 
            // LabelEstado
            // 
            LabelEstado.AutoSize = true;
            LabelEstado.Location = new Point(722, 279);
            LabelEstado.Name = "LabelEstado";
            LabelEstado.Size = new Size(7, 15);
            LabelEstado.TabIndex = 9;
            LabelEstado.Text = "\r\n";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LabelEstado);
            Controls.Add(listBox1);
            Controls.Add(buttonLimpiar);
            Controls.Add(buttonEnviar);
            Controls.Add(textBoxCorreo);
            Controls.Add(textBoxTelefono);
            Controls.Add(textBoxNombre);
            Controls.Add(labelCorreo);
            Controls.Add(labelTelefono);
            Controls.Add(labelNombre);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNombre;
        private Label labelTelefono;
        private Label labelCorreo;
        private TextBox textBoxNombre;
        private TextBox textBoxTelefono;
        private TextBox textBoxCorreo;
        private Button buttonEnviar;
        private Button buttonLimpiar;
        private ListBox listBox1;
        private Label LabelEstado;
    }
}
