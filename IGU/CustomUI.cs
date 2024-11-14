using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IGU
{
    public static class CustomUI
    {
        // Colores personalizables
        private static readonly Color PrimaryColor = Color.DodgerBlue;
        private static readonly Color SecondaryColor = Color.LightSkyBlue;
        private static readonly Color AccentColor = Color.White;
        private static readonly Color ButtonHoverColor = Color.DeepSkyBlue;
        private static readonly Color BorderColor = Color.SteelBlue;
        private static readonly Font DefaultFont = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);

        public static void LoadDefaultStyle(Form actualForm)
        {
            actualForm.BackColor = SecondaryColor;
            actualForm.Padding = new Padding(10);

            foreach (Control control in actualForm.Controls)
            {
                control.Font = DefaultFont;

                if (control is Button button)
                {
                    button.BackColor = PrimaryColor;
                    button.ForeColor = AccentColor;
                    button.FlatStyle = FlatStyle.Flat;
                    button.FlatAppearance.BorderSize = 1;
                    button.FlatAppearance.BorderColor = BorderColor;
                    button.FlatAppearance.MouseOverBackColor = ButtonHoverColor;
                    button.Cursor = Cursors.Hand;
                    button.Padding = new Padding(5);

                    // Bordes redondeados suaves
                    button.Paint += (sender, e) =>
                    {
                        Button btn = (Button)sender;
                        System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
                        int cornerRadius = 10; // Define qué tan redondeado quieres el borde
                        path.AddArc(new Rectangle(0, 0, cornerRadius, cornerRadius), 180, 90);
                        path.AddArc(new Rectangle(btn.Width - cornerRadius, 0, cornerRadius, cornerRadius), 270, 90);
                        path.AddArc(new Rectangle(btn.Width - cornerRadius, btn.Height - cornerRadius, cornerRadius, cornerRadius), 0, 90);
                        path.AddArc(new Rectangle(0, btn.Height - cornerRadius, cornerRadius, cornerRadius), 90, 90);
                        path.CloseAllFigures();
                        btn.Region = new Region(path);
                    };
                }
                else if (control is CheckBox checkBox)
                {
                    checkBox.ForeColor = BorderColor;
                    checkBox.FlatStyle = FlatStyle.Flat;
                    checkBox.BackColor = Color.Transparent;
                }
                else if (control is RadioButton radioButton)
                {
                    radioButton.ForeColor = BorderColor;
                    radioButton.FlatStyle = FlatStyle.Flat;
                    radioButton.BackColor = Color.Transparent;
                }
                else if (control is TextBox textBox)
                {
                    textBox.BackColor = AccentColor;
                    textBox.BorderStyle = BorderStyle.FixedSingle;
                    textBox.ForeColor = BorderColor;
                    textBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
                    textBox.Padding = new Padding(3);
                }
                else if (control is Label label)
                {
                    label.ForeColor = PrimaryColor;
                    label.TextAlign = ContentAlignment.MiddleLeft;
                    label.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
                }
                // Agrega más tipos de controles si es necesario
            }
        }
    }
}
