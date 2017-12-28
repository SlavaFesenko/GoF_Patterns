using System.Collections.Generic;

namespace GoF_Patterns.Proxy.OwnExample
{
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