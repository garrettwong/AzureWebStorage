using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureWebStorage
{
    class Program
    {
        static void Main(string[] args)
        {
            AzureWebStorageConnection awsc = new AzureWebStorageConnection();

            awsc.List();

            awsc.CreateContainer("testcontainer");

            awsc.AddFromFile("testcontainer", @"C:\data\test.txt");

            awsc.List();

            awsc.GetString("testcontainer", "asdf");
        }
    }
}
