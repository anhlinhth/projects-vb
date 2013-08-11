using System;
using System.Drawing;
using System.Windows.Forms;
using ConsoleApplication1;

public class ButtonFlatStyle : Form
{
    Button btn;
    int i = 1;
    FlatStyle[] flatStyles;
    Image img;

    public ButtonFlatStyle()
    {
        Text = "Button Properties";
        Size = new Size(300, 200);

        img = Image.FromFile("YourFile.bmp");

        btn = new Button();
        btn.Parent = this;
        btn.Text = btn.FlatStyle.ToString();
        btn.Location = new Point(10, 10);

        btn.Click += new System.EventHandler(btn_Click);
        btn.Image = img;

        ButtonSize(btn);

        FlatStyle theEnum = new FlatStyle();
        flatStyles = (FlatStyle[])Enum.GetValues(theEnum.GetType());
    }

    static void Main()
    {
        Application.Run(new ButtonFlatStyle());
    }

    private void btn_Click(object sender, EventArgs e)
    {
        Button btn = (Button)sender;
        btn.FlatStyle = flatStyles[i];
        btn.Text = btn.FlatStyle.ToString();
        ButtonSize(btn);

        if (i < flatStyles.Length - 1)
            i++;
        else
            i = 0;
    }

    private void ButtonSize(Button btn)
    {
        int xSize = ((int)(Font.Height * .75) * btn.Text.Length) + (img.Width * 2);
        int ySize = img.Height * 2;
        btn.Size = new Size(xSize, ySize);
    }
}
