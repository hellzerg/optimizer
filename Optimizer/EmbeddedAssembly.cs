using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;

namespace Optimizer
{
    public class EmbeddedAssembly
    {
        private static Dictionary<string, Assembly> dic;

        public static void Load(string embeddedResource, string fileName)
        {
            if (dic == null)
                dic = new Dictionary<string, Assembly>();

            byte[] ba = null;
            Assembly asm = null;
            var curAsm = Assembly.GetExecutingAssembly();

            using (var stm = curAsm.GetManifestResourceStream(embeddedResource))
            {
                if (stm == null)
                    throw new Exception(embeddedResource + " is not found in Embedded Resources.");

                ba = new byte[(int)stm.Length];
                stm.Read(ba, 0, (int)stm.Length);
                try
                {
                    asm = Assembly.Load(ba);

                    dic.Add(asm.FullName, asm);
                    return;
                }
                catch { }
            }

            var fileOk = false;
            var tempFile = "";

            using (var sha1 = new SHA1CryptoServiceProvider())
            {
                var fileHash = BitConverter.ToString(sha1.ComputeHash(ba)).Replace("-", string.Empty);
                ;

                tempFile = Path.GetTempPath() + fileName;

                if (File.Exists(tempFile))
                {
                    var bb = File.ReadAllBytes(tempFile);
                    var fileHash2 = BitConverter.ToString(sha1.ComputeHash(bb)).Replace("-", string.Empty);

                    if (fileHash == fileHash2)
                    {
                        fileOk = true;
                    }
                }
                else
                {
                    fileOk = false;
                }
            }

            if (!fileOk)
            {
                File.WriteAllBytes(tempFile, ba);
            }

            asm = Assembly.LoadFile(tempFile);

            dic.Add(asm.FullName, asm);
        }

        public static Assembly Get(string assemblyFullName)
        {
            if (dic == null || dic.Count == 0)
                return null;

            if (dic.ContainsKey(assemblyFullName))
                return dic[assemblyFullName];

            return null;
        }
    }
}
