# BinViewer
View/ extract 1bpp pixel art/fonts from old arcade games/ spectrum / C64 / Amstrad CPC. 


## How to use

When you run the app simply **File | Open** the ROM file you think has character/sprite data in it, then keep incrementing the offset up/down button until you see graphical data that looks promising. 

Select bytes per row (1 byte = 8 pixels width) and how many rows tall the pixel data is, to get the sprite to look "right". 

This is trial and error - but persevere and reap rewards!

Here is an example showing some sprites from the Sinclair ZX Spectrum game "Manic Miner.z80". Note how Gridlines are turned on. They are not enabled by default - to turn them on press CTRL+G together, or use the **View | Gridlines** menu option.

(Continued after image)

<img width="455" alt="image" src="https://github.com/ScottTunstall/BinViewer/assets/34286887/29ab30ab-0e68-4892-ba54-9e3f7bdbc999">



### Keyboard shortcuts

Use **CTRL+G** to toggle grid on/off. This lets you identify individual pixels in a sprite.

You can zoom in or out with **CTRL+numpad plus/minus**, or input zoom factor into the zoom up/down control directly.

When the offset control is in focus, you can use **Page Up/Down** to page faster through the sprite data.



### Special functions

If you see any sprites you like and wish to clone (steal) for your own games, use the **Edit | Copy As Binary to clipboard** function. This will generate binary you can paste into your own assembly files. Here is a Manic Miner Miner Willy sprite extracted as binary:

<img width="189" alt="image" src="https://user-images.githubusercontent.com/34286887/209685819-afeda96a-c334-464e-974b-850e985a7444.png">



## Legalese

Feel free to clone, fork, create a pull request. If you do adapt this though, please give me credit.

BTW: Use at your own risk. It probably has MemorySteam memory leaks somewhere. I will try and iron these out.


## Next steps planned: 

* show bytes as hex next to image
* Create DATA statements for BASIC so that homebrew devs can create sprites too
* Colour selectors for grid and pixels (not top of my list tbh)
* Context menus for the bytes per column control and rows updown control. The former to have multiples of 2 and the latter to have multiples of 8 as dropdowns.

Do not expect this code to be SOLID, this tool is a quick and dirty means to an end. 
I may refactor when I have time.


