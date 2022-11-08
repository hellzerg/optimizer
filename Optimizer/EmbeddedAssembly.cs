using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;

namespace Optimizer
{
    internal sealed class EmbeddedAssembly
    {
        static Dictionary<string, Assembly> _dictionary;

        internal static void Load(string embeddedResource, string fileName)
        {
            if (_dictionary == null) _dictionary = new Dictionary<string, Assembly>();

            byte[] bytes = null;
            Assembly assembly = null;
            Assembly currentAssembly = Assembly.GetExecutingAssembly();

            using (Stream stream = currentAssembly.GetManifestResourceStream(embeddedResource))
            {
                if (stream == null) throw new Exception(embeddedResource + " is not found in Embedded Resources.");

                bytes = new byte[(int)stream.Length];
                stream.Read(bytes, 0, (int)stream.Length);

                try
                {
                    assembly = Assembly.Load(bytes);

                    _dictionary.Add(assembly.FullName, assembly);
                    return;
                }
                catch (Exception ex)
                {
                    ErrorLogger.LogError("EmbeddedAssembly.Load", ex.Message, ex.StackTrace);
                }
            }

            bool fileOk = false;
            string tempFile = string.Empty;

            using (SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider())
            {
                string fileHash = BitConverter.ToString(sha1.ComputeHash(bytes)).Replace("-", string.Empty);

                tempFile = Path.GetTempPath() + fileName;

                if (File.Exists(tempFile))
                {
                    byte[] byteArray = File.ReadAllBytes(tempFile);
                    string fileHash2 = BitConverter.ToString(sha1.ComputeHash(byteArray)).Replace("-", string.Empty);

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
                File.WriteAllBytes(tempFile, bytes);
            }

            assembly = Assembly.LoadFile(tempFile);

            _dictionary.Add(assembly.FullName, assembly);
        }

        internal static Assembly Get(string assemblyFullName)
        {
            if (_dictionary == null || _dictionary.Count == 0) return null;

            if (_dictionary.ContainsKey(assemblyFullName)) return _dictionary[assemblyFullName];

            return null;
        }
    }
}
