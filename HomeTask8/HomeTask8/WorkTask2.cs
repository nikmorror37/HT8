using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace HomeTask8
{
    public abstract class AJobTitle
    {
        public abstract string Title { get; set; }
    }
    public class Director : AJobTitle, IJobTitle
    {
        public override string Title { get; set; } = "Director";
        public void JobTitle()
        {
            Console.WriteLine(Title);
        }
        
    }

    public class Worker : AJobTitle, IJobTitle
    {
        public override string Title { get; set; } = "Worker";
        public void JobTitle() 
        {
            Console.WriteLine(Title);
        }
    }

    public class Accountant : AJobTitle, IJobTitle
    {
        public override string Title { get; set; } = "Accountant";
        public void JobTitle()
        {
            Console.WriteLine(Title);
        }
    }



}
