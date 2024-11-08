using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Specification;
using POCO;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace BinaryDataRepositoryLib
{
    public class BinaryRepository:IDataRepository
    {
        public bool Serialize(string filename,List<Product>products)
        {
            bool status=false;
            BinaryFormatter Formatter = new BinaryFormatter();
            FileStream Stream = new FileStream(filename,FileMode.OpenOrCreate);
            Formatter.Serialize(Stream,products);
            Stream.Close();
            return status;
        }

        public List<Product>Deserialize(string filename)
        {
            List<Product> products = new List<Product>();
            BinaryFormatter Formatter = new BinaryFormatter();
            FileStream Stream = new FileStream(filename, FileMode.Open);
            if(Stream !=null)
            {
               products=(List<Product>) Formatter.Deserialize(Stream);
            }
            Stream.Close();
            return products;
        }
    }
}
