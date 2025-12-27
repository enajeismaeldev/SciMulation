namespace SciMulation.Assets.controls;

public class ImageButton : Button
{
    public Image NormalImage { get; set; }
    public Image PressedImage { get; set; }

    protected override void OnMouseDown(MouseEventArgs mevent)
    {
        BackgroundImage = PressedImage;
        base.OnMouseDown(mevent);
    }

    protected override void OnMouseUp(MouseEventArgs mevent)
    {
        BackgroundImage = NormalImage;
        base.OnMouseUp(mevent);
    }
}