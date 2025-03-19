using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jurnalmod5_103022300065
{
    internal class SimpleDataBase<T>
    {
       

       
        private List<T> storedData;
   
        private  List<DateTime> inputDates;

        public SimpleDataBase()
        {
            storedData = new List<T>();
            inputDates = new List<DateTime>();
        }
        public void addNewData(T data)
        {
            storedData.Add(data);
            inputDates.Add(DateTime.Now);
        }
        public void PrintAllData()
        {
            for (int i = 0; i < storedData.Count; i++) {
                Console.WriteLine("Data " + (i+1)  +" berisi: " + storedData[i] + ", yang disimpan pada waktu " + inputDates[i]);
            }
            
        }
    }
}
