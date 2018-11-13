using System;
using Entity.Framework;

namespace Service.Framework
{
	/// <summary>
	/// Interface describing responsibilities for any service object
	/// </summary>
	public interface IService
	{
		/// <summary>
		/// All service objects need to return a list of all the entities
		/// </summary>
		/// <returns>A list of all entities</returns>
		EntityList GetAll();

		/// <summary>
		/// Removes all sites from the cache
		/// </summary>
		void ClearCache();

		/// <summary>
		/// Each service object must implement its own cache key name
		/// </summary>
		string KeyName
		{
			get ;
		}
		/// <summary>
		/// Each service object must implement whether its own list should be cached
		/// </summary>
		bool IsCached
		{
			get ;
		}
	}
}