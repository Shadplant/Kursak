using System;
using System.Collections.Generic;
using System.Text;

namespace DataBase_Logic
{
    public class News
    {
        private int news_id;
        private string news_title;
        private string news_text;

        public int News_ID
        {
            get { return news_id; }
            set
            {
                news_id = value;
            }
        }

        public string News_Title
        {
            get { return news_title; }
            set
            {
                news_title = value;
            }
        }

        public string News_Text
        {
            get { return news_text; }
            set
            {
                news_text = value;
            }
        }

    }
}
