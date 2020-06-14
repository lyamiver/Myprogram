using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание8
{
    class Graph
    {
        public static int V;   // Количество вершин

        public LinkedList<int> adj; // Список смежности

        public bool isCyclicUtil(int v, bool visited[], int parent);
        public partial Grah(int V);


    }



    public class partial Grah : Graph
     Graph
    {
        }
    {

        V = v;

        adj = new LinkedList[v];

        for (int i = 0; i < v; ++i)

            adj[i] = new LinkedList();

    }
    // Функция для добавления ребра в график

    void addEdge(int v, int w)

    {

        adj[v].add(w);

        adj[w].add(v);

    }

    // Рекурсивная функция, которая использует visit [] и parent

    // обнаружение цикла в подграфе, достижимом из вершины v.

    Boolean isCyclicUtil(int v, Boolean visited[], int parent)

    {

        // Пометить текущий узел как посещенный

        visited[v] = true;

        Integer i;



        // Повторение для всех вершин, смежных с этой вершиной

        Iterator<Integer> it = adj[v].iterator();

        while (it.hasNext())

        {

            i = it.next();



            // Если соседний не посещен, то повторять

            // это смежно

            if (!visited[i])

            {

                if (isCyclicUtil(i, visited, v))

                    return true;

            }
            // Если соседний посещен и не является родителем

            // текущая вершина, то есть цикл.

            else if (i != parent)

                return true;

        }

        return false;

    }

    // Возвращает true, если граф является деревом, иначе false.

    Boolean isTree()
    {
        // Пометить все вершины как не посещенные и не как части

        // рекурсивного стека

        Boolean visited[] = new Boolean[V];

        for (int i = 0; i < V; i++)

            visited[i] = false;
        // Вызов isCyclicUtil служит нескольким целям

        // Возвращает true, если граф достижим из вершины 0

        // цикличен Он также отмечает все доступные вершины

        // с 0.

        if (isCyclicUtil(0, visited, -1))

            return false;
        // Если мы найдем вершину, которая недостижима от 0

        // (не помечено isCyclicUtil (), тогда мы возвращаем false

        for (int u = 0; u < V; u++)

            if (!visited[u])

                return false;
        return true;

    }
    // Метод драйвера

    public static void main(String args[])

    {
        // Создать график, приведенный на диаграмме выше

        Graph g1 = new Graph(5);

        g1.addEdge(1, 0);

        g1.addEdge(0, 2);

        g1.addEdge(0, 3);

        g1.addEdge(3, 4);

        if (g1.isTree())

            Console.WriteLine("Graph is Tree");

        else

            Console.WriteLine("Graph is not Tree");



        Graph g2 = new Graph(5);

        g2.addEdge(1, 0);

        g2.addEdge(0, 2);

        g2.addEdge(2, 1);

        g2.addEdge(0, 3);

        g2.addEdge(3, 4);



        if (g2.isTree())

            Console.WriteLine("Graph is Tree");

        else

            Console.WriteLine("Graph is not Tree");



    }

}
