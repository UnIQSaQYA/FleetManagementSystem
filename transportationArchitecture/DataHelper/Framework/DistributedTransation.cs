using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

/// <summary>
/// Summary description for DistributedTransation
/// </summary>
/// 
namespace DataHelper.Framework
{
    public class DistributedTransaction : IDisposable
    {
        private bool _happy = true;
        private bool _done = false;
        private IDbTransaction _idbTransaction;
        private bool _disposed = false;
        IDbConnection _connection = null;

        public Boolean Done
        {
            get { return _done; }
            set { _done = value; }
        }
        public Boolean HAPPY
        {
            get { return _happy; }
            set { _happy = value; }
        }

        public void Dispose()
        {
            Dispose(true);
            // This object will be cleaned up by the Dispose method.
            // Therefore, you should call GC.SupressFinalize to
            // take this object off the finalization queue 
            // and prevent finalization code for this object
            // from executing a second time.
            GC.SuppressFinalize(this);
        }

        // Dispose(bool disposing) executes in two distinct scenarios.
        // If disposing equals true, the method has been called directly
        // or indirectly by a user's code. Managed and unmanaged resources
        // can be disposed.
        // If disposing equals false, the method has been called by the 
        // runtime from inside the finalizer and you should not reference 
        // other objects. Only unmanaged resources can be disposed.
        private void Dispose(bool disposing)
        {
            // Check to see if Dispose has already been called.
            if (!this._disposed)
            {
   
         // Avoid runtime error when disposing 
         // (connection broken, etc.)
            try {
   
            // if transaction has not been committed or 
            // rolled back, we need to close it
   
            // Commits if the object is happy, otherwise 
            // rolls back
            if (!_done) 
            {
               if (this._happy) 
               {
                   _idbTransaction.Commit();
               } 
               else 
               {
                   _idbTransaction.Rollback();
               }
            }
         } 
         catch (Exception ex) {}
   
         try
         {
            // -- Important: closes and releases reference to 
            // transaction
            _connection.Close();
            _connection.Dispose();
            _idbTransaction.Dispose();
         }
         catch (Exception ex) { }
      }
       _disposed = true; 
    }

        public IDbConnection Connection()
        {
            return _connection;
        }

        public IDbTransaction Transaction
        {
            get
            {
                // check the object has not been disposed
                if (_disposed)
                {
                    throw new ObjectDisposedException("Transaction");
                }

                // if object's lifetime has expired, caller cannot 
                // access the transaction
                if (this._done) throw new InvalidOperationException("Transaction has been closed and can no longer be used");

                // returns sqlTransaction internally referenced
                return _idbTransaction;
            }
        }
        public DistributedTransaction()
        {
            // opens connection therefore checks if connString is valid
            _connection = DataAccessFactory.CreateConnection();
            try
            {
                _connection.Open();
            }
            catch (Exception e)
            {
                // throw exception with incorrect connstring
                throw new ApplicationException("Unable to open connection.");
            }

            // starts transaction
            _idbTransaction = _connection.BeginTransaction();
        }

        public void Commit()
        {

            // checks the object has not been disposed
            if (_disposed)
            {
                throw new ObjectDisposedException("Transaction");
            }

            // checks a commit or rollback has not been execute
            if (_done)
            {
                throw new InvalidOperationException("Transaction has yet been committed/rolled back");
            }

            // checks we are happy and can therefore commit the transaction
            if (!_happy)
            {
                throw new InvalidOperationException("Transaction has commit disabled and cannot be commited");
            }
            try
            {
                // commits the transaction
                _idbTransaction.Commit();
            }
            catch (Exception ex)
            {
                throw;

            }
            finally
            {
                // updates status to show this object's lifetime 
                // has expired
                _done = true;

                // Always close underlying database connection 
                if (_idbTransaction.Connection != null)
                {
                    if (_idbTransaction.Connection.State ==ConnectionState.Open)
                    {
                        _idbTransaction.Connection.Close();
                    }
                    _idbTransaction.Connection.Dispose();
                }
                // Disposed transaction that now is no more useful
                _idbTransaction.Dispose();
            }
        }
        public void Abort()
        {
            // checks if the object has been disposed
            if (_disposed)
            {
                throw new ObjectDisposedException("SqlTransaction");
            }

            // checks a commit or rollback has not been executed
            if (_done)
            {
                throw new InvalidOperationException("Transaction has yet been committed/rolled back");
            }
            try
            {
                // Rollbacks the transaction
                _idbTransaction.Rollback();
                // updates status to unhappy
                _happy = false;
            }
            catch (Exception ex)
            {
                //throw;
            }
            finally
            {
                // updates status because object's lifetime has expired
                _done = true;
                // closes underling connection to database
                if (_idbTransaction.Connection != null)
                {
                    if (_idbTransaction.Connection.State ==ConnectionState.Open)
                    {
                        _idbTransaction.Connection.Close();
                    }
                    _idbTransaction.Connection.Dispose();
                }
                // Disposes transaction that is no longer useful
                _idbTransaction.Dispose();
            }
        }
    }
}