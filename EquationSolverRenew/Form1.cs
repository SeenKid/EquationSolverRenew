using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquationSolverRenew
{
    public partial class Form1 : Form
    {

        public string ErrorMessage { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        public ClasseForValues CheckInt()
        {
            // VARIABLES 
            bool check = true;
            string message = "\n Veuillez entrer des chiffres dans les champs:";
            string title = "Erreur !";
            var result = new ClasseForValues();
            int i = 0;

            // Reset les couleurs lorsqu'on clique sur le bouton calculer
            X1PlaceHolder.BackColor = Color.Empty;
            X2PlaceHolder.BackColor = Color.Empty;
            Y1PlaceHolder.BackColor = Color.Empty;
            Y2PlaceHolder.BackColor = Color.Empty;
            Answer1PlaceHolder.BackColor = Color.Empty;
            Answer2PlaceHolder.BackColor = Color.Empty;

            // ON CHECK SI LE TEXTE EST UN NOMBRE, SI NON, ON MET UN EFFET ROUGE ET ON OUVRE LA MESSAGEBOX
            if (!int.TryParse(X1PlaceHolder.Text, out int value1))
            {
                X1PlaceHolder.BackColor = Color.Red;
                i = 1;
                result.ErrorMessage += $"{message} {nameof(X1PlaceHolder)}";
            }

            if (!int.TryParse(X2PlaceHolder.Text, out int value2))
            {
                result.ErrorMessage += $"{message} {nameof(X2PlaceHolder)}";
                i = 1;
                X2PlaceHolder.BackColor = Color.Red;
            }

            if (!int.TryParse(Y1PlaceHolder.Text, out int value3))
            {
                result.ErrorMessage += $"{message} {nameof(Y1PlaceHolder)}";
                i = 1;
                Y1PlaceHolder.BackColor = Color.Red;
            }

            if (!int.TryParse(Y2PlaceHolder.Text, out int value4))
            {
                result.ErrorMessage += $"{message} {nameof(Y2PlaceHolder)}";
                i = 1;
                Y2PlaceHolder.BackColor = Color.Red;
            }

            if (!int.TryParse(Answer1PlaceHolder.Text, out int value5))
            {
                result.ErrorMessage += $"{message} {nameof(Answer1PlaceHolder)}";
                i = 1;
                Answer1PlaceHolder.BackColor = Color.Red;
            }

            if (!int.TryParse(Answer2PlaceHolder.Text, out int value6))
            {
                result.ErrorMessage += $"{message} {nameof(Answer2PlaceHolder)}";
                i = 1;
                Answer2PlaceHolder.BackColor = Color.Red;
            }
            result.Value1 = value1;
            result.Value2 = value2;
            result.Value3 = value3;
            result.Value4 = value4;
            result.Value5 = value5;
            result.Value6 = value6;

            if (i == 1)//!string.IsNullOrEmpty(result.ErrorMessage)
            {
                MessageBox.Show(result.ErrorMessage, title);
            }

            return result;
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            var IntChecker = CheckInt();
            if (IntChecker.Check)
            {
                int x1a = IntChecker.Value1; // X1 
                int x2a = IntChecker.Value2; // X2 
                int y1a = IntChecker.Value3; // Y1 
                int y2a = IntChecker.Value4; // Y2 
                int ans1 = IntChecker.Value5; // Ans1 
                int ans2 = IntChecker.Value6; // Ans2 

                //Calcul de X
                var DeterminantX = (ans1 * y2a - ans2 * y1a) / (x1a * y2a - x2a * y1a);
                //Calcul de Y
                var DeterminantY = (x1a * ans2 - x2a * ans1) / (x1a * y2a - x2a * y1a);

                // On Check si le calcul est réalisable, si il ne l'est pas, on affiche une boite d'erreur
                if (DeterminantX <= 0)
                {
                    string message = "Le calcul pour la valeur de X est impossible !";
                    string title = "Erreur !";
                    MessageBox.Show(message, title);

                    if (string.IsNullOrEmpty(reponsebox.Text))
                    {
                        reponsebox.Clear();
                        reponsebox.Text += "Calcul impossible";
                    }
                    else
                    {
                        reponsebox.Clear();
                        reponsebox.Text += "Calcul impossible";
                    }

                    return;
                }

                // On Check si le calcul est réalisable, si il ne l'est pas, on affiche une boite d'erreur
                if (DeterminantY <= 0)
                {
                    if (string.IsNullOrEmpty(reponsebox.Text))
                    {
                        reponsebox.Clear();
                        reponsebox.Text += "Calcul impossible";
                    }
                    else
                    {
                        reponsebox.Clear();
                        reponsebox.Text += "\r\nCalcul impossible";
                    }

                    string message = "Le calcul pour la valeur de Y est impossible !";
                    string title = "Erreur !";
                    MessageBox.Show(message, title);
                    reponsebox.Text = "Calcul impossible";

                    return;
                }

                // Partie calcul, si tout est réalisable
                int calculX = (ans1 * y2a - ans2 * y1a) / (x1a * y2a - x2a * y1a);
                int calculY = (x1a * ans2 - x2a * ans1) / (x1a * y2a - x2a * y1a);

                // On affiche le texte dans la textbox
                if (string.IsNullOrEmpty(reponsebox.Text))
                {
                    reponsebox.Clear();
                    reponsebox.Text += "X= " + String.Format("{0:#,0.00}", calculX) + ";" + "  " + " Y= " + String.Format("{0:#,0.00}", calculY);
                }
                else
                {
                    reponsebox.Clear();
                    reponsebox.Text += "\r\nX= " + String.Format("{0:#,0.00}", calculX) + ";" + "  " + " Y= " + String.Format("{0:#,0.00}", calculY);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AboutBox1 form = new AboutBox1();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var p = new Process();
                p.StartInfo = new ProcessStartInfo(@"https://github.com/SeenKid/EquationSolverRenew")
                {
                    UseShellExecute = true
                };
                p.Start();
            }
            catch (Exception exc)
            {
                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var p = new Process();
                p.StartInfo = new ProcessStartInfo(@"maths.pdf")
                {
                    UseShellExecute = true
                };
                p.Start();
            }
            catch (Exception exc)
            {
                    MessageBox.Show("Le fichier PDF n'est pas dans le même dossier que l'application.");
            }
            
        }

        private void reponsebox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}