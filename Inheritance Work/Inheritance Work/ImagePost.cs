using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Work
{
    internal class ImagePost : Post
    {
        public string ImageURL { get; set; }
        //If I did understand this correctly we put this empty constructor
        //because it's the default constructor, so if you dont add any details
        //to the imagepost, it will just be the standard details given in the
        //default contructor which was made in the post class.
        //note to self: look at implicit and expilicit operators in c sharp
        public ImagePost() { }

        public ImagePost(string title, string sendByUsername, string imageURL, bool isPublic)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUserName = sendByUsername;
            this.IsPublic = isPublic;
            this.ImageURL = imageURL;
        }
        public override string ToString()
        {
            return String.Format($"{this.ID} - {this.Title} - by {this.SendByUserName} - link: {this.ImageURL}");
        }
    }
}
