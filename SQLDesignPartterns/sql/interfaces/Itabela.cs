using System;
using System.Collections.Generic;
using System.Text;

namespace SQLDesignPartterns.sql.interfaces
{
    interface Itabela
{
    public List<string> GetColuna();
    public Dictionary<string,object> GetParamentrosValores();
}
}
