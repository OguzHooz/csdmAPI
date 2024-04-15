﻿using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text.Json;
using csdm.Models;
<<<<<<< HEAD
using csdm.Data;
=======
>>>>>>> 67c149afad9ee6d6098bf3aa8807f134344ac229

namespace csdm.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [RequestSizeLimit(300000000)]
    public class CSDemoController : ControllerBase
    {
<<<<<<< HEAD
        private readonly csdmContext _context;

        public CSDemoController(csdmContext context)
        {
            _context = context;
        }


=======
>>>>>>> 67c149afad9ee6d6098bf3aa8807f134344ac229
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
                    Arguments = $"/C csdm json {path} --output-folder data",
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

            byte[] headerBytes = new byte[4];
            using (var stream = new MemoryStream())
            {
                file.CopyTo(stream);
                stream.Position = 2;
                stream.Read(headerBytes, 0, 4);

                if (headerBytes[0] != 0x44 && headerBytes[1] != 0x45 && headerBytes[2] != 0x4D | 
                    headerBytes[1] != 0x44 && headerBytes[2] != 0x45 && headerBytes[3] != 0x4D)
                {
                    return BadRequest("Invalid file format. The uploaded file is not a valid .dem file.");
                }
            }

            Directory.CreateDirectory("data");

            string fileName = Path.GetFileNameWithoutExtension(file.FileName);
            string filePath = $"data/{fileName}.dem";
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }


            await RunCommands($"data/{fileName}.dem");

            string jsonFile = $"data/{fileName}.json";

            var jsonRead = await System.IO.File.ReadAllTextAsync(jsonFile);

            var jsonResult = JsonSerializer.Deserialize<Root>(jsonRead);

<<<<<<< HEAD
            if (_context.Root.Any(e => e.checksum == jsonResult.checksum))
            {
                return Ok($"Data is already in database with ID: {jsonResult.checksum}");
            }

            _context.Root.Add(jsonResult);
            await _context.SaveChangesAsync();

=======
>>>>>>> 67c149afad9ee6d6098bf3aa8807f134344ac229
            return Ok(jsonResult);
        }
    }
}
