using System;

namespace Store.Web.Utils
{
    public class JQGridData
    {
        private object jsonData;

        public int Page { get; set; }
        public int TotalPages { get; set; }
        public int RecordsOnPage { get; set; }
        public int TotalRecords { get; set; }
        public object[] Rows
        {
            get { return jsonData.GetType().GetProperty("rows").GetValue(jsonData, null) as object[]; }
        }

        public object JsonData { get { return jsonData; } }

        public JQGridData()
        {
        }

        public JQGridData(object jsonData)
        {
            InitFromJson(jsonData);
        }

        public void InitFromJson(object jsonData)
        {
            if (jsonData != null)
            {
                Page = (int)jsonData.GetType().GetProperty("page").GetValue(jsonData, null);
                TotalPages = (int)jsonData.GetType().GetProperty("total").GetValue(jsonData, null);
                TotalRecords = (int)jsonData.GetType().GetProperty("records").GetValue(jsonData, null);

                object rows = jsonData.GetType().GetProperty("rows").GetValue(jsonData, null);
                RecordsOnPage = (int)rows.GetType().GetProperty("Length").GetValue(rows, null);

                this.jsonData = jsonData;
            }
        }

        public object GetValue(int row, int column)
        {
            object rows = jsonData.GetType().GetProperty("rows").GetValue(jsonData, null);
            object onerow = (rows as Array).GetValue(row);
            object currow = onerow.GetType().GetProperties()[0].GetValue(onerow, null);
            return (currow as Array).GetValue(column);
        }

        //То же самое только указываем явно где находятся колонки
        public object GetValue(int row, int column, int cell)
        {
            object rows = jsonData.GetType().GetProperty("rows").GetValue(jsonData, null);
            object onerow = (rows as Array).GetValue(row);
            object currow = onerow.GetType().GetProperties()[cell].GetValue(onerow, null);
            return (currow as Array).GetValue(column);
        }

        /// <summary>
        /// Добавление колонок к началу массива значений
        /// </summary>
        /// <param name="offset">Кол-во пустых колонок, которые будут добавлены</param>
        /// <returns>Изменённая json-структура</returns>
        public object PadArray(int offset)
        {
            object[] rows = jsonData.GetType().GetProperty("rows").GetValue(jsonData, null) as object[];
            for (int i = 0; i < rows.Length; i++)
            {
                object[] vals = rows[i].GetType().GetProperty("cell").GetValue(rows[i], null) as object[];
                object[] newvals = new object[vals.Length + offset];
                vals.CopyTo(newvals, offset);
                rows.SetValue(new { cell = newvals }, i);
            }

            return jsonData;
        }
    }
}