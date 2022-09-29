using System.Drawing;

//image
var myBitmap = new Bitmap("C:\\Users\\Benjamin\\source\\repos\\ImageClassification\\testImg.png");

//get the RGB values of each pixel
for (int x = 0; x < myBitmap.Width; x++)
{
    for (int y = 0; y < myBitmap.Height; y++)
    {
        // Get the color of a pixel within myBitmap.
        Color pixelColor = myBitmap.GetPixel(x, y);
        string pixelColorStringValue =
            pixelColor.R.ToString("D3") + " " +
            pixelColor.G.ToString("D3") + " " +
            pixelColor.B.ToString("D3") + ", ";
        Console.WriteLine(pixelColorStringValue);
        switch (pixelColorStringValue)
        {
            case "255 255 255":
                {
                    // white pixel
                    break;
                }
            case "000 000 000":
                {
                    // black pixel
                    break;
                }
        }
    }
}