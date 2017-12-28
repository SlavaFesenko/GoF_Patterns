using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Patterns.Proxy.OwnExample
{
    abstract class ASubject
    {
        public abstract string GetPage(int number);
    }

    class LogStorage : ASubject
    {
        public override string GetPage(int number)
        {
            // get data from DB
            switch (number)
            {
                case 0: return $"Page #{number}";
                case 1: return $"Page #{number}";
                case 2: return $"Page #{number}";
                    default: return "Page not found";
            }
            
            
        }
    }

    class LogStorageProxy : ASubject
    {
        private LogStorage _logStorage;
        private Dictionary<int, string> _cachedPages;
        public override string GetPage(int number)
        {
            if (_logStorage == null)
            {
                _logStorage = new LogStorage();
            }
            if (_cachedPages == null)
            {
                var page = _logStorage.GetPage(number);

                _cachedPages = new Dictionary<int, string>
                {
                    {number, page + " (from cache)."}
                };

                return page;
            }
            else
            {
                if (!_cachedPages.TryGetValue(number, out var page))
                {
                    page = _logStorage.GetPage(number);
                    _cachedPages.Add(number, page + " (from cache).");
                }

                return page;
            }
        }
    }
}
