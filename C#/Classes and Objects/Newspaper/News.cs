using System;

using System;

namespace Newspaper
{
    public class News
    {
        public string Title { get; private set; }
        public string Text { get; private set; }
        public string Writer { get; private set; }
        public News(string title, string text, string writer)
        {
            Title = title;
            Text = text;
            Writer = writer;
        }
        public void Edit(string newText)
        {
            Text = newText;
        }

        public void ChangeWriter(string newWriter)
        {
            Writer = newWriter;
        }

        public void Rename(string newTitle)
        {
            Title = newTitle;
        }
        public override string ToString()
        {
            return $"{Title} - {Text}: {Writer}";
        }
    }

    
}
