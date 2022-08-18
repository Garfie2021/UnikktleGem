using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace UnikktleGemLib
{
    public static class CopyHelper
    {
        /// <summary>
        /// DeepCopy
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="src"></param>
        /// <returns></returns>
        public static T DeepCopy<T>(this T src)
        {
            using (var stream = new System.IO.MemoryStream())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(stream, src);
                stream.Position = 0;

                return (T)formatter.Deserialize(stream);
            }
        }
    }
}
