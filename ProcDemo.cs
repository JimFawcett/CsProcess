/////////////////////////////////////////////////////////////////////
// ProcDemo.cs  -  Demonstrates creation of child process          //
//                                                                 //
// Language:    C#, version 1.0                                    //
// Platform:    Dell Inspiron 8100, Win2000, SP2                   //
// Application: CSE681 - SW Modeling & Analysis, Fall 2002         //
// Author:      Jim Fawcett, CST 2-187, Syracuse University        //
//              (315) 443-3948, jfawcett@twcny.rr.com              //
/////////////////////////////////////////////////////////////////////
///
using System;
using System.Diagnostics;

namespace ProcessDemo
{
  class ProcDemo
  {
    [STAThread]
    static void Main(string[] args)
    {
      Console.Write("\n  Parent Process ");
      Console.Write("\n ================\n");

      // get information about this process
      
      Process myProc = Process.GetCurrentProcess();
      Console.Write("\n  Process Name = {0}",myProc.ProcessName);
      Console.Write("\n  Main Module  = {0}",myProc.MainModule);
      Console.Write("\n  File Name    = {0}",myProc.MainModule.FileName);

      // start a child process

      string fileToStart = "..\\..\\simpleConsoleApp\\bin\\debug\\simpleConsoleApp.exe";
      string arguments = "FirstArg SecondArg";
      Console.Write("\n\n  Setting Arguments for child process: {0}",arguments);
      ProcessStartInfo startInfo = new ProcessStartInfo(fileToStart,arguments);
      Process child = Process.Start(startInfo);

      Console.Write("\n\n");
    }
  }
}
