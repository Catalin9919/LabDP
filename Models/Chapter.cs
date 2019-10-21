using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Chapter
    {
        private string _chapterTitle;

        public string ChapterTitle
        {
            get { return _chapterTitle; }
            set { _chapterTitle = value; }
        }

        private List<SubChapter> subChapters;

        public List<SubChapter> SubChapters
        {
            get { return subChapters; }
            set { subChapters = value; }
        }
        
        public Chapter(string chaptTitle)
        {
            ChapterTitle = chaptTitle;
        }

        public SubChapter GetSubChapter(int indexOfSubChapter)
        {
            return SubChapters.ElementAt(indexOfSubChapter - 1);
        }

        public int CreateSubChapter(string subChapterName)
        {
            SubChapter newSubChapter = new SubChapter(subChapterName);
            SubChapters.Add(newSubChapter);
            return SubChapters.Count;
        }



    }
}
