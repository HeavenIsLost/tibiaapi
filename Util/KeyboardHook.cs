﻿using System;
using System.Runtime.InteropServices;

namespace Tibia
{
    public class KeyboardHook
    {
        public Objects.Client client;

        public KeyboardHook(Objects.Client c)
        {
            client = c;
        }

        public delegate int HookProc(int nCode, IntPtr wParam, IntPtr lParam);

        //The handle to the hook (used for installing/uninstalling it).
        public static int hHook = 0;

        //This is the Import for the SetWindowsHookEx function.
        //Use this function to install a thread-specific hook.
        [DllImport("user32.dll", CharSet = CharSet.Auto,
         CallingConvention = CallingConvention.StdCall)]
        public static extern int SetWindowsHookEx(int idHook, HookProc lpfn,
        IntPtr hInstance, int threadId);

        //This is the Import for the UnhookWindowsHookEx function.
        //Call this function to uninstall the hook.
        [DllImport("user32.dll", CharSet = CharSet.Auto,
         CallingConvention = CallingConvention.StdCall)]
        public static extern bool UnhookWindowsHookEx(int idHook);

        //This is the Import for the CallNextHookEx function.
        //Use this function to pass the hook information to the next hook procedure in chain.
        [DllImport("user32.dll", CharSet = CharSet.Auto,
         CallingConvention = CallingConvention.StdCall)]
        public static extern int CallNextHookEx(int idHook, int nCode,
        IntPtr wParam, IntPtr lParam);

        public void InstallHook(int HookType, HookProc TheProc)
        {
            hHook = SetWindowsHookEx(HookType, TheProc, (IntPtr)0, AppDomain.GetCurrentThreadId());
        }

        public void UninstallHook()
        {
            UnhookWindowsHookEx(hHook);
        }

        public enum HookTypes : int
        {
            
            WH_KEYBOARD = 2,
            WH_GETMESSAGE = 3,
            WH_CALLWNDPROC = 4,
            WH_CBT = 5,
            WH_SYSMSGFILTER = 6,
            WH_MOUSE = 7,
            WH_HARDWARE = 8,
            WH_DEBUG = 9,
            WH_SHELL = 10,
            WH_FOREGROUNDIDLE = 11,
            WH_CALLWNDPROCRET = 12,
            WH_KEYBOARD_LL = 13,
            WH_MOUSE_LL = 14
        }


    }
}
