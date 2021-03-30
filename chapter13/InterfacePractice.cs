using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter13
{
    public interface Isummation
    {
        int sum(int value1, int value2);
    }

    public interface Isubtraction
    {
        int sub(int value3, int value4);
    }

    public interface Imultiplication
    {
        int multi(int value5, int value6);
    }

    public interface Idivision
    {
        int div(int value7, int valure8);
    }

    public interface Iremainder
    {
        int rem(int value9, int value10);
    }
}
   
