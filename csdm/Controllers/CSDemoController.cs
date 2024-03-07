using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text.Json;
using csdm.Models;

namespace csdm.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [RequestSizeLimit(200000000)]
    public class CSDemoController : ControllerBase
    {
        private async Task RunCommands(string path)
        {
            var analyzeProcess = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = $"/C csdm analyze {path}",
                    UseShellExecute = false,
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true,
                }
            };
            analyzeProcess.Start();
            await analyzeProcess.WaitForExitAsync();

            var jsonProcess = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = $"/C csdm json {path} --output-folder data --force-analyze",
                    UseShellExecute = false,
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true,
                }
            };
            jsonProcess.Start();
            await jsonProcess.WaitForExitAsync();
        }

        [HttpPost]
        [Route("upload")]
        public async Task<IActionResult> UploadDemo(IFormFile file)
        {
            if (file == null)
            {
                return BadRequest("No file uploaded");
            }

            Guid guid = Guid.NewGuid();
            string filePath = $"data/{guid}.dem";
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }


            await RunCommands($"data/{guid}.dem");

            string jsonFile = $"data/{guid}.json";

            var jsonRead = await System.IO.File.ReadAllTextAsync(jsonFile);

            var jsonResult = JsonSerializer.Deserialize<Root>(jsonRead);

            return Ok(jsonResult);
        }
    }
}
