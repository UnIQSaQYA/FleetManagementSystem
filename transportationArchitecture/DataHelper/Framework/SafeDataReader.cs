using System;
using System.Data;

namespace DataHelper.Framework
{
	/// <summary>
	/// This is a DataReader that 'fixes' any null values before
	/// they are returned to our business code
	/// </summary>
	public class SafeDataReader
	{
		#region Data Members
		private IDataReader _dataReader;
		#endregion

		#region Constructor
		public SafeDataReader(IDataReader dr)
		{
			_dataReader = dr;
		}
		#endregion

		#region properties
		/// <summary>
		/// Returns the IsClosed property value from the datareader
		/// </summary>
		public bool IsClosed 
		{
			get { return _dataReader.IsClosed; }
		}

		/// <summary>
		/// Returns the RecordsAffected property value from the underlying datareader.
		/// </summary>
		public int RecordsAffected 
		{
			get { return _dataReader.RecordsAffected; }
		}

		/// <summary>
		/// Returns the depth property value from the datareader
		/// </summary>
		public int Depth 
		{
			get 
			{
				return _dataReader.Depth;
			}
		}
		/// <summary>
		/// Returns the FieldCount property from the datareader
		/// </summary>
		public int FieldCount 
		{
			get 
			{
				return _dataReader.FieldCount;
			}
		}

		/// <summary>
		/// Returns a value from the datareader
		/// </summary>
		/// <remarks>
		/// Returns null for Null value
		/// </remarks>
		public object this[string name] 
		{
			get 
			{
				Object value  = _dataReader[name];
				if (DBNull.Value.Equals(value)) 
					return null;
				else
					return value;
			}
		}

		/// <summary>
		/// Returns a value from the datareader
		/// </summary>
		/// <remarks>
		/// Returns null for Null value
		/// </remarks>
		public object this[int i] 
		{
			get 
			{
				if (_dataReader.IsDBNull(i)) 
					return null;
				else
					return _dataReader[i];
			}
		}

		#endregion

		#region Methods
		
		/// <summary>
		/// Gets a string value from the datareader
		/// </summary>
		/// <remarks>
		/// Returns string.Empty for Null value
		/// </remarks>
		public string GetString(int i) 
		{
			if (_dataReader.IsDBNull(i)) 
				return string.Empty;
			else 
			{
				string s = _dataReader.GetString(i);
				return s;
			}

		}

		/// <summary>
		/// Gets a value of type from the datareader
		/// </summary>
		/// <remarks>
		/// Returns null for Null value
		/// </remarks>
		public object GetValue(int i) 
		{
			if (_dataReader.IsDBNull(i)) 
				return null;
			else
				return _dataReader.GetValue(i);

		}

		/// <summary>
		/// Gets an integer from the datareader
		/// </summary>
		/// <remarks>
		/// returns 0 for Null value
		/// </remarks>
		public int GetInt32(int i) 
		{
			if (_dataReader.IsDBNull(i))
				return 0;
			else
				return _dataReader.GetInt32(i);

		}

		/// <summary>
		/// Gets a double from the datareader
		/// </summary>
		/// <remarks>
		/// Returns 0.0 for Null Value
		/// </remarks>
		public double GetDouble(int i) 
		{
			if (_dataReader.IsDBNull(i)) 
				return 0.0;
			else
				return _dataReader.GetDouble(i);

		}

		/// <summary>
		/// Gets a DateTime from the datareader
		/// </summary>
		/// <remarks>
		/// Returns DateTime.MaxValue for Null value
		/// </remarks>		
		public DateTime GetDateTime(int i) 
		{
			if (_dataReader.IsDBNull(i)) 
				return DateTime.MaxValue;
			else
			{
				return _dataReader.GetDateTime(i);
			}
		}	

		/// <summary>
		/// Gets a Guid value from the datareader
		/// </summary>
		public Guid GetGuid(int i) 
		{
			if (_dataReader.IsDBNull(i)) 
				return Guid.Empty;
			else
				return _dataReader.GetGuid(i);
		}

		/// <summary>
		/// Reads the next row of data from the datareader
		/// </summary>
		public bool Read() 
		{
            try
            {
                return _dataReader.Read();
            }
            catch
            {
                return false;
            }
		}

		/// <summary>
		/// Moves to the next result set in the datareader
		/// </summary>
		public bool NextResult()  
		{
			return _dataReader.NextResult();
		}

		/// <summary>
		/// Closes the datareader.
		/// </summary>
		public void Close() 
		{
            if(_dataReader!=null)
			    _dataReader.Close();
		}

		/// <summary>
		/// Calls the Dispose method on the underlying datareader
		/// </summary>
		public void Dispose() 
		{
			_dataReader.Dispose();
		}

		/// <summary>
		/// Gets a boolean value from the datareader
		/// </summary>
		/// <remarks>
		/// Returns false for Null value
		/// </remarks>
		public bool GetBoolean(int i) 
		{
			if (_dataReader.IsDBNull(i)) 
				return false;
			else
				return _dataReader.GetBoolean(i);
		}

		/// <summary>
		/// Gets a byte value from the datareader
		/// </summary>
		/// <remarks>
		/// Returns 0 for Null value
		/// </remarks>
		public byte GetByte(int i) 
		{
			if (_dataReader.IsDBNull(i)) 
				return 0;
			else
				return _dataReader.GetByte(i);
		}

		/// <summary>
		/// Invokes the GetBytes method of the underlying datareader
		/// </summary>
		/// <remarks>
		/// Returns 0 for Null value
		/// </remarks>
		public long GetBytes(int i, long fieldOffset, Byte[] buffer, int bufferoffset, int length) 
		{
			if (_dataReader.IsDBNull(i)) 
				return 0;
			else
				return _dataReader.GetBytes(i, fieldOffset, buffer, bufferoffset, length);
		}

		/// <summary>
		/// Gets a char value from the datareader
		/// </summary>
		public char GetChar(int i) 
		{
			if (_dataReader.IsDBNull(i)) 
				return Char.MinValue;
			else
				return Convert.ToChar(_dataReader.GetString(i));
		}

		/// <summary>
		/// Invokes the get {Chars method of the underlying datareader
		/// </summary>
		public long GetChars(int i, long fieldoffset, char[] buffer, int bufferoffset, int length) 
		{
			if (_dataReader.IsDBNull(i)) 
				return 0;
			else
				return _dataReader.GetChars(i, fieldoffset, buffer, bufferoffset, length);
		}

		/// <summary>
		/// Invokes the GetData method of the underlying datareader
		/// </summary>
		public IDataReader GetData(int i) 
		{
			return _dataReader.GetData(i);
		}

		/// <summary>
		/// Invokes the GetDataTypeName method of the underlying datareader
		/// </summary>
		public string GetDataTypeName(int i) 
		{
			return _dataReader.GetDataTypeName(i);
		}

		/// <summary>
		/// Gets a decimal value from the datareader
		/// </summary>
		public decimal GetDecimal(int i) 
		{
			if (_dataReader.IsDBNull(i))
				return 0;
			else
				return _dataReader.GetDecimal(i);
		}

		/// <summary>
		/// Invokes the GetFieldType method of the underlying datareader
		/// </summary>
		public Type GetFieldType(int i) 
		{
			return _dataReader.GetFieldType(i);
		}

		/// <summary>
		/// Gets a float value from the datareader
		/// </summary>
		public float GetFloat(int i) 
		{
			if (_dataReader.IsDBNull(i)) 
				return 0.0f;
			else
				return _dataReader.GetFloat(i);
		}

		/// <summary>
		/// Gets a short value from the datareader
		/// </summary>
		public short GetInt16(int i) 
		{
			if (_dataReader.IsDBNull(i)) 
				return 0;
			else
				return _dataReader.GetInt16(i);
		}

		/// <summary>
		/// Gets a long value from the datareader
		/// </summary>
		public long GetInt64(int i) 
		{
			if (_dataReader.IsDBNull(i)) 
				return 0;
			else
				return _dataReader.GetInt64(i);
		}

		/// <summary>
		/// Invokes the get {Name method of the underlying datareader
		/// </summary>
		public string GetName(int i) 
		{
			return _dataReader.GetName(i);
		}

		/// <summary>
		/// Gets an ordinal value from the datareader
		/// </summary>
		public int GetOrdinal(string name) 
		{
			return _dataReader.GetOrdinal(name);
		}

		/// <summary>
		/// Invokes the get {SchemaTable method of the underlying datareader
		/// </summary>
		public DataTable GetSchemaTable() 
		{
			return _dataReader.GetSchemaTable();
		}

		/// <summary>
		/// Invokes the get {Values method of the underlying datareader
		/// </summary>
		public int GetValues(Object[] values) 
		{
			return _dataReader.GetValues(values);
		}


		/// <summary>
		/// Invokes the IsDBNull method of the underlying datareader
		/// </summary>
		public bool IsDBNull(int i) 
		{
			return _dataReader.IsDBNull(i);
		}
		#endregion

	}
}
