using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryModel.response
{
    public class DataResult
    {
        public bool Successfull { get; set; }

        public dynamic Data { get; set; }
        public List<string> Messages { get; set; } = new List<string>();
        public DataResult()
        {
            this.Successfull = true;
        }

        public void LogError(Exception ex)
        {
            this.Successfull = false;
            this.Data = ex.Message;
        }
    }
}
