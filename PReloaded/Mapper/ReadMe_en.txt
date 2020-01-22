FOnline: 2238 Mapper, version 1.29.0

***

Changes in FOnline: 2238 Mapper

 - new interface (Set ScreenWidth = 1090 or higher in client's FOnline.cfg) with re-arranged tabs and submenus
 - zoom % information
 - tile grid (press G to turn it on/off)
 - autowall [wip] (press A and drag mouse to check it out)

***

To run a mapper, specify the server and client path in the Mapper.cfg file.

To load a saved map, type "~<map name>" in the console.
TO save a map, type "^<map name> [/text] [/nopack]". "/text" to save it in text format, "/nopack" to save it in unpacked version.

Other commands, preceded with "*":
 new		create a new map;
 unload		unload the current map;
 scripts	list of scripts;
 size <w> <h>	set a new map size;
 dupl		search for items with the same pids, placed on the same hexes;
 scroll		search for scroll blockes, around which there are less than two other scroll blockers;
 pidpos <pid>	search for all items with a given pid;
 hex <hx> <hy>	search for all objects on a given hex.

To run a script function, use "#". Executed function must be of prototype "string FuncName(string)", string argument is passed from a console, and function results will be displayed in the message box. Default module is "main", to execute a function from another module use "@" (for example, "#module@MyFunc").
Example:
In console, "#MyFunc Hello wo";
In script, "string MyFunc(string my) { return my + "rld!"; }";
Result in the message box: "Result: Hello world!".

Scripts are placed in the "/data" directory. List of loaded scripts is in scripts.cfg. The main script is mapper_main.fos, which contains all reserved functions, and basic list of API functions.

The mapper does not support FO and FO2 map formats, as well as older FOnline map formats.

On the main panel, there is a range of buttons that group the objects by their type.
Below these buttons, there's a panel with buttons toggling the display of items in the map view.
On the right, there are buttons that determine which objects will be selected by clicking and dragging the mouse.
Other buttons:
Fast - displays list of often used items;
Ign - Ignore, shows ignored objects that are not rendered on the map;
Inv - Inventory, shows objects inside a container or inside critters' inventory;
Lst - List, shows all loaded maps and allows to switch between them.

Upon selecting an object, an option window will appear allowing to edit some of it's properties (marked green; white are not editable).
To add an object to Ignored objects list, click it with Ctrl on the object selection panel.
To add an object to the container or inventory, click it with Alt on the object selection panel.
To put an object in a critter's slot, click the item in it's inventory with Shift.

To apply a change in the object properties window to a range of selected objects (of the same type), click To All button.

To remove selected object(s), press Del.

To change direction of a critter, use middle mouse button.

To add a range of objects to already selected objects, hold Ctrl.

To change zoom, use mouse wheel.

To speed up scrolling of objects in the panel, use the following:
Shift - one page,
Ctrl - 100 elements,
Alt - 1000 elements.

To play animation of a selected critter, use "@" command with codes of desired animations. For instance, to play animations of movement, and then using, type "@abal" (case is ignored, as well as whitespaces). If no critter is selected, all critters on the map will play the animation. For information on animation codes, see http://modguide.nma-fallout.com/#Graphics011

To move a critter, hold down Shift and click the desired position.

Hotkeys:
F1: Enable/Disable display of items.
F2: Enable/Disable display of sceneries.
F3: Enable/Disable display of walls.
F4: Enable/Disable display of critter.
F5: Enable/Disable display of tiles.
F6: Enable/Disable display of frequently used objects.
F7: Hide/Show the main panel.
Shift + F7: Fix the position of the main panel (enabled by default).
F8: Enable/Disable scrolling with mouse.
F9: Hide/Show the object properties window.
Shift + F9: Fix the position of the object properties window (disabled by default).
F11: Set rain.
Shift + Escape: Exit the mapper.
Del: Delete the selected objects.
Ctrl + X: Cut objects.
Ctrl + C: Copy objects.
Ctrl + V: Paste objects.
Ctrl + A: Select all.
Ctrl + S: Enable/Disable ignoring of scroll blockers.
Ctrl + B: Show impassable hexes. Red are impassable, and not shootable through. Green are impassable, shootable through.
Ctrl + M: Display NPC information over their heads (this has few modes of display).
Ctrl + L: Save the log to a txt file.
Tab: Change the type of objects selection (diamond or rectangle).
+: Change time by 1 hour.
-: Change time by -1 hour.

Special Entires:
0 - default;
240 - starting position for a player who logged for a first time;
241 - starting position for players on a map with NoLogOff flag.
242 - replication.
243 - car entry point.
245 - vertibird entry point.
246 - boat entry point.