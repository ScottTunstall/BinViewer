# BinViewer
View 1bpp pixel art from old arcade games/ spectrum / C64 

When you run the app simply "File | Open" the ROM file you think has character/sprite data in it, then find the correct offset, select bytes per row (1 byte = 8 pixels width) and how many rows tall the pixel data is. This is trial and error at the moment.

You can zoom in or out with CTRL+numpad plus/minus, or input zoom factor into the zoom up/down control directly.

When the offset control is in focus, you can use Page Up/Down to page faster through memory.

Feel free to clone, fork, create a pull request. If you do adapt this though, please give me credit.

BTW: Use at your own risk. It probably has MemorySteam memory leaks somewhere. I will try and iron these out.

Next steps planned: 

* export as binary DB statements (so you can paste into assembly code) - DONE
* copy image to clipboard  (DONE)
* show bytes as hex next to image
* overlay grid 


Do not expect this code to be SOLID, this tool is a quick and dirty means to an end. 
I may refactor when I have time.

Here is an example showing some sprites from the Sinclair ZX Spectrum game "Manic Miner.z80".

![image](https://user-images.githubusercontent.com/34286887/209683347-021036d3-c69c-4d17-917f-4dccfc2ccd27.png)
