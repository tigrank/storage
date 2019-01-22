using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Remotion.Linq;
using Remotion.Linq.Clauses;
using Storage.Net.Blob;

namespace Storage.Net.Linq
{
   class BlobsQueryExecutor : IQueryExecutor
   {
      public BlobId Current { get; private set; }
      
      public IEnumerable<T> ExecuteCollection<T>(QueryModel queryModel)
      {
         throw new NotImplementedException();
      }

      public T ExecuteScalar<T>(QueryModel queryModel)
      {
         throw new NotImplementedException();
      }

      public T ExecuteSingle<T>(QueryModel queryModel, bool returnDefaultWhenEmpty)
      {
         IEnumerable<T> sequence = ExecuteCollection<T>(queryModel);

         return returnDefaultWhenEmpty ? sequence.SingleOrDefault() : sequence.Single();
      }
   }
}
