using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNamePicker.Receiver
{
    public class NameList
    {
        private List<string> _nameList;
        
        public NameList()
        {
            _nameList = new List<string>();
        }

        public void AddName(string name)
        {
            _nameList.Add(name);
        }

        public void DeleteName(string name)
        {
            _nameList.Remove(name);
        }

        public IEnumerable<string> GetNames()
        {
            return _nameList;
        }
    }
}
