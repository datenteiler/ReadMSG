string fileName = string.Empty;
if (args.Length == 0 || args.Length > 1 )
{
    Console.WriteLine("Bitte nur 1 Argument übergeben!");
}
else
{
    fileName = args[0].ToString();
}

if (!File.Exists(fileName)) 
{
    Console.WriteLine($"Die Datei {fileName} existiert nicht.");
    Environment.Exit(0);
}

try
{
    using var msg = new MsgReader.Outlook.Storage.Message(fileName);    
    Console.WriteLine($"From: {(msg.Sender).DisplayName} {(msg.Sender).Email}");
    Console.WriteLine($"Sent: {msg.SentOn}");
    Console.WriteLine($"Subject: {msg.Subject}");
    Console.WriteLine($"Body:");
    Console.WriteLine(msg.BodyText);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
