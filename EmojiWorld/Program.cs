

string output = "💀☠🌞🐼😁🗿😍☝🥶🇬🥳😎🚺✌⬅💦💪💖©💫💓🚯💣👽🤢😄👩🎯‍🏭🎁😬🧘‍♀️🤪🐨😚😇☠💀";

// Just debug
for (int i = 0; i < output.Length; i++)
{
    Console.WriteLine($"{i},{(int)output[i]}");
}


// Well, that above is not correct
// 

// Target: 72, 101, 108, 108, 111, 32, 87, 111, 114, 108, 100 and add a 😉 at the end.
// make sure it doesn't exist in the input string though

// So, what do we do now?
// There are already a couple of nice techniques
// But what should be ne major boom?
// Alrgithy, we've got a couple of features for the declaration loop
// Let's start simple: How does the randomizer work?

// features
// Just needs dynamics
//   We can declare icons in declaration part of for loop
//   We can also declare a Randomizer
//   We can declare Console Writeline


/*
0,55357    41,55357
1,56448    42,56483
2,9760     43,55356
3,55356    44,56819
4,57118    45,55356
5,55357    46,56814
6,56380    47,55357
7,55357    48,56445
8,56833    49,55358
9,55357    50,56610
10,56831   51,55357
11,55357   52,56836
12,56845   53,55357
13,9757    54,56425
14,55358   55,55356
15,56694   56,57263
16,55356   57,8205
17,56821   58,55356
18,55356   59,57325
19,56812   60,55356
20,55358   61,57217
21,56691   62,55357
22,55357   63,56876
23,56846   64,55358
24,55357   65,56792
25,57018   66,8205
26,9996    67,9792
27,11013   68,65039
28,55357   69,55358
29,56486   70,56618
30,55357   71,55357
31,56490   72,56360
32,55357   73,55357
33,56470   74,56858
34,169     75,55357
35,55357   76,56839
36,56491   77,9760
37,55357   78,55357
38,56467   79,56448
39,55357
40,57007
                
                
*/

// Implementation
// Maybe something like this?
for (dynamic smilez = "💀☠🌞🐼😁🗿😍☝🥶🇬🥳😎🚺✌⬅💦💪💖©💫💓🚯💣👽🤢😄👩🎯‍🏭🎁😬🧘‍♀️🤪🐨😚😇☠💀",
    write = (Action<string>)Console.WriteLine,
    rnd = new Random((int)DateTime.Now.Ticks);
    false;) ;

// Alright, here's the magic trickery:
/*
Trick 2: Think of a number
    Choose a number from 1 to 8.
        Multiply it by 2.
        Now multiply by 5.
        Subtract 5.
        Finally add 7.
    The first digit is the number you chose and the second digit is the number 2 

Here's another one:
Trick 3: Think of a number
    Think of any number.
        Double the number.
        Add 9 with result.
        Subtract 3 with the result.
        Divide the result by 2.
        Subtract the number with the first number started with.
    The answer will always be 3.

Man ... these are so cool
Trick 6: Think of a number between 20 and 100

    Pick a number between 20 and 100.
    Now add your digits together.
    Now subtract the total from your original number.
    Finally, add the digits of the new number together.
    Your answer will always be 9

You know ... a madman would compile all of these into one big monster. Let's see what else they've got.
Btw this stuff is from: https://www.risingstars-uk.com/blog/march-2018/blog-march-2018-magic-maths-blog
I mean ... It can't be that hard to understand what's happening. This would allow for creating custom ones ;)

Trick 5: Think of a number

    Write down a number.
    Add 5.
    Multiply by 3.
    Minus 15.
    Divide by your original number.
    Add 7.
    Your answer is 10.

Answer is 10 is good. We could build a prime number system however, and use that to build numbers, e.g. 2*2*3*5, 2*3, 3*7 etc

How does it work?
let's test

*/
Random r = new Random((int)DateTime.Now.Ticks);
for (int trick = 1; trick < 60000; trick++)
{
    int randomNumber = trick;

    int temp = randomNumber;
    temp += 23; // can be any number
    temp *= 26; // can be any number
    temp -= 23 * 26; // Changed to show that it's composed of the upper numbers, contains both numbers from above
    temp /= randomNumber; // Result will always be the second number= the one used at multiplication

    Console.WriteLine(temp);
}
// So I can use this to create numbers however I like.
// I should also use some of the smiles doing that.
// But let's skip that for later, that's just an addition at the end
// Target: 72 H, 101 E, 108 L, 108 L , 111 O, 32  , 87 W, 111 O, 114 R, 108 L, 100 D and add a 😉 at the end.


// Man ... unicode already sucks, because each char is actully two numbers
// We need a helper function for this, let's design a delegate
// 
// gotta call this one: BitConverter.ToInt32(bytes)

// Well, actually we could write a whole fucking piece of animation voodoo. Let's move over to App.cs

Console.WriteLine();
// This is so awesome, we even get two numbers.
// So basically the loop is at any random position
// We pick a random number between 1 and 8

// We also need a condition part and an increment...
for (dynamic smilez = "💀☠🌞🐼😁🗿😍☝🥶🇬🥳😎🚺✌⬅💦💪💖©💫💓🚯💣👽🤢😄👩🎯‍🏭🎁😬🧘‍♀️🤪🐨😚😇☠💀",
    write = (Action<string>)Console.WriteLine,
    rnd = new Random((int)DateTime.Now.Ticks); false;) ;

// We should start with the increment, and then define how it behaves in the condition
// So what do we do afterall?
// Can I see the integers again?


for (int i = 0; i < 10; i++, i += 2)
{
    Console.WriteLine("test");
    Action<string> test = Console.WriteLine;
    test("This is going to be cool");
}
// note: in the ascii table the right most  bits of a number represent the numer itself. same for letters
// use that? MIght end in some nice bitwise operators

// It's possible to define multiple variables, however they may not be a different type
for (int a = 0, b; a < 10; a++) ;

// This does not work
// for (int a = 0, float b; a < 10; a++) ;

// Oooh, fancy pancy dynamic does allow it
// Cast is required though
for (dynamic a = 0, b = (Action<string>)Console.WriteLine; 5 < 3; a++) ;

// goal is something like this:
for (string i = "💀☠🌞🐼😁🗿😍☝🥶🇬🥳😎🚺✌⬅💦💪💖©💫💓🚯💣👽🤢😄👩🎯‍🏭🎁😬🧘‍♀️🤪🐨😚😇☠💀"; ;) ;




Console.WriteLine("test");
