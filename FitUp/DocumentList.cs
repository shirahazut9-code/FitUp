using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class DocumentList:List<Document>
    {
        public DocumentList() { }
        public DocumentList(IEnumerable<Document> list) : base(list) { }
        public DocumentList(IEnumerable<BaseEntity> list) : base(list.Cast<Document>().ToList()) { }
    }
}
