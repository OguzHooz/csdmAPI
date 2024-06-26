﻿using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text.Json;
using csdm.Models;
using csdm.Data;

namespace csdm.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [RequestSizeLimit(300000000)]
    public class CSDemoController : ControllerBase
    {
        private readonly csdmContext _context;

        public CSDemoController(csdmContext context)
        {
            _context = context;
        }


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
                    Arguments = $"/C csdm json {path} --output-folder csData",
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

            Directory.CreateDirectory("csData");

            string fileName = Path.GetFileNameWithoutExtension(file.FileName);
            string filePath = $"csData/{fileName}.dem";
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }


            await RunCommands($"csData/{fileName}.dem");

            string jsonFile = $"csData/{fileName}.json";

            var jsonRead = await System.IO.File.ReadAllTextAsync(jsonFile);

            var jsonResult = JsonSerializer.Deserialize<Root>(jsonRead);

            var existingPlayerIds = _context.Player.Select(p => p.id).ToList();
            var missingPlayers = jsonResult.players.Where(p => !existingPlayerIds.Contains(p.id)).ToList();

            if (_context.Root.Any(e => e.checksum == jsonResult.checksum) && missingPlayers.Any())
            {
                _context.Player.AddRange(missingPlayers);
                _context.SaveChanges();
                return Ok($"Added {missingPlayers.Count} new player(s) to the database for the existing match with checksum: {jsonResult.checksum}");
            }
            else if (!_context.Root.Any(e => e.checksum == jsonResult.checksum))
            {
                _context.Root.AddRange(jsonResult);
                _context.SaveChanges();
                return Ok($"Added new match and all players to the database with checksum: {jsonResult.checksum}");
            }
            else
            {
                return Ok($"Data is already in the database with checksum: {jsonResult.checksum}, and no new players found.");
            }
        }
    }
}
