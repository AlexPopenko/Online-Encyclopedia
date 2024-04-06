using System.Collections.Generic;

namespace EncyclopediaAPI.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Tag { get; set; } = "";
        public string Creator { get; set; } = "";
        public string Content { get; set; } = "";
        public string CreationDate { get; set; } = "";

        public string SetCreationDate()
        {
            return DateTime.Now.ToString("MM/dd/yyyy H:mm");
        } 

        public Article( int id, string name, string tag, string creator, string content)
        {
            Id = id;
            Name = name;
            Tag = tag;
            Creator = creator;
            CreationDate = SetCreationDate();
            Content = content;

        }

        public static List<Article> GetArticles() => new List<Article>
            // random list of names from "behindthename.com"
            {
                new Article( 1, "Potatoes", "Foods", "Fred", "Potatoes are tasty"),
                new Article( 1, "Tomatoes", "Foods", "Fred", "Tomato Tomato"),
                new Article( 1, "Frogs", "Animals", "George", "Frogs are not snails"),
                new Article( 1, "Deer", "Animals", "Fred", "Deer are fast")
            };
    }
}
