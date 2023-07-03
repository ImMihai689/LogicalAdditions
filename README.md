# Logical Additions
Logic World mod with parts that I think have their place in Logic World (logically)

## Part list:
  ### `8bit Memory` *
  - Isn't memory in Logic World just a pain? "All those D-Latches!" "They're lagging out my game!" Well no more! This little fella can hold *4*kilobyes of data.
  - Use the eight horizontal inputs for data input, the twelve vertical inputs for the address, and, finally the lone horizontal input to write the data at the address. Then your data is held in the memory and can be accessed with the eight outputs.
  ### `16bit Memory` *
  - "Ugh, just 4Kb isn't enough data for my RISC-V processor, I can't make an OS in just 4Kb, not me!" Exactly for people like you, ~~we've~~ I fit **128**kilobytes of available data in just one part! (That's more than most Arduinos!)
  - Use the same instructions as the 8bit memory, exept you change the "eight"s and "twelve" to "sixteen".
  ### `ASCII Controller` 
  - "*sigh*, I whish I could make a display like the 1602 and 2004 LCDs for Arduinos... But how do i control all those pixels?" Answer: You don't! You use the ASCII Controller, and, as it's name emplies, it controls ASCII! No, wait... wrong play of words... ok, ok: It controls pixels! ...To show ASCII... Yes, it has a 5x7 output, perfect for your next LCD-esc display.
  - You send the propper character ASCII code to the eight clumped up pins on the back, and when you pulse the other pin on the back (the "set" pin), the ASCII code will be output-ed. And guess what? When you change the code, as long as you don't pulse the "set" pin, it will remember the code, and output the character.

    *The memory does not retain data if you leave and join the sandbox again. This will be fixed as soon as I find out how to fix it.

# How to install
  - Go to the "Code" button above the files, and press "Download ZIP"
  - Go on steam, right click Logic World in your library, go to "Manage > Browse local files", and open the "GameData" folder
  - Move the just-downloaded mod zip to the GameData folder
  - Extract the zip there (inside the GameData folder)
  - Start the game, and the mod should be in the mods list in-game
