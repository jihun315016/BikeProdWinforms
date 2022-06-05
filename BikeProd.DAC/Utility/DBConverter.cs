using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BikeProd.DAC
{
    public class DBConverter
    {
        public static List<T> DataReaderToList<T>(SqlDataReader reader)
        {
            try
            {
                T obj;
                List<T> list = new List<T>();
                while (reader.Read())
                {
                    obj = Activator.CreateInstance<T>();

                    // 읽어온 칼럼 순회
                    foreach (DataRow row in reader.GetSchemaTable().Rows)
                    {
                        // 클래스 멤버 순회
                        foreach (PropertyInfo p in obj.GetType().GetProperties())
                        {
                            // 읽어온 칼럼 이름이 클래스 멤버로 존재면서,
                            // 읽어온 칼럼 값이 DBNull이 아닌 경우
                            if (row["ColumnName"].ToString() == p.Name
                                && reader[p.Name] != DBNull.Value)
                                p.SetValue(obj, reader[p.Name], null);
                        }
                    }
                    list.Add(obj);
                }
                return list;
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
                return null;
            }
        }
    }
}
