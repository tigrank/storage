using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Storage.Net.Blob;
using Xunit;

namespace Storage.Net.Tests.Linq
{
   public class BlobStorageLinqTest
   {
      [Fact]
      public void QueryFilesTest()
      {
         IBlobStorage blobs = StorageFactory.Blobs.InMemory();

         var result = blobs.Query().Where(i => i.Id.StartsWith("rrr")).ToList();
      }
   }
}
