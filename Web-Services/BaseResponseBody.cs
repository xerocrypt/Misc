using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Xml.Serialization;

namespace Region3.Requesting.DataAccess.Types
{
    public class BaseResponseBody<TDestination, TSource>
    {
        public virtual TDestination Create(TSource dr)
        {
            throw new NotImplementedException("This method needs to be implemented in the derived class.");
        }
    }

    public class BaseResponseBodyMultipleTyped<TDestination, TSource> : BaseResponseBody<TDestination,TSource>
    {
        public BaseResponseBodyMultipleTyped()
        { }

        protected TDestination[] _items;

        [XmlElement("Items")]
        public TDestination[] Items
        {
            get { return _items; }
            set { _items = value; }
        }
        public void PopulateArray(TSource[] rows)
        {
            _items = new TDestination[rows.Length];
            for (int i=0; i<rows.Length; i++)
            {
                _items[i] = Create(rows[i]);
            }
        }
    }

    public class BaseResponseBodyMultiple<T> : BaseResponseBodyMultipleTyped<T,DataRow>
    {
        public BaseResponseBodyMultiple()
        { }

        /*protected T[] _items;

        [XmlElement("Items")]
        public T[] Items
        {
            get { return _items; }
            set { _items = value; }
        }
        public void PopulateArray(DataRow[] rows)
        {
            _items = new T[rows.Length];
            for (int i=0; i<rows.Length; i++)
            {
                _items[i] = Create(rows[i]);
            }
        }*/
    }
}