using System;
using System.Collections.Generic;


namespace App
{
    public class Url
    {
        private readonly DateTime _createdAt;
        private readonly string _url = string.Empty;

        public Url(string url)
        {
            _createdAt = DateTime.Now;
            _url = url;
        }

        public override string ToString()
        {
            return $"[{this._createdAt.ToString("yyyy-MM-dd hh:mm")}] {this._url}";
        }
    }
}
