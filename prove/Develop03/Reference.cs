using System;

namespace develop03
{
    public class Reference
    {
        private string book;
        private string chapter;
        private string verse;

        public Reference(string reference)
        {
            string[] parts = reference.Split(" ");
            string[] chapterAndVerse = parts[1].Split(":");
            this.book = parts[0];
            this.chapter = chapterAndVerse[0];
            this.verse = chapterAndVerse[1];
        }

        public string formatTheReference()
        {
            return $"{book} {chapter}:{verse}";
        }
    }
}