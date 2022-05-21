using System.Diagnostics.CodeAnalysis;

//[assembly: SuppressMessage("Usage", "CS0168", Justification = "Not production code.", Scope = "member", Target = "~M:MyApp.Program.IgnorableCharacters")]

//Severity Code	Description	Project	File	Line	Suppression State
//Warning	CS0168	The variable 'b' is declared but never used	EmojiWorld	D:\repos\OtherRepositories\OhHelloWorld\EmojiWorld\Testing.cs   190 Active

string output = "💀☠🌞🐼😁🗿😍☝🥶🇬🥳😎🚺✌⬅💦💪💖©💫💓🚯💣👽🤢😄👩🎯‍🏭🎁😬🧘‍♀️🤪🐨😚😇☠💀";

// Just debug
for (int i = 0; i < output.Length; i++)
{
    Console.WriteLine($"{i},{(int)output[i]}");
}




Console.WriteLine("test");
