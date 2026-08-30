using System.Text;

namespace TachyonProgram
{

/// <summary>
/// Class <c>Program</c> contains the magical tachyon manifold.
/// </summary>
    public static class Program
    {

        //This is a singleline comment.
        //TODO: Change hardcoded string for the input file to one on your PC.
        public static string FileToRead { get; set; } = "./Example.txt";


        /// <summary>
        /// Starts the tachyon beam by placing a '|' below the start symbol 'S'.
        /// </summary>
        /// <param name="posX">The horizontal position of 'S'.</param>
        /// <param name="posY">The vertical position of 'S'.</param>
        /// <param name="tachyonGrid">The tachyon grid.</param>
        public static void ProcessStart(int posX, int posY, List<string> tachyonGrid)
        {
            string line = tachyonGrid[posY + 1];
            StringBuilder sb = new(line);
            sb[posX] = '|';
            line = sb.ToString();
            tachyonGrid[posY + 1] = line;
        }

        /// <summary>
        /// Creates beams to the left and right when a beam reaches a splitter '^'.
        /// </summary>
        /// <param name="posX">The horizontal position of the splitter.</param>
        /// <param name="posY">The vertical position of the splitter.</param>
        /// <param name="tachyonGrid">The tachyon grid.</param>

        public static void ProcessSplitter(int posX, int posY, List<string> tachyonGrid)
        {
            string line = tachyonGrid[posY];
            StringBuilder sb = new(line);
            if (tachyonGrid[posY - 1][posX] == '|')
            {
                sb[posX - 1] = '|';
                sb[posX + 1] = '|';
                line = sb.ToString();
                tachyonGrid[posY] = line;
            }
        }

        /// <summary>
        /// Continues a beam downward through an empty space.
        /// </summary>
        /// <param name="posX">The horizontal position being checked.</param>
        /// <param name="posY">The vertical position being checked.</param>
        /// <param name="tachyonGrid">The tachyon grid.</param>
        public static void ProcessEmpty(int posX, int posY, List<string> tachyonGrid)
        {
            string line = tachyonGrid[posY];
            StringBuilder sb = new(line);
            if (tachyonGrid[posY - 1][posX] == '|')
            {
                sb[posX] = '|';
                line = sb.ToString();
                tachyonGrid[posY] = line;
            }
        }

        public static void Main(string[] args)
        {
        
            var sr = new StreamReader(FileToRead);
            string srText = sr.ReadToEnd();
            int totalCount = 0;

            List<string> symbols = [.. srText.Split("\n")];
            List<string> tachyonGrid = symbols[..^1];

            Console.WriteLine("Begin Tachyon Manifold start state");
            foreach (var item in tachyonGrid)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("End Tachyon Manifold start state");

            for (int posY = 0; posY < tachyonGrid.Count; posY++)
            {
                var item = tachyonGrid[posY];
                foreach (var (posX, character) in item.Index())
                {
                    if (character == 'S')
                    {
                        ProcessStart(posX, posY, tachyonGrid);
                    }
                    else if (character == '^')
                    {
                        ProcessSplitter(posX, posY, tachyonGrid);
                    }
                    else if (posY != 0)
                    {
                        ProcessEmpty(posX, posY, tachyonGrid);
                    }
                }
            }
            Console.WriteLine($"Begin Taychon Manifold end state");

            foreach (var item in tachyonGrid)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"End Taychon Manifold end state");
            Console.WriteLine($"Total Tachyon Manifold splits were: {totalCount}");
            Console.WriteLine($"If using Example.txt, your total should be 21");
            Console.WriteLine($"If using Example.txt, your total is {(totalCount == 21 ? "RIGHT": "WRONG")}");
        }
    }
}
