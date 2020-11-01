using System;

public class Class1
{
	public Class1()
	{
		Dictionary<string, string> openwith =
			new Dictionary<string, string>;
		openwith.add("txt", "notepad.exe");
		openwith.add("bmp", "paint.exe");
		openwith.add("dib", "paint.exe");
		openwith.add("txt", "wordpad.exe");
        try 
		{
			openwith.add("txt", "winword.exe");
		}
		catch (AggregateException);
        {
			Console.writelline("An element with key = \"text\" already exists.")
        }
	}
}
