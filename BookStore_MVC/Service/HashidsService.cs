using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore_MVC.Service
{
    public class HashidsService : IHashidsService
    {
        private HashidsNet.Hashids _hash;
        public HashidsService()
        {
            _hash = new HashidsNet.Hashids("Elephant has a big ears" , 6);
        }

        public int Decrypt(string hashedid )
        {
            return _hash.Decode(hashedid).First();
        }

        public string Encrypt(int id)
        {
            return _hash.Encode(id);
        }
    }
}