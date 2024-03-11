using System;
using Generic_Practise.Exceptions;

namespace Generic_Practise
{
	public class DataList<T>
	{ 
        private T[] _datas;
        public DataList()
        {
           _datas = Array.Empty<T>();
        }
        public void Add(T data)
        {
            Array.Resize(ref _datas, _datas.Length + 1);
            _datas[_datas.Length - 1] = data;
        }
        public T[] GetAll()
        {
            return _datas;
        }
        public void Delete(T value)
        {
          int indexToRemove = 0;
          bool isContains = true;
          isContains = _datas.Contains(value);
          indexToRemove = Array.IndexOf(_datas, value);
          _datas = _datas.Where((element, index) => index != indexToRemove).ToArray();
        }
    }
}

