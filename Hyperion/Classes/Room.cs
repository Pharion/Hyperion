using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hyperion
{
    class Room
    {

        private string title;

        public string Title
        {
            get { return title; } 
            set { title = value; }
        }

        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        private List<string> exits;
        private List<Item> items;

        public List<Item> Items
        {
            get { return items; }
            set { items = value; }
        }

        // Public Methods

        //Describe()

        //ShowTitle()

        //GetItem()

        //AddExit()

        //RemoveExit()

        //CanExit()

        // Private Methods

        //GetItemList()

        //GetExitList()

        //GetCoordinates()

    }
}
