using System;
using System.Diagnostics;

public class GitHelper
{
    private void ExecuteGitPull(string executablePath)
    {
        try
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo
            {
                FileName = "git",
                Arguments = "pull",
                WorkingDirectory = executablePath,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (Process process = new Process())
            {
                process.StartInfo = processStartInfo;

                process.OutputDataReceived += (sender, e) =>
                {
                    if (!string.IsNullOrEmpty(e.Data))
                    {
                        Console.WriteLine(e.Data);
                    }
                };

                process.ErrorDataReceived += (sender, e) =>
                {
                    if (!string.IsNullOrEmpty(e.Data))
                    {
                        Console.WriteLine("ERROR: " + e.Data);
                    }
                };

                process.Start();

                process.BeginOutputReadLine();
                process.BeginErrorReadLine();

                process.WaitForExit();

                if (process.ExitCode != 0)
                {
                    throw new Exception("O comando git pull falhou com o código de saída: " + process.ExitCode);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro ao executar git pull: " + ex.Message);
        }
    }

    public void GitPull(string executablePath)
    {
        ExecuteGitPull(executablePath);
    }
}
