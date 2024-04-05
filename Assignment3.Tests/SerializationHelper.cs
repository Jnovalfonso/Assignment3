using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Assignment3.Utility;
using NUnit.Framework.Internal.Execution;
using System.Runtime.Serialization.Formatters.Binary;

namespace Assignment3.Tests
{
    public static class SerializationHelper
    {
        static private string _basePath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
        public static void SerializeUsers(SLL users, string fileName)
        {
            fileName = _basePath + "\\BinSerialization" + fileName;

            DataContractSerializer serializer = new DataContractSerializer(typeof(Node));
            using (FileStream stream = File.Create(fileName))
            {
                using (BinaryWriter writer = new BinaryWriter(stream))
                {
                    Node tempNode = users.Head;
                    while (tempNode != null)
                    {
                        serializer.WriteObject(writer.BaseStream, tempNode);
                        tempNode = tempNode.Next;
                    }
                    
                }
            }
        }
        public static SLL DeserializeUsers(string fileName)
        {
            SLL userList = new SLL();
            fileName = _basePath + "\\BinSerialization" + fileName;
            DataContractSerializer serializer = new DataContractSerializer(typeof(Node));

            using (FileStream stream = new FileStream(fileName, FileMode.Open))
            {
                while (stream.Position < stream.Length)
                {
                    Node deserializedNode = (Node)serializer.ReadObject(stream);
                    userList.AddLast(deserializedNode.Data);
                }
            }
            return userList;
        }

    }            
}
