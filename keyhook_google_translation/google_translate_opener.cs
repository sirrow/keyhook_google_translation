﻿using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace keyhook_google_translation
{
	public partial class google_translation_opener : Form
	{

		private const int WH_KEYBOARD_LL = 13;
		private const int WM_KEYDOWN = 0x0100;
		private const int WM_KEYUP = 0x0101;
		private static IntPtr _hookID = IntPtr.Zero;

		private const int VKCODE_CTRL = 162;
		private const int VKCODE_C = 67;

		private bool ctrl;
		private int cc_count;

		public google_translation_opener()
		{
			InitializeComponent();
            _hookID = SetHook(HookCallback);
            cc_count = 0;
        }

		private static IntPtr SetHook(LowLevelKeyboardProc proc)
		{
			using (Process curProcess = Process.GetCurrentProcess())
			using (ProcessModule curModule = curProcess.MainModule)
			{
				return SetWindowsHookEx(WH_KEYBOARD_LL, proc,
					GetModuleHandle(curModule.ModuleName), 0);
			}
		}

		private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

		private IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
		{
		
			int vkCode = Marshal.ReadInt32(lParam);
			
			if (vkCode == VKCODE_CTRL)
			{
				if (wParam == (IntPtr)WM_KEYDOWN)
				{
					ctrl = true;
				}
				else
				{
					ctrl = false;
					cc_count = 0;
				}
			}

			if (vkCode == VKCODE_C && wParam == (IntPtr)WM_KEYDOWN && ctrl == true)
			{
				cc_count++;
				Console.WriteLine(cc_count);
				if (cc_count == 2)
				{
					
					IDataObject dataobject = Clipboard.GetDataObject();
					if (dataobject.GetDataPresent(DataFormats.Text))
					{
						Console.WriteLine(dataobject.GetData(DataFormats.Text));
                        String encodedStr = System.Web.HttpUtility.UrlEncode((String)dataobject.GetData(DataFormats.Text));
                        System.Diagnostics.Process.Start("https://translate.google.co.jp/#en/ja/" + encodedStr);
					}
				}
			}
			
			return CallNextHookEx(_hookID, nCode, wParam, lParam);
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool UnhookWindowsHookEx(IntPtr hhk);

		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

		[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern IntPtr GetModuleHandle(string lpModuleName);

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }
    }
}