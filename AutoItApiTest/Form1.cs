using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoITApi;
namespace AutoItApiTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //AutoIt.AU3_Init();
            int retVal = AutoIt.Run("notepad.exe", "",ShowWindowCommands.SW_MAXIMIZE);
            if (retVal != 0)
                Debug.Print(retVal.ToString());
            AutoIt.WinWaitActive("Unbenannt","");
            IntPtr winHandle = AutoIt.WinGetHandle("Unbenannt", "");
            AutoIt.Send("I'm in notepad");
            //AutoIt.AU3_Sleep(1000);
            string x = new string(' ',1000);
            AutoIt.WinGetClassListByHandle(winHandle, x, 1000);
            Debug.Print(x);
           retVal = AutoIt.WinCloseByHandle(winHandle);
           if (retVal != 0)
               Debug.Print(retVal.ToString());
           winHandle = AutoIt.WinGetHandle("Editor", "");
           
           IntPtr ctrlHandle = AutoIt.ControlGetHandle(winHandle, "Button2");
           AutoIt.ControlGetPosByHandle(winHandle, ctrlHandle, out Rect o);
           AutoIt.ToolTip("hallo");
           Debug.Print(o.ToString());
           AutoIt.ControlClickByHandle(winHandle, ctrlHandle, "", 1);
           AutoIt.ToolTip("", 0,0);
           //AutoIt.AU3_Init();
        }
    }
}
