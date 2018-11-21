using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form5 : Form
    {
        //public int fd;
        public Form5()
        {
            InitializeComponent();
        }

        public static int MinimumDistance(int[] distance, bool[] shortestPathTreeSet, int verticesCount)
        {
            int min = int.MaxValue;
            int minIndex = 0;

            for (int v = 0; v < verticesCount; v++)
            {
                if (shortestPathTreeSet[v] == false && distance[v] <= min)
                {
                    min = distance[v];
                    minIndex = v;
                }
            }

            return minIndex;
        }

        

        public static void PrintPath(int[] parent, int j,int source)
        {


           
                

                if (parent[j] == -1)
                {
                    
                    return;
                }
                
                PrintPath(parent, parent[j], source);
            Console.WriteLine("{0}", j);
            

        }
        public static void Printsolution(int[] distance, int verticesCount, int[] parent, int source, int destination)
        {
            Console.WriteLine("Vertex    Distance from source   path");

            Console.WriteLine("{0} -> {1}\t  {2}\t\t  {3} ", source, destination, distance[destination],source);
            PrintPath(parent,destination, source);
        }

        public static void DijkstraAlgo(int[,] graph, int source, int verticesCount, int destination)
        {
            int[] distance = new int[verticesCount];
            bool[] shortestPathTreeSet = new bool[verticesCount];
            int[] parent = new int[verticesCount];

            for (int i = 0; i < verticesCount; i++)
            {
                parent[source] = -1;
                distance[i] = int.MaxValue;
                shortestPathTreeSet[i] = false;
            }

            distance[source] = 0;

            for (int count = 0; count < verticesCount - 1; count++)
            {
                int u = MinimumDistance(distance, shortestPathTreeSet, verticesCount);
                shortestPathTreeSet[u] = true;

                for (int v = 0; v < verticesCount; v++)
                    if (!shortestPathTreeSet[v] && Convert.ToBoolean(graph[u, v]) && distance[u] != int.MaxValue && distance[u] + graph[u, v] < distance[v])
                    {
                        parent[v] = u;
                        distance[v] = distance[u] + graph[u, v];
                    }
            }

            Printsolution(distance, verticesCount, parent, source, destination);
        }
    public void submit_Click(object sender, EventArgs e)
    {
        int[,] graph =  {{0, 4, 0, 0, 0, 0, 0, 8, 0},
                       {4, 0, 8, 0, 0, 0, 0, 11, 0},
                        {0, 8, 0, 7, 0, 4, 0, 0, 2},
                        {0, 0, 7, 0, 9, 14, 0, 0, 0},
                        {0, 0, 0, 9, 0, 10, 0, 0, 0},
                        {0, 0, 4, 0, 10, 0, 2, 0, 0},
                        {0, 0, 0, 14, 0, 2, 0, 1, 6},
                        {8, 11, 0, 0, 0, 0, 1, 0, 7},
                        {0, 0, 2, 0, 0, 0, 6, 7, 0}
                    };



        int source;
        source = int.Parse(sourcebox.Text);

        int destination;
        destination = int.Parse(destinationbox.Text);

        DijkstraAlgo(graph, source, 9, destination);

    

        }
    }
}





