using System.IO;
using System.Collections.Generic;

/// The purpose of file is to save and load journal to a file.

namespace Develop02
{
    public class File
    {
        public void Save(Journal journal, string FileName)
        {
            using (StreamWriter outputFile = new StreamWriter(FileName))
            {
                List<Entry> entries = journal.GetEntries();
                foreach (Entry entry in entries)
                {
                    string message = $"{entry.GetDate()}|{entry.GetPrompt()}|{entry.GetResponse()}";
                    outputFile.WriteLine(message);
                }

            }
        }
        public List<Entry> Load(string FileName)
        {
            List<Entry> entries = new List<Entry>();
            string[] lines = System.IO.File.ReadAllLines(FileName);
            foreach (string line in lines)
            {
                string[] parts = line.Split("|");

                Entry newEntry = new Entry();
                newEntry.StoreDate(parts[0]);
                newEntry.StorePrompt(parts[1]);
                newEntry.StoreResponse(parts[2]);

                entries.Add(newEntry);
            }
            return entries;
        }
    }
}