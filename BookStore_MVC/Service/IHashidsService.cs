using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore_MVC.Service
{
    interface IHashidsService
    {
        string Encrypt(int id);
        int Decrypt(string hashedid);
    }
}
