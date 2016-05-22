using System.Collections.Specialized;

namespace Store.Web.Utils
{
    public class JQGridPostData
    {
        public int Page { get; set; }
        public int Rows { get; set; }
        public string Sidx { get; set; }
        public string Sord { get; set; }

        public JQGridPostData()
        {
        }

        public JQGridPostData(NameValueCollection collection)
        {
            InitFromCollection(collection);
        }

        public void InitFromCollection(NameValueCollection collection)
        {
            Page = (collection["page"] != null) && (collection["page"].ToString() != string.Empty)
                ? int.Parse(collection["page"].ToString()) : 0;

            Rows = (collection["rows"] != null) && (collection["rows"].ToString() != string.Empty)
                ? int.Parse(collection["rows"].ToString()) : 0;

            Sidx = (collection["sidx"] != null) ? collection["sidx"].ToString() : string.Empty;

            Sord = (collection["sord"] != null) ? collection["sord"].ToString() : string.Empty;
        }

        public void SetCorrectPage(int totalRecords)
        {
            while ((Page - 1) * Rows >= totalRecords && Page != 1)
                Page = Page - 1;
        }

        public static int SetCorrectPage(int page, int rows, int totalRecords)
        {
            while ((page - 1) * rows >= totalRecords && page != 1)
                page = page - 1;

            return page;
        }
    }
}