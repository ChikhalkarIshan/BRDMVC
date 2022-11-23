using System;
using System.Collections.Generic;
using System.Text;

namespace AdditionalClasses
{
    public class FileDescriptionResult
    {
        public FileDescriptionResult(bool invalid = false, bool end = false)
        {
            AtEnd = end;
            InvalidKey = invalid;
        }

        public bool InvalidKey {get; protected set;}
        public bool AtEnd { get; protected set; }
    }
}
