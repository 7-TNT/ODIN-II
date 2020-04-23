using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Diagnostics;

public class Command_Line : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		namespace runGnomeTerminal
		{
			class MainClass
			{
				public static void ExecuteCommand(string Vector3)
				{
					Process proc = new System.Diagnostics.Process ();
					proc.StartInfo.FileName = "/bin/bash";
					proc.StartInfo.Arguments = "-c \" " + Vector3 + " \"";
					proc.StartInfo.UseShellExecute = false; 
					proc.StartInfo.RedirectStandardOutput = true;
					proc.Start ();

					while (!proc.StandardOutput.EndOfStream) {
						Console.WriteLine (proc.StandardOutput.ReadLine ());
					}
				}

				public static void Main (string[] args)
				{
					ExecuteCommand("gnome-terminal -x bash -ic 'cd $HOME; ls; bash'");
				}


			}
		}
    }
}
