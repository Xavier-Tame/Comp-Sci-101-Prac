namespace Undirected_Graph
{
    class Program
    {
        public static void Main(string[] args)
        {
            UndirectedGraph<string> graph = new UndirectedGraph<string>();

            graph.AddNew("Michael");
            graph.AddNew("Charles");
            graph.AddNew("Peter");
            graph.AddNew("Mushroom");
            graph.AddNew("Potato");
            graph.AddNew("Candice");
            graph.AddNew("Dylan");
            graph.AddNew("Raphael");
            graph.AddNew("Sean");
            graph.AddNew("Louis");
            graph.AddNew("Mieka");
            graph.AddNew("Georgia");


            graph.AddExistRelationship("Charles", "Michael");

            graph.AddExistRelationship("Peter", "Potato");

            graph.AddExistRelationship("Mushroom", "Candice");

            graph.AddExistRelationship("Mieka", "Sean");

            graph.AddExistRelationship("Georgia", "Raphael");

            graph.AddExistRelationship("Louis", "Dylan");

            graph.PrintNodeValues();
        }
    }
}
