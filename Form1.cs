using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PicoPlaca
{
    public partial class Form1 : Form
    {
        public DateTime fecha;
        public string placa,digito;
        public TimeSpan hora;
        public double horadecimal;
        public int dia;


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                CamposVacios();
                Verificar();

            }
            catch (Exception ex)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
           
        }


        public void CamposVacios()
        {
            try
            {
                 if ((msktxtPlaca.Text != null) && (msktxtFecha.Text != "  -  -") && (msktxtHora.Text != "  :"))
                {
                    placa = msktxtPlaca.Text;
                    fecha = Convert.ToDateTime(msktxtFecha.Text);
                    horadecimal = Convert.ToDouble(TimeSpan.Parse(msktxtHora.Text).TotalHours);
                    dia = Convert.ToInt16(fecha.DayOfWeek);
                    digito = placa.Substring(7, 1);
                     lblResultado.Text = ("Placa: "+ placa+"\n"+
                                         "Fecha: "+fecha.ToShortDateString()+"\n"+
                                         "Hora: "+horadecimal+"\n"+" dia; "+dia+" "+fecha.ToString("dddd")+"\n"+
                                         "Digito "+digito);

                     msktxtPlaca.Text = "";
                     msktxtFecha.Text = "";
                     msktxtFecha.Enabled = false;
                     msktxtHora.Text = "";
                     msktxtHora.Enabled = false;

                }
                else
                {
                      MessageBox.Show("Please, complete all the information.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

               
}
            catch (Exception ex)
            {
                Console.WriteLine("{0} Exception caught.", ex);
            }
            
        }

        private void msktxtPlaca_TextChanged(object sender, EventArgs e)
        {
            //msktxtPlaca.Text = msktxtPlaca.Text.ToUpper();
            msktxtFecha.Enabled = true;
        }

        private void msktxtFecha_TextChanged(object sender, EventArgs e)
        {
            msktxtHora.Enabled = true;
        }

        private void Verificar()
        {
            switch (dia)
            {
                case 1:
                    if ((digito== "1") || (digito == "2"))
                    {
                        if (((horadecimal >= 7) && (horadecimal <= 9.5)) || ((horadecimal >= 16) && (horadecimal <= 19.5)))
                        {
                            panel1.BackColor = Color.Red;
                            lblcheck.Visible=false;
                            lblwrong.Visible=true;
                            MessageBox.Show("You CAN'T use your car", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                          
                        }
                        else
                        {
                            panel1.BackColor = Color.Green;
                            lblcheck.Visible=true;
                            lblwrong.Visible=false;
                            MessageBox.Show("You CAN use your car", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                           
                        }
                    }
                    break;
                case 2:
                    if ((digito == "3") || (digito == "4"))
                    {
                        if (((horadecimal >= 7) && (horadecimal <= 9.5)) || ((horadecimal >= 16) && (horadecimal <= 19.5)))
                        {
                            panel1.BackColor = Color.Red;
                            lblcheck.Visible=false;
                            lblwrong.Visible=true;
                            MessageBox.Show("You CAN'T use your car", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            panel1.BackColor = Color.Green;
                            lblcheck.Visible=true;
                            lblwrong.Visible=false;
                            MessageBox.Show("You CAN use your car", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                    break;
                case 3:
                    if ((digito == "5") || (digito == "6"))
                    {
                        if (((horadecimal >= 7) && (horadecimal <= 9.5)) || ((horadecimal >= 16) && (horadecimal <= 19.5)))
                        {
                            panel1.BackColor = Color.Red;
                            lblcheck.Visible=false;
                            lblwrong.Visible=true;
                            MessageBox.Show("You CAN'T use your car", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            panel1.BackColor = Color.Green;
                            lblcheck.Visible=true;
                            lblwrong.Visible=false;
                            MessageBox.Show("You CAN use your car", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                    break;
                case 4:
                    if ((digito == "7") || (digito == "8"))
                    {
                        if (((horadecimal >= 7) && (horadecimal <= 9.5)) || ((horadecimal >= 16) && (horadecimal <= 19.5)))
                        {
                            panel1.BackColor = Color.Red;
                            lblcheck.Visible=false;
                            lblwrong.Visible=true;
                            MessageBox.Show("You CAN'T use your car", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            panel1.BackColor = Color.Green;
                            lblcheck.Visible=true;
                            lblwrong.Visible=false;
                            MessageBox.Show("You CAN use your car", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                    break;
                case 5:
                    if ((digito == "9") || (digito == "0"))
                    {
                        if (((horadecimal >= 7) && (horadecimal <= 9.5)) || ((horadecimal >= 16) && (horadecimal <= 19.5)))
                        {
                            panel1.BackColor = Color.Red;
                            lblcheck.Visible = false;
                            lblwrong.Visible = true;
                            MessageBox.Show("You CAN'T use your car", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            panel1.BackColor = Color.Green;
                            lblcheck.Visible = true;
                            lblwrong.Visible = false;
                            MessageBox.Show("You CAN use your car", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                    break;
                default:
                    panel1.BackColor = Color.Green;
                    lblcheck.Visible=true;
                    lblwrong.Visible=false;
                    MessageBox.Show("You CAN use your car. Pico y Placa does not apply on weekends ", "Weekend", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                    break;

            
            }
        
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LblMensaje_Click(object sender, EventArgs e)
        {

        }

        private void lblcheck_Click(object sender, EventArgs e)
        {

        }
    }
}
