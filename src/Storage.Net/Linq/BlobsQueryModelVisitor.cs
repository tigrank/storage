using System;
using System.Collections.Generic;
using System.Text;
using Remotion.Linq;
using Storage.Net.Blob;

namespace Storage.Net.Linq
{
   class BlobsQueryModelVisitor : QueryModelVisitorBase
   {
      public static ListOptions GenerateListOptions(QueryModel queryModel)
      {
         var visitor = new BlobsQueryModelVisitor();
         visitor.VisitQueryModel(queryModel);
         return visitor.GetListOptions();
      }

      private ListOptions GetListOptions()
      {
         return null;
      }
   }
}
