using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Work
{
    internal class Post
    {
        //it is private so no one can acces id and static so it shares the same value among all uses
        private static int currentPostId;

        //properties
        protected int ID { get; set; }
        protected string Title { get; set; }
        protected string SendByUserName { get; set; }
        protected bool IsPublic { get; set; }

        //Default constructor. If a derived class does not invoke a base-
        //class constructor explicitly, the default constructor is called
        //implicitly.
        public Post()
        {
            ID = 0;
            Title = "My First Post";
            IsPublic = true;
            SendByUserName = "Teoman";
        }

        // Instance constructor that has three parameters
        public Post(string title, bool isPublic, string sendByUsername)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.IsPublic = isPublic;
            this.SendByUserName = sendByUsername;
        }

        protected int GetNextID()
        {
            return ++currentPostId;
        }

        //if the user wants to update the post
        public void Update(string title, bool isPublic)
        {
            this.Title = title;
            this.IsPublic = isPublic;
        }

        //overriding ToString(); Method that comes from System.Object
        //also we can do this because every single class inherits from Object Class.
        public override string ToString()
        {
            return String.Format($"{this.ID} - {this.Title} - by {this.SendByUserName}");
        }
    }
}
