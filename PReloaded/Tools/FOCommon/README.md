FOCommon
========

FOCommon is a .NET library written in C# for interacting with FOnline SDK gamedata. Originally FOCommon came about from the desire to have some shared functionality between different internal 2238 tools. Over time it grew into a full-fledged API for reading/editing various gamedata, in turn used by our other tools.

Released under the [MIT license](http://en.wikipedia.org/wiki/MIT_license).

Features
--------
* Full dialog parsing, including demands/results, comments and support for multiple languages.
* Critter proto parser.
* Item proto parser.
* Reading fomap files.
* Various worldmap classes.

Dependencies
--------
* .NET 2.0

Installation
--------
* Load the FOCommon project into your Visual Studio solution.
* Right-click your project in VS and choose "Add Reference" and add the FOCommon project.
* Include the namespaces that you want to use, e.g ```using FOCommon.Parsers;```

Code examples
--------
Here's a small program showing how to work with dialogs:

```c#
using System;
using FOCommon.Dialog;
using FOCommon.Parsers;

namespace FOCommonTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = @"SomeDialog.fodlg";

            DialogParser dialogParser = new DialogParser(fileName);
            if (!dialogParser.Parse())
            {
                Console.WriteLine("Failed to parse or load " + fileName);
                Console.ReadLine();
                return;
            }

            Dialog dialog = dialogParser.GetDialog();

            Console.WriteLine("Loaded " + fileName + "...");
            Console.WriteLine("Dialog languages: " + String.Join(",", dialog.LanguageTrees.ToArray()));
            Console.WriteLine("Comment: " + (string.IsNullOrEmpty(dialog.Comment) ? "<empty>" : dialog.Comment));
            Console.WriteLine("");
            foreach (Node node in dialog.Nodes)
            {
                // Write out each node with english text.
                Console.WriteLine("[{0}] {1}", node.Id, node.Text["engl"]);
            }

            Console.WriteLine();

            // Let's do some editing
            dialog.NpcName["engl"] = "AHS-9";
            dialog.Comment = "Edited by FOCommon.";

            // We add an answer with a demand.
            Answer newAnswer = new Answer();
            Demand newDemand = new Demand();
            newDemand.Param = new Parameter();
            newDemand.Param.ParamDefine = "ST_INTELLECT";
            newDemand.Operator = "=";
            newDemand.NoRecheck = true;
            newDemand.Value = 10;
            newAnswer.Demands.Add(newDemand);
            newAnswer.Text["engl"] = "Hand over the sourcecode now!";
            newAnswer.ToNode = Dialog.Attack;

            // We create a node and attach the answer to it.
            Node newNode = new Node();
            newNode.Text["engl"] = "I am AHS-9, the great and terrible!";
            newNode.ShuffleAnswers = false;
            newNode.Answers.Add(newAnswer);
            newNode.Id = dialog.Nodes.Count + 1;

            dialog.Nodes.Add(newNode);

            // Finally, we save it.
            if (!dialogParser.Save(dialog, fileName))
                Console.WriteLine("Failed to save " + fileName);
            else
                Console.WriteLine("Successfully saved " + fileName);

            Console.ReadLine();
        }
    }
}
```

I'll try to post some more examples later however if you have some immediate questions, send me a message or catch me on IRC.

TODO
--------
There are a lot of things to improve in the codebase, some classes are a bit too low-level and unfriendly to work with, please bear in mind that many of them were originally refactored out from tools.

I've put some TODO in various places of the code, feel free to fix those things and push your patches.

Changelog
--------

#### 1.0.0 - 2013-07-01
* Initial release
