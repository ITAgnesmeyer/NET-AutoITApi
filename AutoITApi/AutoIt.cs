﻿using System;
using System.Runtime.InteropServices;

namespace AutoITApi
{
    public static class AutoIt
    {
#if WIN64
        private const string DllFile = "AutoItX3_x64.dll";
#else
        private const string DllFile = "AutoItX3.dll";
#endif


        [DllImport(DllFile, EntryPoint = "AU3_Init", CharSet = CharSet.Unicode)]
        public static extern void Init();

        [DllImport(DllFile, EntryPoint = "AU3_error", CharSet = CharSet.Unicode)]
        public static extern int error();

        [DllImport(DllFile, EntryPoint = "AU3_AutoItSetOption", CharSet = CharSet.Unicode)]
        public static extern int AutoItSetOption(string szOption, int nValue);

        [DllImport(DllFile, EntryPoint = "AU3_ClipGet", CharSet = CharSet.Unicode)]
        public static extern void ClipGet(string szClip, int nBufSize);

        [DllImport(DllFile, EntryPoint = "AU3_ClipPut", CharSet = CharSet.Unicode)]
        public static extern void ClipPut(string szClip);

        [DllImport(DllFile, EntryPoint = "AU3_ControlClick", CharSet = CharSet.Unicode)]
        public static extern int ControlClick(string szTitle, string szText, string szControl, string szButton,
            int nNumClicks, int nX = DefineConstants.AU3_INTDEFAULT, int nY = DefineConstants.AU3_INTDEFAULT);

        [DllImport(DllFile, EntryPoint = "AU3_ControlClickByHandle", CharSet = CharSet.Unicode)]
        public static extern int ControlClickByHandle(IntPtr hWnd, IntPtr hCtrl, string szButton, int nNumClicks,
            int nX = DefineConstants.AU3_INTDEFAULT, int nY = DefineConstants.AU3_INTDEFAULT);

        [DllImport(DllFile, EntryPoint = "AU3_ControlCommand", CharSet = CharSet.Unicode)]
        public static extern void ControlCommand(string szTitle, string szText, string szControl, string szCommand,
            string szExtra, string szResult, int nBufSize);

        [DllImport(DllFile, EntryPoint = "AU3_ControlCommandByHandle", CharSet = CharSet.Unicode)]
        public static extern void ControlCommandByHandle(IntPtr hWnd, IntPtr hCtrl, string szCommand,
            string szExtra, string szResult, int nBufSize);

        [DllImport(DllFile, EntryPoint = "AU3_ControlListView", CharSet = CharSet.Unicode)]
        public static extern void ControlListView(string szTitle, string szText, string szControl, string szCommand,
            string szExtra1, string szExtra2, string szResult, int nBufSize);

        [DllImport(DllFile, EntryPoint = "AU3_ControlListViewByHandle", CharSet = CharSet.Unicode)]
        public static extern void ControlListViewByHandle(IntPtr hWnd, IntPtr hCtrl, string szCommand,
            string szExtra1, string szExtra2, string szResult, int nBufSize);

        [DllImport(DllFile, EntryPoint = "AU3_ControlDisable", CharSet = CharSet.Unicode)]
        public static extern int ControlDisable(string szTitle, string szText, string szControl);

        [DllImport(DllFile, EntryPoint = "AU3_ControlDisableByHandle", CharSet = CharSet.Unicode)]
        public static extern int ControlDisableByHandle(IntPtr hWnd, IntPtr hCtrl);

        [DllImport(DllFile, EntryPoint = "AU3_ControlEnable", CharSet = CharSet.Unicode)]
        public static extern int ControlEnable(string szTitle, string szText, string szControl);

        [DllImport(DllFile, EntryPoint = "AU3_ControlEnableByHandle", CharSet = CharSet.Unicode)]
        public static extern int ControlEnableByHandle(IntPtr hWnd, IntPtr hCtrl);

        [DllImport(DllFile, EntryPoint = "AU3_ControlFocus", CharSet = CharSet.Unicode)]
        public static extern int ControlFocus(string szTitle, string szText, string szControl);

        [DllImport(DllFile, EntryPoint = "AU3_ControlFocusByHandle", CharSet = CharSet.Unicode)]
        public static extern int ControlFocusByHandle(IntPtr hWnd, IntPtr hCtrl);

        [DllImport(DllFile, EntryPoint = "AU3_ControlGetFocus", CharSet = CharSet.Unicode)]
        public static extern void ControlGetFocus(string szTitle, string szText, string szControlWithFocus,
            int nBufSize);

        [DllImport(DllFile, EntryPoint = "AU3_ControlGetFocusByHandle", CharSet = CharSet.Unicode)]
        public static extern void ControlGetFocusByHandle(IntPtr hWnd, string szControlWithFocus, int nBufSize);

        [DllImport(DllFile, EntryPoint = "AU3_ControlGetHandle", CharSet = CharSet.Unicode)]
        public static extern IntPtr ControlGetHandle(IntPtr hWnd, string szControl);

        [DllImport(DllFile, EntryPoint = "AU3_ControlGetHandleAsText", CharSet = CharSet.Unicode)]
        public static extern void ControlGetHandleAsText(string szTitle, string szText, string szControl,
            string szRetText, int nBufSize);

        [DllImport(DllFile, EntryPoint = "AU3_ControlGetPos", CharSet = CharSet.Unicode)]
        public static extern int ControlGetPos(string szTitle, string szText, string szControl, out Rect lpRect);

        [DllImport(DllFile, EntryPoint = "AU3_ControlGetPosByHandle", CharSet = CharSet.Unicode)]
        public static extern int ControlGetPosByHandle(IntPtr hWnd, IntPtr hCtrl, out Rect lpRect);

        [DllImport(DllFile, EntryPoint = "AU3_ControlGetText", CharSet = CharSet.Unicode)]
        public static extern void ControlGetText(string szTitle, string szText, string szControl,
            string szControlText, int nBufSize);

        [DllImport(DllFile, EntryPoint = "AU3_ControlGetTextByHandle", CharSet = CharSet.Unicode)]
        public static extern void ControlGetTextByHandle(IntPtr hWnd, IntPtr hCtrl, string szControlText,
            int nBufSize);

        [DllImport(DllFile, EntryPoint = "AU3_ControlHide", CharSet = CharSet.Unicode)]
        public static extern int ControlHide(string szTitle, string szText, string szControl);

        [DllImport(DllFile, EntryPoint = "AU3_ControlHideByHandle", CharSet = CharSet.Unicode)]
        public static extern int ControlHideByHandle(IntPtr hWnd, IntPtr hCtrl);

        [DllImport(DllFile, EntryPoint = "AU3_ControlMove", CharSet = CharSet.Unicode)]
        public static extern int ControlMove(string szTitle, string szText, string szControl, int nX, int nY,
            int nWidth = -1, int nHeight = -1);

        [DllImport(DllFile, EntryPoint = "AU3_ControlMoveByHandle", CharSet = CharSet.Unicode)]
        public static extern int ControlMoveByHandle(IntPtr hWnd, IntPtr hCtrl, int nX, int nY, int nWidth = -1,
            int nHeight = -1);

        [DllImport(DllFile, EntryPoint = "AU3_ControlSend", CharSet = CharSet.Unicode)]
        public static extern int ControlSend(string szTitle, string szText, string szControl, string szSendText,
            int nMode = 0);

        [DllImport(DllFile, EntryPoint = "AU3_ControlSendByHandle", CharSet = CharSet.Unicode)]
        public static extern int ControlSendByHandle(IntPtr hWnd, IntPtr hCtrl, string szSendText, int nMode = 0);

        [DllImport(DllFile, EntryPoint = "AU3_ControlSetText", CharSet = CharSet.Unicode)]
        public static extern int ControlSetText(string szTitle, string szText, string szControl,
            string szControlText);

        [DllImport(DllFile, EntryPoint = "AU3_ControlSetTextByHandle", CharSet = CharSet.Unicode)]
        public static extern int ControlSetTextByHandle(IntPtr hWnd, IntPtr hCtrl, string szControlText);

        [DllImport(DllFile, EntryPoint = "AU3_ControlShow", CharSet = CharSet.Unicode)]
        public static extern int ControlShow(string szTitle, string szText, string szControl);

        [DllImport(DllFile, EntryPoint = "AU3_ControlShowByHandle", CharSet = CharSet.Unicode)]
        public static extern int ControlShowByHandle(IntPtr hWnd, IntPtr hCtrl);

        [DllImport(DllFile, EntryPoint = "AU3_ControlTreeView", CharSet = CharSet.Unicode)]
        public static extern void ControlTreeView(string szTitle, string szText, string szControl, string szCommand,
            string szExtra1, string szExtra2, string szResult, int nBufSize);

        [DllImport(DllFile, EntryPoint = "AU3_ControlTreeViewByHandle", CharSet = CharSet.Unicode)]
        public static extern void ControlTreeViewByHandle(IntPtr hWnd, IntPtr hCtrl, string szCommand,
            string szExtra1, string szExtra2, string szResult, int nBufSize);

        [DllImport(DllFile, EntryPoint = "AU3_DriveMapAdd", CharSet = CharSet.Unicode)]
        public static extern void DriveMapAdd(string szDevice, string szShare, int nFlags, string szUser,
            string szPwd, string szResult, int nBufSize);

        [DllImport(DllFile, EntryPoint = "AU3_DriveMapDel", CharSet = CharSet.Unicode)]
        public static extern int DriveMapDel(string szDevice);

        [DllImport(DllFile, EntryPoint = "AU3_DriveMapGet", CharSet = CharSet.Unicode)]
        public static extern void DriveMapGet(string szDevice, string szMapping, int nBufSize);

        [DllImport(DllFile, EntryPoint = "AU3_IsAdmin", CharSet = CharSet.Unicode)]
        public static extern int IsAdmin();

        [DllImport(DllFile, EntryPoint = "AU3_MouseClick", CharSet = CharSet.Unicode)]
        public static extern int MouseClick(string szButton, int nX,
            int nY, int nClicks, int nSpeed);

        [DllImport(DllFile, EntryPoint = "AU3_MouseClickDrag", CharSet = CharSet.Unicode)]
        public static extern int MouseClickDrag(string szButton, int nX1, int nY1, int nX2, int nY2,
            int nSpeed = -1);

        [DllImport(DllFile, EntryPoint = "AU3_MouseDown", CharSet = CharSet.Unicode)]
        public static extern void MouseDown(string szButton);

        [DllImport(DllFile, EntryPoint = "AU3_MouseGetCursor", CharSet = CharSet.Unicode)]
        public static extern int MouseGetCursor();

        [DllImport(DllFile, EntryPoint = "AU3_MouseGetPos", CharSet = CharSet.Unicode)]
        public static extern void MouseGetPos(out Point lpPoint);

        [DllImport(DllFile, EntryPoint = "AU3_MouseMove", CharSet = CharSet.Unicode)]
        public static extern int MouseMove(int nX, int nY, int nSpeed);

        [DllImport(DllFile, EntryPoint = "AU3_MouseUp", CharSet = CharSet.Unicode)]
        public static extern void MouseUp(string szButton);

        [DllImport(DllFile, EntryPoint = "AU3_MouseWheel", CharSet = CharSet.Unicode)]
        public static extern void MouseWheel(string szDirection, int nClicks);

        [DllImport(DllFile, EntryPoint = "AU3_Opt", CharSet = CharSet.Unicode)]
        public static extern int Opt(string szOption, int nValue);

        [DllImport(DllFile, EntryPoint = "AU3_PixelChecksum", CharSet = CharSet.Unicode)]
        public static extern uint PixelChecksum(ref Rect lpRect, int nStep = 1);

        [DllImport(DllFile, EntryPoint = "AU3_PixelGetColor", CharSet = CharSet.Unicode)]
        public static extern int PixelGetColor(int nX, int nY);

        [DllImport(DllFile, EntryPoint = "AU3_PixelSearch", CharSet = CharSet.Unicode)]
        public static extern void PixelSearch(ref Rect lpRect, int nCol, int nVar, int nStep,
            out Point pPointResult);

        [DllImport(DllFile, EntryPoint = "AU3_ProcessClose", CharSet = CharSet.Unicode)]
        public static extern int ProcessClose(string szProcess);

        [DllImport(DllFile, EntryPoint = "AU3_ProcessExists", CharSet = CharSet.Unicode)]
        public static extern int ProcessExists(string szProcess);

        [DllImport(DllFile, EntryPoint = "AU3_ProcessSetPriority", CharSet = CharSet.Unicode)]
        public static extern int ProcessSetPriority(string szProcess, int nPriority);

        [DllImport(DllFile, EntryPoint = "AU3_ProcessWait", CharSet = CharSet.Unicode)]
        public static extern int ProcessWait(string szProcess, int nTimeout);

        [DllImport(DllFile, EntryPoint = "AU3_ProcessWaitClose", CharSet = CharSet.Unicode)]
        public static extern int ProcessWaitClose(string szProcess, int nTimeout);

        [DllImport(DllFile, EntryPoint = "AU3_Run", CharSet = CharSet.Unicode,
            CallingConvention = CallingConvention.StdCall)]
        public static extern int Run(string szProgram, string szDir,
            ShowWindowCommands nShowFlag = ShowWindowCommands.SW_NORMAL);

        [DllImport(DllFile, EntryPoint = "AU3_RunWait", CharSet = CharSet.Unicode)]
        public static extern int RunWait(string szProgram, string szDir,
            ShowWindowCommands nShowFlag = ShowWindowCommands.SW_SHOWNORMAL);

        [DllImport(DllFile, EntryPoint = "AU3_RunAs", CharSet = CharSet.Unicode)]
        public static extern int RunAs(string szUser, string szDomain, string szPassword, int nLogonFlag,
            string szProgram, string szDir, ShowWindowCommands nShowFlag = ShowWindowCommands.SW_SHOWNORMAL);

        [DllImport(DllFile, EntryPoint = "AU3_RunAsWait", CharSet = CharSet.Unicode)]
        public static extern int RunAsWait(string szUser, string szDomain, string szPassword, int nLogonFlag,
            string szProgram, string szDir, ShowWindowCommands nShowFlag = ShowWindowCommands.SW_SHOWNORMAL);

        [DllImport(DllFile, EntryPoint = "AU3_Send", CharSet = CharSet.Unicode)]
        public static extern void Send(string szSendText, int nMode = 0);

        [DllImport(DllFile, EntryPoint = "AU3_Shutdown", CharSet = CharSet.Unicode)]
        public static extern int Shutdown(int nFlags);

        [DllImport(DllFile, EntryPoint = "AU3_AutoItSetOption", CharSet = CharSet.Unicode)]
        public static extern void Sleep(int nMilliseconds);

        [DllImport(DllFile, EntryPoint = "AU3_StatusbarGetText", CharSet = CharSet.Unicode)]
        public static extern int StatusbarGetText(string szTitle, string szText, int nPart, string szStatusText,
            int nBufSize);

        [DllImport(DllFile, EntryPoint = "AU3_StatusbarGetTextByHandle", CharSet = CharSet.Unicode)]
        public static extern int
            StatusbarGetTextByHandle(IntPtr hWnd, int nPart, string szStatusText, int nBufSize);

        [DllImport(DllFile, EntryPoint = "AU3_ToolTip", CharSet = CharSet.Unicode)]
        public static extern void ToolTip(string szTip, int nX = DefineConstants.AU3_INTDEFAULT,
            int nY = DefineConstants.AU3_INTDEFAULT);

        [DllImport(DllFile, EntryPoint = "AU3_WinActivate", CharSet = CharSet.Unicode)]
        public static extern int WinActivate(string szTitle, string szText);

        [DllImport(DllFile, EntryPoint = "AU3_WinActivateByHandle", CharSet = CharSet.Unicode)]
        public static extern int WinActivateByHandle(IntPtr hWnd);

        [DllImport(DllFile, EntryPoint = "AU3_WinActive", CharSet = CharSet.Unicode)]
        public static extern int WinActive(string szTitle, string szText);

        [DllImport(DllFile, EntryPoint = "AU3_WinActiveByHandle", CharSet = CharSet.Unicode)]
        public static extern int WinActiveByHandle(IntPtr hWnd);

        [DllImport(DllFile, EntryPoint = "AU3_WinClose", CharSet = CharSet.Unicode)]
        public static extern int WinClose(string szTitle, string szText);

        [DllImport(DllFile, EntryPoint = "AU3_WinCloseByHandle", CharSet = CharSet.Unicode)]
        public static extern int WinCloseByHandle(IntPtr hWnd);

        [DllImport(DllFile, EntryPoint = "AU3_WinExists", CharSet = CharSet.Unicode)]
        public static extern int WinExists(string szTitle, string szText);

        [DllImport(DllFile, EntryPoint = "AU3_WinExistsByHandle", CharSet = CharSet.Unicode)]
        public static extern int WinExistsByHandle(IntPtr hWnd);

        [DllImport(DllFile, EntryPoint = "AU3_WinGetCaretPos", CharSet = CharSet.Unicode)]
        public static extern int WinGetCaretPos(out Point lpPoint);

        [DllImport(DllFile, EntryPoint = "AU3_WinGetClassList", CharSet = CharSet.Unicode)]
        public static extern void WinGetClassList(string szTitle, string szText, string szRetText, int nBufSize);

        [DllImport(DllFile, EntryPoint = "AU3_WinGetClassListByHandle", CharSet = CharSet.Unicode)]
        public static extern void WinGetClassListByHandle(IntPtr hWnd, string szRetText, int nBufSize);

        [DllImport(DllFile, EntryPoint = "AU3_WinGetClientSize", CharSet = CharSet.Unicode)]
        public static extern int WinGetClientSize(string szTitle, string szText, out Rect lpRect);

        [DllImport(DllFile, EntryPoint = "AU3_WinGetClientSizeByHandle", CharSet = CharSet.Unicode)]
        public static extern int WinGetClientSizeByHandle(IntPtr hWnd, out Rect lpRect);

        [DllImport(DllFile, EntryPoint = "AU3_WinGetHandle", CharSet = CharSet.Unicode)]
        public static extern IntPtr WinGetHandle(string szTitle, string szText);

        [DllImport(DllFile, EntryPoint = "AU3_AutoItSetOption", CharSet = CharSet.Unicode)]
        public static extern void WinGetHandleAsText(string szTitle, string szText, string szRetText, int nBufSize);

        [DllImport(DllFile, EntryPoint = "AU3_WinGetPos", CharSet = CharSet.Unicode)]
        public static extern int WinGetPos(string szTitle, string szText, out Rect lpRect);

        [DllImport(DllFile, EntryPoint = "AU3_WinGetPosByHandle", CharSet = CharSet.Unicode)]
        public static extern int WinGetPosByHandle(IntPtr hWnd, out Rect lpRect);

        [DllImport(DllFile, EntryPoint = "AU3_WinGetProcess", CharSet = CharSet.Unicode)]
        public static extern uint WinGetProcess(string szTitle, string szText);

        [DllImport(DllFile, EntryPoint = "AU3_WinGetProcessByHandle", CharSet = CharSet.Unicode)]
        public static extern uint WinGetProcessByHandle(IntPtr hWnd);

        [DllImport(DllFile, EntryPoint = "AU3_WinGetState", CharSet = CharSet.Unicode)]
        public static extern int WinGetState(string szTitle, string szText);

        [DllImport(DllFile, EntryPoint = "AU3_WinGetStateByHandle", CharSet = CharSet.Unicode)]
        public static extern int WinGetStateByHandle(IntPtr hWnd);

        [DllImport(DllFile, EntryPoint = "AU3_WinGetText", CharSet = CharSet.Unicode)]
        public static extern void WinGetText(string szTitle, string szText, string szRetText, int nBufSize);

        [DllImport(DllFile, EntryPoint = "AU3_WinGetTextByHandle", CharSet = CharSet.Unicode)]
        public static extern void WinGetTextByHandle(IntPtr hWnd, string szRetText, int nBufSize);

        [DllImport(DllFile, EntryPoint = "AU3_WinGetTitle", CharSet = CharSet.Unicode)]
        public static extern void WinGetTitle(string szTitle, string szText, string szRetText, int nBufSize);

        [DllImport(DllFile, EntryPoint = "AU3_WinGetTitleByHandle", CharSet = CharSet.Unicode)]
        public static extern void WinGetTitleByHandle(IntPtr hWnd, string szRetText, int nBufSize);

        [DllImport(DllFile, EntryPoint = "AU3_WinKill", CharSet = CharSet.Unicode)]
        public static extern int WinKill(string szTitle, string szText);

        [DllImport(DllFile, EntryPoint = "AU3_WinKillByHandle", CharSet = CharSet.Unicode)]
        public static extern int WinKillByHandle(IntPtr hWnd);

        [DllImport(DllFile, EntryPoint = "AU3_WinMenuSelectItem", CharSet = CharSet.Unicode)]
        public static extern int WinMenuSelectItem(string szTitle, string szText, string szItem1, string szItem2,
            string szItem3, string szItem4, string szItem5, string szItem6, string szItem7, string szItem8);

        [DllImport(DllFile, EntryPoint = "AU3_WinMenuSelectItemByHandle", CharSet = CharSet.Unicode)]
        public static extern int WinMenuSelectItemByHandle(IntPtr hWnd, string szItem1, string szItem2,
            string szItem3, string szItem4, string szItem5, string szItem6, string szItem7, string szItem8);

        [DllImport(DllFile, EntryPoint = "AU3_WinMinimizeAll", CharSet = CharSet.Unicode)]
        public static extern void WinMinimizeAll();

        [DllImport(DllFile, EntryPoint = "AU3_WinMinimizeAllUndo", CharSet = CharSet.Unicode)]
        public static extern void WinMinimizeAllUndo();

        [DllImport(DllFile, EntryPoint = "AU3_WinMove", CharSet = CharSet.Unicode)]
        public static extern int WinMove(string szTitle, string szText, int nX, int nY, int nWidth = -1,
            int nHeight = -1);

        [DllImport(DllFile, EntryPoint = "AU3_WinMoveByHandle", CharSet = CharSet.Unicode)]
        public static extern int WinMoveByHandle(IntPtr hWnd, int nX, int nY, int nWidth = -1, int nHeight = -1);

        [DllImport(DllFile, EntryPoint = "AU3_WinSetOnTop", CharSet = CharSet.Unicode)]
        public static extern int WinSetOnTop(string szTitle, string szText, int nFlag);

        [DllImport(DllFile, EntryPoint = "AU3_WinSetOnTopByHandle", CharSet = CharSet.Unicode)]
        public static extern int WinSetOnTopByHandle(IntPtr hWnd, int nFlag);

        [DllImport(DllFile, EntryPoint = "AU3_WinSetState", CharSet = CharSet.Unicode)]
        public static extern int WinSetState(string szTitle, string szText, int nFlags);

        [DllImport(DllFile, EntryPoint = "AU3_WinSetStateByHandle", CharSet = CharSet.Unicode)]
        public static extern int WinSetStateByHandle(IntPtr hWnd, int nFlags);

        [DllImport(DllFile, EntryPoint = "AU3_WinSetTitle", CharSet = CharSet.Unicode)]
        public static extern int WinSetTitle(string szTitle, string szText, string szNewTitle);

        [DllImport(DllFile, EntryPoint = "AU3_WinSetTitleByHandle", CharSet = CharSet.Unicode)]
        public static extern int WinSetTitleByHandle(IntPtr hWnd, string szNewTitle);

        [DllImport(DllFile, EntryPoint = "AU3_WinSetTrans", CharSet = CharSet.Unicode)]
        public static extern int WinSetTrans(string szTitle, string szText, int nTrans);

        [DllImport(DllFile, EntryPoint = "AU3_WinSetTransByHandle", CharSet = CharSet.Unicode)]
        public static extern int WinSetTransByHandle(IntPtr hWnd, int nTrans);

        [DllImport(DllFile, EntryPoint = "AU3_WinWait", CharSet = CharSet.Unicode)]
        public static extern int WinWait(string szTitle, string szText, int nTimeout = 0);

        [DllImport(DllFile, EntryPoint = "AU3_WinWaitByHandle", CharSet = CharSet.Unicode)]
        public static extern int WinWaitByHandle(IntPtr hWnd, int nTimeout);

        [DllImport(DllFile, EntryPoint = "AU3_WinWaitActive", CharSet = CharSet.Unicode)]
        public static extern int WinWaitActive(string szTitle, string szText, int nTimeout = 0);

        [DllImport(DllFile, EntryPoint = "AU3_WinWaitActiveByHandle", CharSet = CharSet.Unicode)]
        public static extern int WinWaitActiveByHandle(IntPtr hWnd, int nTimeout);

        [DllImport(DllFile, EntryPoint = "AU3_WinWaitClose", CharSet = CharSet.Unicode)]
        public static extern int WinWaitClose(string szTitle, string szText, int nTimeout = 0);

        [DllImport(DllFile, EntryPoint = "AU3_WinWaitCloseByHandle", CharSet = CharSet.Unicode)]
        public static extern int WinWaitCloseByHandle(IntPtr hWnd, int nTimeout);

        [DllImport(DllFile, EntryPoint = "AU3_WinWaitNotActive", CharSet = CharSet.Unicode)]
        public static extern int WinWaitNotActive(string szTitle, string szText, int nTimeout);

        [DllImport(DllFile, EntryPoint = "AU3_WinWaitNotActiveByHandle", CharSet = CharSet.Unicode)]
        public static extern int WinWaitNotActiveByHandle(IntPtr hWnd, int nTimeout = 0);
    }
}