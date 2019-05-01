using System.Drawing;
using System.Windows.Forms;

namespace AdditiveColorsApp
{
  public partial class Form1 : Form
  {
    private int diameter = 150;
    private int fromCenter = 0;
    private int dimension = 0;
    public Form1()
    {
      fromCenter = diameter / 2;
      dimension = fromCenter + diameter;
      InitializeComponent();
      ClientSize = new Size(dimension, dimension);
    }

    private void onPaint(object sender, PaintEventArgs e)
    {
      //left circle
      //control transparency through alpha parameter of color
      var pen = new Pen(Color.FromArgb(128, 255, 0, 0));
      var brush = new SolidBrush(Color.FromArgb(128, 255, 0, 0));
      var rect = new Rectangle(0, 0, diameter, diameter);
      e.Graphics.DrawEllipse(pen, rect);
      e.Graphics.FillEllipse(brush, rect);

      //right circle
      pen.Color = Color.FromArgb(128, 0, 255, 0);
      brush.Color = Color.FromArgb(128, 0, 255, 0);
      rect = new Rectangle(fromCenter, 0, diameter, diameter);
      e.Graphics.DrawEllipse(pen, rect);
      e.Graphics.FillEllipse(brush, rect);

      //bottom circle
      pen.Color = Color.FromArgb(128, 0, 0, 255);
      brush.Color = Color.FromArgb(128, 0, 0, 255);
      rect = new Rectangle(fromCenter / 2, fromCenter, diameter, diameter);
      e.Graphics.DrawEllipse(pen, rect);
      e.Graphics.FillEllipse(brush, rect);

      //draw labels
      //draw red
      brush.Color = Color.White;
      var font = new Font("Arial", diameter * .0625F, FontStyle.Bold);
      var textX = diameter / 8;
      var textY = diameter / 3;
      var format = new StringFormat();
      e.Graphics.DrawString("Red", font, brush, textX, textY, format);

      //draw yellow
      textX = diameter * 5 / 8;
      textY = diameter / 4;
      e.Graphics.DrawString("Yellow", font, brush, textX, textY, format);

      //draw white
      textX = diameter * 5 / 8;
      textY = diameter * 2 / 3;
      e.Graphics.DrawString("White", font, brush, textX, textY, format);

      //draw green
      textX = diameter * 5 / 8 + fromCenter;
      textY = diameter / 3;
      e.Graphics.DrawString("Green", font, brush, textX, textY, format);

      //draw magenta
      textX = diameter * 5 / 16;
      textY = diameter * 13 / 16;
      e.Graphics.DrawString("Magenta", font, brush, textX, textY, format);

      //draw cyan
      textX = diameter * 7 / 16 + fromCenter;
      textY = diameter * 13 / 16;
      e.Graphics.DrawString("Cyan", font, brush, textX, textY, format);

      //draw Blue
      textX = diameter * 5 / 8;
      textY = diameter * 2 / 3 + fromCenter;
      e.Graphics.DrawString("Blue", font, brush, textX, textY, format);
    }
  }
}
