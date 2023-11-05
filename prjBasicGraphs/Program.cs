using System.Diagnostics.Metrics;
using System.Security.Cryptography.X509Certificates;

namespace prjBasicGraphs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CGraph pleasework = new CGraph();

            pleasework.addNode(1, "Nicole");
            pleasework.addNode(2, "Luke");
            pleasework.addNode(3, "Stefan");

            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader("graph.txt"))
                {
                    string line;
                    // Read and display lines from the file until the end of
                    // the file is reached.
                    while ((line = sr.ReadLine()) != null)
                    {
                        //gets 2nd number
                        string stringAfterChar1 = line.Substring(0, line.IndexOf(' '));
                        string stringAfterChar2 = line.Substring(line.IndexOf(' ') +1);
                        int firstNumber = Convert.ToInt32(stringAfterChar1);
                        int secondNumber = Convert.ToInt32(stringAfterChar2);
                        pleasework.addEdges(firstNumber, secondNumber);

                        bool BFSYes = pleasework.hasPathBFS(firstNumber, secondNumber);


                        if (BFSYes)
                        {
                            Console.WriteLine("Enter the source vertex: ");
                            Console.ReadLine();
                            Console.WriteLine("Enter the destination vertex: ");
                            Console.ReadLine();
                            Console.WriteLine("Shortest path from 0 to 3: ");
                            Console.WriteLine("Length of the path: ");
                        }
                        else
                        {
                            
                        }
                    }
                }
            }
            catch (Exception e)
            {
                
            }

           







            //pleasework.addEdges(1, 3);

            //bool yes = pleasework.hasPathDFS(1, 3);
            //if (yes)
            //{
            //    Console.WriteLine("Nicole is related to Stefan. They can be cousins");
            //}
            //else
            //{
            //    Console.WriteLine("NOOOOOOOOOOOOOOO :)");
            //}


        }

        
    }
}