using System;
using System.Collections.Generic;

namespace App
{
    public class Errors
    {
        private string _field;
        private string _details;

        public Errors(string field, string details)
        {
            _field = field;
            _details = details;
        }

        public override string ToString()
        {
            return $"{{\"{_field}\": \"{_details}\"}}";
        }
    }
}

