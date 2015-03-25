using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace BreadthFirst // karena gw gabisa ngecek langsung cara kerjanya dengan compile dan run
//gw tulis pake komen yang mungkin pas.
//nama List<File> sama obyek yang diciptain dari situ masih gw isi ???
{
    class Program
    {
        public class Person //File
        {
            public Person(string name) //File (string name, string type?)
            {
                this.name = name; //this.name = name; this.type = type
            }
 
            public string name { get; set; } //name, type?
            public List<Person> Friends //List<File> ???
            {
                get
                {
                    return FriendsList; //FileList?
                }
            }
             
            public void isFriendOf(Person p) //isUnder(File f)?
            {
                FriendsList.Add(p); //FileList.Add(f)
            }
 
            List<Person> FriendsList = new List<Person>(); //List<File> FileList = new List<File>();
 
            public override string ToString()
            {
                return name;
            }
        }
 
        public class BreadthFirstAlgorithm
        {
            public Person BuildFriendGraph() //File BuildFileGraph? ini kayaknya test dummy. Mungkin harus bikin yang search ke directory.
            {
                Person Aaron = new Person("Aaron");
                Person Betty = new Person("Betty");
                Person Brian = new Person("Brian");
                Aaron.isFriendOf(Betty);
                Aaron.isFriendOf(Brian);
 
                Person Catherine = new Person("Catherine");
                Person Carson = new Person("Carson");
                Person Darian = new Person("Darian");
                Person Derek = new Person("Derek");
                Betty.isFriendOf(Catherine);
                Betty.isFriendOf(Darian);
                Brian.isFriendOf(Carson);
                Brian.isFriendOf(Derek);
 
                return Aaron;
            }
 
            //http://en.wikipedia.org/wiki/Breadth-first_search#Pseudocode
            public Person Search(Person root, string nameToSearchFor) //File root, string nameToSearchFor
            {
                Queue<Person> Q = new Queue<Person>(); //Kita pakai queue atau stack? disini Queue... anyway, Queue<File>
                HashSet<Person> S = new HashSet<Person>(); //HashSet gw belum gitu ngerti. Bikin HashSet<File> berarti kan.
                Q.Enqueue(root); //tetep
                S.Add(root);	//tetep
 
                while (Q.Count > 0)
                {
                    Person p = Q.Dequeue(); //File f = Q.Dequeue();
                    if (p.name == nameToSearchFor) //f.name == nameToSearchFor
                        return p;
                    foreach (Person friend in p.Friends) //File ?? in f.???
                    {
                        if (!S.Contains(friend)) // !S.Contains(??), ini maksud Containsnya contains salah satu relasi file mungkin?
                        {
                            Q.Enqueue(friend); // Q.Enqueue(??)
                            S.Add(friend); //S.Add(??)
                        }
                    }
                }
                return null;
            }
 
            public void Traverse(Person root) //File root
            {
                Queue<Person> traverseOrder = new Queue<Person>(); //Queue<File> traverseOrder = new Queue<File>();
 
                Queue<Person> Q = new Queue<Person>(); // Queue<File>
                HashSet<Person> S = new HashSet<Person>(); //HashSet<File>
                Q.Enqueue(root);
                S.Add(root);
 
                while (Q.Count > 0)
                {
                    Person p = Q.Dequeue(); // File f;
                    traverseOrder.Enqueue(p); //Enqueue(f)
 
                    foreach (Person friend in p.Friends) //File ?? in p.???
                    {
                        if (!S.Contains(friend)) // !S.Contains(??)
                        {
                            Q.Enqueue(friend); // Q.Enqueue(??)
                            S.Add(friend); //S.Add(??);
                        }
                    }
                }
 
                while (traverseOrder.Count > 0)
                {
                    Person p = traverseOrder.Dequeue(); //File f;
                    Console.WriteLine(p); //(f)
                }
            }
        }
 
        static void Main(string[] args)
        {
            BreadthFirstAlgorithm b = new BreadthFirstAlgorithm();
            Person root = b.BuildFriendGraph();
            Console.WriteLine("Traverse\n------");
            b.Traverse(root);
 
            Console.WriteLine("\nSearch\n------");
            Person p = b.Search(root, "Catherine");
            Console.WriteLine(p == null ? "Person not found" : p.name);
            p = b.Search(root, "Alex");
            Console.WriteLine(p == null ? "Person not found" : p.name);
        }
    }
}