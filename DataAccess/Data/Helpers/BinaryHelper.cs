using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace DataAccess.Data.Helpers
{
        internal class BinaryHelper<T>
        {
            public List<T> LoadAll(string filename)
            {
                try
                {
                    List<T> loadedList = new List<T>();

                    using (FileStream fs = File.Open(filename, FileMode.Open))
                    {
                        BinaryFormatter formatter = new BinaryFormatter();
                        loadedList = formatter.Deserialize(fs) as List<T>;
                    }

                    return loadedList;
                }
                catch (Exception ex)
                { }
                return new List<T>();
            }

            public bool SaveList(List<T> listToSave, string filename)
            {
                try
                {
                    using (Stream stream = File.Open(filename, FileMode.Create))
                    {
                        BinaryFormatter bin = new BinaryFormatter();
                        bin.Serialize(stream, listToSave);
                    }
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }


}