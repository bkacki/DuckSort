using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckSort
{
    internal class Duck : IComparable<Duck>
    {
        public int Size { get; set; }
        public KindOfDuck Kind {  get; set; }

        public int CompareTo(Duck? duckToCompare)
        {
            if (this.Size > duckToCompare.Size)
                return 1;
            else if (this.Size < duckToCompare.Size)
                return -1;
            else 
                return 0;
        }
    }

    enum KindOfDuck
    {
        krzyżówka,
        piżmowa,
        nur,
    }

    enum SortCriteria
    {
        SizeThenKind,
        KindThenSize,
    }

    class DuckComparer : IComparer<Duck>
    {
        public SortCriteria SortBy = SortCriteria.SizeThenKind;

        public int Compare(Duck? x, Duck? y)
        {
            if(SortBy == SortCriteria.SizeThenKind)
            {
                if (x.Size > y.Size)
                    return 1;
                else if (x.Size < y.Size)
                    return -1;
                else 
                {
                    if (x.Kind > y.Kind)
                        return 1;
                    else if (x.Kind < y.Kind)
                        return -1;
                    else
                        return 0;
                }
            }
            else
            {
                if (x.Kind > y.Kind)
                    return 1;
                else if (x.Kind < y.Kind)
                    return -1;
                else
                {
                    if (x.Size > y.Size)
                        return 1;
                    else if (x.Size < y.Size)
                        return -1;
                    else
                        return 0;
                }
            }
        }
    }
}
