# UIManager
A simple UIManager in c# for unity

to use the UIManager :
1 : if you use the UIManager prefab bundled skip step 2 to 3

2 : Create an empty gameobject and attach the UIManager script to it and add a Screen Canvas to it as a child component

3 : link the Screen Canvas to the script of the UIManager in the editor

4 : Make your UI Panel that you want to interact with the UIManager child class of the BasePanel Class

5 : Add your UIPanel prefab to the BasePanel list of the UIManager

6 : to show/hide panels use the function like this : UIManager.Instance.HidePanel<Main_Menu_Panel>();
						     UIManager.Instance.ShowPanel<Main_Menu_Panel>();
where Main_Menu_Panel is the script attached to your main menu panel prefab.

7 : See Main_Menu_Panel and PauseMenu as exemple panel that use the UIManager

5 : Enjoy (make sure your UIManager is in your scene and is not destroyed on load or wte could happen)

Licensing : 

MIT License

Copyright (c) 2018 Guillaume Vachon Bureau (Glytz)

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
