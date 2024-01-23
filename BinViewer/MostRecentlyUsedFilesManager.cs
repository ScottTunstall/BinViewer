using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace BinViewer
{
    public class MostRecentlyUsedFilesManager
    {
        const char Delimiter = '|';
        private const string RegValueName = "MRUList";

        private readonly string _parentRegistrySubKeyName;
        private readonly int _maxRecentlyUsedFiles;

        public MostRecentlyUsedFilesManager(string parentRegistrySubKeyName, int maxRecentlyUsedFiles = 5)
        {
            _parentRegistrySubKeyName = parentRegistrySubKeyName;
            _maxRecentlyUsedFiles = maxRecentlyUsedFiles;
        }


        public void Add(string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(fileName));

            if (fileName.Contains(Delimiter))
                throw new ArgumentException($"Value must not contain '{Delimiter}", nameof(fileName));

            var recentFiles = Get().ToList();
            recentFiles.RemoveAll(mru => string.Equals(mru, fileName, StringComparison.CurrentCultureIgnoreCase));

            recentFiles.Insert(0, fileName);

            var toBeSavedInRegistry = recentFiles.Take(_maxRecentlyUsedFiles);
            Set(toBeSavedInRegistry);
        }


        public void Remove(string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(fileName));

            if (fileName.Contains(Delimiter))
                throw new ArgumentException($"Value must not contain '{Delimiter}", nameof(fileName));

            var recentFiles = Get().ToList();
            recentFiles.RemoveAll(mru => string.Equals(mru, fileName, StringComparison.CurrentCultureIgnoreCase));

            var toBeSavedInRegistry = recentFiles.Take(_maxRecentlyUsedFiles);
            Set(toBeSavedInRegistry);
        }


        public IEnumerable<string> Get()
        {
            RegistryKey? regSubKey = null;

            try
            {
                regSubKey = Registry.CurrentUser.OpenSubKey(_parentRegistrySubKeyName);
                if (regSubKey == null)
                    return Enumerable.Empty<string>();

                var recentFiles = regSubKey.GetValue(RegValueName) as string;
                if (recentFiles == null)
                    return Enumerable.Empty<string>();

                return recentFiles.Split(Delimiter).ToList();
            }
            finally
            {
                regSubKey?.Close();
            }
        }


        private void Set(IEnumerable<string> fullPathSpecs)
        {
            RegistryKey? regSubKey = null;

            try
            {
                var asDelimitedList = string.Join(Delimiter, fullPathSpecs);
                regSubKey = Registry.CurrentUser.CreateSubKey(_parentRegistrySubKeyName);
                regSubKey.SetValue(RegValueName, asDelimitedList, RegistryValueKind.String);
            }
            finally
            {
                regSubKey?.Close();
            }
        }
    }


}
