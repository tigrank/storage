using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Remotion.Linq;
using Remotion.Linq.Parsing.Structure;
using Storage.Net.Blob;

namespace Storage.Net.Linq
{
   internal class BlobsQueryable<T> : QueryableBase<T>
   {
      public BlobsQueryable(IQueryProvider provider) : base(provider)
      {
      }

      public BlobsQueryable(IQueryParser queryParser, IQueryExecutor executor) : base(queryParser, executor)
      {
      }

      public BlobsQueryable(IQueryProvider provider, Expression expression) : base(provider, expression)
      {
      }
   }
}
