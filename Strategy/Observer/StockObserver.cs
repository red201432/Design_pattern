using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class StockObserver
    {
        private string name;
        private ISubject subject;
        public StockObserver(string name,ISubject sub)
        {
            this.name = name;
            this.subject = sub;
        }

        public void CloseStockMarket()
        {
            Console.WriteLine(subject.SubjectState+" "+name+" close stockmarket , working.");
        }
    }

    public class NBAObserver
    {
        private string name;
        private ISubject subject;
        public  NBAObserver(string name, ISubject sub)
        {
            this.name = name;
            this.subject = sub;
        }

        public void CloseStockMarket()
        {
            Console.WriteLine(subject.SubjectState + " " + name + " close NBA , working.");
        }

        public string print(string name) {
            return name;
        }
    }
}
