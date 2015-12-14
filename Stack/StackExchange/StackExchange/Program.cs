using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackExchange
{
    public class Post
    {
        private DateTime _now;
        private int _voteNum = 0;
        public string Title { get; set; }
        public string Description { get; set; }

        public Post()
        {
            _now = DateTime.UtcNow;
        }

        public void Up()
        {
            _voteNum++;
        }

        public void Down()
        {
            _voteNum--;
        }

        public int VoteValue()
        {
            return _voteNum;
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            var post1 = new Post();
            post1.Title = "Post numer 1";
            post1.Description = " figjspšghsjpghisštohij šaoerigjašoerigaou ";
            post1.Up();
            post1.Up();
            post1.Up();
            post1.Up();
            post1.Up();
            post1.Down();
            Debug.WriteLine("Vote value: " + post1.VoteValue());    
        }
    }
}
