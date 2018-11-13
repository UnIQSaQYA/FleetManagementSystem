using System;
using System.Collections;
using System.Collections.ObjectModel;

namespace Entity.Framework
{

    /// <summary>
    /// The EntityList represents a general list of entity objects.
    /// It contains the functionality of both the ArrayList and the
    /// Hashtable collections. 
    /// 
    /// This class could be subtyped if it is necessary to have
    /// strongly-typed collection classes.
    /// </summary>
    public class EntityList : Collection<EntityBase>
    {
        public EntityList()
        {

        }

        /// <summary>
        ///  Adds a entity to the collection
        /// </summary>
        /// <param name="entity"></param>
        public virtual void Add(EntityBase entity)
        {
            base.Add(entity);
        }

        /// <summary>
        ///  Gets a entity from the collection
        /// </summary>
        /// <param name="entity"></param>
        public object this[int index]
        {
            get { return base.Items[index]; }
        }
    }
}
