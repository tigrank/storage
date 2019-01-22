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
      public IEnumerable<T> ExecuteCollection<T>(QueryModel queryModel)
      {
         ParameterExpression currentBlobProperty = Expression.Parameter(typeof(BlobId));
         var projection = Expression.Lambda<Func<BlobId, T>>(queryModel.SelectClause.Selector, currentBlobProperty);
         Func<BlobId, T> projector = projection.Compile();

         for(int i = 0; i < 10; i++)
         {
            var fakeBlob = new BlobId(i.ToString(), BlobItemKind.File);
            yield return projector(fakeBlob);
         }
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
