using System;

namespace md5tool
{
    public interface IFunc
    {
        string MD5file(string filename);
        string SHA1file(string filename);
        void CreateRegKey();
        bool IsAdmin();
        void RunasAdmin(bool verb);
        string ShowMessage(string filename);

    }
}
