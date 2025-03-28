namespace sample1;

using Newtonsoft.Json;
using static ImageProcessor;
using System.Diagnostics;
using System.IO;
using System;

class Program
{
    
    static void Main(string[] args)
    {   
        Personne personne = new Personne("John", 30);
        Console.WriteLine(JsonConvert.SerializeObject(personne, Formatting.Indented));


        string directory = "./assets/images";
        string saveDirectory = "./assets/resized";
        string[] imagePaths = Directory.GetFiles(directory);
        string[] imageSavePaths = new string[imagePaths.Length];
        for (int index = 0; index < imagePaths.Length; index++)
        {
            string fileName = Path.GetFileName(imagePaths[index]);
            imageSavePaths[index] = Path.Combine(saveDirectory, fileName);
        }

        Stopwatch sw = new Stopwatch();
        sw.Start();
        for(int index = 0; index < imagePaths.Length; index++) {
            ImageProcessor.resize(imagePaths[index], imageSavePaths[index], 200, 200);
        }
        sw.Stop();
        Console.WriteLine($"Time taken for sequential execution: {sw.ElapsedMilliseconds} ms");
        
        // Parallel exec
        // string[] imageSavePaths = ["./assets/cs_resized.jpg", "./assets/cs2_resized.jpg", "./assets/cs3_resized.jpg"];
        
        sw.Start();
        ImageProcessor.resizeAll(
            imagePaths,
            imageSavePaths,
            200, 200);
        sw.Stop();
        Console.WriteLine($"Time taken for parallel execution: {sw.ElapsedMilliseconds} ms");
    }
}
