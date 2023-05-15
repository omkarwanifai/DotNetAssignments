using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleWebApp
{
    
public partial class Example1 : System.Web.UI.Page
    {
        private Dictionary<string,string> words = new Dictionary<string, string>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                foreach(KeyValuePair<string,string> dic in words)
                {
                    if (word.Text == dic.Key)
                    {
                        wordshow.Text = dic.Key;
                        translation.Text = dic.Value;
                    }
            }
        }

        protected void search_button(object sender, EventArgs e)
        {
            foreach (KeyValuePair<string, string> ele1 in words)
            {
                if(ele1.Key == word.Text)
                {
                    foundword.Text = ele1.Key;
                    selectedword.Text = word.Text;
                }
                else
                {
                    error.Text = "Enter the full name of word to search";
                }
            }
            
        }

        protected void AddingList(object sender, EventArgs e)
        {
            selectedword.Text = word.Text;
            var selected = word.Text;
            var translation = meaning.Text;
            words.Add(selected, translation);
        }


    }
}