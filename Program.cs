using checker.Models;
using ckecker.Data;
using QRCoder;

//dotnet add package QRCoder --version 1.8.0
//dotnet add package AWSSDK.S3 --version 4.0.23.4
    static void guis()
    {
        Guid newGuid = Guid.NewGuid();
        string guid = newGuid.ToString();
        var qrGenerator = new QRCodeGenerator();
        var qrData = qrGenerator.CreateQrCode(guid,QRCodeGenerator.ECCLevel.Q);
        var pngBytes = new PngByteQRCode(qrData);
        byte[] imagen = pngBytes.GetGraphic(20);
        Console.WriteLine(guid);
    }


    guis();


