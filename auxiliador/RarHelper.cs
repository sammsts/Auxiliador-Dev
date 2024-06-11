using System.Diagnostics;

public class RarHelper
{
    public void CreateRarArchive(string directoryPath, string outputRarPath)
    {
        try
        {
            if (Directory.Exists(directoryPath))
            {
                string rarExePath = @"C:\Program Files\WinRAR\Rar.exe";

                ProcessStartInfo processStartInfo = new ProcessStartInfo
                {
                    FileName = rarExePath,
                    Arguments = $"a -r \"{outputRarPath}\" \"{directoryPath}\\*\"",
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
                        throw new Exception("O comando WinRAR falhou com o código de saída: " + process.ExitCode);
                    }
                }
            }
            else
            {
                throw new DirectoryNotFoundException($"O diretório especificado não existe: {directoryPath}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro ao criar o arquivo RAR: " + ex.Message);
        }
    }
}
