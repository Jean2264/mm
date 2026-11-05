using System;
using System.Collections.Generic;
using System.Text;

namespace E_9.Entidades
{
    public class PagedResult<T>
    {
        public List<T> Data { get; set; }
        public int Total {  get; set; }
    }
}
