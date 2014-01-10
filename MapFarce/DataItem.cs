﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MapFarce
{
    public class DataItem
    {
        public DataItem(int fieldCount)
        {
            FieldCount = fieldCount;
            Values = new SortedList<DataField, object>(FieldCount);
        }

        public int FieldCount { get; private set; }
        public DataField GetField(int i) { return Values.Keys[i]; }

        public object GetValue(DataField field)
        {
            return Values[field];
        }

        public object GetValue(int i)
        {
            return Values.Values[i];
        }

        public void AddValue(DataField field, object value)
        {
            Values.Add(field, value);
        }

        SortedList<DataField, object> Values;
    }

    public abstract class DataField : IComparable<DataField>
    {
        public abstract string Name { get; protected set; }
        //Type Type { get; }

        public abstract int CompareTo(DataField other);
    }
}
