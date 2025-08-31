using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCAMPO1ControlesFormulario
{
    public class FormularioNombre : System.Windows.Forms.Form
    {
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label lblResultado;

        private void InitializeComponent()
        {
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(355, 145);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(16, 13);
            this.lblResultado.TabIndex = 0;
            this.lblResultado.Text = "---";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(216, 138);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(412, 145);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(117, 23);
            this.btnMostrar.TabIndex = 2;
            this.btnMostrar.Text = "Mostrar Nombre";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormularioNombre
            // 
            this.ClientSize = new System.Drawing.Size(806, 361);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblResultado);
            this.Name = "FormularioNombre";
            this.Text = "FormularioNombre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
