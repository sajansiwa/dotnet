using hello_world;
using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace world
{
    class Program
    {
        static void Main (string[] args)
        {
            World dis = new World();

            dis.Greetings();

        }
    }
}