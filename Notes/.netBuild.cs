/*
How to Run C# in VSCode (and Compile, Debug, and Create a Project)
by: TRAVIS MEDIA SEP 29, 2021 3 COMMENTS 3 MINUTE READ
While many developers use Visual Studio for C# development, I still use VSCode. In this post, I'll show you how to run C# in VSCode, as well as create a project, execute the code, debug, and compile it.
Quick Nav
How to Run C# in VSCode
1. Install .NET 5.0
2. Create a new C# project in VSCode
3. Run Your C# Code in VSCode
4. Debug Your C# Code in VSCode
5. Compile Your C# Code in VSCode
Conclusion
As stated above, I make it a point to use VSCode for as many things as I can get away with.

I feel comfortable in VSCode, know the shortcuts, and just don’t like jumping editors.

I started out with C# in Visual Studio because I was told to. It’s easy, has many, many features, and is what the tutorials told me to use.

Later, I made it a point to become efficient in it with VSCode. I was using it for everything else. Why not with C#? Visual Studio, to me, is just too bulky and has too much going on.

So in this post, I want to help you do the same.

Whether you are just starting out in C# or have decided to switch from Visual Studio to VSCode, I’m going to share with you how to run, debug, execute, and compile your C# code in VSCode.

Watch the Video?
Before we get started, if you prefer video format, check out the tutorial on YouTube.



Otherwise, continue reading.

How to Run C# in VSCode
1. Install .NET 5.0
First, install .NET 5.0. You can do that here:

https://dotnet.microsoft.com/download

Then confirm that dotnet is installed by checking the version in a terminal window:

dotnet --version
# 5.0.202 (or whatever version yours is)
Also go ahead and install this C# VSCode extension.

2. Create a new C# project in VSCode
Next, create a new project and open it in VSCode:

dotnet new console -o app
cd app
code . # to open project in VSCode
Now you should see a simple Hello World app with the main code in Program.cs

3. Run Your C# Code in VSCode
To execute your code, simply run:

dotnet run
…and you should see Hello World displayed in the console.

4. Debug Your C# Code in VSCode
First, be sure you installed the official C# extension mentioned above. If not, it can be found here.

Next, in VSCode open the Command Palette by going to View > Command Palette (or use the shortcut if you know what it is), and search for .NET: Generate Assets for Build and Debug



Choosing this will generate a .vscode folder with a prepopulated build configuration in it.

Now go to the “Run and Debug” tab in VSCode, set your breakpoint(s), and click the Play button to debug.



5. Compile Your Code
To compile your code, run:

dotnet build
After that is done you will have an executable (exe or dll) in your /bin folder. Depending on your build configuration it may be in a Debug folder or a Release folder.

Conclusion
And that’s how you run C# code in VSCode.

Now build our your code, debug it as needed, run dotnet run to execute your code, and dotnet build to compile it.

Rinse and repeat.

Let me know below if you have any questions.
*/