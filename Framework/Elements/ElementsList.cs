using System;
using System.Collections;
using System.Collections.Generic;
using Framework.Driver;
using OpenQA.Selenium;

namespace Framework.Elements
{
    public class ElementsList : IList<Element>
    {
        private List<IWebElement> _elements => DriverManager.Driver.FindElements(Search);

        public int Count
        {
            get
            {
                return _elements.Count;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public Element this[int index]
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        internal Search Search;

        internal ElementsList()
        {
        }

        public int IndexOf(Element item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, Element item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        public void Add(Element item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(Element item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(Element[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(Element item)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<Element> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
