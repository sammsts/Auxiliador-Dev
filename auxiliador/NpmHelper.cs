using System;
using System.Diagnostics;

public class NpmHelper
{
    private void ExecuteNpmBuild(string executablePath)
    {
        try
        {
            string npmPath = @"C:\Program Files\nodejs\npm.cmd";

            ProcessStartInfo processStartInfo = new ProcessStartInfo
            {
                FileName = npmPath,
                Arguments = "run build",
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
                    throw new Exception("O comando npm run build falhou com o código de saída: " + process.ExitCode);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro ao executar npm run build: " + ex.Message);
        }
    }

    public void NpmBuild(string executablePath)
    {
        ExecuteNpmBuild(executablePath);
    }
}
