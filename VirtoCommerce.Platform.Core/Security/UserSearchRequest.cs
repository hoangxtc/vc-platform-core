﻿using VirtoCommerce.Platform.Core.Common;

namespace VirtoCommerce.Platform.Core.Security
{
    public class UserSearchRequest : ValueObject
    {
        public UserSearchRequest()
        {
            TakeCount = 20;
        }

        public string[] AccountTypes { get; set; }
        public string Keyword { get; set; }
        public string MemberId { get; set; }
        public int SkipCount { get; set; }
        public int TakeCount { get; set; }
    }
}
