using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ejercicio_1
{
    partial class Form1
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
            components.Dispose();

        base.Dispose(disposing);
    }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            p1 = new TextBox();
            p2 = new TextBox();
            p3 = new TextBox();
            p4 = new TextBox();
            Completivo = new TextBox();
            Extraordinario = new TextBox();
            CajaCompletivo = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            CajaExtraordinario = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            btnEnviar = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            cajaResultado = new GroupBox();
            lblPromedioGeneral = new Label();
            lblCompletivo = new Label();
            lblEstado = new Label();
            lblExtraordinario = new Label();
            lblPromedio = new Label();
            label6 = new Label();
            CajaCompletivo.SuspendLayout();
            CajaExtraordinario.SuspendLayout();
            cajaResultado.SuspendLayout();
            SuspendLayout();
            // 
            // p1
            // 
            p1.Location = new Point(12, 51);
            p1.Name = "p1";
            p1.PlaceholderText = "Periodo 1";
            p1.Size = new Size(100, 31);
            p1.TabIndex = 0;
            // 
            // p2
            // 
            p2.Location = new Point(12, 109);
            p2.Name = "p2";
            p2.PlaceholderText = "Periodo 2";
            p2.Size = new Size(100, 31);
            p2.TabIndex = 1;
            // 
            // p3
            // 
            p3.Location = new Point(12, 164);
            p3.Name = "p3";
            p3.PlaceholderText = "Periodo 3";
            p3.Size = new Size(100, 31);
            p3.TabIndex = 2;
            // 
            // p4
            // 
            p4.Location = new Point(12, 217);
            p4.Name = "p4";
            p4.PlaceholderText = "Periodo 4";
            p4.Size = new Size(100, 31);
            p4.TabIndex = 3;
            // 
            // Completivo
            // 
            Completivo.Location = new Point(161, 90);
            Completivo.Name = "Completivo";
            Completivo.PlaceholderText = "Completivo";
            Completivo.Size = new Size(100, 31);
            Completivo.TabIndex = 4;
            // 
            // Extraordinario
            // 
            Extraordinario.Location = new Point(176, 88);
            Extraordinario.Name = "Extraordinario";
            Extraordinario.PlaceholderText = "Extraordinario";
            Extraordinario.Size = new Size(100, 31);
            Extraordinario.TabIndex = 5;
            // 
            // CajaCompletivo
            // 
            CajaCompletivo.Controls.Add(label2);
            CajaCompletivo.Controls.Add(label1);
            CajaCompletivo.Controls.Add(Completivo);
            CajaCompletivo.Location = new Point(151, 9);
            CajaCompletivo.Name = "CajaCompletivo";
            CajaCompletivo.Size = new Size(275, 128);
            CajaCompletivo.TabIndex = 6;
            CajaCompletivo.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 93);
            label2.Name = "label2";
            label2.Size = new Size(149, 25);
            label2.TabIndex = 8;
            label2.Text = "Nota completivo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 27);
            label1.Name = "label1";
            label1.Size = new Size(255, 25);
            label1.TabIndex = 7;
            label1.Text = "ingrese la nota del completivo:";
            // 
            // CajaExtraordinario
            // 
            CajaExtraordinario.Controls.Add(label4);
            CajaExtraordinario.Controls.Add(label3);
            CajaExtraordinario.Controls.Add(Extraordinario);
            CajaExtraordinario.Location = new Point(151, 143);
            CajaExtraordinario.Name = "CajaExtraordinario";
            CajaExtraordinario.Size = new Size(291, 122);
            CajaExtraordinario.TabIndex = 7;
            CajaExtraordinario.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 88);
            label4.Name = "label4";
            label4.Size = new Size(170, 25);
            label4.TabIndex = 7;
            label4.Text = "Nota Extraordinario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 27);
            label3.Name = "label3";
            label3.Size = new Size(277, 25);
            label3.TabIndex = 6;
            label3.Text = "Ingrese la nota del Extraordinario:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 9);
            label5.Name = "label5";
            label5.Size = new Size(74, 25);
            label5.TabIndex = 8;
            label5.Text = "Ingrese:";
            // 
            // btnEnviar
            // 
            btnEnviar.BackColor = SystemColors.ControlLight;
            btnEnviar.Location = new Point(12, 352);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(112, 34);
            btnEnviar.TabIndex = 9;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = false;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = SystemColors.ControlLight;
            btnLimpiar.Location = new Point(344, 352);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(112, 34);
            btnLimpiar.TabIndex = 10;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.ControlLight;
            btnSalir.Location = new Point(652, 352);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(112, 34);
            btnSalir.TabIndex = 11;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // cajaResultado
            // 
            cajaResultado.Controls.Add(lblPromedioGeneral);
            cajaResultado.Controls.Add(lblCompletivo);
            cajaResultado.Controls.Add(lblEstado);
            cajaResultado.Controls.Add(lblExtraordinario);
            cajaResultado.Controls.Add(lblPromedio);
            cajaResultado.Location = new Point(464, 17);
            cajaResultado.Name = "cajaResultado";
            cajaResultado.Size = new Size(300, 254);
            cajaResultado.TabIndex = 13;
            cajaResultado.TabStop = false;
            // 
            // lblPromedioGeneral
            // 
            lblPromedioGeneral.AutoSize = true;
            lblPromedioGeneral.Location = new Point(6, 19);
            lblPromedioGeneral.Name = "lblPromedioGeneral";
            lblPromedioGeneral.Size = new Size(157, 25);
            lblPromedioGeneral.TabIndex = 4;
            lblPromedioGeneral.Text = "Promedio general:";
            // 
            // lblCompletivo
            // 
            lblCompletivo.AutoSize = true;
            lblCompletivo.Location = new Point(6, 107);
            lblCompletivo.Name = "lblCompletivo";
            lblCompletivo.Size = new Size(104, 25);
            lblCompletivo.TabIndex = 3;
            lblCompletivo.Text = "Completivo";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(6, 200);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(70, 25);
            lblEstado.TabIndex = 2;
            lblEstado.Text = "Estado:";
            // 
            // lblExtraordinario
            // 
            lblExtraordinario.AutoSize = true;
            lblExtraordinario.Location = new Point(6, 147);
            lblExtraordinario.Name = "lblExtraordinario";
            lblExtraordinario.Size = new Size(126, 25);
            lblExtraordinario.TabIndex = 1;
            lblExtraordinario.Text = "Extraordinario:";
            // 
            // lblPromedio
            // 
            lblPromedio.AutoSize = true;
            lblPromedio.Location = new Point(6, 65);
            lblPromedio.Name = "lblPromedio";
            lblPromedio.Size = new Size(94, 25);
            lblPromedio.TabIndex = 0;
            lblPromedio.Text = "Promedio:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(41, 357);
            label6.Name = "label6";
            label6.Size = new Size(0, 25);
            label6.TabIndex = 14;
            // 
            // Form1
            // 
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(cajaResultado);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEnviar);
            Controls.Add(label5);
            Controls.Add(CajaExtraordinario);
            Controls.Add(p1);
            Controls.Add(p2);
            Controls.Add(p3);
            Controls.Add(p4);
            Controls.Add(CajaCompletivo);
            Name = "Form1";
            Text = "Form1";
            CajaCompletivo.ResumeLayout(false);
            CajaCompletivo.PerformLayout();
            CajaExtraordinario.ResumeLayout(false);
            CajaExtraordinario.PerformLayout();
            cajaResultado.ResumeLayout(false);
            cajaResultado.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox p1;
    private TextBox p2;
    private TextBox p3;
    private TextBox p4;
    private TextBox Completivo;
    private TextBox Extraordinario;
    private GroupBox CajaCompletivo;
        private Label label1;
        private Label label2;
        private GroupBox CajaExtraordinario;
        private Label label4;
        private Label label3;
        private Label label5;
        private Button btnEnviar;
        private Button btnLimpiar;
        private Button btnSalir;
        private GroupBox cajaResultado;
        private Label lblCompletivo;
        private Label lblEstado;
        private Label lblExtraordinario;
        private Label lblPromedio;
        private Label label6;
        private Label lblPromedioGeneral;
    }
}
