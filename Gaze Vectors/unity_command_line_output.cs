private string ExecuteProcessTerminal(float x, float y, float z)
    {
        try
        {
            UnityEngine.Debug.Log("============== X-axis Vector =" + x + " ===============");
			UnityEngine.Debug.Log("============== Y-axis Vector =" + y + " ===============");
			UnityEngine.Debug.Log("============== Z-axis Vector =" + z + " ===============");
            ProcessStartInfo startInfo = new ProcessStartInfo()
            {
                FileName = "/bin/bash",
                UseShellExecute = false,
                RedirectStandardError = true,
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                CreateNoWindow = true,
                Argument_1 = " -c \"" + x + " \""
				Argument_2 = " -c \"" + y + " \""
				Argument_3 = " -c \"" + z + " \""
            };
            Process myProcess = new Process
            {
                StartInfo = startInfo
            };
            myProcess.Start();
            string output = myProcess.StandardOutput.ReadToEnd();
            UnityEngine.Debug.Log(GetStringResult(output));
            myProcess.WaitForExit();
            UnityEngine.Debug.Log("============== End ===============");
 
            return output;
        }
        catch (Exception e)
        {
            print(e);
            return null;
        }
    }