using System.Diagnostics.Eventing.Reader;

namespace ejercicio_1
{
    public partial class Form1 : Form
    {
        int click = 1;
        double promedio;
        double completivo;
        double PromedioP;
        double promedioC;
        double PromedioE;

        

       


        public Form1()
        {
            InitializeComponent();
            CajaCompletivo.Hide();
            CajaExtraordinario.Hide();
            lblCompletivo.Hide();
            lblExtraordinario.Hide();
            lblPromedio.Hide();
            btnEnviar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnSalir.FlatStyle = FlatStyle.Flat;
        }


        private void btnEnviar_Click(object sender, EventArgs e)
        {


            if (click == 1)
            {

                double P1, P2, P3, P4;

                P1 = double.Parse(p1.Text);
                P2 = double.Parse(p2.Text);
                P3 = double.Parse(p3.Text);
                P4 = double.Parse(p4.Text);

                promedio = (P1 + P2 + P3 + P4) / 4;

                PromedioP = (P1 + P2 + P3 + P4) / 4;

                if (promedio > 69 && promedio <= 100)
                {
                    lblPromedio.Show();
                    lblPromedio.Text = "promedio:" + PromedioP;
                    lblPromedioGeneral.Text = "promedio general:" + promedio;
                    lblEstado.Text = "Estado: aprobado";
                    btnEnviar.Enabled = false;

                }
                else if (promedio <= 69 && promedio >= 0)
                {
                    lblPromedio.Show();
                    lblPromedio.Text = "promedio:" + PromedioP;
                    click = 2;
                    CajaCompletivo.Show();

                }

                else
                {
                    MessageBox.Show("ingrese valores validos");
                    click = 1;
                }


            }

            else if (click == 2)
            {
                

                completivo = double.Parse(Completivo.Text);

                promedio = (PromedioP* 0.5) + (completivo * 0.5);

                promedioC = (PromedioP * 0.5) + (completivo * 0.5);


                if (promedio > 69 && promedio <= 100)
                {
                    lblCompletivo.Show();
                    lblCompletivo.Text = "Completivo:" + promedioC;
                    lblPromedio.Text = "Promedio:" + PromedioP;
                    lblPromedioGeneral.Text = "promedio general:" + promedio;
                    lblEstado.Text = "Estado: aprobado";
                    btnEnviar.Enabled = false;

                }
                else if (promedio <= 69 && promedio >= 0)
                {
                    lblCompletivo.Show();
                    lblCompletivo.Text = "Completivo:" + promedioC;
                    CajaExtraordinario.Show();
                    click = 3;

                }
                else
                {
                    MessageBox.Show("profavor ingrese valores validos");
                    click = 2;
                }

            }

            else if (click == 3)
            {
                double extraordinario;
                completivo = double.Parse(Completivo.Text);
                extraordinario = double.Parse(Extraordinario.Text);

                promedio = (promedio * 0.3) + (extraordinario * 0.7);
                PromedioE =(promedio * 0.3) + (extraordinario * 0.7);

                if (promedio > 69 && promedio <= 100)
                {
                    lblExtraordinario.Show();

                    lblPromedio.Text = "Promedio:" + PromedioP;
                    lblCompletivo.Text = "Completivo:" + promedioC;
                    lblExtraordinario.Text = "Extraordinario:" + PromedioE;
                    lblPromedioGeneral.Text = "promedio general:" + promedio;
                    lblEstado.Text = "Estado: aprobado";
                    btnEnviar.Enabled = false;


                }
                else if (promedio <= 69 && promedio >= 0)
                {
                    lblExtraordinario.Show();
                    lblPromedio.Text = "Promedio:" + PromedioP;
                    lblCompletivo.Text = "Completivo:" + promedioC;
                    lblExtraordinario.Text = "Extraordinario:" + PromedioE;
                    lblPromedioGeneral.Text = "promedio general:" + promedio;
                    lblEstado.Text = "Estado: Reprobado";
                    btnEnviar.Enabled = false;

                }
                else
                {
                    MessageBox.Show("Porfa ingrese valores consistentes ");
                    click = 3;
                }
            }


        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            p1.Text = "";
            p2.Text = "";
            p3.Text = "";
            p4.Text = "";
            lblPromedio.Text = "Promedio:";
            lblCompletivo.Text = "Completivo:";
            lblExtraordinario.Text = "Extraordinario:";
            lblEstado.Text = "Estado:";

            CajaCompletivo.Hide();
            CajaExtraordinario.Hide();
            cajaResultado.Hide();
            btnEnviar.Enabled = true;

            click = 1;


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

        










