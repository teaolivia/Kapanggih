// BFS dalam C#

using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

namespace CollectionsApplication
{
	class BreadthFirst
  {
	
/*		  Queue q = new Queue();
		  
		  q. Enqueue(' ');
		  
		  Console.WriteLine();
		  foreach (string c in q)
			Console.Write(c + " ");
			Console.WriteLine();
			q.Enqueue(' ');
			q.Enqueue(' ');
			Console.WriteLine(" ");
			foreach (string c in q)
				Console.Write(c + " ");
				Console.WriteLine();
			foreach (string c in q)
				Console.Write(c + " ");
				Console.WriteLine();
	*/		
		void MakeQueue(Queue q) // membuat Queue kosong, head(q) diisi 0
		{ 
			Queue q = new Queue[];
		}
		
		void AddQueue(Queue q, int v) // memasukkan v ke dalam antrian q pada posisi belakang
		{ 
			int temp; // temporary untuk prosedur add
			foreach (int v in q)
			q.Enqueue()
		}
		
		void DeleteQueue(Queue q, int v) // menghapus v dari head(q)
		{ 
			int temp; // temporary untuk prosedur delete
			foreach (int v in q)
				Console.WriteLine(c + " ");				
		}
		
		bool IsEmpty(Queue q) // TRUE jika kosong dan FALSE jika sebaliknya
		{ 
			if Queue[size] == 0
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
			int head;
			int tail;
			int size;
		} Queue; // tipe bentukan queue
		private Queue q; // queue
		private bool[] dikunjungi = new bool[q.size]; 
  }
  
  class BreadthFirstSearch // implementasi method
  {
	    static void Main(string[] args)
		{
			MakeQueue(q);
			Console.WriteLine(' ', v);
			dikunjungi[v] = true;
			AddQueue(q,v);
			while (!=IsEmpty(q)) 
			{
				DeleteQueue(q,v);
				for(v>0, v<w, v++)
				{
					if (!=dikunjungi[w])
					{
						Console.WriteLine(' ', w);
						AddQueue(q, w);
						dikunjungi[w] = true;
					}
				}
			}
		}
  }
}