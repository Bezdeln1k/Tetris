using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    enum Day : byte     //созданному типу данных Day (которому по-умолчанию присвоен int)
                        //присвоили тип byte, чтобы занимало меньше места в памяти
                        //enum вместо class хранит перечисления
    {
        Mon = 1, Tue, Wed, Thu, Fri, Sat, Sun //Mon = 1, потому что по-умолчанию нумерация с 0, а для дней недели это не подходит
    }
}
