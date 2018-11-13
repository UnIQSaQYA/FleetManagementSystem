using System;

namespace Entity.Framework
{
	/// <summary>
	/// The EntityBase is a superclass for all the entity objects
	/// in the Domain/Object Model. General entity-manipulation classes
	/// in the data access layers can rely on the fact that all entity 
	/// objects have a common superclass.
	/// </summary>
	/// <remarks>
	/// 
	/// </remarks>
	public abstract class EntityBase
	{
		#region Data Members
	
		//public static object defaultID = null;
		private object _id;
		
		#endregion

		#region Constructor		
		public EntityBase(object id)
		{
			_id = id;
		}
		
		#endregion

		#region Properties
		
		public object ID
		{
			get { return _id; }
			set { _id = value; }
		}

		#endregion
	}
}
