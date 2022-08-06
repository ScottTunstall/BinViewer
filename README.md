# BinViewer
View 1bpp pixel art from old arcade games/ spectrum / C64 

When you run the app simply "File | Open" the ROM file you think has character/sprite data in it, then find the correct offset, select bytes per row (1 byte = 8 pixels width) and how many rows tall the pixel data is.
You can zoom in or out with CTRL+numpad plus/minus

Feel free to clone, fork, create a pull request. If you do adapt this though, please give me credit.

BTW: Use at your own risk. It probably has MemorySteam memory leaks somewhere. I will try and iron these out.

Next steps planned: 

* export as binary DB statements (so you can paste into assembly code) - DONE
* copy image to clipboard  (DONE)
* show bytes as hex next to image
* overlay grid 


Do not expect this code to be SOLID, this tool is a quick and dirty means to an end. 
I may refactor when I have time.
