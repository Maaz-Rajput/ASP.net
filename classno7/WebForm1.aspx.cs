using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

namespace classno7
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            //NON-GENERIC TYPES 

            /*
            ArrayList al = new ArrayList();
            al.Add(10);
            al.Add("ABC");
            al.Add(true);
            al.Add(12.43);


            for (int i =0; i< al.Count; i++ ) {
                Response.Write(al[i] + "<br>");
            }

            Response.Write("<br><br>");

            foreach (object a  in al) {
                Response.Write(a + "<br>");
            }

    */
            /*
                    Hashtable ht = new Hashtable();
                    ht.Add(2 , "abc");
                    ht.Add(1 , 10);
                    ht.Add(4 , 20);
                    ht.Add(3 , "xyz");


                    foreach(DictionaryEntry de in ht) {

                        Response.Write(de.Key + "      " + de.Value + "<br>");
                    };
                   


            SortedList sl = new SortedList();
            sl.Add(2, "abc");
            sl.Add(1, 10);
            sl.Add(4, 20);
            sl.Add(3, "xyz");


            foreach (DictionaryEntry de in sl)
            {

                Response.Write(de.Key + "      " + de.Value + "<br>");
            };
             


            Stack sk = new Stack();
            sk.Push("abc");
            sk.Push("xyz");
            sk.Push("lmn");
            sk.Push("jkl");

            foreach(var a in sk) {
                Response.Write(a + "<br>");
            }

   

            Queue q = new Queue();
            q.Enqueue("abc");
            q.Enqueue("xya");
            q.Enqueue("jkl");
            q.Enqueue("tuv");

            foreach (var a in q)
            {
                Response.Write(a + "<br>");
            }


  


            //GENERIC TYPE
            List<String> ls = new List<string>();
            ls.Add("10");
            ls.Add("20");
            ls.Add("30");
            ls.Add(40.ToString());


            foreach (string a in ls) {
                Response.Write(a + "<br>");
            }

       

            Employee e1 = new Employee();
            e1.ID = 10;
            e1.NAME = "abc";

            Response.Write(e1.ID + "  " + e1.NAME);

            Employee e2 = new Employee();
            e2.ID = 20;
            e2.NAME = "xyz";


            Response.Write(e2.ID + "  " + e2.NAME);

            Employee e3 = new Employee();
            e3.ID = 30;
            e3.NAME = "jkl";


            Response.Write(e3.ID + "  " + e3.NAME);




            List<Employee> ls = new List<Employee>();
            ls.Add(new Employee() { ID=1 , NAME = "amin"});
            ls.Add(new Employee() { ID = 2, NAME = "anas" });
            ls.Add(new Employee() { ID = 3, NAME = "hamza" });

    */

            List<Employee> ls = new List<Employee>() {
                new Employee() { ID = 1, NAME = "amin" },
                new Employee() { ID = 2, NAME = "anas" },
                new Employee() { ID = 3, NAME = "hamza" }
            };





            foreach (Employee em in ls) {
                Response.Write(em.ID + "    " + em.NAME  + "<br>");
            }


        }


        class Employee {

            public int ID { get;  set; }
            public string NAME { get; set; }
        }


    }
}