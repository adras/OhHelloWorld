string output = "💀☠🌞🐼😁🗿😍☝🥶🇵🇬🥳😎🚺✌⬅💦💪💖©💫💓🚯💣🇳🇮👽🤢😄👩🎯‍🏭🎁😬🧘‍♀️🤪🐨😚😇☠💀";

// Target: 72, 101, 108, 108, 111, 32, 87, 111, 114, 108, 100

for (int i = 0; i < output.Length; i++)
{
    Console.WriteLine($"{i},{(int)output[i]}");
}

for (int i = 0; i < 10; i++, i+=2)
{
    Console.WriteLine("test");
    Action<string> test = Console.WriteLine;
    test("This is going to be cool");
}

// It's possible to define multiple variables, however they may not be a different type
for (int a = 0, b; a < 10; a++) ;

// This does not work
// for (int a = 0, float b; a < 10; a++) ;

// Oooh, fancy pancy dynamic does allow it
// Cast is required though
for (dynamic a = 0, b = (Action<string>)Console.WriteLine; 5 < 3; a++) ;

// goal is something like this:
for (string i = "💀☠🌞🐼😁🗿😍☝🥶🇵🇬🥳😎🚺✌⬅💦💪💖©💫💓🚯💣🇳🇮👽🤢😄👩🎯‍🏭🎁😬🧘‍♀️🤪🐨😚😇☠💀"; ;) ;

Console.WriteLine("test");