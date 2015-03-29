using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace DepthFirst // karena gw gabisa ngecek langsung cara kerjanya dengan compile dan run
//gw tulis pake komen yang mungkin pas.
//nama List<File> sama obyek yang diciptain dari situ masih gw isi ???
{
    class Program
    {
        public class File //File
        {
            public File(string name) //File (string name, string type?)
            {
                this.name = name; //this.name = name; this.type = type
            }
 
            public string name { get; set; } //name, type?
            public List<File> files //List<File> ???
            {
                get
                {
                    return FileList; //FileList?
                }
            }
             
            public void isUnder(File f) //isUnder(File f)?
            {
                FileList.Add(f); //FileList.Add(f)
            }
 
            List<File> FileList = new List<File>(); //List<File> FileList = new List<File>();
 
            public override string ToString()
            {
                return name;
            }
        }
 
        public class DepthFirstAlgorithm
        {
          /*  public File BuildFileGraph() //File BuildFileGraph? ini kayaknya test dummy. Mungkin harus bikin yang search ke directory.
            {
                File Aaron = new File("Aaron");
                File Betty = new File("Betty");
                File Brian = new File("Brian");
                Aaron.isUnder(Betty);
                Aaron.isUnder(Brian);
 
                File Catherine = new File("Catherine");
                File Carson = new File("Carson");
                File Darian = new File("Darian");
                File Derek = new File("Derek");
                Betty.isUnder(Catherine);
                Betty.isUnder(Darian);
                Brian.isUnder(Carson);
                Brian.isUnder(Derek);
 
                return Aaron;
            } */
 
            //http://en.wikipedia.org/wiki/Breadth-first_search#Pseudocode
            public File Search(File root, string nameToSearchFor) //File root, string nameToSearchFor
            {
                Stack<File> S = new Stack<File>(); //Kita pakai queue atau stack? disini Queue... anyway, Queue<File>
                HashSet<File> H = new HashSet<File>(); //HashSet gw belum gitu ngerti. Bikin HashSet<File> berarti kan.
                S.Push(root); //tetep
                H.Add(root);	//tetep
 
                while (S.Count > 0)
                {
                    File f = S.Pop(); //File f = Q.Dequeue();
                    if (f.name == nameToSearchFor) //f.name == nameToSearchFor
                        return f;
                    foreach (File files in f.FileList) //File ?? in f.???
                    {
                        if (!S.Contains(files)) // !S.Contains(??), ini maksud Containsnya contains salah satu relasi file mungkin?
                        {
                            S.Pop(files); // Q.Enqueue(??)
                            H.Add(files); //S.Add(??)
                        }
                    }
                }
                return null;
            }
 
            public void Traverse(File root) //File root
            {
                Stack<File> traverseOrder = new Stack<File>(); //Queue<File> traverseOrder = new Queue<File>();
 
                Stack<File> S = new Stack<File>(); // Queue<File>
                HashSet<File> H = new HashSet<File>(); //HashSet<File>
                S.push(root);
                H.Add(root);
 
                while (S.Count > 0)
                {
                    File f = S.Pop(); // File f;
                    traverseOrder.Push(f); //Enqueue(f)
 
                    foreach (File files in f.FileList) //File ?? in p.???
                    {
                        if (!S.Contains(files)) // !S.Contains(??)
                        {
                            S.Push(files); // Q.Enqueue(??)
                            H.Add(files); //S.Add(??);
                        }
                    }
                }
 
                while (traverseOrder.Count > 0)
                {
                    Files f = traverseOrder.Pop(); //File f;
                    Console.WriteLine(f); //(f)
                }
            }
        }
		
		void MakeStack(Stack s) // membuat Stack kosong, top(s) diisi 0
		{
			Stack s = new Stack[];
		}
		
		void AddStack(Stack s, int v) // memasukkan v ke dalam stack S pada posisi belakang
		{ 
			int temp; // temporary untuk prosedur add
			foreach (int v in s)
			s.Push()
		}
		
		void DeleteStack(Stack s, int v) // menghapus v dari top(s)
		{ 
			int temp; // temporary untuk prosedur delete
			foreach (int v in s)
				Console.WriteLine(c + " ");				
		}
		
		bool IsEmpty(Stack s) // TRUE jika kosong dan FALSE jika sebaliknya
		{ 
			if Stack[size] == 0
			{
				return true;
			} 
			else 
				{
					return false;
				}
		}
		
		
		private int w; // simpul yang dikunjungi
		private int v; // simpul awal kunjungan
		private struct int 
		{
			int top;
			int size;
		} Stack; // tipe bentukan Stack
		private Stack s; // Stack
		private bool[] dikunjungi = new bool[s.size]; 
  }
 
        /*static void Main(string[] args)
        {
            DepthFirst d = new DepthFirst();
            File root = d.BuildFileGraph();
            Console.WriteLine("Traverse\n------");
            d.Traverse(root);
 
            Console.WriteLine("\nSearch\n------");
            File f = d.Search(root, "Catherine");
            Console.WriteLine(f == null ? "Person not found" : f.name);
            f = d.Search(root, "Alex");
            Console.WriteLine(f == null ? "Person not found" : f.name);
        } */
    }
}