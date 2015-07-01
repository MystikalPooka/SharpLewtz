using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpLewtz
{
    public interface IObject
    {
        #region FIELDS

        string Name { get; set; } //"gem" "weapon table"
        bool isEnabled    { get; set; } 
        int Probability { get; set; }
        bool Always       { get; set; } //is this always enabled?

        LootTable parentTable { get; set; } //owner of this object
        #endregion

        #region EVENTS
        event EventHandler hit;
        void OnHit(EventArgs e);
        #endregion
    }

    public interface ICreatableObject : IObject
    {
        //returns a new instance of an item using the default constructor for that item (or table O.o)
        IObject CreateInstance();
    }

    public interface ITable : IObject
    {
        int rollCount { get; set; } //total amount of "things" returned from this table is <= count

        IEnumerable<IObject> Contents { get; }

        IEnumerable<Item> Results { get; } //the full result set that is returned to things (and sometimes stuff)
    }
}
